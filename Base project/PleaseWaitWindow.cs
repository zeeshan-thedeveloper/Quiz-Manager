using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base_project
{
    public partial class PleaseWaitWindow : Form
    {
       
        public PleaseWaitWindow()
        {
            InitializeComponent();
            GlobalStaticVariablesAndMethods.currentStatus = "Please wait";
           

        }


        private void PleaseWaitWindow_Load(object sender, EventArgs e)
        {
            timer1.Tick += Timer1_Tick;
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            labelInfo.Text = GlobalStaticVariablesAndMethods.currentStatus;
            
        }
    }
}
