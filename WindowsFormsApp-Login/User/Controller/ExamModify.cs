using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp_Login.User.Model;

namespace WindowsFormsApp_Login.User.Controller
{
    internal class ExamModify
    {
        public ExamModify() { 
        }
        SqlCommand sqlCommand;
        SqlDataReader dataReader;
        public List<Question> Questions(string querry)
        {
            List<Question> q = new List<Question>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(querry, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    q.Add(new Question(dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(5), dataReader.GetString(6), dataReader.GetInt32(7), dataReader.GetInt32(8)));
                    
                }
                sqlConnection.Close();
            }
            return q;
        }

        public List<TaiKhoan> TaiKhoans(string querry)
        {
            List<TaiKhoan> tk = new List<TaiKhoan>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(querry, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    tk.Add(new TaiKhoan(dataReader.GetString(1), dataReader.GetString(2)));
                }
                sqlConnection.Close();
            }
            return tk;
        }
    }
}
