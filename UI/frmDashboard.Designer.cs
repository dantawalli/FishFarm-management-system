namespace FishFarm
{
    partial class frmDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLogout = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblCashFlow = new System.Windows.Forms.Label();
            this.lblSale = new System.Windows.Forms.Label();
            this.lblPond = new System.Windows.Forms.Label();
            this.lblStoking = new System.Windows.Forms.Label();
            this.lblLogoTile = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblFooter = new System.Windows.Forms.Label();
            this.pnlStocking = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStockingRecords = new System.Windows.Forms.Label();
            this.pnlPond = new System.Windows.Forms.Panel();
            this.lblPondReport = new System.Windows.Forms.Label();
            this.lblPondRecords = new System.Windows.Forms.Label();
            this.pnlSales = new System.Windows.Forms.Panel();
            this.lblSalesReport = new System.Windows.Forms.Label();
            this.lblSalesRecord = new System.Windows.Forms.Label();
            this.pnlCashFlow = new System.Windows.Forms.Panel();
            this.lblCashFlowReports = new System.Windows.Forms.Label();
            this.lblCashflowRecords = new System.Windows.Forms.Label();
            this.pnlSalary = new System.Windows.Forms.Panel();
            this.lblSalaryReports = new System.Windows.Forms.Label();
            this.lblSalaryRecords = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.pnlStocking.SuspendLayout();
            this.pnlPond.SuspendLayout();
            this.pnlSales.SuspendLayout();
            this.pnlCashFlow.SuspendLayout();
            this.pnlSalary.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(107)))));
            this.pnlTop.Controls.Add(this.label2);
            this.pnlTop.Controls.Add(this.lblLogout);
            this.pnlTop.Controls.Add(this.lblSalary);
            this.pnlTop.Controls.Add(this.lblCashFlow);
            this.pnlTop.Controls.Add(this.lblSale);
            this.pnlTop.Controls.Add(this.lblPond);
            this.pnlTop.Controls.Add(this.lblStoking);
            this.pnlTop.Controls.Add(this.lblLogoTile);
            this.pnlTop.Controls.Add(this.picLogo);
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1499, 50);
            this.pnlTop.TabIndex = 0;
            this.pnlTop.TabStop = true;
            this.pnlTop.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlTop_Paint);
            this.pnlTop.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(268, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Users";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            this.label2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseClick);
            this.label2.MouseLeave += new System.EventHandler(this.Label2_MouseLeave);
            this.label2.MouseHover += new System.EventHandler(this.Label2_MouseHover);
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogout.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.ForeColor = System.Drawing.Color.White;
            this.lblLogout.Location = new System.Drawing.Point(1289, 12);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(77, 25);
            this.lblLogout.TabIndex = 8;
            this.lblLogout.Text = "Logout";
            this.lblLogout.Click += new System.EventHandler(this.LblLogout_Click);
            this.lblLogout.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LblUsersReports_MouseClick);
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSalary.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.ForeColor = System.Drawing.Color.White;
            this.lblSalary.Location = new System.Drawing.Point(1082, 14);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(67, 25);
            this.lblSalary.TabIndex = 7;
            this.lblSalary.Text = "Salary";
            this.lblSalary.Click += new System.EventHandler(this.LblSalary_Click);
            this.lblSalary.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseClick);
            // 
            // lblCashFlow
            // 
            this.lblCashFlow.AutoSize = true;
            this.lblCashFlow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCashFlow.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashFlow.ForeColor = System.Drawing.Color.White;
            this.lblCashFlow.Location = new System.Drawing.Point(888, 14);
            this.lblCashFlow.Name = "lblCashFlow";
            this.lblCashFlow.Size = new System.Drawing.Size(100, 25);
            this.lblCashFlow.TabIndex = 6;
            this.lblCashFlow.Text = "Cash Flow";
            this.lblCashFlow.Click += new System.EventHandler(this.LblCashFlow_Click);
            this.lblCashFlow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseClick);
            // 
            // lblSale
            // 
            this.lblSale.AutoSize = true;
            this.lblSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSale.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSale.ForeColor = System.Drawing.Color.White;
            this.lblSale.Location = new System.Drawing.Point(753, 14);
            this.lblSale.Name = "lblSale";
            this.lblSale.Size = new System.Drawing.Size(56, 25);
            this.lblSale.TabIndex = 5;
            this.lblSale.Text = "Sales";
            this.lblSale.Click += new System.EventHandler(this.LblSale_Click);
            this.lblSale.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseClick);
            // 
            // lblPond
            // 
            this.lblPond.AutoSize = true;
            this.lblPond.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPond.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPond.ForeColor = System.Drawing.Color.White;
            this.lblPond.Location = new System.Drawing.Point(608, 12);
            this.lblPond.Name = "lblPond";
            this.lblPond.Size = new System.Drawing.Size(59, 25);
            this.lblPond.TabIndex = 4;
            this.lblPond.Text = "Pond";
            this.lblPond.Click += new System.EventHandler(this.LblPond_Click);
            this.lblPond.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseClick);
            // 
            // lblStoking
            // 
            this.lblStoking.AutoSize = true;
            this.lblStoking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblStoking.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoking.ForeColor = System.Drawing.Color.White;
            this.lblStoking.Location = new System.Drawing.Point(416, 13);
            this.lblStoking.Name = "lblStoking";
            this.lblStoking.Size = new System.Drawing.Size(91, 25);
            this.lblStoking.TabIndex = 3;
            this.lblStoking.Text = "Stocking";
            this.lblStoking.Click += new System.EventHandler(this.LblStoking_Click);
            this.lblStoking.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseClick);
            this.lblStoking.MouseHover += new System.EventHandler(this.LblStoking_MouseHover);
            // 
            // lblLogoTile
            // 
            this.lblLogoTile.AutoSize = true;
            this.lblLogoTile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogoTile.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogoTile.ForeColor = System.Drawing.Color.White;
            this.lblLogoTile.Location = new System.Drawing.Point(58, 9);
            this.lblLogoTile.Name = "lblLogoTile";
            this.lblLogoTile.Size = new System.Drawing.Size(106, 30);
            this.lblLogoTile.TabIndex = 1;
            this.lblLogoTile.Text = "Fish Farm";
            this.lblLogoTile.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseClick);
            // 
            // picLogo
            // 
            this.picLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(52, 53);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            this.picLogo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(107)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageIndex = 0;
            this.label1.Location = new System.Drawing.Point(503, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "MANAGEMENT SYSTEM";
            this.label1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(443, 191);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(444, 432);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseClick);
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(107)))));
            this.pnlFooter.Controls.Add(this.lblFooter);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 657);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1354, 50);
            this.pnlFooter.TabIndex = 4;
            this.pnlFooter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseClick);
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter.ForeColor = System.Drawing.Color.White;
            this.lblFooter.Location = new System.Drawing.Point(452, 16);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(422, 25);
            this.lblFooter.TabIndex = 0;
            this.lblFooter.Text = "Fish Farm management system copyright 2019";
            this.lblFooter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseClick);
            // 
            // pnlStocking
            // 
            this.pnlStocking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(107)))));
            this.pnlStocking.Controls.Add(this.label3);
            this.pnlStocking.Controls.Add(this.lblStockingRecords);
            this.pnlStocking.Location = new System.Drawing.Point(372, 50);
            this.pnlStocking.Name = "pnlStocking";
            this.pnlStocking.Size = new System.Drawing.Size(179, 100);
            this.pnlStocking.TabIndex = 6;
            this.pnlStocking.Visible = false;
            this.pnlStocking.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Stocking Report";
            this.label3.Click += new System.EventHandler(this.Label3_Click_1);
            this.label3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseClick);
            // 
            // lblStockingRecords
            // 
            this.lblStockingRecords.AutoSize = true;
            this.lblStockingRecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblStockingRecords.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockingRecords.ForeColor = System.Drawing.Color.White;
            this.lblStockingRecords.Location = new System.Drawing.Point(9, 14);
            this.lblStockingRecords.Name = "lblStockingRecords";
            this.lblStockingRecords.Size = new System.Drawing.Size(167, 25);
            this.lblStockingRecords.TabIndex = 10;
            this.lblStockingRecords.Text = "Stocking Records";
            this.lblStockingRecords.Click += new System.EventHandler(this.LblStockingRecords_Click);
            this.lblStockingRecords.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseClick);
            // 
            // pnlPond
            // 
            this.pnlPond.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(107)))));
            this.pnlPond.Controls.Add(this.lblPondReport);
            this.pnlPond.Controls.Add(this.lblPondRecords);
            this.pnlPond.Location = new System.Drawing.Point(545, 50);
            this.pnlPond.Name = "pnlPond";
            this.pnlPond.Size = new System.Drawing.Size(179, 100);
            this.pnlPond.TabIndex = 12;
            this.pnlPond.Visible = false;
            // 
            // lblPondReport
            // 
            this.lblPondReport.AutoSize = true;
            this.lblPondReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPondReport.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPondReport.ForeColor = System.Drawing.Color.White;
            this.lblPondReport.Location = new System.Drawing.Point(24, 52);
            this.lblPondReport.Name = "lblPondReport";
            this.lblPondReport.Size = new System.Drawing.Size(126, 25);
            this.lblPondReport.TabIndex = 11;
            this.lblPondReport.Text = "Pond Report";
            this.lblPondReport.Click += new System.EventHandler(this.LblPondReport_Click);
            // 
            // lblPondRecords
            // 
            this.lblPondRecords.AutoSize = true;
            this.lblPondRecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPondRecords.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPondRecords.ForeColor = System.Drawing.Color.White;
            this.lblPondRecords.Location = new System.Drawing.Point(24, 12);
            this.lblPondRecords.Name = "lblPondRecords";
            this.lblPondRecords.Size = new System.Drawing.Size(135, 25);
            this.lblPondRecords.TabIndex = 10;
            this.lblPondRecords.Text = "Pond Records";
            this.lblPondRecords.Click += new System.EventHandler(this.LblPondRecords_Click);
            // 
            // pnlSales
            // 
            this.pnlSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(107)))));
            this.pnlSales.Controls.Add(this.lblSalesReport);
            this.pnlSales.Controls.Add(this.lblSalesRecord);
            this.pnlSales.Location = new System.Drawing.Point(700, 50);
            this.pnlSales.Name = "pnlSales";
            this.pnlSales.Size = new System.Drawing.Size(179, 100);
            this.pnlSales.TabIndex = 13;
            this.pnlSales.Visible = false;
            // 
            // lblSalesReport
            // 
            this.lblSalesReport.AutoSize = true;
            this.lblSalesReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSalesReport.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesReport.ForeColor = System.Drawing.Color.White;
            this.lblSalesReport.Location = new System.Drawing.Point(24, 52);
            this.lblSalesReport.Name = "lblSalesReport";
            this.lblSalesReport.Size = new System.Drawing.Size(123, 25);
            this.lblSalesReport.TabIndex = 11;
            this.lblSalesReport.Text = "Sales Report";
            this.lblSalesReport.Click += new System.EventHandler(this.LblSalesReport_Click);
            // 
            // lblSalesRecord
            // 
            this.lblSalesRecord.AutoSize = true;
            this.lblSalesRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSalesRecord.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesRecord.ForeColor = System.Drawing.Color.White;
            this.lblSalesRecord.Location = new System.Drawing.Point(24, 12);
            this.lblSalesRecord.Name = "lblSalesRecord";
            this.lblSalesRecord.Size = new System.Drawing.Size(132, 25);
            this.lblSalesRecord.TabIndex = 10;
            this.lblSalesRecord.Text = "Sales Records";
            this.lblSalesRecord.Click += new System.EventHandler(this.LblSalesRecord_Click);
            // 
            // pnlCashFlow
            // 
            this.pnlCashFlow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(107)))));
            this.pnlCashFlow.Controls.Add(this.lblCashFlowReports);
            this.pnlCashFlow.Controls.Add(this.lblCashflowRecords);
            this.pnlCashFlow.Location = new System.Drawing.Point(852, 50);
            this.pnlCashFlow.Name = "pnlCashFlow";
            this.pnlCashFlow.Size = new System.Drawing.Size(179, 100);
            this.pnlCashFlow.TabIndex = 14;
            this.pnlCashFlow.Visible = false;
            // 
            // lblCashFlowReports
            // 
            this.lblCashFlowReports.AutoSize = true;
            this.lblCashFlowReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCashFlowReports.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashFlowReports.ForeColor = System.Drawing.Color.White;
            this.lblCashFlowReports.Location = new System.Drawing.Point(8, 57);
            this.lblCashFlowReports.Name = "lblCashFlowReports";
            this.lblCashFlowReports.Size = new System.Drawing.Size(167, 25);
            this.lblCashFlowReports.TabIndex = 11;
            this.lblCashFlowReports.Text = "Cash Flow Report";
            this.lblCashFlowReports.Click += new System.EventHandler(this.LblCashFlowReports_Click);
            // 
            // lblCashflowRecords
            // 
            this.lblCashflowRecords.AutoSize = true;
            this.lblCashflowRecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCashflowRecords.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashflowRecords.ForeColor = System.Drawing.Color.White;
            this.lblCashflowRecords.Location = new System.Drawing.Point(7, 14);
            this.lblCashflowRecords.Name = "lblCashflowRecords";
            this.lblCashflowRecords.Size = new System.Drawing.Size(168, 25);
            this.lblCashflowRecords.TabIndex = 10;
            this.lblCashflowRecords.Text = "Cash Flow Record";
            this.lblCashflowRecords.Click += new System.EventHandler(this.LblCashflowRecords_Click);
            // 
            // pnlSalary
            // 
            this.pnlSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(107)))));
            this.pnlSalary.Controls.Add(this.lblSalaryReports);
            this.pnlSalary.Controls.Add(this.lblSalaryRecords);
            this.pnlSalary.Location = new System.Drawing.Point(1030, 50);
            this.pnlSalary.Name = "pnlSalary";
            this.pnlSalary.Size = new System.Drawing.Size(179, 100);
            this.pnlSalary.TabIndex = 15;
            this.pnlSalary.Visible = false;
            // 
            // lblSalaryReports
            // 
            this.lblSalaryReports.AutoSize = true;
            this.lblSalaryReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSalaryReports.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalaryReports.ForeColor = System.Drawing.Color.White;
            this.lblSalaryReports.Location = new System.Drawing.Point(21, 58);
            this.lblSalaryReports.Name = "lblSalaryReports";
            this.lblSalaryReports.Size = new System.Drawing.Size(134, 25);
            this.lblSalaryReports.TabIndex = 11;
            this.lblSalaryReports.Text = "Salary Report";
            this.lblSalaryReports.Click += new System.EventHandler(this.LblSalaryReports_Click);
            // 
            // lblSalaryRecords
            // 
            this.lblSalaryRecords.AutoSize = true;
            this.lblSalaryRecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSalaryRecords.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalaryRecords.ForeColor = System.Drawing.Color.White;
            this.lblSalaryRecords.Location = new System.Drawing.Point(21, 14);
            this.lblSalaryRecords.Name = "lblSalaryRecords";
            this.lblSalaryRecords.Size = new System.Drawing.Size(135, 25);
            this.lblSalaryRecords.TabIndex = 10;
            this.lblSalaryRecords.Text = "Salary Record";
            this.lblSalaryRecords.Click += new System.EventHandler(this.LblSalaryRecords_Click);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1354, 707);
            this.Controls.Add(this.pnlSalary);
            this.Controls.Add(this.pnlCashFlow);
            this.Controls.Add(this.pnlSales);
            this.Controls.Add(this.pnlPond);
            this.Controls.Add(this.pnlStocking);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fish Farm Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmUserDashboard_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.pnlStocking.ResumeLayout(false);
            this.pnlStocking.PerformLayout();
            this.pnlPond.ResumeLayout(false);
            this.pnlPond.PerformLayout();
            this.pnlSales.ResumeLayout(false);
            this.pnlSales.PerformLayout();
            this.pnlCashFlow.ResumeLayout(false);
            this.pnlCashFlow.PerformLayout();
            this.pnlSalary.ResumeLayout(false);
            this.pnlSalary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblLogoTile;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblCashFlow;
        private System.Windows.Forms.Label lblSale;
        private System.Windows.Forms.Label lblPond;
        private System.Windows.Forms.Label lblStoking;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlStocking;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStockingRecords;
        private System.Windows.Forms.Panel pnlPond;
        private System.Windows.Forms.Label lblPondReport;
        private System.Windows.Forms.Label lblPondRecords;
        private System.Windows.Forms.Panel pnlSales;
        private System.Windows.Forms.Label lblSalesReport;
        private System.Windows.Forms.Label lblSalesRecord;
        private System.Windows.Forms.Panel pnlCashFlow;
        private System.Windows.Forms.Label lblCashFlowReports;
        private System.Windows.Forms.Label lblCashflowRecords;
        private System.Windows.Forms.Panel pnlSalary;
        private System.Windows.Forms.Label lblSalaryReports;
        private System.Windows.Forms.Label lblSalaryRecords;
    }
}