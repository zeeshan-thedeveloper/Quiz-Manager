using System;
using System.Data;
using System.Data.SqlClient;

namespace Base_project
{
    internal class DatasetManager
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

        public static void deleteQuestionFromDataBase(int tableId)
        {
            int taget = getTheTargetIndexWithRespectToTableIndexing(tableId);
            if (taget != -1)
            {
                //Now we have the index where our target row wrt actual tbale indexing
                GlobalStaticVariablesAndMethods.currentDataSetUsedForHoldingQuestions.Tables[0].Rows[taget].Delete();
            }
            else
            {
                GlobalStaticVariablesAndMethods.CreateErrorMessage("There is error in deleting this question from dataset..!!");
            }
        }

        public static void deleteQuestionFromDataSet(int dataSetIndex)
        {
            GlobalStaticVariablesAndMethods.currentDataSetUsedForHoldingQuestions.Tables[0].Rows[dataSetIndex].Delete();
        }

        public static bool insertRowInTable(String question, String answers, String rightAnswer)
        {
            DataRow row = GlobalStaticVariablesAndMethods.currentDataSetUsedForHoldingQuestions.Tables[0].NewRow();
            row["QuizTopicName"] = GlobalStaticVariablesAndMethods.currentTopicName;
            row["Question"] = question;
            row["Answers"] = answers;
            row["RightAnswer"] = rightAnswer;

            GlobalStaticVariablesAndMethods.currentDataSetUsedForHoldingQuestions.Tables[0].Rows.Add(row);

            return true;
        }

        public static bool saveQuizToDatabase()
        {
            try
            {
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(GlobalStaticVariablesAndMethods.currentSqlDataAdapter);

                GlobalStaticVariablesAndMethods.currentSqlDataAdapter.UpdateCommand = sqlCommandBuilder.GetUpdateCommand();

                GlobalStaticVariablesAndMethods.currentSqlDataAdapter.Update(GlobalStaticVariablesAndMethods.currentDataSetUsedForHoldingQuestions.Tables[0]);

                Console.WriteLine("Saved to database");
            }
            catch (Exception e)
            {
                GlobalStaticVariablesAndMethods.CreateErrorMessage("Error in saving chnages to database");
            }

            return true;
        }

        public static void upddateDataSet(String question, String answers, String rightAnswer, int index)
        {
            int target = getTheTargetIndexWithRespectToTableIndexing(index);
            if (target != -1)
            {
                GlobalStaticVariablesAndMethods.currentDataSetUsedForHoldingQuestions.Tables[0].Rows[target]["Question"] = question;
                GlobalStaticVariablesAndMethods.currentDataSetUsedForHoldingQuestions.Tables[0].Rows[target]["Answers"] = answers;
                GlobalStaticVariablesAndMethods.currentDataSetUsedForHoldingQuestions.Tables[0].Rows[target]["RightAnswer"] = rightAnswer;
            }
            else
            {
                GlobalStaticVariablesAndMethods.CreateErrorMessage("There is error in updating question in this dataset..!!");
            }
        }

        private static int getTheTargetIndexWithRespectToTableIndexing(int tableId)
        {
            DataTableReader dataTableReader = new DataTableReader(GlobalStaticVariablesAndMethods.currentDataSetUsedForHoldingQuestions.Tables[0]);
            int targetIndex = 0;
            while (dataTableReader.Read())
            {
                //searching required row to delete.

                int id = (int)dataTableReader[0];
                if (id == tableId)
                {
                    return targetIndex;
                }
                targetIndex++;
            }

            return -1;
        }
    }
}