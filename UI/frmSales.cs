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
    public partial class frmSales : Form
    {
        public frmSales()
        {
            InitializeComponent();
        }
        SalesBLL s = new SalesBLL();
        SalesDAL dal = new SalesDAL();


        private void FrmSales_Load(object sender, EventArgs e)
        {

            DataTable dt = dal.Select();
            dgvstocking.DataSource = dt;
        }

        private void BtnAdd_Click_1(object sender, EventArgs e)
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

     

       

        private void BtnUpdate_Click_1(object sender, EventArgs e)
        {
            s.id = Convert.ToInt32(txtId.Text);
            s.pond_id = txtPondId.Text;
            s.added_date = DateTime.Now;
            s.species = txtSpecies.Text;
            s.quantity = txtQuantity.Text;
            s.total_cost = txtTCost.Text;
            s.remarks = txtRemarks.Text;

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

        private void BtnDelete_Click_1(object sender, EventArgs e)
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

       

     

       

        private void Dgvstocking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtId.Text = dgvstocking.Rows[rowIndex].Cells[0].Value.ToString();
            txtPondId.Text = dgvstocking.Rows[rowIndex].Cells[1].Value.ToString();
            txtSpecies.Text = dgvstocking.Rows[rowIndex].Cells[3].Value.ToString();
            txtQuantity.Text = dgvstocking.Rows[rowIndex].Cells[4].Value.ToString();
            txtTCost.Text = dgvstocking.Rows[rowIndex].Cells[5].Value.ToString();
            txtRemarks.Text = dgvstocking.Rows[rowIndex].Cells[6].Value.ToString();

        }

        private void Dgvstocking_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtId.Text = dgvstocking.Rows[rowIndex].Cells[0].Value.ToString();
            txtPondId.Text = dgvstocking.Rows[rowIndex].Cells[1].Value.ToString();
            txtSpecies.Text = dgvstocking.Rows[rowIndex].Cells[3].Value.ToString();
            txtQuantity.Text = dgvstocking.Rows[rowIndex].Cells[4].Value.ToString();
            txtTCost.Text = dgvstocking.Rows[rowIndex].Cells[5].Value.ToString();
            txtRemarks.Text = dgvstocking.Rows[rowIndex].Cells[6].Value.ToString();

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

        private void BtnReport_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "\r\n\r\n Fish Farm Management System";
            printer.SubTitle = "Sales Report";
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
            // Creating iTextSharp Table from the DataTable data
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
            using (FileStream stream = new FileStream(folderPath + "FishFarm_Sales.pdf", FileMode.Create))
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
    }
    }


