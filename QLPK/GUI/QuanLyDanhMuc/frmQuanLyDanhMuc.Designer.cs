
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
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnDichVu = new System.Windows.Forms.Button();
            this.btnBacSi = new System.Windows.Forms.Button();
            this.btnBenhNhan = new System.Windows.Forms.Button();
            this.pnlXemQuanLyDanhMuc = new System.Windows.Forms.Panel();
            this.pnlNutQuanLyDanhMuc.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNutQuanLyDanhMuc
            // 
            this.pnlNutQuanLyDanhMuc.Controls.Add(this.btnNhanVien);
            this.pnlNutQuanLyDanhMuc.Controls.Add(this.btnDichVu);
            this.pnlNutQuanLyDanhMuc.Controls.Add(this.btnBacSi);
            this.pnlNutQuanLyDanhMuc.Controls.Add(this.btnBenhNhan);
            this.pnlNutQuanLyDanhMuc.Location = new System.Drawing.Point(2, 3);
            this.pnlNutQuanLyDanhMuc.Name = "pnlNutQuanLyDanhMuc";
            this.pnlNutQuanLyDanhMuc.Size = new System.Drawing.Size(225, 446);
            this.pnlNutQuanLyDanhMuc.TabIndex = 0;
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Location = new System.Drawing.Point(10, 220);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(212, 50);
            this.btnNhanVien.TabIndex = 3;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.UseVisualStyleBackColor = true;
            // 
            // btnDichVu
            // 
            this.btnDichVu.Location = new System.Drawing.Point(10, 149);
            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.Size = new System.Drawing.Size(212, 50);
            this.btnDichVu.TabIndex = 2;
            this.btnDichVu.Text = "Dịch vụ";
            this.btnDichVu.UseVisualStyleBackColor = true;
            // 
            // btnBacSi
            // 
            this.btnBacSi.Location = new System.Drawing.Point(10, 77);
            this.btnBacSi.Name = "btnBacSi";
            this.btnBacSi.Size = new System.Drawing.Size(212, 50);
            this.btnBacSi.TabIndex = 1;
            this.btnBacSi.Text = "Bác sĩ";
            this.btnBacSi.UseVisualStyleBackColor = true;
            // 
            // btnBenhNhan
            // 
            this.btnBenhNhan.Location = new System.Drawing.Point(10, 9);
            this.btnBenhNhan.Name = "btnBenhNhan";
            this.btnBenhNhan.Size = new System.Drawing.Size(212, 50);
            this.btnBenhNhan.TabIndex = 0;
            this.btnBenhNhan.Text = "Bệnh nhân";
            this.btnBenhNhan.UseVisualStyleBackColor = true;
            // 
            // pnlXemQuanLyDanhMuc
            // 
            this.pnlXemQuanLyDanhMuc.Location = new System.Drawing.Point(233, 3);
            this.pnlXemQuanLyDanhMuc.Name = "pnlXemQuanLyDanhMuc";
            this.pnlXemQuanLyDanhMuc.Size = new System.Drawing.Size(564, 446);
            this.pnlXemQuanLyDanhMuc.TabIndex = 1;
            // 
            // frmQuanLyDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlXemQuanLyDanhMuc);
            this.Controls.Add(this.pnlNutQuanLyDanhMuc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLyDanhMuc";
            this.Text = "frmQuanTriHeThong";
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
    }
}