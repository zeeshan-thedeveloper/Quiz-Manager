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
    public partial class TeacherPortal : Form
    {
        public static String TopicName;
        public TeacherPortal()
        {
            InitializeComponent();
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  SinInAndSinUpScreen.topicName = textBoxSamoel.Text;

          //  this.Hide();
        }

        private void buttonCreateNewQuiz_Click(object sender, EventArgs e)
        {
            //location 179, 61
            CreateNewQuizDialog createNewQuizDialog = new CreateNewQuizDialog();
            createNewQuizDialog.ShowDialog();
            MessageBox.Show("Recievded Topic : " + TopicName);
            label1QuizName.Text = TopicName;
           //string na= createNewQuizDialog.textBoxQuizName.Text;
            panelCreateNewQuiz.Location = new Point(179, 61);
            panelCreateNewQuiz.BringToFront();

            //   panelCreateNewQuiz.Visible = true;

        }

        private void TeacherPortal_Load(object sender, EventArgs e)
        {

        }

        private void buttonOpenQuiz_Click(object sender, EventArgs e)
        {
            panelOpenQuiz.Location = new Point(179, 61);
            panelOpenQuiz.BringToFront();
        }

        private void buttonScheduleQuiz_Click(object sender, EventArgs e)
        {
            panelScheduleQuiz.Location = new Point(179, 61);
            panelScheduleQuiz.BringToFront();
        }

        private void tabPageCreateQuiz_Click(object sender, EventArgs e)
        {

        }
       
    }
}
