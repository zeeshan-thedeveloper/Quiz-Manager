using System;
using System.Windows.Forms;

namespace Base_project
{
    public partial class SettingConnectionStringWindow : Form
    {
        public SettingConnectionStringWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GlobalStaticVariablesAndMethods.currentConnectionString = richTextBoxConnectionString.Text;
            this.Hide();
        }
    }
}