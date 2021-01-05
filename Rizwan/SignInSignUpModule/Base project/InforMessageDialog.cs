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
    public partial class InforMessageDialog : Form
    {
        public InforMessageDialog(String message)
        {
            InitializeComponent();
            label1.Text = message;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
