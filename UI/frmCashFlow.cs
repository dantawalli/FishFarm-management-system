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
    public partial class frmCashFlow : Form
    {
        public frmCashFlow()
        {
            InitializeComponent();
        }

        CashInBLL c = new CashInBLL();
        CashInDAL dal = new CashInDAL();
        cashOutBLL co = new cashOutBLL();
        cashOutDAL odal = new cashOutDAL();


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

        private void BtnReport_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "\r\n\r\n Fish Farm Management System";
            printer.SubTitle = "Cash Flow Report";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Thank you for using Fish Farm Management system";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvcashflow);
        }
        private void Dgvcashflow_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtId.Text = dgvcashflow.Rows[rowIndex].Cells[0].Value.ToString();
            txtSource.Text = dgvcashflow.Rows[rowIndex].Cells[2].Value.ToString();
            txtAmount.Text = dgvcashflow.Rows[rowIndex].Cells[3].Value.ToString();
            txtComments.Text = dgvcashflow.Rows[rowIndex].Cells[4].Value.ToString();

            txtIdOut.Text = dgvcashflow.Rows[rowIndex].Cells[5].Value.ToString();
            txtActivity.Text = dgvcashflow.Rows[rowIndex].Cells[7].Value.ToString();
            txtAmountOut.Text = dgvcashflow.Rows[rowIndex].Cells[8].Value.ToString();
            txtCommentsOut.Text = dgvcashflow.Rows[rowIndex].Cells[9].Value.ToString();
        }
        private void Dgvstocking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtId.Text = dgvcashflow.Rows[rowIndex].Cells[0].Value.ToString();
            txtSource.Text = dgvcashflow.Rows[rowIndex].Cells[2].Value.ToString();
            txtAmount.Text = dgvcashflow.Rows[rowIndex].Cells[3].Value.ToString();
            txtComments.Text = dgvcashflow.Rows[rowIndex].Cells[4].Value.ToString();

            txtIdOut.Text = dgvcashflow.Rows[rowIndex].Cells[5].Value.ToString();
            txtActivity.Text = dgvcashflow.Rows[rowIndex].Cells[7].Value.ToString();
            txtAmountOut.Text = dgvcashflow.Rows[rowIndex].Cells[8].Value.ToString();
            txtCommentsOut.Text = dgvcashflow.Rows[rowIndex].Cells[9].Value.ToString();
        }

        private void FrmCashFlow_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvcashflow.DataSource = dt;

            DataTable dto = odal.Select();
            dgvcashflow.DataSource = dto;
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

        private void clear()
        {
            txtId.Text = "";
            txtSource.Text = "";
            txtAmount.Text = "";
            txtComments.Text = "";

        }

        private void clearOut()
        {
            txtIdOut.Text = "";
            txtActivity.Text = "";
            txtAmountOut.Text = "";
            txtCommentsOut.Text = "";
        }


        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            c.id = Convert.ToInt32(txtId.Text);
            c.date = DateTime.Now;
            c.source = txtSource.Text;
            c.amount = txtAmount.Text;
            c.comment = txtComments.Text;

            bool success = dal.Update(c);

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
            dgvcashflow.DataSource = dt;
        }

        private void LblSearch_Click(object sender, EventArgs e)
        {

        }

        private void BtnPDF_Click(object sender, EventArgs e)
        {
            // Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(dgvcashflow.ColumnCount);
            pdfTable.DefaultCell.Padding = 10;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 2;

           
            //Adding Header row
            foreach (DataGridViewColumn column in dgvcashflow.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(237, 237, 235);
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (DataGridViewRow row in dgvcashflow.Rows)
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
            using (FileStream stream = new FileStream(folderPath + "FishFarm_Cashflow.pdf", FileMode.Create))
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

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            c.id = Convert.ToInt32(txtId.Text);
            bool isSuccess = dal.Delete(c);

            if (isSuccess == true)
            {
                MessageBox.Show("Record successfully deleted");
                clear();
            }
            else
            {
                MessageBox.Show("Record Failed to delete");
            }
            DataTable dto = odal.Select();
            dgvcashflow.DataSource = dto;
        }

        private void Button3_Click(object sender, EventArgs e)
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

        private void BtnUpdateOut_Click(object sender, EventArgs e)
        {
            co.id = Convert.ToInt32(txtIdOut.Text);
            co.date = DateTime.Now;
            co.activity = txtActivity.Text;
            co.amount = txtAmountOut.Text;
            co.comment = txtCommentsOut.Text;

            bool success = odal.Update(co);

            if (success == true)
            {
                MessageBox.Show("Record successfully updated");
                clearOut();
            }
            else
            {
                MessageBox.Show("Record failed to update");
            }
            DataTable dto = odal.Select();
            dgvcashflow.DataSource = dto;
        }

        private void BtnDeleteOut_Click(object sender, EventArgs e)
        {
            co.id = Convert.ToInt32(txtIdOut.Text);
            bool isSuccess = odal.Delete(co);

            if (isSuccess == true)
            {
                MessageBox.Show("Record successfully deleted");
                clearOut();
            }
            else
            {
                MessageBox.Show("Record Failed to delete");
            }
            DataTable dt = dal.Select();
            dgvcashflow.DataSource = dt;
        }
    }
    }
