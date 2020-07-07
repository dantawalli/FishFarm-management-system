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
    public partial class frmUserSalary : Form
    {
        public frmUserSalary()
        {
            InitializeComponent();
        }
        SalaryBLL s = new SalaryBLL();
        SalaryDAL dal = new SalaryDAL();

        private void clear()
        {
            txtAmount.Text = "";
            txtPaidTo.Text = "";
            txtPaidBy.Text = "";
            cmbMonth.Text = "";
            txtComments.Text = "";

        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //getting data from UI
            s.amount_paid = txtAmount.Text;
            s.paid_to = txtPaidTo.Text;
            s.paid_by = txtPaidBy.Text;
            s.month = cmbMonth.Text;
            s.date = DateTime.Now;
            s.comments = txtComments.Text;

            //Insert Data into database
            bool success = dal.Insert(s);

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
            dgvSalary.DataSource = dt;
        }

        private void FrmUserSalary_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvSalary.DataSource = dt;
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;

            if (keywords != null)
            {
                DataTable dt = dal.Search(keywords);
                dgvSalary.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.Select();
                dgvSalary.DataSource = dt;
            }
        }
    }
}
