namespace FishFarm
{
    partial class frmStocking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStocking));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblPoundId = new System.Windows.Forms.Label();
            this.txtPondId = new System.Windows.Forms.TextBox();
            this.txtSpecies = new System.Windows.Forms.TextBox();
            this.lblSpecies = new System.Windows.Forms.Label();
            this.txtAWeight = new System.Windows.Forms.TextBox();
            this.lblAW = new System.Windows.Forms.Label();
            this.txtTWeight = new System.Windows.Forms.TextBox();
            this.lblTWeight = new System.Windows.Forms.Label();
            this.txtUCost = new System.Windows.Forms.TextBox();
            this.lblUCost = new System.Windows.Forms.Label();
            this.txtTCost = new System.Windows.Forms.TextBox();
            this.lblTCost = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvstocking = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnPDF = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstocking)).BeginInit();
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
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1333, 74);
            this.pnlHeader.TabIndex = 0;
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
            this.lblHeader.Text = "STOCKING RECORDS";
            // 
            // lblPoundId
            // 
            this.lblPoundId.AutoSize = true;
            this.lblPoundId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoundId.Location = new System.Drawing.Point(46, 191);
            this.lblPoundId.Name = "lblPoundId";
            this.lblPoundId.Size = new System.Drawing.Size(71, 21);
            this.lblPoundId.TabIndex = 1;
            this.lblPoundId.Text = "Pond ID";
            this.lblPoundId.Click += new System.EventHandler(this.LblPoundId_Click);
            // 
            // txtPondId
            // 
            this.txtPondId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPondId.Location = new System.Drawing.Point(185, 191);
            this.txtPondId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPondId.Name = "txtPondId";
            this.txtPondId.Size = new System.Drawing.Size(206, 29);
            this.txtPondId.TabIndex = 2;
            this.txtPondId.TextChanged += new System.EventHandler(this.TxtPondId_TextChanged);
            // 
            // txtSpecies
            // 
            this.txtSpecies.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecies.Location = new System.Drawing.Point(185, 251);
            this.txtSpecies.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSpecies.Name = "txtSpecies";
            this.txtSpecies.Size = new System.Drawing.Size(206, 29);
            this.txtSpecies.TabIndex = 4;
            // 
            // lblSpecies
            // 
            this.lblSpecies.AutoSize = true;
            this.lblSpecies.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecies.Location = new System.Drawing.Point(46, 259);
            this.lblSpecies.Name = "lblSpecies";
            this.lblSpecies.Size = new System.Drawing.Size(67, 21);
            this.lblSpecies.TabIndex = 3;
            this.lblSpecies.Text = "Species";
            // 
            // txtAWeight
            // 
            this.txtAWeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAWeight.Location = new System.Drawing.Point(185, 305);
            this.txtAWeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAWeight.Name = "txtAWeight";
            this.txtAWeight.Size = new System.Drawing.Size(206, 29);
            this.txtAWeight.TabIndex = 6;
            // 
            // lblAW
            // 
            this.lblAW.AutoSize = true;
            this.lblAW.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAW.Location = new System.Drawing.Point(46, 313);
            this.lblAW.Name = "lblAW";
            this.lblAW.Size = new System.Drawing.Size(133, 21);
            this.lblAW.TabIndex = 5;
            this.lblAW.Text = "Average Weight";
            // 
            // txtTWeight
            // 
            this.txtTWeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTWeight.Location = new System.Drawing.Point(185, 360);
            this.txtTWeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTWeight.Name = "txtTWeight";
            this.txtTWeight.Size = new System.Drawing.Size(206, 29);
            this.txtTWeight.TabIndex = 8;
            // 
            // lblTWeight
            // 
            this.lblTWeight.AutoSize = true;
            this.lblTWeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTWeight.Location = new System.Drawing.Point(46, 368);
            this.lblTWeight.Name = "lblTWeight";
            this.lblTWeight.Size = new System.Drawing.Size(108, 21);
            this.lblTWeight.TabIndex = 7;
            this.lblTWeight.Text = "Total Weight";
            // 
            // txtUCost
            // 
            this.txtUCost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUCost.Location = new System.Drawing.Point(185, 410);
            this.txtUCost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUCost.Name = "txtUCost";
            this.txtUCost.Size = new System.Drawing.Size(206, 29);
            this.txtUCost.TabIndex = 10;
            // 
            // lblUCost
            // 
            this.lblUCost.AutoSize = true;
            this.lblUCost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUCost.Location = new System.Drawing.Point(46, 417);
            this.lblUCost.Name = "lblUCost";
            this.lblUCost.Size = new System.Drawing.Size(80, 21);
            this.lblUCost.TabIndex = 9;
            this.lblUCost.Text = "Unit Cost";
            // 
            // txtTCost
            // 
            this.txtTCost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTCost.Location = new System.Drawing.Point(185, 464);
            this.txtTCost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTCost.Name = "txtTCost";
            this.txtTCost.Size = new System.Drawing.Size(206, 29);
            this.txtTCost.TabIndex = 12;
            // 
            // lblTCost
            // 
            this.lblTCost.AutoSize = true;
            this.lblTCost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTCost.Location = new System.Drawing.Point(46, 472);
            this.lblTCost.Name = "lblTCost";
            this.lblTCost.Size = new System.Drawing.Size(85, 21);
            this.lblTCost.TabIndex = 11;
            this.lblTCost.Text = "Total Cost";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(50, 542);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 40);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.Btn_Click);
            // 
            // dgvstocking
            // 
            this.dgvstocking.AllowUserToAddRows = false;
            this.dgvstocking.AllowUserToDeleteRows = false;
            this.dgvstocking.AllowUserToOrderColumns = true;
            this.dgvstocking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstocking.Location = new System.Drawing.Point(435, 191);
            this.dgvstocking.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvstocking.Name = "dgvstocking";
            this.dgvstocking.ReadOnly = true;
            this.dgvstocking.Size = new System.Drawing.Size(840, 300);
            this.dgvstocking.TabIndex = 14;
            this.dgvstocking.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgvstocking_RowHeaderMouseClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(498, 137);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(777, 29);
            this.txtSearch.TabIndex = 16;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(430, 139);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(61, 21);
            this.lblSearch.TabIndex = 15;
            this.lblSearch.Text = "Search";
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Location = new System.Drawing.Point(656, 542);
            this.btnReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(142, 40);
            this.btnReport.TabIndex = 17;
            this.btnReport.Text = "Print Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(351, 542);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 40);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Teal;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(204, 542);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(101, 40);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(185, 137);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(206, 29);
            this.txtId.TabIndex = 21;
            this.txtId.Visible = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(46, 137);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(27, 21);
            this.lblID.TabIndex = 20;
            this.lblID.Text = "ID";
            this.lblID.Visible = false;
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF.ForeColor = System.Drawing.Color.White;
            this.btnPDF.Location = new System.Drawing.Point(938, 542);
            this.btnPDF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(142, 40);
            this.btnPDF.TabIndex = 22;
            this.btnPDF.Text = "Genrate PDF";
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Click += new System.EventHandler(this.BtnPDF_Click);
            // 
            // frmStocking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1333, 605);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgvstocking);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTCost);
            this.Controls.Add(this.lblTCost);
            this.Controls.Add(this.txtUCost);
            this.Controls.Add(this.lblUCost);
            this.Controls.Add(this.txtTWeight);
            this.Controls.Add(this.lblTWeight);
            this.Controls.Add(this.txtAWeight);
            this.Controls.Add(this.lblAW);
            this.Controls.Add(this.txtSpecies);
            this.Controls.Add(this.lblSpecies);
            this.Controls.Add(this.txtPondId);
            this.Controls.Add(this.lblPoundId);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmStocking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStoking";
            this.Load += new System.EventHandler(this.FrmStoking_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstocking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblPoundId;
        private System.Windows.Forms.TextBox txtPondId;
        private System.Windows.Forms.TextBox txtSpecies;
        private System.Windows.Forms.Label lblSpecies;
        private System.Windows.Forms.TextBox txtAWeight;
        private System.Windows.Forms.Label lblAW;
        private System.Windows.Forms.TextBox txtTWeight;
        private System.Windows.Forms.Label lblTWeight;
        private System.Windows.Forms.TextBox txtUCost;
        private System.Windows.Forms.Label lblUCost;
        private System.Windows.Forms.TextBox txtTCost;
        private System.Windows.Forms.Label lblTCost;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvstocking;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnPDF;
    }
}