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
    public partial class TempPanel : Form
    {
        public TempPanel()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }




        ArrayList optionsList, questionsList;
        private void panelCreateNewQuiz_Paint(object sender, PaintEventArgs e)
        {
            //Here we need to write the actions which should be performed when foerm is loaded
            comboBoxCOptionsType.SelectedIndex = 0;
            optionsList = new ArrayList();
            questionsList = new ArrayList();
            labelStartingTextInCenter.Dock = DockStyle.Fill;
            labelStartingTextInCenter.TextAlign = ContentAlignment.MiddleCenter;
        }

    }
}
