﻿
namespace QLPK.GUI.KhamBenh
{
    partial class frmKhamBenh
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
            this.pnlXemThanhToan = new System.Windows.Forms.Panel();
            this.pnlNutThanhToan = new System.Windows.Forms.Panel();
            this.btnChanDoan = new System.Windows.Forms.Button();
            this.btnLapPhieuKetQuaXetNghiem = new System.Windows.Forms.Button();
            this.btnLapPhieuDangKyXetNghiem = new System.Windows.Forms.Button();
            this.btnLapPhieuDangKiKhamBenh = new System.Windows.Forms.Button();
            this.btnLapPhieuSuDungDichVu = new System.Windows.Forms.Button();
            this.pnlNutThanhToan.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlXemThanhToan
            // 
            this.pnlXemThanhToan.Location = new System.Drawing.Point(234, 2);
            this.pnlXemThanhToan.Name = "pnlXemThanhToan";
            this.pnlXemThanhToan.Size = new System.Drawing.Size(564, 446);
            this.pnlXemThanhToan.TabIndex = 5;
            // 
            // pnlNutThanhToan
            // 
            this.pnlNutThanhToan.Controls.Add(this.btnLapPhieuSuDungDichVu);
            this.pnlNutThanhToan.Controls.Add(this.btnChanDoan);
            this.pnlNutThanhToan.Controls.Add(this.btnLapPhieuKetQuaXetNghiem);
            this.pnlNutThanhToan.Controls.Add(this.btnLapPhieuDangKyXetNghiem);
            this.pnlNutThanhToan.Controls.Add(this.btnLapPhieuDangKiKhamBenh);
            this.pnlNutThanhToan.Location = new System.Drawing.Point(3, 2);
            this.pnlNutThanhToan.Name = "pnlNutThanhToan";
            this.pnlNutThanhToan.Size = new System.Drawing.Size(225, 446);
            this.pnlNutThanhToan.TabIndex = 4;
            // 
            // btnChanDoan
            // 
            this.btnChanDoan.Location = new System.Drawing.Point(9, 215);
            this.btnChanDoan.Name = "btnChanDoan";
            this.btnChanDoan.Size = new System.Drawing.Size(212, 50);
            this.btnChanDoan.TabIndex = 2;
            this.btnChanDoan.Text = "Phiếu chẩn đoán";
            this.btnChanDoan.UseVisualStyleBackColor = true;
            // 
            // btnLapPhieuKetQuaXetNghiem
            // 
            this.btnLapPhieuKetQuaXetNghiem.Location = new System.Drawing.Point(10, 149);
            this.btnLapPhieuKetQuaXetNghiem.Name = "btnLapPhieuKetQuaXetNghiem";
            this.btnLapPhieuKetQuaXetNghiem.Size = new System.Drawing.Size(212, 50);
            this.btnLapPhieuKetQuaXetNghiem.TabIndex = 1;
            this.btnLapPhieuKetQuaXetNghiem.Text = "Lập phiếu kết quả xét nghiệm";
            this.btnLapPhieuKetQuaXetNghiem.UseVisualStyleBackColor = true;
            // 
            // btnLapPhieuDangKyXetNghiem
            // 
            this.btnLapPhieuDangKyXetNghiem.Location = new System.Drawing.Point(9, 79);
            this.btnLapPhieuDangKyXetNghiem.Name = "btnLapPhieuDangKyXetNghiem";
            this.btnLapPhieuDangKyXetNghiem.Size = new System.Drawing.Size(212, 50);
            this.btnLapPhieuDangKyXetNghiem.TabIndex = 1;
            this.btnLapPhieuDangKyXetNghiem.Text = "Lập phiếu đăng ký xét nghiệm";
            this.btnLapPhieuDangKyXetNghiem.UseVisualStyleBackColor = true;
            // 
            // btnLapPhieuDangKiKhamBenh
            // 
            this.btnLapPhieuDangKiKhamBenh.Location = new System.Drawing.Point(10, 10);
            this.btnLapPhieuDangKiKhamBenh.Name = "btnLapPhieuDangKiKhamBenh";
            this.btnLapPhieuDangKiKhamBenh.Size = new System.Drawing.Size(212, 50);
            this.btnLapPhieuDangKiKhamBenh.TabIndex = 0;
            this.btnLapPhieuDangKiKhamBenh.Text = "Lập phiếu đăng kí khám bệnh";
            this.btnLapPhieuDangKiKhamBenh.UseVisualStyleBackColor = true;
            // 
            // btnLapPhieuSuDungDichVu
            // 
            this.btnLapPhieuSuDungDichVu.Location = new System.Drawing.Point(9, 282);
            this.btnLapPhieuSuDungDichVu.Name = "btnLapPhieuSuDungDichVu";
            this.btnLapPhieuSuDungDichVu.Size = new System.Drawing.Size(212, 50);
            this.btnLapPhieuSuDungDichVu.TabIndex = 3;
            this.btnLapPhieuSuDungDichVu.Text = "Lập phiếu sử dụng dịch vụ chữa bệnh";
            this.btnLapPhieuSuDungDichVu.UseVisualStyleBackColor = true;
            // 
            // frmKhamBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlXemThanhToan);
            this.Controls.Add(this.pnlNutThanhToan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKhamBenh";
            this.Text = "frmKhamBenh";
            this.pnlNutThanhToan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlXemThanhToan;
        private System.Windows.Forms.Panel pnlNutThanhToan;
        private System.Windows.Forms.Button btnLapPhieuDangKyXetNghiem;
        private System.Windows.Forms.Button btnLapPhieuDangKiKhamBenh;
        private System.Windows.Forms.Button btnLapPhieuKetQuaXetNghiem;
        private System.Windows.Forms.Button btnChanDoan;
        private System.Windows.Forms.Button btnLapPhieuSuDungDichVu;
    }
}