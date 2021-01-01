using System;
using System.Windows.Forms;
using System.Data;
namespace Base_project
{
    public partial class Test : Form
    {

        DataSet dataSet;
        DataTable questionDataHolderTable;
        public Test()
        {
            InitializeComponent();
            dataSet = DatasetManager.createDataSetForHoldingQuestions("Test");

            questionDataHolderTable = DatasetManager.createDataTableForHoldingQuestions("tee");

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            DataRow dataRow = questionDataHolderTable.NewRow();

            dataRow["Question"] = "Hey";
            dataRow["Answers"] = "hello";
            dataRow["RightAnswer"] = "ge";


            questionDataHolderTable.Rows.Add(dataRow);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataSet.Tables.Add(questionDataHolderTable);

            dataGridViewTable.DataSource = dataSet.Tables[0];

        }
    }
}
