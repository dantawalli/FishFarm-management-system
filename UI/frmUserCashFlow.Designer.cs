namespace FishFarm.UI
{
    partial class frmUserCashFlow
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
            this.gbcashoutflow = new System.Windows.Forms.GroupBox();
            this.txtCommentsOut = new System.Windows.Forms.TextBox();
            this.btnAddOut = new System.Windows.Forms.Button();
            this.lblCommentsout = new System.Windows.Forms.Label();
            this.lblActivity = new System.Windows.Forms.Label();
            this.txtActivity = new System.Windows.Forms.TextBox();
            this.lblAmountOut = new System.Windows.Forms.Label();
            this.txtAmountOut = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.gbCashInflow = new System.Windows.Forms.GroupBox();
            this.lblSource = new System.Windows.Forms.Label();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.lblComments = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgvcashflow = new System.Windows.Forms.DataGridView();
            this.gbcashoutflow.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.gbCashInflow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcashflow)).BeginInit();
            this.SuspendLayout();
            // 
            // gbcashoutflow
            // 
            this.gbcashoutflow.Controls.Add(this.txtCommentsOut);
            this.gbcashoutflow.Controls.Add(this.btnAddOut);
            this.gbcashoutflow.Controls.Add(this.lblCommentsout);
            this.gbcashoutflow.Controls.Add(this.lblActivity);
            this.gbcashoutflow.Controls.Add(this.txtActivity);
            this.gbcashoutflow.Controls.Add(this.lblAmountOut);
            this.gbcashoutflow.Controls.Add(this.txtAmountOut);
            this.gbcashoutflow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gbcashoutflow.Location = new System.Drawing.Point(5, 336);
            this.gbcashoutflow.Name = "gbcashoutflow";
            this.gbcashoutflow.Size = new System.Drawing.Size(417, 267);
            this.gbcashoutflow.TabIndex = 68;
            this.gbcashoutflow.TabStop = false;
            this.gbcashoutflow.Text = "Cash outflow";
            // 
            // txtCommentsOut
            // 
            this.txtCommentsOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommentsOut.Location = new System.Drawing.Point(115, 104);
            this.txtCommentsOut.Multiline = true;
            this.txtCommentsOut.Name = "txtCommentsOut";
            this.txtCommentsOut.Size = new System.Drawing.Size(282, 109);
            this.txtCommentsOut.TabIndex = 54;
            // 
            // btnAddOut
            // 
            this.btnAddOut.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOut.ForeColor = System.Drawing.Color.White;
            this.btnAddOut.Location = new System.Drawing.Point(204, 220);
            this.btnAddOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddOut.Name = "btnAddOut";
            this.btnAddOut.Size = new System.Drawing.Size(101, 40);
            this.btnAddOut.TabIndex = 62;
            this.btnAddOut.Text = "ADD";
            this.btnAddOut.UseVisualStyleBackColor = false;
            this.btnAddOut.Click += new System.EventHandler(this.BtnAddOut_Click);
            // 
            // lblCommentsout
            // 
            this.lblCommentsout.AutoSize = true;
            this.lblCommentsout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommentsout.Location = new System.Drawing.Point(18, 107);
            this.lblCommentsout.Name = "lblCommentsout";
            this.lblCommentsout.Size = new System.Drawing.Size(92, 21);
            this.lblCommentsout.TabIndex = 53;
            this.lblCommentsout.Text = "Comments";
            // 
            // lblActivity
            // 
            this.lblActivity.AutoSize = true;
            this.lblActivity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivity.Location = new System.Drawing.Point(18, 36);
            this.lblActivity.Name = "lblActivity";
            this.lblActivity.Size = new System.Drawing.Size(69, 21);
            this.lblActivity.TabIndex = 49;
            this.lblActivity.Text = "Activity";
            // 
            // txtActivity
            // 
            this.txtActivity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActivity.Location = new System.Drawing.Point(118, 33);
            this.txtActivity.Name = "txtActivity";
            this.txtActivity.Size = new System.Drawing.Size(279, 29);
            this.txtActivity.TabIndex = 50;
            // 
            // lblAmountOut
            // 
            this.lblAmountOut.AutoSize = true;
            this.lblAmountOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountOut.Location = new System.Drawing.Point(16, 71);
            this.lblAmountOut.Name = "lblAmountOut";
            this.lblAmountOut.Size = new System.Drawing.Size(72, 21);
            this.lblAmountOut.TabIndex = 43;
            this.lblAmountOut.Text = "Amount";
            // 
            // txtAmountOut
            // 
            this.txtAmountOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountOut.Location = new System.Drawing.Point(118, 68);
            this.txtAmountOut.Name = "txtAmountOut";
            this.txtAmountOut.Size = new System.Drawing.Size(279, 29);
            this.txtAmountOut.TabIndex = 44;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(204, 226);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 40);
            this.btnAdd.TabIndex = 58;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
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
            this.pnlHeader.Size = new System.Drawing.Size(1333, 50);
            this.pnlHeader.TabIndex = 63;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(107)))));
            this.lblHeader.Location = new System.Drawing.Point(559, 8);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(234, 30);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "CASH FLOW RECORDS";
            // 
            // gbCashInflow
            // 
            this.gbCashInflow.Controls.Add(this.lblSource);
            this.gbCashInflow.Controls.Add(this.txtComments);
            this.gbCashInflow.Controls.Add(this.lblComments);
            this.gbCashInflow.Controls.Add(this.txtAmount);
            this.gbCashInflow.Controls.Add(this.btnAdd);
            this.gbCashInflow.Controls.Add(this.lblAmount);
            this.gbCashInflow.Controls.Add(this.txtSource);
            this.gbCashInflow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCashInflow.Location = new System.Drawing.Point(5, 57);
            this.gbCashInflow.Name = "gbCashInflow";
            this.gbCashInflow.Size = new System.Drawing.Size(421, 273);
            this.gbCashInflow.TabIndex = 67;
            this.gbCashInflow.TabStop = false;
            this.gbCashInflow.Text = "Cash inflow";
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSource.Location = new System.Drawing.Point(18, 39);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(62, 21);
            this.lblSource.TabIndex = 39;
            this.lblSource.Text = "Source";
            // 
            // txtComments
            // 
            this.txtComments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComments.Location = new System.Drawing.Point(115, 106);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(279, 113);
            this.txtComments.TabIndex = 52;
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComments.Location = new System.Drawing.Point(16, 106);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(92, 21);
            this.lblComments.TabIndex = 51;
            this.lblComments.Text = "Comments";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(115, 71);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(279, 29);
            this.txtAmount.TabIndex = 42;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(18, 71);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(72, 21);
            this.lblAmount.TabIndex = 41;
            this.lblAmount.Text = "Amount";
            // 
            // txtSource
            // 
            this.txtSource.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSource.Location = new System.Drawing.Point(115, 36);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(279, 29);
            this.txtSource.TabIndex = 40;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(521, 63);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(800, 29);
            this.txtSearch.TabIndex = 66;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(444, 66);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(61, 21);
            this.lblSearch.TabIndex = 65;
            this.lblSearch.Text = "Search";
            // 
            // dgvcashflow
            // 
            this.dgvcashflow.AllowUserToAddRows = false;
            this.dgvcashflow.AllowUserToDeleteRows = false;
            this.dgvcashflow.AllowUserToOrderColumns = true;
            this.dgvcashflow.Location = new System.Drawing.Point(448, 96);
            this.dgvcashflow.Name = "dgvcashflow";
            this.dgvcashflow.Size = new System.Drawing.Size(873, 507);
            this.dgvcashflow.TabIndex = 64;
            // 
            // frmUserCashFlow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1333, 605);
            this.Controls.Add(this.gbcashoutflow);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.gbCashInflow);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgvcashflow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUserCashFlow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUserCashFlow";
            this.Load += new System.EventHandler(this.FrmUserCashFlow_Load);
            this.gbcashoutflow.ResumeLayout(false);
            this.gbcashoutflow.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.gbCashInflow.ResumeLayout(false);
            this.gbCashInflow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcashflow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbcashoutflow;
        private System.Windows.Forms.TextBox txtCommentsOut;
        private System.Windows.Forms.Button btnAddOut;
        private System.Windows.Forms.Label lblCommentsout;
        private System.Windows.Forms.Label lblActivity;
        private System.Windows.Forms.TextBox txtActivity;
        private System.Windows.Forms.Label lblAmountOut;
        private System.Windows.Forms.TextBox txtAmountOut;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox gbCashInflow;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dgvcashflow;
    }
}