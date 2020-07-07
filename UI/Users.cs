using DGVPrinterHelper;
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
using System.IO;
using System.Reflection;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace FishFarm.UI
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }
        UsersDAL dal = new UsersDAL();
        UsersBLL u = new UsersBLL();

        private void LblHeader_Click(object sender, EventArgs e)
        {

        }
        private void clear()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }
        #region checking empty fields
        private bool notEmpty()
        {
            if(txtAUsername.Text == "" || txtAPassword.Text == "")
            {
                return true;
            }
            return false;
        }
        #endregion
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            u.ID = 1;
            u.Username = txtAUsername.Text;
            u.Password = txtAPassword.Text;
            u.UserType = "Admin";

            if (txtAUsername.Text == "")
            {
                MessageBox.Show("Username cannot empty");
            }
           else if (txtAPassword.Text == "")
            {
                MessageBox.Show("Password cannot empty");
            }
            else
            {
                bool success = dal.Update(u);

                if (success == true)
                {
                    MessageBox.Show("Record successfully updated");
                    clear();
                }
                else
                {
                    MessageBox.Show("Record failed to update");
                }
                DataTable dt = dal.Select();
                dgvstocking.DataSource = dt;


            }
        }

        private void Users_Load(object sender, EventArgs e)
        {
            DataTable data = dal.SelectAll();
            
            
                txtAUsername.Text = data.Rows[0]["Username"].ToString();
                txtAPassword.Text = data.Rows[0]["Password"].ToString();
                DataTable dt = dal.Select();
                dgvstocking.DataSource = dt;
            

        }
        #region checking empty fields
        private bool UserNotEmpty()
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                return true;
            }
            return false;
        }
        #endregion

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Select what you want to update from the list");
            }
            else
            {
                u.ID = Convert.ToInt32(txtID.Text);
                u.Username = txtUsername.Text;
                u.Password = txtPassword.Text;
                u.UserType = "User";

                if (txtUsername.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Username or  password cannot be empty");
                }
                else
                {
                    bool success = dal.Update(u);

                    if (success == true)
                    {
                        MessageBox.Show("Record successfully updated");
                    }
                    else
                    {
                        MessageBox.Show("Record failed to update");
                    }

                    DataTable dt = dal.Select();
                    dgvstocking.DataSource = dt;
                }
            }
            }
        
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //getting data from UI
            u.Username = txtUsername.Text;
            u.Password = txtPassword.Text;
            u.UserType = "User";
            if (UserNotEmpty() == true)
            {
                MessageBox.Show("Username or password cannot be empty");
            }
            else
            {
                //Insert Data into database
                bool success = dal.Insert(u);

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
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Select what you want to delete from the list");
            }
            else
            {
                u.ID = Convert.ToInt32(txtID.Text);
                bool isSuccess = dal.Delete(u);

                if (isSuccess == true)
                {
                    MessageBox.Show("Record successfully deleted");
                    clear();
                }
                else
                {
                    MessageBox.Show("Record Failed to delete");
                }
                DataTable dt = dal.Select();
                dgvstocking.DataSource = dt;
            }
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

        private void Dgvstocking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "\r\n\r\n Fish Farm Management System";
            printer.SubTitle = "Users Report";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Thank you for using Fish Farm Management system";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvstocking);
        }

        private void BtnPDF_Click(object sender, EventArgs e)
        {
            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(dgvstocking.ColumnCount);
            pdfTable.DefaultCell.Padding = 10;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 2;

            //Adding Header row
            foreach (DataGridViewColumn column in dgvstocking.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(237, 237, 235);
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (DataGridViewRow row in dgvstocking.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(cell.Value.ToString());
                }
            }

            //Exporting to PDF
            string folderPath = "C:\\FishFarm_PDFs\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + "FishFarm_Users.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
            }
            MessageBox.Show("PDF  file successfully created check C:\\FishFarm_PDFs for your PDF");
        }

        private void Dgvstocking_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
            int rowIndex = e.RowIndex;
            String txtUserType = dgvstocking.Rows[rowIndex].Cells[3].Value.ToString();
            if(txtUserType == "Admin")
            {
                txtID.Text = dgvstocking.Rows[rowIndex].Cells[0].Value.ToString();
                txtAUsername.Text = dgvstocking.Rows[rowIndex].Cells[1].Value.ToString();
                txtAPassword.Text = dgvstocking.Rows[rowIndex].Cells[2].Value.ToString();
            }
            else if(txtUserType == "User")
            {
                txtID.Text = dgvstocking.Rows[rowIndex].Cells[0].Value.ToString();
                txtUsername.Text = dgvstocking.Rows[rowIndex].Cells[1].Value.ToString();
                txtPassword.Text = dgvstocking.Rows[rowIndex].Cells[2].Value.ToString();

            }
           
        
            

        }

        private void TxtAUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
