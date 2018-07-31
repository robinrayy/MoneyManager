using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MoneyManagerLibrary
{
    public class TransactionDAO : IDisposable
    {
        SqlConnection conn = null;
        public TransactionDAO()
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

        public List<Transaction> GetAllTransactionDataByID(string id)
        {
            List<Transaction> list = new List<Transaction>();

            //string connString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = DBMoneyManager; Integrated Security = True;";
            try
            {

                string sqlstring = @"select * from transactionmm where ID = @id";

                SqlCommand cmd = new SqlCommand(sqlstring, conn);

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = cmd.ExecuteReader();
                
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DateTime date = DateTime.Parse(reader["Date"].ToString());
                        string cat= reader["category"].ToString();
                        string sub = reader["subcategory"].ToString();
                        double amount = Double.Parse(reader["amount"].ToString());
                        string note = reader["note"]?.ToString();
                        string Id = reader["ID"]?.ToString();
                        list.Add(new Transaction(date, cat, sub, amount, note, Id));
                    }
                }
                reader.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn != null) conn.Close();
            }

            return list;
        }

        public int Insert(Transaction trans)
        {
            int result = 0;
            try
            {
                //string pureSqlString = 
                //    @"insert into jurusan values ('" + 
                //        jurusan.Kode + "', '" + jurusan.Keterangan + "')";

                string sqlString = @"insert into transactionmm values (@date, @category, @subcategory, @amount, @note, @id)";
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = sqlString;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@date", trans.Date);
                    cmd.Parameters.AddWithValue("@category", trans.Category);
                    cmd.Parameters.AddWithValue("@subcategory", trans.SubCategory);
                    cmd.Parameters.AddWithValue("@amount", trans.Amount);
                    cmd.Parameters.AddWithValue("@note", trans.Note);
                    cmd.Parameters.AddWithValue("@id", trans.ID);
                    result = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public void Dispose()
        {
            if (conn != null) conn.Close();
        }
    }
}
