﻿
namespace QLPK.GUI.ThanhToan
{
    partial class frmThanhToan
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
            this.pnlNutThanhToan = new System.Windows.Forms.Panel();
            this.btnTongHopChiPhi = new System.Windows.Forms.Button();
            this.btnThongTinPhieuThuTienTamUng = new System.Windows.Forms.Button();
            this.btnThongTinBanKe = new System.Windows.Forms.Button();
            this.pnlXemThanhToan = new System.Windows.Forms.Panel();
            this.pnlNutThanhToan.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNutThanhToan
            // 
            this.pnlNutThanhToan.Controls.Add(this.btnTongHopChiPhi);
            this.pnlNutThanhToan.Controls.Add(this.btnThongTinPhieuThuTienTamUng);
            this.pnlNutThanhToan.Controls.Add(this.btnThongTinBanKe);
            this.pnlNutThanhToan.Location = new System.Drawing.Point(2, 3);
            this.pnlNutThanhToan.Name = "pnlNutThanhToan";
            this.pnlNutThanhToan.Size = new System.Drawing.Size(225, 446);
            this.pnlNutThanhToan.TabIndex = 0;
            // 
            // btnTongHopChiPhi
            // 
            this.btnTongHopChiPhi.Location = new System.Drawing.Point(10, 149);
            this.btnTongHopChiPhi.Name = "btnTongHopChiPhi";
            this.btnTongHopChiPhi.Size = new System.Drawing.Size(212, 50);
            this.btnTongHopChiPhi.TabIndex = 2;
            this.btnTongHopChiPhi.Text = "Bảng tổng hợp chi phí";
            this.btnTongHopChiPhi.UseVisualStyleBackColor = true;
            // 
            // btnThongTinPhieuThuTienTamUng
            // 
            this.btnThongTinPhieuThuTienTamUng.Location = new System.Drawing.Point(10, 77);
            this.btnThongTinPhieuThuTienTamUng.Name = "btnThongTinPhieuThuTienTamUng";
            this.btnThongTinPhieuThuTienTamUng.Size = new System.Drawing.Size(212, 50);
            this.btnThongTinPhieuThuTienTamUng.TabIndex = 1;
            this.btnThongTinPhieuThuTienTamUng.Text = "Thông tin phiếu thu tiền tạm ứng";
            this.btnThongTinPhieuThuTienTamUng.UseVisualStyleBackColor = true;
            // 
            // btnThongTinBanKe
            // 
            this.btnThongTinBanKe.Location = new System.Drawing.Point(10, 9);
            this.btnThongTinBanKe.Name = "btnThongTinBanKe";
            this.btnThongTinBanKe.Size = new System.Drawing.Size(212, 50);
            this.btnThongTinBanKe.TabIndex = 0;
            this.btnThongTinBanKe.Text = "Thông tin bản kê";
            this.btnThongTinBanKe.UseVisualStyleBackColor = true;
            // 
            // pnlXemThanhToan
            // 
            this.pnlXemThanhToan.Location = new System.Drawing.Point(233, 3);
            this.pnlXemThanhToan.Name = "pnlXemThanhToan";
            this.pnlXemThanhToan.Size = new System.Drawing.Size(564, 446);
            this.pnlXemThanhToan.TabIndex = 1;
            // 
            // frmThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlXemThanhToan);
            this.Controls.Add(this.pnlNutThanhToan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThanhToan";
            this.Text = "frmQuanTriHeThong";
            this.pnlNutThanhToan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNutThanhToan;
        private System.Windows.Forms.Button btnTongHopChiPhi;
        private System.Windows.Forms.Button btnThongTinPhieuThuTienTamUng;
        private System.Windows.Forms.Button btnThongTinBanKe;
        private System.Windows.Forms.Panel pnlXemThanhToan;
    }
}