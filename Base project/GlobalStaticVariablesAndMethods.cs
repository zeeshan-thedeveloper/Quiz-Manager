using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Base_project
{
    internal class GlobalStaticVariablesAndMethods
    {
        private static Char sepChar = ';';
        static public String loadingMessage{get;set;}
        static public String CantAddMultipleTrueFalseErrorMessage { set { } get { return "Cant not add true false more than once"; } }
        static public String ChangesSavedInDataseInfoMessage { set { } get { return "Saved Changes in list, these will not be applied until you save changes...!!"; } }
        static public String ChangesSavedInfoMessage { set { } get { return "Saved Changes..!!"; } }
        static public String currentConnectionString { get; set; }
        static public DataSet currentDataSetUsedForHoldingQuestions { get; set; }
        static public DataTable currentDataTableUsedForHoldingQuestions { get; set; }
        static public int currentQuectionNumber { get; set; }
        static public int currentSizeOfDataSet { get; set; }
        static public SqlDataAdapter currentSqlDataAdapter { get; set; }
        static public string currentSubjectName { get; set; }
        static public string currentTopicName { get; set; }
        static public string currentStatus { get; set; }
        static public String FileavedAsPdfInfoMessage { set { } get { return "File saved..!!!"; } }
        static public bool isCurrentQuizTopicSaved { get; set; }
        static public String MultipleOptionSelectedErrorMessage { set { } get { return "Please only one option as right asnwer..!!"; } }
        static public String NoOptionTypeSelectedErrorMessage { set { } get { return "Please any option type"; } }
        static public String NoTableNameGivemErrorMessage { set { } get { return " Please give any subject name.. "; } }
        static public String NotAddedOptionsErrorMessage { set { } get { return "Please add some options for question"; } }
        static public String NoTextFoundInOptionTextBoxErrorMessage { set { } get { return " Please write something in option then add "; } }
        static public String NoTopicSelectedErrorMessage { set { } get { return "Please select any topic"; } }
        static public String NotQuestionErrorMessage { set { } get { return "Please add question"; } }

        static public LoadingProgressForm LoadingProgressForm = new LoadingProgressForm();
        static public  PleaseWaitWindow waitWindow = new PleaseWaitWindow();

        //Infor messages
        static public String QuestionDeletedInfoMessage { set { } get { return "Removed from list ( Note untill you save it it will not be affected in database.) "; } }

        static public string selectedPrinter { get; set; }
        static public Char seperatorCharactor { get { return sepChar; } set { value = sepChar; } }

        //Error messages.
        static public String UnsavedQuizErrorMessage { set { } get { return "Please Save the current opened quiz..!!"; } }

        static public String UnSelectedErrorMessage { set { } get { return "Please select at least one options as Right asnwer..!!"; } }

        public static void CreateErrorMessage(String message)
        {
            ErrorInforDialog errorInforDialog = new ErrorInforDialog(message);
            errorInforDialog.ShowDialog();
        }

        public static void DisplayProgressDialog()
        {
            LoadingProgressForm.ShowDialog();

        }
        public static void HideProgressDialog()
        {
            LoadingProgressForm.backgroundWorker.CancelAsync();
            LoadingProgressForm.Hide();
        }
        public static void CreateInfoMesssage(String message)
        {
            InforMessageDialog inforMessageDialog = new InforMessageDialog(message);
            inforMessageDialog.ShowDialog();
        }

        public static void DisplayPleaseWaitWindow()
        {
            waitWindow.ShowDialog();
        }
        public static void HideleaseWaitWindow()
        {
            
            waitWindow.Hide();
        }


        public static List<string> GetTableNames()
        {
            using (SqlConnection connection = new SqlConnection(GlobalStaticVariablesAndMethods.currentConnectionString))
            {
                connection.Open();
                DataTable schema = connection.GetSchema("Tables");
                List<string> TableNames = new List<string>();
                foreach (DataRow row in schema.Rows)
                {
                    Console.WriteLine("Tabke name" + row);
                    TableNames.Add(row[2].ToString());

                    try
                    {
                        GlobalStaticVariablesAndMethods.currentStatus ="Loading Subject : \n "+ row[2].ToString();
                        System.Threading.Thread.Sleep(500);
                    }
                    catch { }
                }

                System.Threading.Thread.Sleep(3000);
       
                return TableNames;
            }
        }
    }
}