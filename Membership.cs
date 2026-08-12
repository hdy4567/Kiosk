using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk
{
    public partial class Membership : Form
    {
        public Membership()
        {
            InitializeComponent();
            pnlStamp.Hide();
            pnl_Pop_Membership.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("포인트를 적립하겠습니까 ?",
                "포인트 적립",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question
                 );
            if (result == DialogResult.Yes)
            {
                pnlStamp.Show();

            }
        }

        private void Membership_Load(object sender, EventArgs e)
        {

        }

        private void btn__Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("포인트를 적립하겠습니까 ?",
                "포인트 적립",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question
                 );
            if (result == DialogResult.Yes)
            {
                pnl_Pop_Membership.Show();
            }

        }
        string[] inputs = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "00", "000" };


        private void Pop_Membership_Load(object sender, EventArgs e)
        {
            // 폼 안의 모든 Button 컨트롤을 찾아서 입력 버튼인 경우 이벤트를 바인딩합니다.
            BindNumButtons(this);
        }

        private void BindNumButtons(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is Button btn && inputs.Contains(btn.Text))
                {
                    btn.Click += NumButton_Click;
                }
                else if (control.HasChildren)
                {
                    BindNumButtons(control); // 패널 등 하위 컨테이너에 있는 버튼도 탐색
                }
            }
        }

        private void NumButton_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                // 클릭된 버튼의 부모 컨테이너에 따라 입력될 타겟 컨트롤을 다르게 지정합니다.
                if (IsChildOf(btn, pnl_Pop_Membership))
                {
                    label17.Text += btn.Text;
                }
                else if (IsChildOf(btn, pnlStamp))
                {
                    textBox1.Text += btn.Text;
                }
            }
        }

        // 특정 컨트롤이 특정 부모 컨트롤(패널 등)의 하위에 포함되어 있는지 확인하는 헬퍼 메서드
        private bool IsChildOf(Control child, Control parent)
        {
            Control current = child.Parent;
            while (current != null)
            {
                if (current == parent) return true;
                current = current.Parent;
            }
            return false;
        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void button15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_topEarn_Click(object sender, EventArgs e)
        {

        }

        private void btn_topEarn_Paint(object sender, PaintEventArgs e)
        {
            Control ctrl = (Control)sender;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            int radius = 15;

            // 전체 컨트롤 크기 구하기
            Rectangle rect = new Rectangle(0, 0, ctrl.Width, ctrl.Height);
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();

            // 위쪽 양쪽 모서리만 둥글게 깎는 경로(Path) 정의
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90); // 위쪽 왼쪽
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90); // 위쪽 오른쪽
            path.AddLine(rect.Right, rect.Bottom, rect.X, rect.Bottom); // 아래쪽은 직각 유지
            path.CloseFigure();

            // 주황색 배경 채우기 (현재 쓰신 주황색 RGB 값에 맞게 변경 가능)
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(255, 128, 0)))
            {
                e.Graphics.FillPath(brush, path);
            }
            ctrl.Region = new Region(path);


        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btn_topEarn_Click_1(object sender, EventArgs e)
        {

        }

        private void roundTopPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundToplabel1_Click(object sender, EventArgs e)
        {

        }
    }
}