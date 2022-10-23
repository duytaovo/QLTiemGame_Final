namespace QLTiemGame
{
    partial class Option
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
            this.lblDangXuat = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picReport = new System.Windows.Forms.PictureBox();
            this.picCategory = new System.Windows.Forms.PictureBox();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.btnGDC = new System.Windows.Forms.Button();
            this.btnQLDM = new System.Windows.Forms.Button();
            this.btnTK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDangXuat
            // 
            this.lblDangXuat.AutoSize = true;
            this.lblDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangXuat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblDangXuat.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblDangXuat.Location = new System.Drawing.Point(566, 25);
            this.lblDangXuat.Name = "lblDangXuat";
            this.lblDangXuat.Size = new System.Drawing.Size(113, 25);
            this.lblDangXuat.TabIndex = 14;
            this.lblDangXuat.TabStop = true;
            this.lblDangXuat.Text = "Đăng Xuất";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(310, 471);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Báo cáo, thống kê";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(92, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Các Tùy Chọn:";
            // 
            // picReport
            // 
            this.picReport.Image = global::QLTiemGame.Properties.Resources.vector_285_14_01_512;
            this.picReport.Location = new System.Drawing.Point(303, 281);
            this.picReport.Name = "picReport";
            this.picReport.Size = new System.Drawing.Size(184, 128);
            this.picReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picReport.TabIndex = 10;
            this.picReport.TabStop = false;
            // 
            // picCategory
            // 
            this.picCategory.Image = global::QLTiemGame.Properties.Resources.google_sites_icon_large;
            this.picCategory.Location = new System.Drawing.Point(428, 80);
            this.picCategory.Name = "picCategory";
            this.picCategory.Size = new System.Drawing.Size(183, 125);
            this.picCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCategory.TabIndex = 8;
            this.picCategory.TabStop = false;
            // 
            // picHome
            // 
            this.picHome.BackColor = System.Drawing.Color.Transparent;
            this.picHome.Image = global::QLTiemGame.Properties.Resources.trangchu;
            this.picHome.Location = new System.Drawing.Point(173, 77);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(184, 128);
            this.picHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHome.TabIndex = 9;
            this.picHome.TabStop = false;
            // 
            // btnGDC
            // 
            this.btnGDC.Location = new System.Drawing.Point(208, 223);
            this.btnGDC.Name = "btnGDC";
            this.btnGDC.Size = new System.Drawing.Size(109, 40);
            this.btnGDC.TabIndex = 15;
            this.btnGDC.Text = "Giao diện chính";
            this.btnGDC.UseVisualStyleBackColor = true;
            this.btnGDC.Click += new System.EventHandler(this.btnGDC_Click);
            // 
            // btnQLDM
            // 
            this.btnQLDM.Location = new System.Drawing.Point(451, 223);
            this.btnQLDM.Name = "btnQLDM";
            this.btnQLDM.Size = new System.Drawing.Size(109, 40);
            this.btnQLDM.TabIndex = 16;
            this.btnQLDM.Text = "Quản lý danh mục";
            this.btnQLDM.UseVisualStyleBackColor = true;
            this.btnQLDM.Click += new System.EventHandler(this.btnQLDM_Click);
            // 
            // btnTK
            // 
            this.btnTK.Location = new System.Drawing.Point(331, 415);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(109, 35);
            this.btnTK.TabIndex = 17;
            this.btnTK.Text = "Thống kê";
            this.btnTK.UseVisualStyleBackColor = true;
            // 
            // Option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.btnQLDM);
            this.Controls.Add(this.btnGDC);
            this.Controls.Add(this.lblDangXuat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picReport);
            this.Controls.Add(this.picHome);
            this.Controls.Add(this.picCategory);
            this.Name = "Option";
            this.Text = "Option";
            ((System.ComponentModel.ISupportInitialize)(this.picReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel lblDangXuat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picReport;
        private System.Windows.Forms.PictureBox picCategory;
        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.Button btnGDC;
        private System.Windows.Forms.Button btnQLDM;
        private System.Windows.Forms.Button btnTK;
    }
}