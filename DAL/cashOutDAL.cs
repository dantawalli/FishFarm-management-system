using FishFarm.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishFarm.DAL
{
    class cashOutDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        #region select Data From Database
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT dbo.cash_in_records.*, dbo.cash_out_records.* FROM dbo.cash_in_records RIGHT JOIN dbo.cash_out_records ON cash_in_records.id = cash_out_records.[ID.]";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        #endregion
        #region Insert Data in Database
        public bool Insert(cashOutBLL c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                String sql = "INSERT INTO  cash_out_records([Date.], Activity, [Amount.], [Comment.]) VALUES(@date, @activity, @amount, @comment)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@date", c.date);
                cmd.Parameters.AddWithValue("@activity", c.activity);
                cmd.Parameters.AddWithValue("@amount", c.amount);
                cmd.Parameters.AddWithValue("@comment", c.comment);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        #endregion
        #region Update data in Database
        public bool Update(cashOutBLL c)
        {

            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                String sql = "UPDATE cash_out_records SET [Date.]=@date, Activity=@activity, [Amount.]=@amount, [Comment.]=@comment WHERE [ID.] = @id;";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", c.id);
                cmd.Parameters.AddWithValue("@date", c.date);
                cmd.Parameters.AddWithValue("@activity", c.activity);
                cmd.Parameters.AddWithValue("@amount", c.amount);
                cmd.Parameters.AddWithValue("@comment", c.comment);



                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        #endregion
        #region Delete Data from Database
        public bool Delete(cashOutBLL c)
        {

            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                String sql = "DELETE cash_out_records WHERE [ID.] = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", c.id);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        #endregion
        #region Search Data From Database Using Keywords
        public DataTable Search(string keywords)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                String sql = "Select * From CashFlow_View WHERE [ID.] LIKE '%" + keywords + "%' OR Activity LIKE '%" + keywords + "%'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        #endregion
        #region select year From cash_out_records table
        public DataTable SelectYear()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT [Date.] FROM cash_out_records";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        #endregion
        #region Select current month report(cashout Activity)
        public DataTable CurrentMonthCashOutActivity(cashOutBLL c)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            String sql = "";
            try
            {
                if (c.month == 0)
                {
                    sql = "SELECT distinct Activity FROM cash_out_records WHERE MONTH([Date.]) BETWEEN 0 AND 13  AND YEAR([Date.]) = @year";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@year", c.year);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    conn.Open();
                    adapter.Fill(dt);
                }
                else
                {
                    sql = "SELECT distinct Activity FROM cash_out_records WHERE MONTH([Date.]) = @month AND YEAR([Date.]) = @year";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@month", c.month);
                    cmd.Parameters.AddWithValue("@year", c.year);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    conn.Open();
                    adapter.Fill(dt);
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        #endregion
        #region Select current month report(Total Amount)
        public DataTable CurrentMonthTotalAmount(cashOutBLL c)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            String sql = "";
            try
            {
                if (c.month == 0)
                {
                    sql = "SELECT SUM([Amount.]) AS 'total_amount' FROM cash_out_records WHERE MONTH([Date.]) BETWEEN 0 AND 13  AND YEAR([Date.]) = @year";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@year", c.year);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    conn.Open();
                    adapter.Fill(dt);
                }
                else
                {
                    sql = "SELECT SUM([Amount.]) AS 'total_amount' FROM cash_out_records WHERE MONTH([Date.]) = @month AND YEAR([Date.]) = @year";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@month", c.month);
                    cmd.Parameters.AddWithValue("@year", c.year);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    conn.Open();
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        #endregion
    }
}
