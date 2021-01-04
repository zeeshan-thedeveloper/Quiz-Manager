using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Base_project
{
    class DatasetManager
    {
        public static DataSet createDataSetForHoldingQuestions(String subjectName)
        {
            SqlConnection connection = new SqlConnection(GlobalStaticVariablesAndMethods.currentConnectionString);
            connection.Open();

            SqlCommand sqlCommand = new SqlCommand("Select * from " + subjectName, connection);

            GlobalStaticVariablesAndMethods.currentSqlDataAdapter = new SqlDataAdapter(sqlCommand);

            DataSet dataSet = new DataSet();

            GlobalStaticVariablesAndMethods.currentSqlDataAdapter.Fill(dataSet);

            return dataSet;

        }
        public static DataTable createDataTableForHoldingQuestions(String topicName)
        {
         
            DataTable questionDataHolderTable = new DataTable();
            questionDataHolderTable.TableName = topicName;
            
            DataColumn question = new DataColumn();
            question.ColumnName = "Question";
            question.DataType = Type.GetType("System.String");

            DataColumn answers = new DataColumn();
            answers.ColumnName = "Answers";
            answers.DataType = Type.GetType("System.String");

            DataColumn rightAnswer = new DataColumn();
            rightAnswer.ColumnName = "RightAnswer";
            rightAnswer.DataType = Type.GetType("System.String");

            questionDataHolderTable.Columns.Add(question);
            questionDataHolderTable.Columns.Add(answers);
            questionDataHolderTable.Columns.Add(rightAnswer);

            return  questionDataHolderTable;

        }

        public static bool insertRowInTable( String question, String answers, String rightAnswer)
        {
            DataRow row = GlobalStaticVariablesAndMethods.currentDataSetUsedForHoldingQuestions.Tables[0].NewRow();
            row["QuizTopicName"] = GlobalStaticVariablesAndMethods.currentTopicName;
            row["Question"] =question;
            row["Answers"]=answers;
            row["RightAnswer"] =rightAnswer;

            GlobalStaticVariablesAndMethods.currentDataSetUsedForHoldingQuestions.Tables[0].Rows.Add(row);

            

            return true;
        }

        public static bool saveQuizToDatabase()
        {

            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(GlobalStaticVariablesAndMethods.currentSqlDataAdapter);

            GlobalStaticVariablesAndMethods.currentSqlDataAdapter.UpdateCommand = sqlCommandBuilder.GetUpdateCommand();

            GlobalStaticVariablesAndMethods.currentSqlDataAdapter.Update(GlobalStaticVariablesAndMethods.currentDataSetUsedForHoldingQuestions.Tables[0]);

            

            Console.WriteLine("Saved to database");



            return true;
        }




    }
}
