namespace FishFarm.UI
{
    partial class frmSalesReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesReport));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.lblYearly = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblQuantityFed = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlPond = new System.Windows.Forms.Panel();
            this.lblPondNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbldateOrYear = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlPond.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1317, 74);
            this.pnlHeader.TabIndex = 117;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(107)))));
            this.lblHeader.Location = new System.Drawing.Point(560, 20);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(160, 30);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "SALES REPORT";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.lblTotalCost);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(869, 223);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 115);
            this.panel1.TabIndex = 124;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.ForeColor = System.Drawing.Color.White;
            this.lblTotalCost.Location = new System.Drawing.Point(12, 57);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(190, 21);
            this.lblTotalCost.TabIndex = 1;
            this.lblTotalCost.Text = "00000000000000000000";
            this.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(64, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total Cost";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbYear
            // 
            this.cmbYear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(918, 110);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(216, 25);
            this.cmbYear.TabIndex = 121;
            this.cmbYear.SelectedValueChanged += new System.EventHandler(this.CmbYear_SelectedValueChanged);
            // 
            // lblYearly
            // 
            this.lblYearly.AutoSize = true;
            this.lblYearly.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearly.Location = new System.Drawing.Point(845, 111);
            this.lblYearly.Name = "lblYearly";
            this.lblYearly.Size = new System.Drawing.Size(43, 21);
            this.lblYearly.TabIndex = 120;
            this.lblYearly.Text = "Year";
            // 
            // cmbMonth
            // 
            this.cmbMonth.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June ",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbMonth.Location = new System.Drawing.Point(154, 111);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(216, 25);
            this.cmbMonth.TabIndex = 119;
            this.cmbMonth.SelectedValueChanged += new System.EventHandler(this.CmbMonth_SelectedValueChanged);
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.Location = new System.Drawing.Point(76, 112);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(61, 21);
            this.lblMonth.TabIndex = 118;
            this.lblMonth.Text = "Month";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(108)))));
            this.panel2.Controls.Add(this.lblQuantityFed);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(533, 223);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 115);
            this.panel2.TabIndex = 123;
            // 
            // lblQuantityFed
            // 
            this.lblQuantityFed.AutoSize = true;
            this.lblQuantityFed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityFed.ForeColor = System.Drawing.Color.White;
            this.lblQuantityFed.Location = new System.Drawing.Point(14, 58);
            this.lblQuantityFed.Name = "lblQuantityFed";
            this.lblQuantityFed.Size = new System.Drawing.Size(190, 21);
            this.lblQuantityFed.TabIndex = 1;
            this.lblQuantityFed.Text = "00000000000000000000";
            this.lblQuantityFed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(52, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Quantity Sales";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlPond
            // 
            this.pnlPond.AutoSize = true;
            this.pnlPond.BackColor = System.Drawing.Color.Crimson;
            this.pnlPond.Controls.Add(this.lblPondNum);
            this.pnlPond.Controls.Add(this.label1);
            this.pnlPond.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPond.Location = new System.Drawing.Point(232, 223);
            this.pnlPond.Name = "pnlPond";
            this.pnlPond.Size = new System.Drawing.Size(225, 115);
            this.pnlPond.TabIndex = 122;
            // 
            // lblPondNum
            // 
            this.lblPondNum.AutoSize = true;
            this.lblPondNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPondNum.ForeColor = System.Drawing.Color.White;
            this.lblPondNum.Location = new System.Drawing.Point(11, 58);
            this.lblPondNum.Name = "lblPondNum";
            this.lblPondNum.Size = new System.Drawing.Size(190, 21);
            this.lblPondNum.TabIndex = 1;
            this.lblPondNum.Text = "00000000000000000000";
            this.lblPondNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of pond sales from";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbldateOrYear
            // 
            this.lbldateOrYear.AutoSize = true;
            this.lbldateOrYear.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lbldateOrYear.Location = new System.Drawing.Point(664, 155);
            this.lbldateOrYear.Name = "lbldateOrYear";
            this.lbldateOrYear.Size = new System.Drawing.Size(56, 25);
            this.lbldateOrYear.TabIndex = 126;
            this.lbldateOrYear.Text = "2019";
            this.lbldateOrYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(561, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 125;
            this.label2.Text = "Report for ";
            // 
            // frmSalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1317, 566);
            this.Controls.Add(this.lbldateOrYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.lblYearly);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlPond);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSalesReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSalesReport";
            this.Load += new System.EventHandler(this.FrmSalesReport_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlPond.ResumeLayout(false);
            this.pnlPond.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label lblYearly;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblQuantityFed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlPond;
        private System.Windows.Forms.Label lblPondNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbldateOrYear;
        private System.Windows.Forms.Label label2;
    }
}