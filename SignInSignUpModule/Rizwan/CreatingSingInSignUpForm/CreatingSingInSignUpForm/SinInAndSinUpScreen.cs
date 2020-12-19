using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreatingSingInSignUpForm
{
    public partial class SinInAndSinUpScreen : Form
    {
        public SinInAndSinUpScreen()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelSininUpOption.Location = new Point(55, 351);
            panelCreateAccount.BringToFront();
            panelCreateAccount.Visible = true;
            panelCreateAccount.Location = new Point(27, 73);
        }

        

        private void button3_Click_1(object sender, EventArgs e)
        {
            panelSininUpOption.Location = new Point(55, 351);
            panelSinIn.BringToFront();
            panelCreateAccount.Visible = false;
            panelSinIn.Location = new Point(41, 95);
        }
    }
}
