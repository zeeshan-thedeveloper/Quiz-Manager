using System;
using System.Collections;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
namespace Base_project
{
    public partial class GetQuizTopicNameWindow : Form
    {
        BackgroundWorker dataLoaderThread;
        List<String> names;

        public GetQuizTopicNameWindow()
        {
            InitializeComponent();
            dataLoaderThread = new BackgroundWorker();
            dataLoaderThread.DoWork += DataLoaderThread_DoWork;
            dataLoaderThread.ProgressChanged += DataLoaderThread_ProgressChanged;
            dataLoaderThread.WorkerSupportsCancellation = true;
            dataLoaderThread.WorkerReportsProgress = true;

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

        private void comboBoxAlreadyCreatedTopics_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxTopicNam.Text = comboBoxAlreadyCreatedTopics.SelectedItem.ToString();
        }

        private void comboBoxSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxAlreadyCreatedTopics.Items.Clear();
            String subjectName = comboBoxSubjects.SelectedItem.ToString();
            ArrayList topics = DatabaseManager.GetAllQuizTopics(subjectName);
            foreach (String topic in topics)
            {
                comboBoxAlreadyCreatedTopics.Items.Add(topic);
            }
        }

        private void GetQuizTopicNameWindow_Load(object sender, EventArgs e)
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