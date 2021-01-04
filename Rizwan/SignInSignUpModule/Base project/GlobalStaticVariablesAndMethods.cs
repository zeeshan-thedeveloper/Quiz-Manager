using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Base_project
{
    class GlobalStaticVariablesAndMethods
    {
        static public string currentTopicName{get;set;}
        static public string currentSubjectName { get; set; }

        static public int currentQuectionNumber { get; set; }

        static public bool isCurrentQuizTopicSaved { get; set; }

        static public DataSet currentDataSetUsedForHoldingQuestions { get; set; }
        
        static public DataTable currentDataTableUsedForHoldingQuestions { get; set; }

        static public String currentConnectionString { get; set; }


        static public String UnsavedQuizErrorMessage { set { } get { return "Please Save the current opened quiz..!!"; } }
        static public String UnSelectedErrorMessage { set { } get { return "Please select at least one options as Right asnwer..!!"; } }
        static public String MultipleOptionSelectedErrorMessage { set { } get { return "Please only one option as right asnwer..!!"; } }

        static public String NotAddedOptionsErrorMessage { set { } get { return "Please add some options for question"; } }

        static public String NoOptionTypeSelectedErrorMessage { set { } get { return "Please any option type"; } }

        static public String CantAddMultipleTrueFalseErrorMessage { set { } get { return "Cant not add true false more than once"; } }

        static public String NotQuestionErrorMessage { set { } get { return "Please add question"; } }

        static public String NoTextFoundInOptionTextBoxErrorMessage { set { } get { return" Please write something in option then add "; } }
        static public String NoTableNameGivemErrorMessage { set { } get { return " Please give any subject name.. "; } }


        public static void CreateErrorMessage(String message)
        {
            ErrorInforDialog errorInforDialog = new ErrorInforDialog(message);
            errorInforDialog.ShowDialog();
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
                    Console.WriteLine("Tabke name"+row);
                    TableNames.Add(row[2].ToString());
                }
                return TableNames;
            }
        }
    }

   
}
