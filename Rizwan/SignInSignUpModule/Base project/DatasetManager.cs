using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Base_project
{
    class DatasetManager
    {
        public static DataSet createDataSetForHoldingQuestions(String subjectName)
        {
            DataSet dataSet = new DataSet();
            dataSet.DataSetName = subjectName;

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

            return questionDataHolderTable;

        }
        public static bool insertRowInTable(DataTable dataTable, String question, String answers, String rightAnswer)
        {
            DataRow dataRow = dataTable.NewRow();

            dataRow[0] = question;
            dataRow[1] = answers;
            dataRow[2] = rightAnswer;

            
            return true;
        }

        public static bool joinDataSetAndTable(DataSet dataSet, DataTable dataTable)
        {
            dataSet.Tables.Add(dataTable);

            return true;
        }




    }
}
