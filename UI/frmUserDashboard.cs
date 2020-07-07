using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace FishFarm.UI
{
    public partial class frmUserDashboard : Form
    {
        public frmUserDashboard()
        {
            InitializeComponent();
        }

        private void LblStoking_Click(object sender, EventArgs e)
        {
            frmUserStocking Ustocking = new frmUserStocking();
            Ustocking.Show();
        }

        private void LblPond_Click(object sender, EventArgs e)
        {
            frmUserPond pond = new frmUserPond();
            pond.Show();
        }

        private void LblSale_Click(object sender, EventArgs e)
        {
            frmUserSales sales = new frmUserSales();
            sales.Show();
        }

        private void LblCashFlow_Click(object sender, EventArgs e)
        {
            frmUserCashFlow cashFlow = new frmUserCashFlow();
            cashFlow.Show();
        }

        private void LblSalary_Click(object sender, EventArgs e)
        {
            frmUserSalary salary = new frmUserSalary();
            salary.Show();
        }

        private void LblLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
            
        }

        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var Client = new WebClient())
                using (var stream = Client.OpenRead("https://www.google.com"))
                {
                    return true;
                }
                    
            }
            catch
            {
                return false;
            }
        }
        private void LblUpdate_Click(object sender, EventArgs e)
        {
            if(CheckForInternetConnection() == true)
            {
                System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
                frmEmail email = new frmEmail();
                email.Show();
            }
            else if(CheckForInternetConnection() == false)
            {
                MessageBox.Show("You must be connected to the internet to update system");
            }
           
            
        }

        private void FrmUserDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
