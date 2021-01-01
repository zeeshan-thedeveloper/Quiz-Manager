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
    public partial class GetQuizTopicNameWindow : Form
    {
        public GetQuizTopicNameWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxTopicNam.Text.Length <= 0)
            {
                ErrorInforDialog errorInforDialog = new ErrorInforDialog("Please provide a name for creating quiz...!!");
                errorInforDialog.ShowDialog();
            }
            else if (comboBoxSubjects.SelectedIndex >= 0)
            {
                GlobalStaticVariablesAndMethods.currentTopicName = textBoxTopicNam.Text;
                GlobalStaticVariablesAndMethods.currentSubjectName = comboBoxSubjects.SelectedItem.ToString();

                this.Hide();

            }
            else
            {
                ErrorInforDialog errorInforDialog = new ErrorInforDialog("Please select any subject...!!");
                errorInforDialog.ShowDialog();

            }
        }

        private void closedForm_Click(object sender, FormClosedEventArgs e)
        {
            GlobalStaticVariablesAndMethods.currentTopicName = null;
            this.Hide();
        }
    }
}
