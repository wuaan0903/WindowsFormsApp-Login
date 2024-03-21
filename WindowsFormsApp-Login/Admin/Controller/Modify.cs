using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp_Login
{
    class Modify
    {
        public Modify()
        {
        }
        SqlCommand sqlCommand;
        SqlDataReader dataReader;
        public List<TaiKhoan> TaiKhoans(string querry)
        {
            List<TaiKhoan> tk = new List<TaiKhoan>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection() )
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(querry,sqlConnection);
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
