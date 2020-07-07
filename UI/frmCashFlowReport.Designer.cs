namespace FishFarm.UI
{
    partial class frmCashFlowReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCashFlowReport));
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblCashOut = new System.Windows.Forms.Label();
            this.lblCashIn = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNumActivities = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumSources = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlPond = new System.Windows.Forms.Panel();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.lblYearly = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.CashIn = new System.Windows.Forms.GroupBox();
            this.CashOut = new System.Windows.Forms.GroupBox();
            this.lbldateOrYear = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlPond.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(72, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Amount";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Controls.Add(this.lblCashOut);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(1017, 250);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(216, 115);
            this.panel4.TabIndex = 122;
            // 
            // lblCashOut
            // 
            this.lblCashOut.AutoSize = true;
            this.lblCashOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashOut.ForeColor = System.Drawing.Color.White;
            this.lblCashOut.Location = new System.Drawing.Point(14, 56);
            this.lblCashOut.Name = "lblCashOut";
            this.lblCashOut.Size = new System.Drawing.Size(190, 21);
            this.lblCashOut.TabIndex = 1;
            this.lblCashOut.Text = "00000000000000000000";
            this.lblCashOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCashIn
            // 
            this.lblCashIn.AutoSize = true;
            this.lblCashIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashIn.ForeColor = System.Drawing.Color.White;
            this.lblCashIn.Location = new System.Drawing.Point(14, 58);
            this.lblCashIn.Name = "lblCashIn";
            this.lblCashIn.Size = new System.Drawing.Size(190, 21);
            this.lblCashIn.TabIndex = 1;
            this.lblCashIn.Text = "00000000000000000000";
            this.lblCashIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(74, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Amount";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(108)))));
            this.panel2.Controls.Add(this.lblCashIn);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(361, 250);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 115);
            this.panel2.TabIndex = 120;
            // 
            // lblNumActivities
            // 
            this.lblNumActivities.AutoSize = true;
            this.lblNumActivities.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumActivities.ForeColor = System.Drawing.Color.White;
            this.lblNumActivities.Location = new System.Drawing.Point(12, 57);
            this.lblNumActivities.Name = "lblNumActivities";
            this.lblNumActivities.Size = new System.Drawing.Size(190, 21);
            this.lblNumActivities.TabIndex = 1;
            this.lblNumActivities.Text = "00000000000000000000";
            this.lblNumActivities.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(36, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Number of activities";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumSources
            // 
            this.lblNumSources.AutoSize = true;
            this.lblNumSources.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumSources.ForeColor = System.Drawing.Color.White;
            this.lblNumSources.Location = new System.Drawing.Point(11, 58);
            this.lblNumSources.Name = "lblNumSources";
            this.lblNumSources.Size = new System.Drawing.Size(190, 21);
            this.lblNumSources.TabIndex = 1;
            this.lblNumSources.Text = "00000000000000000000";
            this.lblNumSources.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.lblNumActivities);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(697, 250);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 115);
            this.panel1.TabIndex = 121;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of sources";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlPond
            // 
            this.pnlPond.AutoSize = true;
            this.pnlPond.BackColor = System.Drawing.Color.Crimson;
            this.pnlPond.Controls.Add(this.lblNumSources);
            this.pnlPond.Controls.Add(this.label1);
            this.pnlPond.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPond.Location = new System.Drawing.Point(60, 250);
            this.pnlPond.Name = "pnlPond";
            this.pnlPond.Size = new System.Drawing.Size(216, 115);
            this.pnlPond.TabIndex = 119;
            // 
            // cmbYear
            // 
            this.cmbYear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(903, 98);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(216, 25);
            this.cmbYear.TabIndex = 118;
            this.cmbYear.SelectedValueChanged += new System.EventHandler(this.CmbYear_SelectedValueChanged);
            // 
            // lblYearly
            // 
            this.lblYearly.AutoSize = true;
            this.lblYearly.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearly.Location = new System.Drawing.Point(825, 99);
            this.lblYearly.Name = "lblYearly";
            this.lblYearly.Size = new System.Drawing.Size(43, 21);
            this.lblYearly.TabIndex = 117;
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
            this.cmbMonth.Location = new System.Drawing.Point(134, 99);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(216, 25);
            this.cmbMonth.TabIndex = 116;
            this.cmbMonth.SelectedValueChanged += new System.EventHandler(this.CmbMonth_SelectedValueChanged);
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.Location = new System.Drawing.Point(56, 100);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(61, 21);
            this.lblMonth.TabIndex = 115;
            this.lblMonth.Text = "Month";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(107)))));
            this.lblHeader.Location = new System.Drawing.Point(560, 20);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(219, 30);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "CASH FLOW REPORT";
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
            this.pnlHeader.TabIndex = 114;
            // 
            // CashIn
            // 
            this.CashIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashIn.Location = new System.Drawing.Point(34, 181);
            this.CashIn.Name = "CashIn";
            this.CashIn.Size = new System.Drawing.Size(582, 270);
            this.CashIn.TabIndex = 123;
            this.CashIn.TabStop = false;
            this.CashIn.Text = "Cash In";
            // 
            // CashOut
            // 
            this.CashOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashOut.Location = new System.Drawing.Point(670, 181);
            this.CashOut.Name = "CashOut";
            this.CashOut.Size = new System.Drawing.Size(582, 270);
            this.CashOut.TabIndex = 124;
            this.CashOut.TabStop = false;
            this.CashOut.Text = "Cash Out";
            // 
            // lbldateOrYear
            // 
            this.lbldateOrYear.AutoSize = true;
            this.lbldateOrYear.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lbldateOrYear.Location = new System.Drawing.Point(682, 126);
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
            this.label2.Location = new System.Drawing.Point(579, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 125;
            this.label2.Text = "Report for ";
            // 
            // frmCashFlowReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1317, 566);
            this.Controls.Add(this.lbldateOrYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlPond);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.lblYearly);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.CashIn);
            this.Controls.Add(this.CashOut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCashFlowReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCashFlowReport";
            this.Load += new System.EventHandler(this.FrmCashFlowReport_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlPond.ResumeLayout(false);
            this.pnlPond.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblCashOut;
        private System.Windows.Forms.Label lblCashIn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNumActivities;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumSources;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlPond;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label lblYearly;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.GroupBox CashIn;
        private System.Windows.Forms.GroupBox CashOut;
        private System.Windows.Forms.Label lbldateOrYear;
        private System.Windows.Forms.Label label2;
    }
}