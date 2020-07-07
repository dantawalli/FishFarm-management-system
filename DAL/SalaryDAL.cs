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
    class SalaryDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        #region select Data From Database
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                String sql = "Select * From salary_records";
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
        public bool Insert(SalaryBLL s)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                String sql = "INSERT INTO  salary_records(amount_paid, paid_to, paid_by, month, date, comments) VALUES( @amount_paid, @paid_to, @paid_by, @month, @date, @comments)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@amount_paid", s.amount_paid);
                cmd.Parameters.AddWithValue("@paid_to", s.paid_to);
                cmd.Parameters.AddWithValue("@paid_by", s.paid_by);
                cmd.Parameters.AddWithValue("@month", s.month);
                cmd.Parameters.AddWithValue("@date", s.date);
                cmd.Parameters.AddWithValue("@comments", s.comments);

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
        public bool Update(SalaryBLL s)
        {

            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                String sql = "UPDATE salary_records SET amount_paid=@amount_paid, paid_to=@paid_to, paid_by=@paid_by, month=@month, date=@date, comments=@comments WHERE id = @id;";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", s.id);
                cmd.Parameters.AddWithValue("@amount_paid", s.amount_paid);
                cmd.Parameters.AddWithValue("@paid_to", s.paid_to);
                cmd.Parameters.AddWithValue("@paid_by", s.paid_by);
                cmd.Parameters.AddWithValue("@month", s.month);
                cmd.Parameters.AddWithValue("@date", s.date);
                cmd.Parameters.AddWithValue("@comments", s.comments);

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
        public bool Delete(SalaryBLL s)
        {

            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                String sql = "DELETE salary_records WHERE id = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", s.id);

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
                String sql = "Select * From salary_records WHERE id LIKE '%" + keywords + "%' OR paid_to LIKE '%" + keywords + "%' OR month LIKE '%" + keywords + "%' OR paid_by LIKE '%" + keywords + "%'";
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
        #region select year From Salary table
        public DataTable SelectYear()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT date FROM salary_records";
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
        #region Select current month report(Amount paid)
        public DataTable CurrentMonthSalaryPaid(SalaryBLL s)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            String sql = "";
            try
            {
                if (s.montho == 0)
                {
                    sql = "SELECT SUM(amount_paid) As 'amount_paid' FROM salary_records WHERE MONTH(date) BETWEEN 0 AND 13  AND YEAR(date) = @year";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@year", s.year);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    conn.Open();
                    adapter.Fill(dt);
                }
                else
                {
                    sql = "SELECT SUM(amount_paid) As 'amount_paid' FROM salary_records WHERE MONTH(date) = @month AND YEAR(date) = @year";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@month", s.montho);
                    cmd.Parameters.AddWithValue("@year", s.year);
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
        #region Select current month report(People paid)
        public DataTable CurrentMonthPeoplePaid(SalaryBLL s)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            String sql = "";
            try
            {
                if (s.montho == 0)
                {
                    sql = "SELECT distinct paid_to FROM salary_records WHERE MONTH(date) BETWEEN 0 AND 13  AND YEAR(date) = @year";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@year", s.year);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    conn.Open();
                    adapter.Fill(dt);
                }
                else
                {
                    sql = "SELECT distinct paid_to FROM salary_records WHERE MONTH(date) = @month AND YEAR(date) = @year";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@month", s.montho);
                    cmd.Parameters.AddWithValue("@year", s.year);
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
        #region Select current month report(paid by)
        public DataTable CurrentMonthPaidby(SalaryBLL s)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            String sql = "";
            try
            {
                if (s.montho == 0)
                {
                    sql = "SELECT distinct paid_by FROM salary_records WHERE MONTH(date) BETWEEN 0 AND 13  AND YEAR(date) = @year";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@year", s.year);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    conn.Open();
                    adapter.Fill(dt);
                }
                else
                {
                    sql = "SELECT distinct paid_by FROM salary_records WHERE MONTH(date) = @month AND YEAR(date) = @year";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@month", s.montho);
                    cmd.Parameters.AddWithValue("@year", s.year);
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
