using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace CreatingSingInSignUpForm
{
    public partial class RightAnswerChooserDialog : Form
    {
        ArrayList optionList;
        public RightAnswerChooserDialog(ref ArrayList optionList)
        {
            this.optionList = optionList;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean flag = true;
            foreach (var option in optionList)
            {
                if (option is CheckBox)
                {
                    CheckBox checkBox = option as CheckBox;
                    if (checkBox.Checked)
                    {
                        flag = false;
                        this.Hide();
                        break;
                    }
                }
                else
                {
                    RadioButton radioButton = option as RadioButton;
                    if (radioButton.Checked)
                    {
                        flag = false;
                        this.Hide();
                        break;
                    }
                }
            }

            if(flag)
            MessageBox.Show("Please select the righ answer");

        }

        private void RightAnswerChooserDialog_Load(object sender, EventArgs e)
        {
            foreach (var option in optionList)
            {
                if (option is CheckBox)
                {
                    flowLayoutPanelCQOptions.Controls.Add(option as CheckBox);
                }
                else
                {
                    flowLayoutPanelCQOptions.Controls.Add(option as RadioButton);
                }
                
            }



        }
    }
}
