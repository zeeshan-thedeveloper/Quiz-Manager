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
    public partial class CreateNewQuizDialog : Form
    {
        public CreateNewQuizDialog()
        {
            InitializeComponent();
        }

        private void CreateNewQuizDialog_Load(object sender, EventArgs e)
        {

            comboBoxSubjectList.Items.Add("Sindhi");
            comboBoxSubjectList.Items.Add("Pakistan Studies");
            comboBoxSubjectList.Items.Add("Urdu");
            comboBoxSubjectList.Items.Add("English");
            comboBoxSubjectList.Items.Add("Mathematics");
            comboBoxSubjectList.Items.Add("Science");
  
        }

        private void buttonCreateQuiz_Click(object sender, EventArgs e)
        {
            TeacherPortal.TopicName = textBoxQuizName.Text;

            this.DialogResult = System.Windows.Forms.DialogResult.No;

        }
    }
}
