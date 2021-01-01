using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Base_project
{
    class GlobalStaticVariables
    {
        static public string currentTopicName{get;set;}
        static public string currentSubjectName { get; set; }

        static public int currentQuectionNumber { get; set; }

        static public bool isCurrentQuizTopicSaved { get; set; }

        static public DataSet currentDataSetUsedForHoldingQuestions { get; set; }
        
        static public DataTable currentDataTableUsedForHoldingQuestions { get; set; }

        

        static public String UnsavedQuizErrorMessage { set { } get { return "Please Save the current opened quiz..!!"; } }

        public static void CreateErrorMessage(String message)
        {
            ErrorInforDialog errorInforDialog = new ErrorInforDialog(message);
            errorInforDialog.ShowDialog();
        }
    }

   
}
