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
    public partial class frmUserCashFlow : Form
    {
        public frmUserCashFlow()
        {
            InitializeComponent();
        }
        CashInBLL c = new CashInBLL();
        CashInDAL dal = new CashInDAL();
        cashOutBLL co = new cashOutBLL();
        cashOutDAL odal = new cashOutDAL();

        private void FrmUserCashFlow_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvcashflow.DataSource = dt;

            DataTable dto = odal.Select();
            dgvcashflow.DataSource = dto;
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;

            if (keywords != null)
            {
                DataTable dt = dal.Search(keywords);
                dgvcashflow.DataSource = dt;
                DataTable dto = odal.Search(keywords);
                dgvcashflow.DataSource = dto;
            }
            else
            {
                DataTable dt = dal.Select();
                dgvcashflow.DataSource = dt;
                DataTable dto = dal.Select();
                dgvcashflow.DataSource = dto;
            }
        }

        private void clear()
        {
            txtSource.Text = "";
            txtAmount.Text = "";
            txtComments.Text = "";

        }

        private void clearOut()
        {
            txtActivity.Text = "";
            txtAmountOut.Text = "";
            txtCommentsOut.Text = "";
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //getting data from UI
            c.date = DateTime.Now;
            c.source = txtSource.Text;
            c.amount = txtAmount.Text;
            c.comment = txtComments.Text;

            //Insert Data into database
            bool success = dal.Insert(c);

            if (success == true)
            {
                MessageBox.Show("Record successfully saved");
                clear();
            }
            else
            {
                MessageBox.Show("Record failed to saved");
            }
            DataTable dt = dal.Select();
            dgvcashflow.DataSource = dt;

        }

        private void BtnAddOut_Click(object sender, EventArgs e)
        {
            //getting data from UI
            co.date = DateTime.Now;
            co.activity = txtActivity.Text;
            co.amount = txtAmountOut.Text;
            co.comment = txtCommentsOut.Text;

            //Insert Data into database
            bool success = odal.Insert(co);

            if (success == true)
            {
                MessageBox.Show("Record successfully saved");
                clearOut();
            }
            else
            {
                MessageBox.Show("Record failed to saved");
            }
            DataTable dto = odal.Select();
            dgvcashflow.DataSource = dto;

        }
    }
}
