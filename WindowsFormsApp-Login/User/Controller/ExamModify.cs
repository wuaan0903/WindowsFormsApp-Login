using System;
using System.Collections;
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

        public List<Subject> Subjects(string querry)
        {
            List<Subject> sj = new List<Subject>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(querry, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    sj.Add(new Subject(dataReader.GetString(1)));
                }
                sqlConnection.Close();
            }
            return sj;
        }
        public List<Exam> Exams(string querry)
        {
            List<Exam> ex = new List<Exam>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(querry, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    ex.Add(new Exam(dataReader.GetInt32(0),dataReader.GetString(1), dataReader.GetInt32(2), dataReader.GetInt32(3), dataReader.GetInt32(4)));
                }
                sqlConnection.Close();
            }
            return ex;
        }
        public List<History> histories(string querry)
        {
            List<History> hs = new List<History>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(querry, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    hs.Add(new History(dataReader.GetInt32(1), dataReader.GetInt32(2), dataReader.GetString(3), dataReader.GetInt32(4), dataReader.GetInt32(5), dataReader.GetInt32(7)));
                }
                sqlConnection.Close();
            }
            return hs;
        }
        public int CountExam(string querry,string nameExam,int id)
        {
            int count = 0;
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(querry, sqlConnection);

                dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    
                    int id_user = dataReader.GetInt32(0);
                    string name_exam = dataReader.GetString(1);
                    int different_number_exams = dataReader.GetInt32(2);
                    if (id_user == id && name_exam == nameExam)
                    {
                        count = different_number_exams;
                        break;
                    }
                    //Console.WriteLine($"id_user: {id_user}, name_exam: {name_exam}, different_number_exams: {different_number_exams}");
                }
                sqlConnection.Close();
            }
            return count;
        }
        public void HistoryTest(string querry)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(querry, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

            }    
        }

        public List<Exam> GetExams(string query)
        {
            List<Exam> exams = new List<Exam>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            exams.Add(new Exam(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetInt32(2), dataReader.GetInt32(3), dataReader.GetInt32(4)));
                        }
                    }
                }
            }
            return exams;
        }
        public List<Subject> GetSubject(string query)
        {
            List<Subject> subject = new List<Subject>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            subject.Add(new Subject(dataReader.GetString(1)));
                        }
                    }
                }
            }
            return subject;
        }

        public static void InsertQuestion(Question q)
        {
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();

                string sql = "INSERT INTO Question (Id_Exam,question, AnswerA, AnswerB, AnswerC, AnswerD, Correct_Answer, Status) " +
                             "VALUES (@Id_Exam, @question, @AnswerA, @AnswerB, @AnswerC, @AnswerD, @CorrectAnswer, @Status)";

                using (SqlCommand statement = new SqlCommand(sql, conn))
                {
                    statement.Parameters.AddWithValue("@Id_Exam", q.Id_exam);
                    statement.Parameters.AddWithValue("@question", q.Question1);
                    statement.Parameters.AddWithValue("@AnswerA", q.AnswerA);
                    statement.Parameters.AddWithValue("@AnswerB", q.AnswerB);
                    statement.Parameters.AddWithValue("@AnswerC", q.AnswerC);
                    statement.Parameters.AddWithValue("@AnswerD", q.AnswerD);
                    statement.Parameters.AddWithValue("@CorrectAnswer", q.Answer);
                    statement.Parameters.AddWithValue("@Status", 0);

                    statement.ExecuteNonQuery();
                }
            }
        }
        public static void InsertExam(Exam exam)
        {
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();




                // Thực hiện chèn bản ghi
                string query = "INSERT INTO list_exam (Name_Exam, Exam_Number, number_Question, Time) " +
                               "VALUES ( @NameExam, @NumberExam, @SoCauHoi, @ThoiGian)";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@NameExam", exam.Name_exam);
                    command.Parameters.AddWithValue("@NumberExam", exam.Exam_number);
                    command.Parameters.AddWithValue("@SoCauHoi", exam.Number_question);
                    command.Parameters.AddWithValue("@ThoiGian", exam.Time);

                    command.ExecuteNonQuery();
                }




                conn.Close();
            }
        }
        public static void Delete(int id)
        {
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();

                string sql = "DELETE FROM list_exam WHERE Id_Exam = @Id";

                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    command.ExecuteNonQuery();
                }
            }
        }
        public static void DeleteQuestion(int a)
        {
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();

                string sql = "DELETE FROM Question WHERE  Id_Exam = @Id_Exam";

                using (SqlCommand command = new SqlCommand(sql, conn))
                {

                    command.Parameters.AddWithValue("@Id_Exam", a);

                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Question> GetQuestions(int id_exam)
        {
            List<Question> dataList = new List<Question>();

            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();

                string sql = "SELECT * FROM Question WHERE Id_Exam = @Id_Exam";

                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@Id_Exam", id_exam);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dataList.Add(new Question
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("id_question")),
                                Id_exam = reader.GetInt32(reader.GetOrdinal("Id_Exam")),
                                Question1 = reader.GetString(reader.GetOrdinal("question")),
                                AnswerA = reader.GetString(reader.GetOrdinal("AnswerA")),
                                AnswerB = reader.GetString(reader.GetOrdinal("AnswerB")),
                                AnswerC = reader.GetString(reader.GetOrdinal("AnswerC")),
                                AnswerD = reader.GetString(reader.GetOrdinal("AnswerD")),
                                Answer = reader.GetInt32(reader.GetOrdinal("Correct_Answer")),
                                Status = reader.GetInt32(reader.GetOrdinal("Status"))
                            });
                        }
                    }
                }
            }

            return dataList;
        }
        public List<Exam> GetExams_Search(string name_ex, int de_so)
        {
            List<Exam> exams = new List<Exam>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                string query = "SELECT * FROM list_exam WHERE Name_Exam LIKE @NameExam";
                if (de_so != -1)
                {
                    query += " AND Exam_Number = @NumberExam";
                }
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@NameExam", "%" + name_ex + "%");
                    if (de_so != -1)
                    {
                        sqlCommand.Parameters.AddWithValue("@NumberExam", de_so);
                    }

                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            exams.Add(new Exam(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetInt32(2), dataReader.GetInt32(3), dataReader.GetInt32(4)));
                        }
                    }
                }
            }
            return exams;
        }


    }
}
