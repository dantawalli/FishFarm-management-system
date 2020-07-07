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
    class StockingDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        #region select Data From Database
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                String sql = "Select * From stocking_records";
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
        public bool Insert(StockingBLL s)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                String sql = "INSERT INTO  stocking_records(added_date,pond_id, species, average_weight, total_weight, unit_cost, total_cost) VALUES(@added_date,@pond_id, @species, @average_weight, @total_weight, @unit_cost, @total_cost)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@added_date", s.added_date);
                cmd.Parameters.AddWithValue("@pond_id", s.pond_id);
                cmd.Parameters.AddWithValue("@species", s.species);
                cmd.Parameters.AddWithValue("@average_weight", s.average_weight);
                cmd.Parameters.AddWithValue("@total_weight", s.total_weight);
                cmd.Parameters.AddWithValue("@unit_cost", s.unit_cost);
                cmd.Parameters.AddWithValue("@total_cost", s.total_cost);
         
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
        public bool Update(StockingBLL s)
        {

            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                String sql = "UPDATE stocking_records SET added_date=@added_date,pond_id=@pond_id, species=@species, average_weight=@average_weight, total_weight=@total_weight, unit_cost=@unit_cost, total_cost=@total_cost WHERE id = @id;";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", s.id);
                cmd.Parameters.AddWithValue("@added_date", s.added_date);
                cmd.Parameters.AddWithValue("@pond_id", s.pond_id);
                cmd.Parameters.AddWithValue("@species", s.species);
                cmd.Parameters.AddWithValue("@average_weight", s.average_weight);
                cmd.Parameters.AddWithValue("@total_weight", s.total_weight);
                cmd.Parameters.AddWithValue("@unit_cost", s.unit_cost);
                cmd.Parameters.AddWithValue("@total_cost", s.total_cost);
                

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
        public bool Delete(StockingBLL s)
        {

            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                String sql = "DELETE stocking_records WHERE id = @id";
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
                String sql = "Select * From stocking_records WHERE id LIKE '%" + keywords + "%' OR pond_id LIKE '%" + keywords + "%' OR species LIKE '%" + keywords + "%'";
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
        #region select year From Stocking table
        public DataTable SelectYear()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT added_date FROM stocking_records";
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
        #region Select current month report(Number of Pond Stocked)
        public DataTable CurrentMonthPondStocked(StockingBLL s)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            String sql = ""; 
            try
            {
                if(s.month == 0)
                {
                    sql = "SELECT distinct pond_id FROM stocking_records WHERE MONTH(added_date) BETWEEN 0 AND 13  AND YEAR(added_date) = @year";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@year", s.year);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    conn.Open();
                    adapter.Fill(dt);
                }
                else
                {
                    sql = "SELECT distinct pond_id FROM stocking_records WHERE MONTH(added_date) = @month AND YEAR(added_date) = @year";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@month", s.month);
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
        #region Select current month report(Number of Pond Species)
        public DataTable CurrentMonthNumberSpecies(StockingBLL s)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            String sql = "";
            try
            {
                if (s.month == 0)
                {
                    sql = "SELECT distinct species FROM stocking_records WHERE MONTH(added_date) BETWEEN 0 AND 13  AND YEAR(added_date) = @year";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@year", s.year);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    conn.Open();
                    adapter.Fill(dt);
                }
                else
                {
                    sql = "SELECT distinct species FROM stocking_records WHERE MONTH(added_date) = @month AND YEAR(added_date) = @year";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@month", s.month);
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
        #region Select current month report(Total weight)
        public DataTable CurrentMonthTotalWeight(StockingBLL s)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            String sql = "";
            try
            {
                if (s.month == 0)
                {
                    sql = "SELECT SUM(total_weight) AS 'total_weight' FROM stocking_records WHERE MONTH(added_date) BETWEEN 0 AND 13  AND YEAR(added_date) = @year";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@year", s.year);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    conn.Open();
                    adapter.Fill(dt);
                }
                else
                {
                    sql = "SELECT SUM(total_weight) AS 'total_weight' FROM stocking_records WHERE MONTH(added_date) = @month AND YEAR(added_date) = @year";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@month", s.month);
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
        #region Select current month report(Total cost)
        public DataTable CurrentMonthTotalCost(StockingBLL s)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            String sql = "";
            try
            {
                if (s.month == 0)
                {
                    sql = "SELECT SUM(total_cost) As 'total_cost' FROM stocking_records WHERE MONTH(added_date) BETWEEN 0 AND 13  AND YEAR(added_date) = @year";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@year", s.year);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    conn.Open();
                    adapter.Fill(dt);
                }
                else
                {
                    sql = "SELECT SUM(total_cost) As 'total_cost' FROM stocking_records WHERE MONTH(added_date) = @month AND YEAR(added_date) = @year";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@month", s.month);
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
