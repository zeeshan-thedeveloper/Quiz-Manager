using System;
using System.Windows.Forms;

namespace Base_project
{
    public partial class ErrorInforDialog : Form
    {
        public ErrorInforDialog(String erroMsg)
        {
            InitializeComponent();
            labelErrorMsg.Text = erroMsg;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}