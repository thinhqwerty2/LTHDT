﻿
namespace QLPK.GUI.QuanLyDanhMuc
{
    partial class frmQuanLyDanhMuc
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
            this.pnlNutQuanLyDanhMuc = new System.Windows.Forms.Panel();
            this.btnBenh = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnDichVu = new System.Windows.Forms.Button();
            this.btnBacSi = new System.Windows.Forms.Button();
            this.btnBenhNhan = new System.Windows.Forms.Button();
            this.pnlXemQuanLyDanhMuc = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNutQuanLyDanhMuc.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNutQuanLyDanhMuc
            // 
            this.pnlNutQuanLyDanhMuc.BackColor = System.Drawing.Color.DarkCyan;
            this.pnlNutQuanLyDanhMuc.Controls.Add(this.btnBenh);
            this.pnlNutQuanLyDanhMuc.Controls.Add(this.btnNhanVien);
            this.pnlNutQuanLyDanhMuc.Controls.Add(this.btnDichVu);
            this.pnlNutQuanLyDanhMuc.Controls.Add(this.btnBacSi);
            this.pnlNutQuanLyDanhMuc.Controls.Add(this.btnBenhNhan);
            this.pnlNutQuanLyDanhMuc.Location = new System.Drawing.Point(-5, -8);
            this.pnlNutQuanLyDanhMuc.Name = "pnlNutQuanLyDanhMuc";
            this.pnlNutQuanLyDanhMuc.Size = new System.Drawing.Size(160, 530);
            this.pnlNutQuanLyDanhMuc.TabIndex = 0;
            // 
            // btnBenh
            // 
            this.btnBenh.Location = new System.Drawing.Point(17, 341);
            this.btnBenh.Name = "btnBenh";
            this.btnBenh.Size = new System.Drawing.Size(133, 50);
            this.btnBenh.TabIndex = 4;
            this.btnBenh.Text = "Bệnh";
            this.btnBenh.UseVisualStyleBackColor = true;
            this.btnBenh.Click += new System.EventHandler(this.btnBenh_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Location = new System.Drawing.Point(17, 273);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(133, 50);
            this.btnNhanVien.TabIndex = 3;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnDichVu
            // 
            this.btnDichVu.Location = new System.Drawing.Point(17, 199);
            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.Size = new System.Drawing.Size(133, 50);
            this.btnDichVu.TabIndex = 2;
            this.btnDichVu.Text = "Dịch vụ";
            this.btnDichVu.UseVisualStyleBackColor = true;
            this.btnDichVu.Click += new System.EventHandler(this.btnDichVu_Click);
            // 
            // btnBacSi
            // 
            this.btnBacSi.Location = new System.Drawing.Point(17, 121);
            this.btnBacSi.Name = "btnBacSi";
            this.btnBacSi.Size = new System.Drawing.Size(133, 50);
            this.btnBacSi.TabIndex = 1;
            this.btnBacSi.Text = "Bác sĩ";
            this.btnBacSi.UseVisualStyleBackColor = true;
            this.btnBacSi.Click += new System.EventHandler(this.btnBacSi_Click);
            // 
            // btnBenhNhan
            // 
            this.btnBenhNhan.Location = new System.Drawing.Point(17, 40);
            this.btnBenhNhan.Name = "btnBenhNhan";
            this.btnBenhNhan.Size = new System.Drawing.Size(133, 50);
            this.btnBenhNhan.TabIndex = 0;
            this.btnBenhNhan.Text = "Bệnh nhân";
            this.btnBenhNhan.UseVisualStyleBackColor = true;
            this.btnBenhNhan.Click += new System.EventHandler(this.btnBenhNhan_Click);
            // 
            // pnlXemQuanLyDanhMuc
            // 
            this.pnlXemQuanLyDanhMuc.BackColor = System.Drawing.SystemColors.Control;
            this.pnlXemQuanLyDanhMuc.Location = new System.Drawing.Point(176, 3);
            this.pnlXemQuanLyDanhMuc.Name = "pnlXemQuanLyDanhMuc";
            this.pnlXemQuanLyDanhMuc.Size = new System.Drawing.Size(966, 508);
            this.pnlXemQuanLyDanhMuc.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Location = new System.Drawing.Point(151, -8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 572);
            this.panel1.TabIndex = 2;
            // 
            // frmQuanLyDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 515);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlXemQuanLyDanhMuc);
            this.Controls.Add(this.pnlNutQuanLyDanhMuc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLyDanhMuc";
            this.Text = "frmQuanTriHeThong";
            this.Load += new System.EventHandler(this.frmQuanLyDanhMuc_Load);
            this.pnlNutQuanLyDanhMuc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNutQuanLyDanhMuc;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnDichVu;
        private System.Windows.Forms.Button btnBacSi;
        private System.Windows.Forms.Button btnBenhNhan;
        private System.Windows.Forms.Panel pnlXemQuanLyDanhMuc;
        private System.Windows.Forms.Button btnBenh;
        private System.Windows.Forms.Panel panel1;
    }
}