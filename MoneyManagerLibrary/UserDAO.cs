using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MoneyManagerLibrary
{
    class UserDAO
    {
        SqlConnection conn = null;
        //SqlTransaction trans = null;

        public UserDAO()
        {
            try
            {
                conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
                conn.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<User> GetAllUserData() {
            List<User> list = new List<User>();

            //string connString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = DBMoneyManager; Integrated Security = True;";
            try
            {
                
                string sqlstring = @"select * from User";

                SqlCommand cmd = new SqlCommand(sqlstring, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string id = reader["ID"].ToString();
                        string name = reader["name"].ToString();
                        string pass = reader["password"].ToString();
                        string email = reader["email"].ToString();
                        string question = reader["question"]?.ToString();
                        string ans = reader["answer"]?.ToString();
                        list.Add(new User(id,name,pass, email,question, ans));
                    }
                }
                reader.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
                Console.ReadKey();
                throw;
            }
            finally
            {
                if (conn != null) conn.Close();
            }

            return list;
        }

        public int Insert(User user)
        {
            int result = 0;
            try
            {
                //string pureSqlString = 
                //    @"insert into jurusan values ('" + 
                //        jurusan.Kode + "', '" + jurusan.Keterangan + "')";

                string sqlString = @"insert into User values (@id, @name, @password, @email, @question, @answer)";
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = sqlString;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@id", user.ID);
                    cmd.Parameters.AddWithValue("@name", user.Nama);
                    cmd.Parameters.AddWithValue("@password", user.Password);
                    cmd.Parameters.AddWithValue("@email", user.Email);
                    cmd.Parameters.AddWithValue("@question", user.Question);
                    cmd.Parameters.AddWithValue("@answer", user.Answer);
                    result = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

    }
}

