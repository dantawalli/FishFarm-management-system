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
    public partial class frmUserStocking : Form
    {
        public frmUserStocking()
        {
            InitializeComponent();
        }
        StockingBLL s = new StockingBLL();
        StockingDAL dal = new StockingDAL();

        

        private void clear()
        {
            txtId.Text = "";
            txtPondId.Text = "";
            txtSpecies.Text = "";
            txtAWeight.Text = "";
            txtTWeight.Text = "";
            txtUCost.Text = "";
            txtTCost.Text = "";
        }

        private void FrmUserStocking_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvstocking.DataSource = dt;
        }

      
        private void BtnAdd_Click_1(object sender, EventArgs e)
        {

            //getting data from UI
            s.added_date = DateTime.Now;
            s.pond_id = Convert.ToInt32(txtPondId.Text);
            s.species = txtSpecies.Text;
            s.average_weight = txtAWeight.Text;
            s.total_weight = txtTWeight.Text;
            s.unit_cost = Convert.ToDecimal(txtUCost.Text);
            s.total_cost = Convert.ToDecimal(txtTCost.Text);

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

        private void TxtSearch_TextChanged_1(object sender, EventArgs e)
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
