
namespace QLPK.GUI.QuanLyDanhMuc
{
    partial class frmDanhMucDichVu
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
            this.lblMaDichVu = new System.Windows.Forms.Label();
            this.lblMaLoaiDichVu = new System.Windows.Forms.Label();
            this.lblTenDichVu = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblDonVi = new System.Windows.Forms.Label();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.txtMaDichVu = new System.Windows.Forms.TextBox();
            this.txtTenDichVu = new System.Windows.Forms.TextBox();
            this.txtGiaTri = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.cmbMaLoaiDichVu = new System.Windows.Forms.ComboBox();
            this.lvwCapNhatThongTinDichVu = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lblMaDichVu
            // 
            this.lblMaDichVu.AutoSize = true;
            this.lblMaDichVu.Location = new System.Drawing.Point(45, 51);
            this.lblMaDichVu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaDichVu.Name = "lblMaDichVu";
            this.lblMaDichVu.Size = new System.Drawing.Size(63, 13);
            this.lblMaDichVu.TabIndex = 0;
            this.lblMaDichVu.Text = "Mã dịch vụ:";
            // 
            // lblMaLoaiDichVu
            // 
            this.lblMaLoaiDichVu.AutoSize = true;
            this.lblMaLoaiDichVu.Location = new System.Drawing.Point(45, 87);
            this.lblMaLoaiDichVu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaLoaiDichVu.Name = "lblMaLoaiDichVu";
            this.lblMaLoaiDichVu.Size = new System.Drawing.Size(82, 13);
            this.lblMaLoaiDichVu.TabIndex = 0;
            this.lblMaLoaiDichVu.Text = "Mã loại dịch vụ:";
            // 
            // lblTenDichVu
            // 
            this.lblTenDichVu.AutoSize = true;
            this.lblTenDichVu.Location = new System.Drawing.Point(45, 125);
            this.lblTenDichVu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenDichVu.Name = "lblTenDichVu";
            this.lblTenDichVu.Size = new System.Drawing.Size(67, 13);
            this.lblTenDichVu.TabIndex = 0;
            this.lblTenDichVu.Text = "Tên dịch vụ:";
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(301, 51);
            this.lblGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(26, 13);
            this.lblGia.TabIndex = 0;
            this.lblGia.Text = "Giá:";
            // 
            // lblDonVi
            // 
            this.lblDonVi.AutoSize = true;
            this.lblDonVi.Location = new System.Drawing.Point(301, 87);
            this.lblDonVi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDonVi.Name = "lblDonVi";
            this.lblDonVi.Size = new System.Drawing.Size(38, 13);
            this.lblDonVi.TabIndex = 0;
            this.lblDonVi.Text = "Đơn vị";
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Location = new System.Drawing.Point(301, 125);
            this.lblGhiChu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(47, 13);
            this.lblGhiChu.TabIndex = 0;
            this.lblGhiChu.Text = "Ghi chú:";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(36, 182);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(51, 24);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(118, 182);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(51, 24);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(212, 182);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(51, 24);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(312, 182);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(51, 24);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.Location = new System.Drawing.Point(423, 182);
            this.btnNhapLai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(51, 24);
            this.btnNhapLai.TabIndex = 1;
            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.UseVisualStyleBackColor = true;
            // 
            // txtMaDichVu
            // 
            this.txtMaDichVu.Location = new System.Drawing.Point(140, 46);
            this.txtMaDichVu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaDichVu.Name = "txtMaDichVu";
            this.txtMaDichVu.Size = new System.Drawing.Size(76, 20);
            this.txtMaDichVu.TabIndex = 2;
            // 
            // txtTenDichVu
            // 
            this.txtTenDichVu.Location = new System.Drawing.Point(140, 125);
            this.txtTenDichVu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenDichVu.Name = "txtTenDichVu";
            this.txtTenDichVu.Size = new System.Drawing.Size(76, 20);
            this.txtTenDichVu.TabIndex = 2;
            // 
            // txtGiaTri
            // 
            this.txtGiaTri.Location = new System.Drawing.Point(350, 87);
            this.txtGiaTri.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGiaTri.Name = "txtGiaTri";
            this.txtGiaTri.Size = new System.Drawing.Size(76, 20);
            this.txtGiaTri.TabIndex = 2;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(350, 125);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(76, 20);
            this.txtGhiChu.TabIndex = 2;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(350, 45);
            this.txtGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(76, 20);
            this.txtGia.TabIndex = 3;
            // 
            // cmbMaLoaiDichVu
            // 
            this.cmbMaLoaiDichVu.FormattingEnabled = true;
            this.cmbMaLoaiDichVu.Location = new System.Drawing.Point(140, 84);
            this.cmbMaLoaiDichVu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbMaLoaiDichVu.Name = "cmbMaLoaiDichVu";
            this.cmbMaLoaiDichVu.Size = new System.Drawing.Size(92, 21);
            this.cmbMaLoaiDichVu.TabIndex = 4;
            // 
            // lvwCapNhatThongTinDichVu
            // 
            this.lvwCapNhatThongTinDichVu.HideSelection = false;
            this.lvwCapNhatThongTinDichVu.Location = new System.Drawing.Point(30, 223);
            this.lvwCapNhatThongTinDichVu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvwCapNhatThongTinDichVu.Name = "lvwCapNhatThongTinDichVu";
            this.lvwCapNhatThongTinDichVu.Size = new System.Drawing.Size(530, 119);
            this.lvwCapNhatThongTinDichVu.TabIndex = 5;
            this.lvwCapNhatThongTinDichVu.UseCompatibleStateImageBehavior = false;
            // 
            // frmDanhMucDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lvwCapNhatThongTinDichVu);
            this.Controls.Add(this.cmbMaLoaiDichVu);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtGiaTri);
            this.Controls.Add(this.txtTenDichVu);
            this.Controls.Add(this.txtMaDichVu);
            this.Controls.Add(this.btnNhapLai);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblGhiChu);
            this.Controls.Add(this.lblDonVi);
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.lblTenDichVu);
            this.Controls.Add(this.lblMaLoaiDichVu);
            this.Controls.Add(this.lblMaDichVu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmDanhMucDichVu";
            this.Text = "Cập nhật thông tin dịch vụ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaDichVu;
        private System.Windows.Forms.Label lblMaLoaiDichVu;
        private System.Windows.Forms.Label lblTenDichVu;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblDonVi;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.TextBox txtMaDichVu;
        private System.Windows.Forms.TextBox txtTenDichVu;
        private System.Windows.Forms.TextBox txtGiaTri;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.ComboBox cmbMaLoaiDichVu;
        private System.Windows.Forms.ListView lvwCapNhatThongTinDichVu;
    }
}