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
    }
}