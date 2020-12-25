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
    public partial class CreateQuizParentWindow : Form
    {
       
        public CreateQuizParentWindow()
        {
            InitializeComponent();
            HideChild();
        }

        private void buttonCQAddNewQuestion_Click(object sender, EventArgs e)
        {
            panelAddNewQuestion.Show();
            panelAddNewQuestion.Location = new Point(33, 33);
            panelAddNewQuestion.BringToFront();
        }

        private void buttonCQShowAllQuestions_Click(object sender, EventArgs e)
        {
            HideChild();
           panelShowAllQuestions.Show();
           panelShowAllQuestions.Location = new Point(33, 33);
           panelShowAllQuestions.BringToFront();
        }

        private void buttonSaveQuizInSystem_Click(object sender, EventArgs e)
        {

        }

        private void HideChild()
        {
            panelAddNewQuestion.Hide();
            panelShowAllQuestions.Hide();
        }

        private void comboBoxCOptionsType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCOptionsType.SelectedIndex == 0)
            {
                panelMcqtypeOption.Location = new Point(9, 52);
                panelMcqtypeOption.BringToFront();
            }
            else
            {
               
            }
        }
    }
}
