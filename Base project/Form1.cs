using System;
using System.Configuration;
using System.Windows.Forms;
using System.Threading;

namespace Base_project
{
    public partial class Form1 : Form
    {
        private AddSubjectParentWindow addSubjectParentWindow;
        private AnalyticsParentWindow analyticsParentWindow;
        private CreateQuizParentWindow createQuizParentWindow;
        private OpenQuizParentWindow openQuizParentWindow;
        private PrintQuizParentWindow printQuizParentWindow;

        public Form1()
        {
            InitializeComponent();
            createQuizParentWindow = new CreateQuizParentWindow();
            openQuizParentWindow = new OpenQuizParentWindow();
            printQuizParentWindow = new PrintQuizParentWindow();
            addSubjectParentWindow = new AddSubjectParentWindow();
            analyticsParentWindow = new AnalyticsParentWindow();
            GlobalStaticVariablesAndMethods.isCurrentQuizTopicSaved = true;
            
            
        }

        private void TimerLoadingForm_Tick(object sender, EventArgs e)
        {
            try
            {
                Thread.Sleep(3000);
                GlobalStaticVariablesAndMethods.loadingMessage = "jfldfjlkdsf";
           //     GlobalStaticVariablesAndMethods.HideProgressDialog();
                this.Visible = true;
            }
            catch (Exception d)
            {
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Setting connection string // by loading from app config file.
            GlobalStaticVariablesAndMethods.loadingMessage = "Please wait we are setting up enviroment for you..!!";
            GlobalStaticVariablesAndMethods.DisplayProgressDialog();
           
            GlobalStaticVariablesAndMethods.currentConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;


        }

        private void buttonAddSubject_Click(object sender, EventArgs e)
        {
            if (GlobalStaticVariablesAndMethods.isCurrentQuizTopicSaved)
            {
                HideChild();

               

                AddSubjectParentWindow addSubjectParentWindow = new AddSubjectParentWindow();
                addSubjectParentWindow.ShowDialog();
            }
            else
            {
                GlobalStaticVariablesAndMethods.CreateErrorMessage(GlobalStaticVariablesAndMethods.UnsavedQuizErrorMessage);
            }
        }

        private void buttonAnalytics_Click(object sender, EventArgs e)
        {
            if (GlobalStaticVariablesAndMethods.isCurrentQuizTopicSaved)
            {
                HideChild();

                analyticsParentWindow.MdiParent = this;
                analyticsParentWindow.Show();
                analyticsParentWindow.BringToFront();
                analyticsParentWindow.Dock = DockStyle.Top;
            }
            else
            {
                GlobalStaticVariablesAndMethods.CreateErrorMessage(GlobalStaticVariablesAndMethods.UnsavedQuizErrorMessage);
            }
        }

        private void buttonCreateNewQuiz_Click(object sender, EventArgs e)
        {
            if (GlobalStaticVariablesAndMethods.isCurrentQuizTopicSaved)
            {
                


                HideChild();

                GlobalStaticVariablesAndMethods.currentTopicName = null; //this will be setted from dialog window which we are opening down
                GlobalStaticVariablesAndMethods.currentSubjectName = null;//this will be setted from dialog window which we are opening down

                GetQuizTopicNameWindow getQuizTopicNameWindow = new GetQuizTopicNameWindow();
                getQuizTopicNameWindow.ShowDialog();

                if (GlobalStaticVariablesAndMethods.currentTopicName != null)
                {
                    //this means some topic name is provided
                    createQuizParentWindow.MdiParent = this;
                    createQuizParentWindow.Show();
                    createQuizParentWindow.BringToFront();
                    createQuizParentWindow.Dock = DockStyle.Top;

                    //setting the isQuizSavedflag;

                    GlobalStaticVariablesAndMethods.isCurrentQuizTopicSaved = false;

                    //Create a dataset to hold the questions...

                    GlobalStaticVariablesAndMethods.currentQuectionNumber = 1;

                    GlobalStaticVariablesAndMethods.currentDataSetUsedForHoldingQuestions = DatasetManager.createDataSetForHoldingQuestions(GlobalStaticVariablesAndMethods.currentSubjectName);
                    GlobalStaticVariablesAndMethods.currentSizeOfDataSet = GlobalStaticVariablesAndMethods.currentDataSetUsedForHoldingQuestions.Tables[0].Rows.Count;

                    //We will now use this gloabl variable to store questions.
                }
                else
                {
                    GlobalStaticVariablesAndMethods.isCurrentQuizTopicSaved = true;
                }
            }
            else
            {
                GlobalStaticVariablesAndMethods.CreateErrorMessage(GlobalStaticVariablesAndMethods.UnsavedQuizErrorMessage);
            }
            //Open dialog
        }

        private void buttonOpenQuiz_Click(object sender, EventArgs e)
        {
            if (GlobalStaticVariablesAndMethods.isCurrentQuizTopicSaved)
            {


                HideChild();

                TopicSelectorDialog topicSelectorDialog = new TopicSelectorDialog(this, createQuizParentWindow, openQuizParentWindow);
                topicSelectorDialog.ShowDialog();
            }
            else
            {
                GlobalStaticVariablesAndMethods.CreateErrorMessage(GlobalStaticVariablesAndMethods.UnsavedQuizErrorMessage);
            }
        }

        private void buttonPrint_Click_1(object sender, EventArgs e)
        {
            if (GlobalStaticVariablesAndMethods.isCurrentQuizTopicSaved)
            {
                HideChild();
                printQuizParentWindow.MdiParent = this;
                printQuizParentWindow.Show();
                printQuizParentWindow.BringToFront();
                printQuizParentWindow.Dock = DockStyle.Top;
            }
            else
            {
                GlobalStaticVariablesAndMethods.CreateErrorMessage(GlobalStaticVariablesAndMethods.UnsavedQuizErrorMessage);
            }
        }

   

        private void HideChild()
        {
            createQuizParentWindow.Dispose();
            openQuizParentWindow.Dispose();
            printQuizParentWindow.Dispose();
            addSubjectParentWindow.Dispose();
            analyticsParentWindow.Dispose();

            createQuizParentWindow = new CreateQuizParentWindow();
            openQuizParentWindow = new OpenQuizParentWindow();
            printQuizParentWindow = new PrintQuizParentWindow();
            addSubjectParentWindow = new AddSubjectParentWindow();
            analyticsParentWindow = new AnalyticsParentWindow();
        }
    }
}