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

        private void buttonCreateSubject_Click(object sender, EventArgs e)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
          string   sql = "CREATE TABLE myTable" +  
    "(myId INTEGER CONSTRAINT PKeyMyId PRIMARY KEY," +  
    "myName CHAR(50), myAddress CHAR(255), myBalance FLOAT)";

            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.ExecuteNonQuery();
        }
    }
}
