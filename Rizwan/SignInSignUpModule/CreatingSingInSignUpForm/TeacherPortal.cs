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
        public static String topicName;
        public static String subjectName;

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
            topicName = null;
            CreateNewQuizDialog createNewQuizDialog = new CreateNewQuizDialog();
            createNewQuizDialog.ShowDialog();
            if (topicName != null)
            {

                panelCreateNewQuiz.Location = new Point(179, 61);
                panelCreateNewQuiz.Visible = true;
                panelCreateNewQuiz.BringToFront();
                panelSubOptionsOfCreateQuiz.Visible = true;
                panelSubOptionsOfCreateQuiz.Location = new Point(905, 31);
                panelSubOptionsOfCreateQuiz.BringToFront();

            }
            else
            {

                ErrorInfoDialog errorInfo = new ErrorInfoDialog("No quiz created..!!");
                errorInfo.ShowDialog();

            }



        }

        private void TeacherPortal_Load(object sender, EventArgs e)
        {
            panelCreateNewQuiz.Visible = false;
            panelSubOptionsOfCreateQuiz.Visible = false;
            panelOpenQuizOptionHoler.Location = new Point(179, 61);
            panelOpenQuizOptionHoler.Visible = true;
            panelOpenQuizOptionHoler.BringToFront();

        }

        private void buttonOpenQuiz_Click(object sender, EventArgs e)
        {
            panelOpenQuizOptionHoler.Location = new Point(179, 61);
            panelOpenQuizOptionHoler.Visible = true;
            panelOpenQuizOptionHoler.BringToFront();


        }

        private void buttonScheduleQuiz_Click(object sender, EventArgs e)
        {
            panelScheduleQuiz.Location = new Point(179, 61);
            panelScheduleQuiz.BringToFront();
        }

        private void tabPageCreateQuiz_Click(object sender, EventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void panelTrueFasleOptions_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        

        private void groupBoxAddOptionsPanel_Enter(object sender, EventArgs e)
        {

        }

        private void panelQuestionOptionHoler_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButtonTrueOption_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonFalseOptoin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panelSubOptionsOfCreateQuiz_Paint(object sender, PaintEventArgs e)
        {

        }


        private void panelShowAllQuestionsOptionHoler_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

     

        
    }
}
