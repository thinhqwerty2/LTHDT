
namespace QLPK.GUI.ChuaBenh
{
    partial class frmChuaBenh
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
            this.btnBangDichVuChuaBenh = new System.Windows.Forms.Button();
            this.btnLapPhieuThuTamUng = new System.Windows.Forms.Button();
            this.pnlNutThanhToan.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlXemThanhToan
            // 
            this.pnlXemThanhToan.Location = new System.Drawing.Point(234, 2);
            this.pnlXemThanhToan.Name = "pnlXemThanhToan";
            this.pnlXemThanhToan.Size = new System.Drawing.Size(564, 446);
            this.pnlXemThanhToan.TabIndex = 3;
            // 
            // pnlNutThanhToan
            // 
            this.pnlNutThanhToan.Controls.Add(this.btnBangDichVuChuaBenh);
            this.pnlNutThanhToan.Controls.Add(this.btnLapPhieuThuTamUng);
            this.pnlNutThanhToan.Location = new System.Drawing.Point(3, 2);
            this.pnlNutThanhToan.Name = "pnlNutThanhToan";
            this.pnlNutThanhToan.Size = new System.Drawing.Size(225, 446);
            this.pnlNutThanhToan.TabIndex = 2;
            // 
            // btnBangDichVuChuaBenh
            // 
            this.btnBangDichVuChuaBenh.Location = new System.Drawing.Point(10, 77);
            this.btnBangDichVuChuaBenh.Name = "btnBangDichVuChuaBenh";
            this.btnBangDichVuChuaBenh.Size = new System.Drawing.Size(212, 50);
            this.btnBangDichVuChuaBenh.TabIndex = 1;
            this.btnBangDichVuChuaBenh.Text = "Bảng dịch vụ chữa bệnh";
            this.btnBangDichVuChuaBenh.UseVisualStyleBackColor = true;
            // 
            // btnLapPhieuThuTamUng
            // 
            this.btnLapPhieuThuTamUng.Location = new System.Drawing.Point(10, 9);
            this.btnLapPhieuThuTamUng.Name = "btnLapPhieuThuTamUng";
            this.btnLapPhieuThuTamUng.Size = new System.Drawing.Size(212, 50);
            this.btnLapPhieuThuTamUng.TabIndex = 0;
            this.btnLapPhieuThuTamUng.Text = "Lập phiếu thu tạm ứng";
            this.btnLapPhieuThuTamUng.UseVisualStyleBackColor = true;
            // 
            // frmChuaBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlXemThanhToan);
            this.Controls.Add(this.pnlNutThanhToan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChuaBenh";
            this.Text = "frmChuaBenh";
            this.pnlNutThanhToan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlXemThanhToan;
        private System.Windows.Forms.Panel pnlNutThanhToan;
        private System.Windows.Forms.Button btnBangDichVuChuaBenh;
        private System.Windows.Forms.Button btnLapPhieuThuTamUng;
    }
}