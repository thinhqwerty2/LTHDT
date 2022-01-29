
namespace QLPK.GUI.BaoCaoThongKe
{
    partial class frmBaoCaoThongKe
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
            this.pnlNutQuanTriHeThong = new System.Windows.Forms.Panel();
            this.btnDoanhThuThuoc = new System.Windows.Forms.Button();
            this.btnDoanhThuDichVu = new System.Windows.Forms.Button();
            this.btnKhamBenh = new System.Windows.Forms.Button();
            this.btnBenhNhan = new System.Windows.Forms.Button();
            this.pnlXemQuanTriHeThong = new System.Windows.Forms.Panel();
            this.btnChuaBenh = new System.Windows.Forms.Button();
            this.pnlNutQuanTriHeThong.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNutQuanTriHeThong
            // 
            this.pnlNutQuanTriHeThong.Controls.Add(this.btnChuaBenh);
            this.pnlNutQuanTriHeThong.Controls.Add(this.btnDoanhThuThuoc);
            this.pnlNutQuanTriHeThong.Controls.Add(this.btnDoanhThuDichVu);
            this.pnlNutQuanTriHeThong.Controls.Add(this.btnKhamBenh);
            this.pnlNutQuanTriHeThong.Controls.Add(this.btnBenhNhan);
            this.pnlNutQuanTriHeThong.Location = new System.Drawing.Point(3, 2);
            this.pnlNutQuanTriHeThong.Name = "pnlNutQuanTriHeThong";
            this.pnlNutQuanTriHeThong.Size = new System.Drawing.Size(225, 446);
            this.pnlNutQuanTriHeThong.TabIndex = 2;
            // 
            // btnDoanhThuThuoc
            // 
            this.btnDoanhThuThuoc.Location = new System.Drawing.Point(10, 141);
            this.btnDoanhThuThuoc.Name = "btnDoanhThuThuoc";
            this.btnDoanhThuThuoc.Size = new System.Drawing.Size(212, 50);
            this.btnDoanhThuThuoc.TabIndex = 3;
            this.btnDoanhThuThuoc.Text = "Doanh thu thuốc";
            this.btnDoanhThuThuoc.UseVisualStyleBackColor = true;
            // 
            // btnDoanhThuDichVu
            // 
            this.btnDoanhThuDichVu.Location = new System.Drawing.Point(10, 74);
            this.btnDoanhThuDichVu.Name = "btnDoanhThuDichVu";
            this.btnDoanhThuDichVu.Size = new System.Drawing.Size(212, 50);
            this.btnDoanhThuDichVu.TabIndex = 2;
            this.btnDoanhThuDichVu.Text = "Doanh thu dịch vụ";
            this.btnDoanhThuDichVu.UseVisualStyleBackColor = true;
            // 
            // btnKhamBenh
            // 
            this.btnKhamBenh.Location = new System.Drawing.Point(10, 208);
            this.btnKhamBenh.Name = "btnKhamBenh";
            this.btnKhamBenh.Size = new System.Drawing.Size(212, 50);
            this.btnKhamBenh.TabIndex = 1;
            this.btnKhamBenh.Text = "Khám bệnh";
            this.btnKhamBenh.UseVisualStyleBackColor = true;
            // 
            // btnBenhNhan
            // 
            this.btnBenhNhan.Location = new System.Drawing.Point(10, 9);
            this.btnBenhNhan.Name = "btnBenhNhan";
            this.btnBenhNhan.Size = new System.Drawing.Size(212, 50);
            this.btnBenhNhan.TabIndex = 0;
            this.btnBenhNhan.Text = "Bệnh nhân";
            this.btnBenhNhan.UseVisualStyleBackColor = true;
            this.btnBenhNhan.Click += new System.EventHandler(this.btnBenhNhan_Click);
            // 
            // pnlXemQuanTriHeThong
            // 
            this.pnlXemQuanTriHeThong.Location = new System.Drawing.Point(234, 2);
            this.pnlXemQuanTriHeThong.Name = "pnlXemQuanTriHeThong";
            this.pnlXemQuanTriHeThong.Size = new System.Drawing.Size(564, 446);
            this.pnlXemQuanTriHeThong.TabIndex = 3;
            // 
            // btnChuaBenh
            // 
            this.btnChuaBenh.Location = new System.Drawing.Point(13, 275);
            this.btnChuaBenh.Name = "btnChuaBenh";
            this.btnChuaBenh.Size = new System.Drawing.Size(212, 50);
            this.btnChuaBenh.TabIndex = 4;
            this.btnChuaBenh.Text = "Chữa bệnh";
            this.btnChuaBenh.UseVisualStyleBackColor = true;
            // 
            // frmBaoCaoThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlNutQuanTriHeThong);
            this.Controls.Add(this.pnlXemQuanTriHeThong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBaoCaoThongKe";
            this.Text = "frmBaoCaoThongKe";
            this.pnlNutQuanTriHeThong.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNutQuanTriHeThong;
        private System.Windows.Forms.Button btnDoanhThuThuoc;
        private System.Windows.Forms.Button btnDoanhThuDichVu;
        private System.Windows.Forms.Button btnKhamBenh;
        private System.Windows.Forms.Button btnBenhNhan;
        private System.Windows.Forms.Panel pnlXemQuanTriHeThong;
        private System.Windows.Forms.Button btnChuaBenh;
    }
}