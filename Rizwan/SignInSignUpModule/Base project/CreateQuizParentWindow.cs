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
namespace Base_project
{
    public partial class CreateQuizParentWindow : Form
    {

        public CreateQuizParentWindow()
        {
            InitializeComponent();
            Console.WriteLine("New quiz creation window is created with topic name" + GlobalStaticVariables.currentTopicName);
            HideChild();

          
           


        }
        private void CreateQuizParentWindow_Load(object sender, EventArgs e)
        {
            labelSubjectName.Text = "Topic Name: "+GlobalStaticVariables.currentTopicName;
            labelTopicName.Text ="Subject Name: "+ GlobalStaticVariables.currentSubjectName;
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

            ArrayList QueztionsItems = new ArrayList();//Main list of questions.....


            //Question 1
            QuizQuestionListItem quizQuestionListItem = new QuizQuestionListItem(); 
            quizQuestionListItem.QuizSubject = "Programming";
            quizQuestionListItem.QuizTitle = "Quiz 1";
            quizQuestionListItem.QuizQuestionData = " Hey thi is the queztio";

            //options of question 1..
            ArrayList options = new ArrayList();

            CheckBox checkBox = new CheckBox();
            checkBox.Text = "Options A";
            checkBox.Height = 15;
            checkBox.Width = 50;

            options.Add(checkBox);


            quizQuestionListItem.Options = options;

            QueztionsItems.Add(quizQuestionListItem);//This will be the list of all questions

            //Question 2
             quizQuestionListItem = new QuizQuestionListItem();
            quizQuestionListItem.QuizSubject = "Programming pro";
            quizQuestionListItem.QuizTitle = "Quiz 2";
            quizQuestionListItem.QuizQuestionData = " Hey thi is the queztio";

            //options of question 2..
             options = new ArrayList();

            checkBox = new CheckBox();
            checkBox.Text = "Options B";
            checkBox.Height = 15;
            checkBox.Width = 50;

            options.Add(checkBox);


            quizQuestionListItem.Options = options;

            QueztionsItems.Add(quizQuestionListItem);//This will be the list of all questions


            //Question 3

            //Question 2
            quizQuestionListItem = new QuizQuestionListItem();
            quizQuestionListItem.QuizSubject = "Programming pro";
            quizQuestionListItem.QuizTitle = "Quiz 2";
            quizQuestionListItem.QuizQuestionData = " Hey thi is the queztio";

            //options of question 2..
            options = new ArrayList();

            checkBox = new CheckBox();
            checkBox.Text = "Options B";
            checkBox.Height = 15;
            checkBox.Width = 50;

            options.Add(checkBox);


            quizQuestionListItem.Options = options;

            QueztionsItems.Add(quizQuestionListItem);//This will be the list of all questions

            foreach (QuizQuestionListItem questionListItem in QueztionsItems)
            {

                flowLayoutPanelCreateQuizPanelShowAllListItemHolder.Controls.Add(questionListItem);
                questionListItem.Width = flowLayoutPanelCreateQuizPanelShowAllListItemHolder.Width;


            }
            



        }

        private void buttonSaveQuizInSystem_Click(object sender, EventArgs e)
        {

        }

        private void HideChild()
        {
            panelAddNewQuestion.Hide();
            panelShowAllQuestions.Hide();
        }
        
     

        private void panelShowAllQuestions_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButtonFalseOption_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            this.Hide();
        }

       
        }
    }

