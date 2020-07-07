using FishFarm.BLL;
using FishFarm.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishFarm.UI
{
    public partial class frmSalesReport : Form
    {
        public frmSalesReport()
        {
            InitializeComponent();
        }
        SalesDAL dal = new SalesDAL();
        SalesBLL adal = new SalesBLL();
        

        private void FrmSalesReport_Load(object sender, EventArgs e)
        {
            #region Getting Year and Month
            string month = cmbMonth.Text;
            string year = cmbYear.Text;
            if (year == "")
            {
                year = DateTime.Now.Year.ToString();

            }
            if (month == "")
            {
                month = DateTime.Now.Month.ToString();
            }
            int yearNum = Convert.ToInt32(year);
            int monthNum = Convert.ToInt32(month);
            adal.year = yearNum;
            adal.month = monthNum;
            #endregion
            #region Seting text for report label
            #region changing number to name
            if (monthNum == 1)
            {
                month = "January";
            }
            if (monthNum == 1)
            {
                month = "February";
            }
            if (monthNum == 3)
            {
                month = "March";
            }
            if (monthNum == 4)
            {
                month = "April";
            }
            if (monthNum == 5)
            {
                month = "May";
            }
            if (monthNum == 6)
            {
                month = "June";
            }
            if (monthNum == 7)
            {
                month = "July";
            }
            if (monthNum == 8)
            {
                month = "August";
            }
            if (monthNum == 9)
            {
                month = "September";
            }
            if (monthNum == 10)
            {
                month = "October";
            }
            if (monthNum == 11)
            {
                month = "November";
            }
            if (monthNum == 12)
            {
                month = "December";
            }
            #endregion
            lbldateOrYear.Text = month + " " + year;
            #endregion
            #region Retrieve years and remove duplicate 
            DataTable dt = dal.SelectYear();

            foreach (DataRow row in dt.Rows)
            {
                string aDate = row["added_date"].ToString();
                DateTime adate = Convert.ToDateTime(aDate);
                string yDate = adate.Year.ToString();
                cmbYear.Items.Add(yDate);

            }
            List<object> list = new List<object>();
            foreach (object o in cmbYear.Items)
            {
                if (!list.Contains(o))
                {
                    list.Add(o);
                }
            }
            cmbYear.Items.Clear();
            cmbYear.Items.AddRange(list.ToArray());
            #endregion
            #region Setting current month report(Number of pond sales from)

            DataTable pondNumber = dal.CurrentMonthPondSales(adal);
            int PondNum = pondNumber.Rows.Count;
            lblPondNum.Text = Convert.ToString(PondNum);

            #endregion
            #region Setting current month report(Total Quantity)

            DataTable totalQuantity = dal.CurrentMonthTotalQunatity(adal);

            foreach (DataRow row in totalQuantity.Rows)
            {
                string sum = row["total_quantity"].ToString();
                if (sum == "")
                {
                    sum = "0";
                }
                if (sum == "1")
                {
                    lblQuantityFed.Text = sum + "kg";
                }
                else
                {
                    lblQuantityFed.Text = sum +  "kg";
                }

            }
            #endregion
            #region Setting current month report(Total Cost)
            DataTable totalCost = dal.CurrentMonthTotalCost(adal);

            foreach (DataRow row in totalCost.Rows)
            {
                string sum = row["total_cost"].ToString();
                if (sum == "")
                {
                    sum = "0";
                }
                lblTotalCost.Text = "N" + sum;
            }
            #endregion
        }

        private void CmbMonth_SelectedValueChanged(object sender, EventArgs e)
        {
            string month = cmbMonth.Text;
            string year = cmbYear.Text;
            int monthNum = DateTime.Now.Month;
            #region changing name to number
            if (month == "January")
            {
                monthNum = 1;
            }
            if (month == "February")
            {
                monthNum = 2;
            }
            if (month == "March")
            {
                monthNum = 3;
            }
            if (month == "April")
            {
                monthNum = 4;
            }
            if (month == "May")
            {
                monthNum = 5;
            }
            if (month == "June")
            {
                monthNum = 6;
            }
            if (month == "July")
            {
                monthNum = 7;
            }
            if (month == "August")
            {
                monthNum = 8;
            }
            if (month == "September")
            {
                monthNum = 9;
            }
            if (month == "October")
            {
                monthNum = 10;
            }
            if (month == "November")
            {
                monthNum = 11;
            }
            if (month == "December")
            {
                monthNum = 12;
            }
            #endregion
            if (year == "")
            {
                year = DateTime.Now.Year.ToString();

            }
            if (month == "")
            {
                month = DateTime.Now.Month.ToString();
            }
            int yearNum = Convert.ToInt32(year);
            adal.year = yearNum;
            adal.month = monthNum;
            #region Seting text for report label
            #region changing number to name
            if (monthNum == 1)
            {
                month = "January";
            }
            if (monthNum == 1)
            {
                month = "February";
            }
            if (monthNum == 3)
            {
                month = "March";
            }
            if (monthNum == 4)
            {
                month = "April";
            }
            if (monthNum == 5)
            {
                month = "May";
            }
            if (monthNum == 6)
            {
                month = "June";
            }
            if (monthNum == 7)
            {
                month = "July";
            }
            if (monthNum == 8)
            {
                month = "August";
            }
            if (monthNum == 9)
            {
                month = "September";
            }
            if (monthNum == 10)
            {
                month = "October";
            }
            if (monthNum == 11)
            {
                month = "November";
            }
            if (monthNum == 12)
            {
                month = "December";
            }
            #endregion
            lbldateOrYear.Text = month + " " + year;
            #endregion
            #region Setting current month report(Number of pond sales from)

            DataTable pondNumber = dal.CurrentMonthPondSales(adal);
            int PondNum = pondNumber.Rows.Count;
            lblPondNum.Text = Convert.ToString(PondNum);

            #endregion
            #region Setting current month report(Total Quantity)

            DataTable totalQuantity = dal.CurrentMonthTotalQunatity(adal);

            foreach (DataRow row in totalQuantity.Rows)
            {
                string sum = row["total_quantity"].ToString();
                if (sum == "")
                {
                    sum = "0";
                }
                
                    lblQuantityFed.Text = sum + "kg";
                

            }
            #endregion
            #region Setting current month report(Total Cost)
            DataTable totalCost = dal.CurrentMonthTotalCost(adal);

            foreach (DataRow row in totalCost.Rows)
            {
                string sum = row["total_cost"].ToString();
                if (sum == "")
                {
                    sum = "0";
                }
                lblTotalCost.Text = "N" + sum;
            }
            #endregion
        }

        private void CmbYear_SelectedValueChanged(object sender, EventArgs e)
        {
            string month = cmbMonth.Text;
            string year = cmbYear.Text;
            int monthNum = DateTime.Now.Month;
            #region changing name to number
            if (month == "January")
            {
                monthNum = 1;
            }
            if (month == "February")
            {
                monthNum = 2;
            }
            if (month == "March")
            {
                monthNum = 3;
            }
            if (month == "April")
            {
                monthNum = 4;
            }
            if (month == "May")
            {
                monthNum = 5;
            }
            if (month == "June")
            {
                monthNum = 6;
            }
            if (month == "July")
            {
                monthNum = 7;
            }
            if (month == "August")
            {
                monthNum = 8;
            }
            if (month == "September")
            {
                monthNum = 9;
            }
            if (month == "October")
            {
                monthNum = 10;
            }
            if (month == "November")
            {
                monthNum = 11;
            }
            if (month == "December")
            {
                monthNum = 12;
            }
            #endregion
            if (year == "")
            {
                year = DateTime.Now.Year.ToString();

            }
            if (month == "")
            {
                month = "0";
                monthNum = Convert.ToInt32(month);
            }
            int yearNum = Convert.ToInt32(year);
            adal.year = yearNum;
            adal.month = monthNum;
            #region Seting text for report label
            #region changing number to name
            if (monthNum == 1)
            {
                month = "January";
            }
            if (monthNum == 1)
            {
                month = "February";
            }
            if (monthNum == 3)
            {
                month = "March";
            }
            if (monthNum == 4)
            {
                month = "April";
            }
            if (monthNum == 5)
            {
                month = "May";
            }
            if (monthNum == 6)
            {
                month = "June";
            }
            if (monthNum == 7)
            {
                month = "July";
            }
            if (monthNum == 8)
            {
                month = "August";
            }
            if (monthNum == 9)
            {
                month = "September";
            }
            if (monthNum == 10)
            {
                month = "October";
            }
            if (monthNum == 11)
            {
                month = "November";
            }
            if (monthNum == 12)
            {
                month = "December";
            }
            #endregion
            if (month == "0")
            {
                lbldateOrYear.Text = year;
            }
            else
            {
                lbldateOrYear.Text = month + " " + year;
            }

            #endregion
            #region Setting current month report(Number of pond sales from)

            DataTable pondNumber = dal.CurrentMonthPondSales(adal);
            int PondNum = pondNumber.Rows.Count;
            lblPondNum.Text = Convert.ToString(PondNum);

            #endregion
            #region Setting current month report(Total Quantity)

            DataTable totalQuantity = dal.CurrentMonthTotalQunatity(adal);

            foreach (DataRow row in totalQuantity.Rows)
            {
                string sum = row["total_quantity"].ToString();
                if (sum == "")
                {
                    sum = "0";
                }
                else
                {
                    lblQuantityFed.Text = sum + "kg";
                }

            }
            #endregion
            #region Setting current month report(Total Cost)
            DataTable totalCost = dal.CurrentMonthTotalCost(adal);

            foreach (DataRow row in totalCost.Rows)
            {
                string sum = row["total_cost"].ToString();
                if (sum == "")
                {
                    sum = "0";
                }
                lblTotalCost.Text = "N" + sum;
            }
            #endregion
        }
    }
}
