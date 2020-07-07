namespace FishFarm
{
    partial class frmCashFlow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCashFlow));
            this.txtComments = new System.Windows.Forms.TextBox();
            this.lblComments = new System.Windows.Forms.Label();
            this.txtActivity = new System.Windows.Forms.TextBox();
            this.lblActivity = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgvcashflow = new System.Windows.Forms.DataGridView();
            this.txtAmountOut = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.lblSource = new System.Windows.Forms.Label();
            this.lblAmountOut = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.txtCommentsOut = new System.Windows.Forms.TextBox();
            this.lblCommentsout = new System.Windows.Forms.Label();
            this.gbCashInflow = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbcashoutflow = new System.Windows.Forms.GroupBox();
            this.lblIdOut = new System.Windows.Forms.Label();
            this.btnUpdateOut = new System.Windows.Forms.Button();
            this.txtIdOut = new System.Windows.Forms.TextBox();
            this.btnDeleteOut = new System.Windows.Forms.Button();
            this.btnAddOut = new System.Windows.Forms.Button();
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcashflow)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.gbCashInflow.SuspendLayout();
            this.gbcashoutflow.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtComments
            // 
            this.txtComments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComments.Location = new System.Drawing.Point(115, 139);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(279, 70);
            this.txtComments.TabIndex = 52;
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComments.Location = new System.Drawing.Point(16, 139);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(92, 21);
            this.lblComments.TabIndex = 51;
            this.lblComments.Text = "Comments";
            // 
            // txtActivity
            // 
            this.txtActivity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActivity.Location = new System.Drawing.Point(118, 63);
            this.txtActivity.Name = "txtActivity";
            this.txtActivity.Size = new System.Drawing.Size(279, 29);
            this.txtActivity.TabIndex = 50;
            // 
            // lblActivity
            // 
            this.lblActivity.AutoSize = true;
            this.lblActivity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivity.Location = new System.Drawing.Point(18, 66);
            this.lblActivity.Name = "lblActivity";
            this.lblActivity.Size = new System.Drawing.Size(69, 21);
            this.lblActivity.TabIndex = 49;
            this.lblActivity.Text = "Activity";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(521, 62);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(800, 29);
            this.txtSearch.TabIndex = 48;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(444, 65);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(61, 21);
            this.lblSearch.TabIndex = 47;
            this.lblSearch.Text = "Search";
            this.lblSearch.Click += new System.EventHandler(this.LblSearch_Click);
            // 
            // dgvcashflow
            // 
            this.dgvcashflow.AllowUserToAddRows = false;
            this.dgvcashflow.AllowUserToDeleteRows = false;
            this.dgvcashflow.AllowUserToOrderColumns = true;
            this.dgvcashflow.Location = new System.Drawing.Point(448, 95);
            this.dgvcashflow.Name = "dgvcashflow";
            this.dgvcashflow.Size = new System.Drawing.Size(873, 453);
            this.dgvcashflow.TabIndex = 46;
            this.dgvcashflow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgvstocking_CellContentClick);
            this.dgvcashflow.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgvcashflow_RowHeaderMouseClick);
            // 
            // txtAmountOut
            // 
            this.txtAmountOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountOut.Location = new System.Drawing.Point(118, 98);
            this.txtAmountOut.Name = "txtAmountOut";
            this.txtAmountOut.Size = new System.Drawing.Size(279, 29);
            this.txtAmountOut.TabIndex = 44;
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(115, 104);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(279, 29);
            this.txtAmount.TabIndex = 42;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(18, 104);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(72, 21);
            this.lblAmount.TabIndex = 41;
            this.lblAmount.Text = "Amount";
            // 
            // txtSource
            // 
            this.txtSource.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSource.Location = new System.Drawing.Point(115, 69);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(279, 29);
            this.txtSource.TabIndex = 40;
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSource.Location = new System.Drawing.Point(18, 72);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(62, 21);
            this.lblSource.TabIndex = 39;
            this.lblSource.Text = "Source";
            // 
            // lblAmountOut
            // 
            this.lblAmountOut.AutoSize = true;
            this.lblAmountOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountOut.Location = new System.Drawing.Point(16, 101);
            this.lblAmountOut.Name = "lblAmountOut";
            this.lblAmountOut.Size = new System.Drawing.Size(72, 21);
            this.lblAmountOut.TabIndex = 43;
            this.lblAmountOut.Text = "Amount";
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
            this.pnlHeader.TabIndex = 38;
            // 
            // txtCommentsOut
            // 
            this.txtCommentsOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommentsOut.Location = new System.Drawing.Point(115, 134);
            this.txtCommentsOut.Multiline = true;
            this.txtCommentsOut.Name = "txtCommentsOut";
            this.txtCommentsOut.Size = new System.Drawing.Size(282, 79);
            this.txtCommentsOut.TabIndex = 54;
            // 
            // lblCommentsout
            // 
            this.lblCommentsout.AutoSize = true;
            this.lblCommentsout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommentsout.Location = new System.Drawing.Point(16, 137);
            this.lblCommentsout.Name = "lblCommentsout";
            this.lblCommentsout.Size = new System.Drawing.Size(92, 21);
            this.lblCommentsout.TabIndex = 53;
            this.lblCommentsout.Text = "Comments";
            // 
            // gbCashInflow
            // 
            this.gbCashInflow.Controls.Add(this.lblId);
            this.gbCashInflow.Controls.Add(this.txtId);
            this.gbCashInflow.Controls.Add(this.lblSource);
            this.gbCashInflow.Controls.Add(this.btnUpdate);
            this.gbCashInflow.Controls.Add(this.txtComments);
            this.gbCashInflow.Controls.Add(this.btnDelete);
            this.gbCashInflow.Controls.Add(this.lblComments);
            this.gbCashInflow.Controls.Add(this.txtAmount);
            this.gbCashInflow.Controls.Add(this.btnAdd);
            this.gbCashInflow.Controls.Add(this.lblAmount);
            this.gbCashInflow.Controls.Add(this.txtSource);
            this.gbCashInflow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCashInflow.Location = new System.Drawing.Point(5, 56);
            this.gbCashInflow.Name = "gbCashInflow";
            this.gbCashInflow.Size = new System.Drawing.Size(421, 273);
            this.gbCashInflow.TabIndex = 56;
            this.gbCashInflow.TabStop = false;
            this.gbCashInflow.Text = "Cash inflow";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(18, 37);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(27, 21);
            this.lblId.TabIndex = 62;
            this.lblId.Text = "ID";
            this.lblId.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(115, 34);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(279, 29);
            this.txtId.TabIndex = 63;
            this.txtId.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Teal;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(160, 217);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(101, 40);
            this.btnUpdate.TabIndex = 61;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(296, 217);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 40);
            this.btnDelete.TabIndex = 60;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(26, 218);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 40);
            this.btnAdd.TabIndex = 58;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // gbcashoutflow
            // 
            this.gbcashoutflow.Controls.Add(this.lblIdOut);
            this.gbcashoutflow.Controls.Add(this.btnUpdateOut);
            this.gbcashoutflow.Controls.Add(this.txtIdOut);
            this.gbcashoutflow.Controls.Add(this.btnDeleteOut);
            this.gbcashoutflow.Controls.Add(this.txtCommentsOut);
            this.gbcashoutflow.Controls.Add(this.btnAddOut);
            this.gbcashoutflow.Controls.Add(this.lblCommentsout);
            this.gbcashoutflow.Controls.Add(this.lblActivity);
            this.gbcashoutflow.Controls.Add(this.txtActivity);
            this.gbcashoutflow.Controls.Add(this.lblAmountOut);
            this.gbcashoutflow.Controls.Add(this.txtAmountOut);
            this.gbcashoutflow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gbcashoutflow.Location = new System.Drawing.Point(5, 335);
            this.gbcashoutflow.Name = "gbcashoutflow";
            this.gbcashoutflow.Size = new System.Drawing.Size(417, 267);
            this.gbcashoutflow.TabIndex = 57;
            this.gbcashoutflow.TabStop = false;
            this.gbcashoutflow.Text = "Cash outflow";
            // 
            // lblIdOut
            // 
            this.lblIdOut.AutoSize = true;
            this.lblIdOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdOut.Location = new System.Drawing.Point(21, 31);
            this.lblIdOut.Name = "lblIdOut";
            this.lblIdOut.Size = new System.Drawing.Size(27, 21);
            this.lblIdOut.TabIndex = 64;
            this.lblIdOut.Text = "ID";
            this.lblIdOut.Visible = false;
            // 
            // btnUpdateOut
            // 
            this.btnUpdateOut.BackColor = System.Drawing.Color.Teal;
            this.btnUpdateOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateOut.ForeColor = System.Drawing.Color.White;
            this.btnUpdateOut.Location = new System.Drawing.Point(160, 218);
            this.btnUpdateOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdateOut.Name = "btnUpdateOut";
            this.btnUpdateOut.Size = new System.Drawing.Size(101, 40);
            this.btnUpdateOut.TabIndex = 64;
            this.btnUpdateOut.Text = "UPDATE";
            this.btnUpdateOut.UseVisualStyleBackColor = false;
            this.btnUpdateOut.Click += new System.EventHandler(this.BtnUpdateOut_Click);
            // 
            // txtIdOut
            // 
            this.txtIdOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdOut.Location = new System.Drawing.Point(118, 28);
            this.txtIdOut.Name = "txtIdOut";
            this.txtIdOut.ReadOnly = true;
            this.txtIdOut.Size = new System.Drawing.Size(279, 29);
            this.txtIdOut.TabIndex = 65;
            this.txtIdOut.Visible = false;
            // 
            // btnDeleteOut
            // 
            this.btnDeleteOut.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteOut.ForeColor = System.Drawing.Color.White;
            this.btnDeleteOut.Location = new System.Drawing.Point(296, 218);
            this.btnDeleteOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteOut.Name = "btnDeleteOut";
            this.btnDeleteOut.Size = new System.Drawing.Size(101, 40);
            this.btnDeleteOut.TabIndex = 63;
            this.btnDeleteOut.Text = "DELETE";
            this.btnDeleteOut.UseVisualStyleBackColor = false;
            this.btnDeleteOut.Click += new System.EventHandler(this.BtnDeleteOut_Click);
            // 
            // btnAddOut
            // 
            this.btnAddOut.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOut.ForeColor = System.Drawing.Color.White;
            this.btnAddOut.Location = new System.Drawing.Point(26, 218);
            this.btnAddOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddOut.Name = "btnAddOut";
            this.btnAddOut.Size = new System.Drawing.Size(101, 40);
            this.btnAddOut.TabIndex = 62;
            this.btnAddOut.Text = "ADD";
            this.btnAddOut.UseVisualStyleBackColor = false;
            this.btnAddOut.Click += new System.EventHandler(this.Button3_Click);
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF.ForeColor = System.Drawing.Color.White;
            this.btnPDF.Location = new System.Drawing.Point(914, 553);
            this.btnPDF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(177, 40);
            this.btnPDF.TabIndex = 62;
            this.btnPDF.Text = "Genrate PDF";
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Click += new System.EventHandler(this.BtnPDF_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Location = new System.Drawing.Point(638, 553);
            this.btnReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(177, 40);
            this.btnReport.TabIndex = 59;
            this.btnReport.Text = "Print Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // frmCashFlow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1333, 605);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgvcashflow);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.gbCashInflow);
            this.Controls.Add(this.gbcashoutflow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCashFlow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCashFlow";
            this.Load += new System.EventHandler(this.FrmCashFlow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcashflow)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.gbCashInflow.ResumeLayout(false);
            this.gbCashInflow.PerformLayout();
            this.gbcashoutflow.ResumeLayout(false);
            this.gbcashoutflow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.TextBox txtActivity;
        private System.Windows.Forms.Label lblActivity;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dgvcashflow;
        private System.Windows.Forms.TextBox txtAmountOut;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblAmountOut;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.TextBox txtCommentsOut;
        private System.Windows.Forms.Label lblCommentsout;
        private System.Windows.Forms.GroupBox gbCashInflow;
        private System.Windows.Forms.GroupBox gbcashoutflow;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdateOut;
        private System.Windows.Forms.Button btnDeleteOut;
        private System.Windows.Forms.Button btnAddOut;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblIdOut;
        private System.Windows.Forms.TextBox txtIdOut;
    }
}