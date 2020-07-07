namespace FishFarm.UI
{
    partial class frmUserStocking
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserStocking));
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgvstocking = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtTCost = new System.Windows.Forms.TextBox();
            this.lblTCost = new System.Windows.Forms.Label();
            this.txtUCost = new System.Windows.Forms.TextBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblUCost = new System.Windows.Forms.Label();
            this.txtTWeight = new System.Windows.Forms.TextBox();
            this.txtAWeight = new System.Windows.Forms.TextBox();
            this.lblAW = new System.Windows.Forms.Label();
            this.txtSpecies = new System.Windows.Forms.TextBox();
            this.lblSpecies = new System.Windows.Forms.Label();
            this.txtPondId = new System.Windows.Forms.TextBox();
            this.lblPoundId = new System.Windows.Forms.Label();
            this.lblTWeight = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstocking)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(177, 130);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(206, 29);
            this.txtId.TabIndex = 63;
            this.txtId.Visible = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(38, 130);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(27, 21);
            this.lblID.TabIndex = 62;
            this.lblID.Text = "ID";
            this.lblID.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(490, 130);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(777, 29);
            this.txtSearch.TabIndex = 61;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged_1);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(423, 133);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(61, 21);
            this.lblSearch.TabIndex = 60;
            this.lblSearch.Text = "Search";
            // 
            // dgvstocking
            // 
            this.dgvstocking.AllowUserToAddRows = false;
            this.dgvstocking.AllowUserToDeleteRows = false;
            this.dgvstocking.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvstocking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvstocking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvstocking.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvstocking.Location = new System.Drawing.Point(427, 184);
            this.dgvstocking.Name = "dgvstocking";
            this.dgvstocking.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvstocking.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvstocking.Size = new System.Drawing.Size(840, 301);
            this.dgvstocking.TabIndex = 59;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(177, 536);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 40);
            this.btnAdd.TabIndex = 58;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click_1);
            // 
            // txtTCost
            // 
            this.txtTCost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTCost.Location = new System.Drawing.Point(177, 456);
            this.txtTCost.Name = "txtTCost";
            this.txtTCost.Size = new System.Drawing.Size(206, 29);
            this.txtTCost.TabIndex = 57;
            // 
            // lblTCost
            // 
            this.lblTCost.AutoSize = true;
            this.lblTCost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTCost.Location = new System.Drawing.Point(38, 464);
            this.lblTCost.Name = "lblTCost";
            this.lblTCost.Size = new System.Drawing.Size(85, 21);
            this.lblTCost.TabIndex = 56;
            this.lblTCost.Text = "Total Cost";
            // 
            // txtUCost
            // 
            this.txtUCost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUCost.Location = new System.Drawing.Point(177, 403);
            this.txtUCost.Name = "txtUCost";
            this.txtUCost.Size = new System.Drawing.Size(206, 29);
            this.txtUCost.TabIndex = 55;
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
            // lblUCost
            // 
            this.lblUCost.AutoSize = true;
            this.lblUCost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUCost.Location = new System.Drawing.Point(38, 411);
            this.lblUCost.Name = "lblUCost";
            this.lblUCost.Size = new System.Drawing.Size(80, 21);
            this.lblUCost.TabIndex = 54;
            this.lblUCost.Text = "Unit Cost";
            // 
            // txtTWeight
            // 
            this.txtTWeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTWeight.Location = new System.Drawing.Point(177, 352);
            this.txtTWeight.Name = "txtTWeight";
            this.txtTWeight.Size = new System.Drawing.Size(206, 29);
            this.txtTWeight.TabIndex = 53;
            // 
            // txtAWeight
            // 
            this.txtAWeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAWeight.Location = new System.Drawing.Point(177, 298);
            this.txtAWeight.Name = "txtAWeight";
            this.txtAWeight.Size = new System.Drawing.Size(206, 29);
            this.txtAWeight.TabIndex = 51;
            // 
            // lblAW
            // 
            this.lblAW.AutoSize = true;
            this.lblAW.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAW.Location = new System.Drawing.Point(38, 306);
            this.lblAW.Name = "lblAW";
            this.lblAW.Size = new System.Drawing.Size(133, 21);
            this.lblAW.TabIndex = 50;
            this.lblAW.Text = "Average Weight";
            // 
            // txtSpecies
            // 
            this.txtSpecies.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecies.Location = new System.Drawing.Point(177, 243);
            this.txtSpecies.Name = "txtSpecies";
            this.txtSpecies.Size = new System.Drawing.Size(206, 29);
            this.txtSpecies.TabIndex = 49;
            // 
            // lblSpecies
            // 
            this.lblSpecies.AutoSize = true;
            this.lblSpecies.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecies.Location = new System.Drawing.Point(38, 251);
            this.lblSpecies.Name = "lblSpecies";
            this.lblSpecies.Size = new System.Drawing.Size(67, 21);
            this.lblSpecies.TabIndex = 48;
            this.lblSpecies.Text = "Species";
            // 
            // txtPondId
            // 
            this.txtPondId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPondId.Location = new System.Drawing.Point(177, 184);
            this.txtPondId.Name = "txtPondId";
            this.txtPondId.Size = new System.Drawing.Size(206, 29);
            this.txtPondId.TabIndex = 47;
            // 
            // lblPoundId
            // 
            this.lblPoundId.AutoSize = true;
            this.lblPoundId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoundId.Location = new System.Drawing.Point(38, 184);
            this.lblPoundId.Name = "lblPoundId";
            this.lblPoundId.Size = new System.Drawing.Size(71, 21);
            this.lblPoundId.TabIndex = 46;
            this.lblPoundId.Text = "Pond ID";
            // 
            // lblTWeight
            // 
            this.lblTWeight.AutoSize = true;
            this.lblTWeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTWeight.Location = new System.Drawing.Point(38, 360);
            this.lblTWeight.Name = "lblTWeight";
            this.lblTWeight.Size = new System.Drawing.Size(108, 21);
            this.lblTWeight.TabIndex = 52;
            this.lblTWeight.Text = "Total Weight";
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
            this.pnlHeader.Size = new System.Drawing.Size(1333, 74);
            this.pnlHeader.TabIndex = 45;
            // 
            // frmUserStocking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1333, 605);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgvstocking);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTCost);
            this.Controls.Add(this.lblTCost);
            this.Controls.Add(this.txtUCost);
            this.Controls.Add(this.lblUCost);
            this.Controls.Add(this.txtTWeight);
            this.Controls.Add(this.txtAWeight);
            this.Controls.Add(this.lblAW);
            this.Controls.Add(this.txtSpecies);
            this.Controls.Add(this.lblSpecies);
            this.Controls.Add(this.txtPondId);
            this.Controls.Add(this.lblPoundId);
            this.Controls.Add(this.lblTWeight);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUserStocking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stocking Records";
            this.Load += new System.EventHandler(this.FrmUserStocking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvstocking)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dgvstocking;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtTCost;
        private System.Windows.Forms.Label lblTCost;
        private System.Windows.Forms.TextBox txtUCost;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblUCost;
        private System.Windows.Forms.TextBox txtTWeight;
        private System.Windows.Forms.TextBox txtAWeight;
        private System.Windows.Forms.Label lblAW;
        private System.Windows.Forms.TextBox txtSpecies;
        private System.Windows.Forms.Label lblSpecies;
        private System.Windows.Forms.TextBox txtPondId;
        private System.Windows.Forms.Label lblPoundId;
        private System.Windows.Forms.Label lblTWeight;
        private System.Windows.Forms.Panel pnlHeader;
    }
}