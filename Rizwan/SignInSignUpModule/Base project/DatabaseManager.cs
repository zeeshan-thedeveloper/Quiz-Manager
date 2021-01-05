using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.SqlClient;
namespace Base_project
{
    class DatabaseManager
    {
        public static ArrayList GetAllQuizTopics(String subjectName)
        {
            ArrayList topics = new ArrayList();
            SqlConnection connection = new SqlConnection(GlobalStaticVariablesAndMethods.currentConnectionString);
            connection.Open();
            String qury = "SELECT DISTINCT QuizTopicName from " + subjectName;
            SqlCommand sqlCommand = new SqlCommand(qury, connection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                topics.Add(sqlDataReader["QuizTopicName"]);
            }


            return topics;

        }
    }
}
