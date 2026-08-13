using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sushikiosk
{
    public partial class ReceiptForm : Form
    {


        public ReceiptForm(List<MenuForm.OrderItem> orderList)
        {
            InitializeComponent();

            // 날짜 / 시간
            lblOrderDate.Text =
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            int totalPrice = 0;

            string receipt = "";

            foreach (MenuForm.OrderItem item in orderList)
            {
                int itemTotal =
                    item.IsFree ? 0 : item.Price * item.Quantity;

                string itemName =
                    item.IsFree
                    ? item.Name + " (당첨!)"
                    : item.Name;

                receipt +=
                    itemName + "    " +
                    item.Quantity + "개    " +
                    itemTotal.ToString("N0") + "원" +
                    Environment.NewLine +
                    Environment.NewLine;

                totalPrice += itemTotal;
            }

            // TextBox에는 메뉴 내역만
            txtReceipt.Text = receipt;

            // 총금액은 별도 Label
            lblReceiptTotal.Text =
                "총 금액    " + totalPrice.ToString("N0") + "원";

            int receiptHeight = Math.Max(100, orderList.Count * 35);

            txtReceipt.Height = receiptHeight;

            // 총 금액 위치
            lblReceiptTotal.Top = txtReceipt.Bottom + 20;

            // 닫기 버튼 위치
            btnClose.Top = lblReceiptTotal.Bottom + 30;


            // 영수증 전체에 필요한 실제 높이
            int fullHeight = btnClose.Bottom + 30;


            // 현재 모니터에서 사용할 수 있는 최대 높이
            int maxHeight = Screen.FromControl(this).WorkingArea.Height - 100;


            // 주문이 적으면 폼 자체를 늘리고
            // 주문이 많으면 화면 높이까지만 늘림
            this.ClientSize = new Size(
                this.ClientSize.Width,
                Math.Min(fullHeight, maxHeight)
            );


            // 내용이 화면보다 길면 폼 자체에 스크롤 생성
            this.AutoScroll = true;

            this.AutoScrollMinSize = new Size(
                0,
                fullHeight
            );
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
