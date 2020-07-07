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
    public partial class frmEmail : Form
    {
        public frmEmail()
        {
            InitializeComponent();
        }

        private void FrmEmail_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            label1.Text = progressBar1.Value.ToString() + "%";
          while(progressBar1.Value == 99)
            {
                string txtFrom = "buharinasir1996@outlook.com";
                string txtTo = "buharinasir1996@gmail.com";
                string txtSubject = "Fish Farm Management System";
                string txtMessage = "Fish Farm Management System Monthly Report for Stocking, Pond, Sales/Havesting, Cash Flow, Salary";
                string txtSmtpClient = "smtp.live.com";
                string txtUsername = "buharinasir1996@outlook.com";
                string txtPassword = "#include<Danyaya>";
                string attachment1 = "C:\\FishFarm_PDFs\\FishFarm_Stocking.pdf";
                string attachment2 = "C:\\FishFarm_PDFs\\FishFarm_pond.pdf";
                string attachment3 = "C:\\FishFarm_PDFs\\FishFarm_Salary.pdf";
                string attachment4 = "C:\\FishFarm_PDFs\\FishFarm_Sales.pdf";
                string attachment5 = "C:\\FishFarm_PDFs\\FishFarm_Cashflow.pdf";

                MailMessage mail = new MailMessage(txtFrom, txtTo, txtSubject, txtMessage);
                mail.Attachments.Add(new Attachment(attachment1));
                mail.Attachments.Add(new Attachment(attachment2));
                mail.Attachments.Add(new Attachment(attachment3));
                mail.Attachments.Add(new Attachment(attachment4));
                mail.Attachments.Add(new Attachment(attachment5));
                SmtpClient client = new SmtpClient(txtSmtpClient);
                client.Port = 587;
                client.Credentials = new System.Net.NetworkCredential(txtUsername, txtPassword);
                client.EnableSsl = true;
                client.Send(mail);
                MessageBox.Show("System Successfully Updated.");
            }
        }
    }
}
