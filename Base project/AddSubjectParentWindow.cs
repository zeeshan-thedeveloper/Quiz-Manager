using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
namespace Base_project
{
    public partial class AddSubjectParentWindow : Form
    {
        BackgroundWorker dataLoaderThread,tableCreatorThread;
        List<String> names;
        String tableName;
        public AddSubjectParentWindow()
        {
            InitializeComponent();
            dataLoaderThread = new BackgroundWorker();
            dataLoaderThread.DoWork += DataLoaderThread_DoWork;
            dataLoaderThread.ProgressChanged += DataLoaderThread_ProgressChanged;
            dataLoaderThread.WorkerSupportsCancellation = true;
            dataLoaderThread.WorkerReportsProgress = true;

            tableCreatorThread = new BackgroundWorker();
            tableCreatorThread.DoWork += TableCreatorThread_DoWork;
            tableCreatorThread.ProgressChanged += TableCreatorThread_ProgressChanged;
            tableCreatorThread.WorkerReportsProgress = true;
            tableCreatorThread.WorkerSupportsCancellation = true;


            names = new List<string>();

        }

       

        private void AddSubjectParentWindow_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SettingConnectionStringWindow settingConnectionStringWindow = new SettingConnectionStringWindow();
            settingConnectionStringWindow.ShowDialog();
        }

        private void buttonCreateTable_Click(object sender, EventArgs e)
        {
            try
            {
               
               
                if (richTextBoxTableName.Text.Length > 0)
                {
                   tableName = richTextBoxTableName.Text.Replace(' ', '_');

                    tableCreatorThread.RunWorkerAsync();
                    //MessageBox.Show("Running table cretor");
                    GlobalStaticVariablesAndMethods.DisplayPleaseWaitWindow();
                }
                else
                {
                    GlobalStaticVariablesAndMethods.CreateErrorMessage(GlobalStaticVariablesAndMethods.NoTableNameGivemErrorMessage);
                }
            }
            catch (Exception x)
            {
                GlobalStaticVariablesAndMethods.CreateErrorMessage(x.Message);
            }
        }

        private void buttonShowAvailSub_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.Clear();
            dataLoaderThread.RunWorkerAsync();
            GlobalStaticVariablesAndMethods.DisplayPleaseWaitWindow();
            
            
        }
        //Background workers

        #region message loader thread
        private void DataLoaderThread_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //this will be called when backround work willbe done.
            
            GlobalStaticVariablesAndMethods.HideleaseWaitWindow();

            foreach (String tables in names)
            {
                listBox1.Items.Add(tables);
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


        #region table creator thread


        private void TableCreatorThread_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            switch (e.ProgressPercentage)
            {
                case 0:

                    //every thing is done successfully

                    

                    GlobalStaticVariablesAndMethods.HideleaseWaitWindow();


                    break;

                case 1:

                    //error occured while creating table.

                    GlobalStaticVariablesAndMethods.HideleaseWaitWindow();

                    break;
            }
        }

        private void TableCreatorThread_DoWork(object sender, DoWorkEventArgs e)
        {

            try
            {

             

                SqlConnection connection = new SqlConnection(GlobalStaticVariablesAndMethods.currentConnectionString);
                connection.Open();
                String qury = "CREATE TABLE " + tableName + " ( Id INT NOT NULL PRIMARY KEY IDENTITY(1,1),   QuizTopicName VARCHAR(MAX) NULL,    Question VARCHAR(MAX) NULL,    Answers VARCHAR(MAX) NULL,    RightAnswer VARCHAR(MAX) NULL)";
                SqlCommand sqlCommand = new SqlCommand(qury, connection);
                sqlCommand.ExecuteNonQuery();
                connection.Close();
                GlobalStaticVariablesAndMethods.currentStatus = "subject : " + tableName + " Added succesfully";
                
                tableCreatorThread.ReportProgress(0);

            }
            catch (Exception q) {

                GlobalStaticVariablesAndMethods.currentStatus = "Could not add subject due to : !" + q.Message;
                System.Threading.Thread.Sleep(5000);
                MessageBox.Show("Error :" + q.Message);
                tableCreatorThread.ReportProgress(1);
                MessageBox.Show("Error :" + q.Message);
               

            }

        }

        #endregion



    }
}