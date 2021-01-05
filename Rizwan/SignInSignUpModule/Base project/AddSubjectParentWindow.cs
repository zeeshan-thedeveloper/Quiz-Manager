using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
namespace Base_project
{
    public partial class AddSubjectParentWindow : Form
    {
        public AddSubjectParentWindow()
        {
            InitializeComponent();
        }

        private void AddSubjectParentWindow_Load(object sender, EventArgs e)
        {

        }
        private void buttonCreateTable_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(GlobalStaticVariablesAndMethods.currentConnectionString);
                connection.Open();
                if (richTextBoxTableName.Text.Length > 0)
                {
                    String tableName = richTextBoxTableName.Text.Replace(' ', '_');
                    String qury = "CREATE TABLE "+tableName+ " ( Id INT NOT NULL PRIMARY KEY IDENTITY(1,1),   QuizTopicName VARCHAR(MAX) NULL,    Question VARCHAR(MAX) NULL,    Answers VARCHAR(MAX) NULL,    RightAnswer VARCHAR(MAX) NULL)";
                    SqlCommand sqlCommand = new SqlCommand(qury, connection);

                    sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("Subject added Successfully.");
                    
                    
                    connection.Close();
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
            foreach (String tables in GlobalStaticVariablesAndMethods.GetTableNames())
            {
                listBox1.Items.Add(tables);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SettingConnectionStringWindow settingConnectionStringWindow = new SettingConnectionStringWindow();
            settingConnectionStringWindow.ShowDialog();
        }
    }
}
