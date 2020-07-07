using FishFarm.BLL;
using FishFarm.DAL;
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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        UsersDAL dal = new UsersDAL();
        UsersBLL u = new UsersBLL();
        public int dash = 0;
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            DataTable data = dal.SelectAll();          
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            foreach (DataRow row in data.Rows)
            {
                string DBusername = row["Username"].ToString();
                string DBPassword = row["Password"].ToString();
                string DBUserType = row["UserType"].ToString();
                if (username == DBusername && password == DBPassword && DBUserType == "User")
                {
                    dash = 2;
                    break;
                
                }
                else if (username == DBusername && password == DBPassword && DBUserType == "Admin")
                {
                    dash = 1;
                    break;
                    
                }
                else
                {
                    dash = 0;
                    
                }
            }

            this.Hide();
            if(dash == 0)
            {
                MessageBox.Show("Wrong Username/Password Combination");
                FrmLogin FL = new FrmLogin();
                FL.Show();
            }
            else if(dash == 1)
            {
                frmDashboard FDB = new frmDashboard();
                FDB.Show();
            }
            else if(dash == 2)
            {
                frmUserDashboard FUDB = new frmUserDashboard();
                FUDB.Show();
            }
            
            
        }

        private void PnlTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtUsername_Validated(object sender, EventArgs e)
        {

        }
    }
    }

