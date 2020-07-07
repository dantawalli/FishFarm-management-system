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
    public partial class frmUserSales : Form
    {
        public frmUserSales()
        {
            InitializeComponent();
        }
        SalesBLL s = new SalesBLL();
        SalesDAL dal = new SalesDAL();

        private void FrmUserSales_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvstocking.DataSource = dt;
        }

        private void Dgvstocking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = dal.Select();
            dgvstocking.DataSource = dt;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //getting data from UI
            s.pond_id = txtPondId.Text;
            s.added_date = DateTime.Now;
            s.species = txtSpecies.Text;
            s.quantity = txtQuantity.Text;
            s.total_cost = txtTCost.Text;
            s.remarks = txtRemarks.Text;

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
            dgvstocking.DataSource = dt;
        }

        private void clear()
        {
            txtId.Text = "";
            txtPondId.Text = "";
            txtSpecies.Text = "";
            txtQuantity.Text = "";
            txtTCost.Text = "";
            txtRemarks.Text = "";

        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;

            if (keywords != null)
            {
                DataTable dt = dal.Search(keywords);
                dgvstocking.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.Select();
                dgvstocking.DataSource = dt;
            }
        }
    }
}
