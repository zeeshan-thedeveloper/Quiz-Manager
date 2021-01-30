using System;
using System.Collections;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
namespace Base_project
{
    public partial class TopicSelectorDialog : Form
    {
        private CreateQuizParentWindow createQuizParentWindow;
        private Form1 form1;
        private OpenQuizParentWindow openQuizParentWindow;
        BackgroundWorker dataLoaderThread, tableCreatorThread;
        List<String> names;
        String tableName;

        public TopicSelectorDialog(Form1 form1, CreateQuizParentWindow createQuizParentWindow, OpenQuizParentWindow openQuizParentWindow)
        {
            InitializeComponent();
            listBox1.SelectionMode = SelectionMode.One;
            this.form1 = form1;
            this.createQuizParentWindow = createQuizParentWindow;
            this.openQuizParentWindow = openQuizParentWindow;

            dataLoaderThread = new BackgroundWorker();
            dataLoaderThread.DoWork += DataLoaderThread_DoWork;
            dataLoaderThread.ProgressChanged += DataLoaderThread_ProgressChanged;
            dataLoaderThread.WorkerSupportsCancellation = true;
            dataLoaderThread.WorkerReportsProgress = true;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                createQuizParentWindow.MdiParent = form1;
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
                this.Hide();
            }
            else
            {
                GlobalStaticVariablesAndMethods.CreateErrorMessage(GlobalStaticVariablesAndMethods.NoTopicSelectedErrorMessage);
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                GlobalStaticVariablesAndMethods.currentDataSetUsedForHoldingQuestions = DatasetManager.createDataSetForHoldingQuestions(GlobalStaticVariablesAndMethods.currentSubjectName);

                openQuizParentWindow.MdiParent = form1;
                openQuizParentWindow.Show();
                openQuizParentWindow.BringToFront();
                openQuizParentWindow.Dock = DockStyle.Top;

                this.Hide();
            }
            else
            {
                GlobalStaticVariablesAndMethods.CreateErrorMessage(GlobalStaticVariablesAndMethods.NoTopicSelectedErrorMessage);
            }
        }

        private void comboBoxSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            String subject = comboBoxSubjects.SelectedItem.ToString();
            ArrayList topics = DatabaseManager.GetAllQuizTopics(subject);


            foreach (String topic in topics)
            {
                listBox1.Items.Add(topic);
            }


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                GlobalStaticVariablesAndMethods.currentTopicName = listBox1.SelectedItem.ToString();
            }
        }

        private void TopicSelectorDialog_Load(object sender, EventArgs e)
        {
            //Call background worker class.
            dataLoaderThread.RunWorkerAsync();
            GlobalStaticVariablesAndMethods.DisplayPleaseWaitWindow();

        }


        #region message loader thread
        private void DataLoaderThread_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //this will be called when backround work willbe done.

            GlobalStaticVariablesAndMethods.HideleaseWaitWindow();

            foreach (String tables in names)
            {
                comboBoxSubjects.Items.Add(tables);
            }

        }

        private void DataLoaderThread_DoWork(object sender, DoWorkEventArgs e)
        {
            //this will call the methods which are supposed to run on background.
            try
            {
                names = GlobalStaticVariablesAndMethods.GetTableNames();
                dataLoaderThread.ReportProgress(0);
            }
            catch (Exception m)
            {

            }
        }

        #endregion

    }
}