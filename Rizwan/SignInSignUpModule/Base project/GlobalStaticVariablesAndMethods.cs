using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
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

        

        static public String UnsavedQuizErrorMessage { set { } get { return "Please Save the current opened quiz..!!"; } }
        static public String UnSelectedErrorMessage { set { } get { return "Please select at least one options as Right asnwer..!!"; } }
        static public String MultipleOptionSelectedErrorMessage { set { } get { return "Please only one option as right asnwer..!!"; } }

        static public String NotAddedOptionsErrorMessage { set { } get { return "Please add some options for question"; } }

        static public String NoOptionTypeSelectedErrorMessage { set { } get { return "Please any option type"; } }

        static public String CantAddMultipleTrueFalseErrorMessage { set { } get { return "Cant not add true false more than once"; } }

        static public String NotQuestionErrorMessage { set { } get { return "Please add question"; } }



        public static void CreateErrorMessage(String message)
        {
            ErrorInforDialog errorInforDialog = new ErrorInforDialog(message);
            errorInforDialog.ShowDialog();
        }
    }

   
}
