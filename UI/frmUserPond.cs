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
    public partial class frmUserPond : Form
    {
        public frmUserPond()
        {
            InitializeComponent();
        }
        PondBLL p = new PondBLL();
        PondDAL dal = new PondDAL();
        private void FrmUserPond_Load(object sender, EventArgs e)
        {

            DataTable dt = dal.Select();
            dgvstocking.DataSource = dt;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //getting data from UI
            p.pond_id = txtPondId.Text;
            p.added_date = DateTime.Now;
            p.input_type = txtInputType.Text;
            p.qty = txtQuantity.Text;
            p.total_cost = txtTCost.Text;
            p.remarks = txtRemarks.Text;

            //Insert Data into database
            bool success = dal.Insert(p);

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
            txtInputType.Text = "";
            txtQuantity.Text = "";
            txtTCost.Text = "";
            txtRemarks.Text = "";

        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            //Getting keywords from UI
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
