﻿
namespace QLPK
{
    partial class frmChinh
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
            this.btnHeThong = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnDanhMuc = new System.Windows.Forms.Button();
            this.btnKhamChuaBenh = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.pnlChinh = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlXinChao = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblXinChao = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            this.pnlXinChao.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHeThong
            // 
            this.btnHeThong.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHeThong.Location = new System.Drawing.Point(331, 36);
            this.btnHeThong.Name = "btnHeThong";
            this.btnHeThong.Size = new System.Drawing.Size(126, 44);
            this.btnHeThong.TabIndex = 0;
            this.btnHeThong.Text = "Quản trị hệ thống";
            this.btnHeThong.UseVisualStyleBackColor = true;
            this.btnHeThong.Click += new System.EventHandler(this.btnHeThong_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Location = new System.Drawing.Point(832, 36);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(126, 44);
            this.btnBaoCao.TabIndex = 3;
            this.btnBaoCao.Text = "Báo cáo thống kê";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnDanhMuc
            // 
            this.btnDanhMuc.Location = new System.Drawing.Point(503, 36);
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Size = new System.Drawing.Size(126, 44);
            this.btnDanhMuc.TabIndex = 1;
            this.btnDanhMuc.Text = "Quản lý danh mục";
            this.btnDanhMuc.UseVisualStyleBackColor = true;
            this.btnDanhMuc.Click += new System.EventHandler(this.btnDanhMuc_Click);
            // 
            // btnKhamChuaBenh
            // 
            this.btnKhamChuaBenh.Location = new System.Drawing.Point(661, 36);
            this.btnKhamChuaBenh.Name = "btnKhamChuaBenh";
            this.btnKhamChuaBenh.Size = new System.Drawing.Size(126, 44);
            this.btnKhamChuaBenh.TabIndex = 2;
            this.btnKhamChuaBenh.Text = "Khám chữa bệnh";
            this.btnKhamChuaBenh.UseVisualStyleBackColor = true;
            this.btnKhamChuaBenh.Click += new System.EventHandler(this.btnKhamBenh_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(1002, 36);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(126, 44);
            this.btnThanhToan.TabIndex = 4;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // pnlChinh
            // 
            this.pnlChinh.Location = new System.Drawing.Point(23, 164);
            this.pnlChinh.Name = "pnlChinh";
            this.pnlChinh.Size = new System.Drawing.Size(1144, 515);
            this.pnlChinh.TabIndex = 2;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnBaoCao);
            this.pnlMenu.Controls.Add(this.btnHeThong);
            this.pnlMenu.Controls.Add(this.btnThanhToan);
            this.pnlMenu.Controls.Add(this.btnKhamChuaBenh);
            this.pnlMenu.Controls.Add(this.btnDanhMuc);
            this.pnlMenu.Location = new System.Drawing.Point(23, 12);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1144, 108);
            this.pnlMenu.TabIndex = 3;
            // 
            // pnlXinChao
            // 
            this.pnlXinChao.Controls.Add(this.lblName);
            this.pnlXinChao.Controls.Add(this.lblXinChao);
            this.pnlXinChao.Location = new System.Drawing.Point(23, 126);
            this.pnlXinChao.Name = "pnlXinChao";
            this.pnlXinChao.Size = new System.Drawing.Size(1144, 32);
            this.pnlXinChao.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(201, 4);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "label1";
            // 
            // lblXinChao
            // 
            this.lblXinChao.AutoSize = true;
            this.lblXinChao.Location = new System.Drawing.Point(122, 4);
            this.lblXinChao.Name = "lblXinChao";
            this.lblXinChao.Size = new System.Drawing.Size(52, 13);
            this.lblXinChao.TabIndex = 0;
            this.lblXinChao.Text = "Xin chào:";
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 691);
            this.Controls.Add(this.pnlXinChao);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlChinh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống quản lý phòng khám";
            this.Load += new System.EventHandler(this.frmChinh_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlXinChao.ResumeLayout(false);
            this.pnlXinChao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnHeThong;
        private System.Windows.Forms.Button btnKhamChuaBenh;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Button btnDanhMuc;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Panel pnlChinh;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlXinChao;
        private System.Windows.Forms.Label lblXinChao;
        private System.Windows.Forms.Label lblName;
    }
}