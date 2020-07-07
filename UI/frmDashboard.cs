using FishFarm.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishFarm
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void PnlTop_Paint(object sender, PaintEventArgs e)
        {
            pnlCashFlow.Hide();
            pnlPond.Hide();
            pnlSales.Hide();
            pnlStocking.Hide();
            pnlSalary.Hide();
        }

        private void FrmUserDashboard_Load(object sender, EventArgs e)
        {

        }

        private void LblLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void LblStoking_Click(object sender, EventArgs e)
        {
            pnlStocking.Show();
            pnlPond.Hide();
            pnlSales.Hide();
            pnlCashFlow.Hide();
            pnlSalary.Hide();

        }

        private void LblPond_Click(object sender, EventArgs e)
        {
  
            pnlStocking.Hide();
            pnlPond.Show();
            pnlSales.Hide();
            pnlCashFlow.Hide();
            pnlSalary.Hide();
        }

        private void LblSale_Click(object sender, EventArgs e)
        {
 
            pnlStocking.Hide();
            pnlPond.Hide();
            pnlSales.Show();
            pnlCashFlow.Hide();
            pnlSalary.Hide();
        }

        private void LblCashFlow_Click(object sender, EventArgs e)
        {
            pnlStocking.Hide();
            pnlPond.Hide();
            pnlSales.Hide();
            pnlCashFlow.Show();
            pnlSalary.Hide();
        }

        private void LblSalary_Click(object sender, EventArgs e)
        {
            pnlStocking.Hide();
            pnlPond.Hide();
            pnlSales.Hide();
            pnlCashFlow.Hide();
            pnlSalary.Show();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            user.Show();
            pnlStocking.Hide();
            pnlPond.Hide();
            pnlSales.Hide();
            pnlCashFlow.Hide();
            pnlSalary.Hide();
        }

        private void UsersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {
           
          
        }

        private void Label2_MouseHover(object sender, EventArgs e)
        {
          //  pnlUsers.Show();
        }

        private void Label2_MouseLeave(object sender, EventArgs e)
        {
           // pnlUsers.Hide();
        }

        private void PnlUsers_MouseHover(object sender, EventArgs e)
        {

        }

        private void Label2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void LblUsersReports_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void LblStoking_MouseHover(object sender, EventArgs e)
        {
           // pnlStocking.Show();
        }

        private void LblStockingRecords_Click(object sender, EventArgs e)
        {
            frmStocking stocking = new frmStocking();
            stocking.Show();
            pnlStocking.Hide();
        }

        private void LblLogout_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void PnlTop_Click(object sender, EventArgs e)
        {
      
        }

        private void PnlTop_MouseClick(object sender, MouseEventArgs e)
        {
            ///frmDashboard frmDashboard = new frmDashboard();
               // frmDashboard.Show();
        }

        private void LblPondRecords_Click(object sender, EventArgs e)
        {
            frmPond pond = new frmPond();
            pond.Show();
            pnlPond.Hide();
        }

        private void LblSalesRecord_Click(object sender, EventArgs e)
        {
            frmSales sales = new frmSales();
            sales.Show();
            pnlSales.Hide();

        }

        private void LblCashflowRecords_Click(object sender, EventArgs e)
        {

            frmCashFlow cashflow = new frmCashFlow();
            cashflow.Show();
            pnlCashFlow.Hide();
        }

        private void LblSalaryRecords_Click(object sender, EventArgs e)
        {

            frmSalary salary = new frmSalary();
            salary.Show();
            pnlSalary.Hide();
        }

        private void Label3_Click_1(object sender, EventArgs e)
        {
            frmStockingReport stockingReport = new frmStockingReport();
            stockingReport.Show();
            pnlStocking.Hide();
        }

        private void LblPondReport_Click(object sender, EventArgs e)
        {
            frmPondReport pondReport = new frmPondReport();
            pondReport.Show();
            pnlPond.Hide();
        }

        private void LblSalesReport_Click(object sender, EventArgs e)
        {
            frmSalesReport salesReport = new frmSalesReport();
            salesReport.Show();
            pnlSales.Hide();
        }

        private void LblCashFlowReports_Click(object sender, EventArgs e)
        {
            frmCashFlowReport cashFlowReport = new frmCashFlowReport();
            cashFlowReport.Show();
            pnlCashFlow.Hide();
        }

        private void LblSalaryReports_Click(object sender, EventArgs e)
        {
            frmSalaryReport salaryReport = new frmSalaryReport();
            salaryReport.Show();
            pnlSalary.Hide();
        }
    }
}
