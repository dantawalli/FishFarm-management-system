namespace FishFarm.UI
{
    partial class frmUserDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserDashboard));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.lblLogout = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblCashFlow = new System.Windows.Forms.Label();
            this.lblSale = new System.Windows.Forms.Label();
            this.lblPond = new System.Windows.Forms.Label();
            this.lblStoking = new System.Windows.Forms.Label();
            this.lblLogoTile = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblFooter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(107)))));
            this.pnlTop.Controls.Add(this.lblUpdate);
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
            this.pnlTop.Size = new System.Drawing.Size(1500, 53);
            this.pnlTop.TabIndex = 5;
            this.pnlTop.TabStop = true;
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUpdate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdate.ForeColor = System.Drawing.Color.White;
            this.lblUpdate.Location = new System.Drawing.Point(1060, 14);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(145, 25);
            this.lblUpdate.TabIndex = 9;
            this.lblUpdate.Text = "System Update";
            this.lblUpdate.Click += new System.EventHandler(this.LblUpdate_Click);
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
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSalary.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.ForeColor = System.Drawing.Color.White;
            this.lblSalary.Location = new System.Drawing.Point(889, 14);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(143, 25);
            this.lblSalary.TabIndex = 7;
            this.lblSalary.Text = "Salary Records";
            this.lblSalary.Click += new System.EventHandler(this.LblSalary_Click);
            // 
            // lblCashFlow
            // 
            this.lblCashFlow.AutoSize = true;
            this.lblCashFlow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCashFlow.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashFlow.ForeColor = System.Drawing.Color.White;
            this.lblCashFlow.Location = new System.Drawing.Point(696, 15);
            this.lblCashFlow.Name = "lblCashFlow";
            this.lblCashFlow.Size = new System.Drawing.Size(176, 25);
            this.lblCashFlow.TabIndex = 6;
            this.lblCashFlow.Text = "Cash Flow Records";
            this.lblCashFlow.Click += new System.EventHandler(this.LblCashFlow_Click);
            // 
            // lblSale
            // 
            this.lblSale.AutoSize = true;
            this.lblSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSale.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSale.ForeColor = System.Drawing.Color.White;
            this.lblSale.Location = new System.Drawing.Point(550, 13);
            this.lblSale.Name = "lblSale";
            this.lblSale.Size = new System.Drawing.Size(132, 25);
            this.lblSale.TabIndex = 5;
            this.lblSale.Text = "Sales Records";
            this.lblSale.Click += new System.EventHandler(this.LblSale_Click);
            // 
            // lblPond
            // 
            this.lblPond.AutoSize = true;
            this.lblPond.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPond.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPond.ForeColor = System.Drawing.Color.White;
            this.lblPond.Location = new System.Drawing.Point(392, 13);
            this.lblPond.Name = "lblPond";
            this.lblPond.Size = new System.Drawing.Size(135, 25);
            this.lblPond.TabIndex = 4;
            this.lblPond.Text = "Pond Records";
            this.lblPond.Click += new System.EventHandler(this.LblPond_Click);
            // 
            // lblStoking
            // 
            this.lblStoking.AutoSize = true;
            this.lblStoking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblStoking.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoking.ForeColor = System.Drawing.Color.White;
            this.lblStoking.Location = new System.Drawing.Point(193, 13);
            this.lblStoking.Name = "lblStoking";
            this.lblStoking.Size = new System.Drawing.Size(167, 25);
            this.lblStoking.TabIndex = 3;
            this.lblStoking.Text = "Stocking Records";
            this.lblStoking.Click += new System.EventHandler(this.LblStoking_Click);
            // 
            // lblLogoTile
            // 
            this.lblLogoTile.AutoSize = true;
            this.lblLogoTile.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogoTile.ForeColor = System.Drawing.Color.White;
            this.lblLogoTile.Location = new System.Drawing.Point(58, 9);
            this.lblLogoTile.Name = "lblLogoTile";
            this.lblLogoTile.Size = new System.Drawing.Size(106, 30);
            this.lblLogoTile.TabIndex = 1;
            this.lblLogoTile.Text = "Fish Farm";
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(52, 53);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(107)))));
            this.pnlFooter.Controls.Add(this.lblFooter);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 647);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1354, 60);
            this.pnlFooter.TabIndex = 8;
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter.ForeColor = System.Drawing.Color.White;
            this.lblFooter.Location = new System.Drawing.Point(452, 26);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(422, 25);
            this.lblFooter.TabIndex = 0;
            this.lblFooter.Text = "Fish Farm management system copyright 2019";
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
            this.label1.TabIndex = 6;
            this.label1.Text = "MANAGEMENT SYSTEM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(443, 191);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(444, 432);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmUserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 707);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUserDashboard";
            this.Text = "Fish Farm Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmUserDashboard_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblCashFlow;
        private System.Windows.Forms.Label lblSale;
        private System.Windows.Forms.Label lblPond;
        private System.Windows.Forms.Label lblStoking;
        private System.Windows.Forms.Label lblLogoTile;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUpdate;
    }
}