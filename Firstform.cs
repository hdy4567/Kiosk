using System.Linq.Expressions;

namespace Kiosk
{
    public partial class Firstform : Form
    {
        public Firstform()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            Here_In hereinform = new Here_In();
            hereinform.Show();
            this.Hide();
        }

        private void lb_herein_Click(object sender, EventArgs e)
        {

        }   
    }
}
