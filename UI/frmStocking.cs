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


namespace FishFarm
{
    public partial class frmStocking : Form
    {
        public frmStocking()
        {
            InitializeComponent();
        }
        StockingBLL s = new StockingBLL();
        StockingDAL dal = new StockingDAL();
        private void FrmStoking_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvstocking.DataSource = dt;

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            if (txtPondId.Text == "" || txtSpecies.Text == "" || txtAWeight.Text == "" || txtUCost.Text == "" || txtTCost.Text == "")
            {
                MessageBox.Show("All fields must be filled");
            }
            else
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
        }
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
       

        private void Dgvstocking_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtId.Text = dgvstocking.Rows[rowIndex].Cells[0].Value.ToString();
            txtPondId.Text = dgvstocking.Rows[rowIndex].Cells[2].Value.ToString();
            txtSpecies.Text = dgvstocking.Rows[rowIndex].Cells[3].Value.ToString();
            txtAWeight.Text = dgvstocking.Rows[rowIndex].Cells[4].Value.ToString();
            txtTWeight.Text = dgvstocking.Rows[rowIndex].Cells[5].Value.ToString();
            txtUCost.Text = dgvstocking.Rows[rowIndex].Cells[6].Value.ToString();
            txtTCost.Text = dgvstocking.Rows[rowIndex].Cells[7].Value.ToString();
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (txtPondId.Text == "" || txtSpecies.Text == "" || txtAWeight.Text == "" || txtUCost.Text == "" || txtTCost.Text == "")
            {
                MessageBox.Show("All fields must be filled");
            }
            else
            {
                s.id = Convert.ToInt32(txtId.Text);
                s.added_date = DateTime.Now;
                s.pond_id = Convert.ToInt32(txtPondId.Text);
                s.species = txtSpecies.Text;
                s.average_weight = txtAWeight.Text;
                s.total_weight = txtTWeight.Text;
                s.unit_cost = Convert.ToDecimal(txtUCost.Text);
                s.total_cost = Convert.ToDecimal(txtTCost.Text);

                bool success = dal.Update(s);

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
        private void TxtPondId_TextChanged(object sender, EventArgs e)
        {
            if(System.Text.RegularExpressions.Regex.IsMatch(txtPondId.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtPondId.Text = txtPondId.Text.Remove(txtPondId.Text.Length - 1);
            }
        }

        private void LblPoundId_Click(object sender, EventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (txtPondId.Text == "" || txtSpecies.Text == "" || txtAWeight.Text == "" || txtUCost.Text == "" || txtTCost.Text == "")
            {
                MessageBox.Show("All fields must be filled");
            }
            else
            {
                s.id = Convert.ToInt32(txtId.Text);
                bool isSuccess = dal.Delete(s);

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

        private void BtnReport_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "\r\n\r\n Fish Farm Management System";
            printer.SubTitle = "Stocking Report";
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
            using (FileStream stream = new FileStream(folderPath + "FishFarm_Stocking.pdf", FileMode.Create))
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

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            //Getting keywords from UI
            string keywords = txtSearch.Text;
            
            if(keywords != null)
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

