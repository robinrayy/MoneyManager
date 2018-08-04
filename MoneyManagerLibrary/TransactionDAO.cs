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

                string sqlstring = @"select * from transactionmm where ID = @id order by date";

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
            

            return list;
        }

        public List<TransactionHeader> GetAllTransactionHeaderByID(string id)
        {
            List<TransactionHeader> list = new List<TransactionHeader>();

            //string connString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = DBMoneyManager; Integrated Security = True;";
            try
            {

                string sqlstring = @"SELECT *
                                    FROM (
                                        select Date, Category, Sum(Amount) as Total from TransactionMM where ID = @id group by Date, Category
                                    ) as s
                                    PIVOT
                                    (
                                        SUM(Total)
                                        FOR [Category] IN (Income, Expense)
                                    )AS pvt";

                SqlCommand cmd = new SqlCommand(sqlstring, conn);

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        double inc = 0;
                        double exp = 0;

                        DateTime date = DateTime.Parse(reader["Date"].ToString());
                        if (reader["Income"] != DBNull.Value)
                        {
                            inc = Double.Parse(reader["Income"].ToString());
                        }

                        if (reader["Expense"] != DBNull.Value)
                        {
                            exp = Double.Parse(reader["Expense"].ToString());
                        } 
                        
                        list.Add(new TransactionHeader {
                                Date = date,
                                Income =  inc,
                                Expense = exp
                        });
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

        public List<Transaction> GetTransactionsByRange(DateTime date, string id, double range1, double range2)
        {
            List<Transaction> list = new List<Transaction>();

            try
            {

                string sqlstring = @"select * from transactionmm where ID = @id and Date = @date and Amount between @r1 and @r2";

                SqlCommand cmd = new SqlCommand(sqlstring, conn);

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@Date", date);
                cmd.Parameters.AddWithValue("@r1", range1);
                cmd.Parameters.AddWithValue("@r2", range2);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DateTime dt = DateTime.Parse(reader["Date"].ToString());
                        string cat = reader["category"].ToString();
                        string sub = reader["subcategory"].ToString();
                        double amount = Double.Parse(reader["amount"].ToString());
                        string note = reader["note"]?.ToString();
                        string Id = reader["ID"]?.ToString();
                        list.Add(new Transaction(dt, cat, sub, amount, note, Id));
                    }
                }
                reader.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
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
