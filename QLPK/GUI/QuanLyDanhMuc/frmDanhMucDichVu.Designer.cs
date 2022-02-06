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
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtTenDichVu = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.lblTenDichVu = new System.Windows.Forms.Label();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.txtMaDichVu = new System.Windows.Forms.TextBox();
            this.lblDonViTinh = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblMaDichVu = new System.Windows.Forms.Label();
            this.dgvDanhMucDichVu = new System.Windows.Forms.DataGridView();
            this.txtTimKiemDichVu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoLanSuDung = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkHienThiTatCa = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(397, 63);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(2);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(76, 20);
            this.txtGhiChu.TabIndex = 71;
            // 
            // txtTenDichVu
            // 
            this.txtTenDichVu.Location = new System.Drawing.Point(136, 63);
            this.txtTenDichVu.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenDichVu.Name = "txtTenDichVu";
            this.txtTenDichVu.Size = new System.Drawing.Size(76, 20);
            this.txtTenDichVu.TabIndex = 70;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Location = new System.Drawing.Point(310, 63);
            this.lblGhiChu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(47, 13);
            this.lblGhiChu.TabIndex = 69;
            this.lblGhiChu.Text = "Ghi chú:";
            // 
            // lblTenDichVu
            // 
            this.lblTenDichVu.AutoSize = true;
            this.lblTenDichVu.Location = new System.Drawing.Point(48, 63);
            this.lblTenDichVu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenDichVu.Name = "lblTenDichVu";
            this.lblTenDichVu.Size = new System.Drawing.Size(67, 13);
            this.lblTenDichVu.TabIndex = 68;
            this.lblTenDichVu.Text = "Tên dịch vụ:";
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.Location = new System.Drawing.Point(451, 154);
            this.btnNhapLai.Margin = new System.Windows.Forms.Padding(2);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(62, 28);
            this.btnNhapLai.TabIndex = 65;
            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.UseVisualStyleBackColor = true;
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(359, 154);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(62, 28);
            this.btnLuu.TabIndex = 64;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(262, 154);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(62, 28);
            this.btnXoa.TabIndex = 63;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(170, 154);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(62, 28);
            this.btnSua.TabIndex = 62;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(74, 154);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(62, 28);
            this.btnThem.TabIndex = 66;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(136, 89);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(2);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(76, 20);
            this.txtDonGia.TabIndex = 58;
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Location = new System.Drawing.Point(397, 36);
            this.txtDonViTinh.Margin = new System.Windows.Forms.Padding(2);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(76, 20);
            this.txtDonViTinh.TabIndex = 57;
            // 
            // txtMaDichVu
            // 
            this.txtMaDichVu.Location = new System.Drawing.Point(136, 36);
            this.txtMaDichVu.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaDichVu.Name = "txtMaDichVu";
            this.txtMaDichVu.Size = new System.Drawing.Size(76, 20);
            this.txtMaDichVu.TabIndex = 56;
            // 
            // lblDonViTinh
            // 
            this.lblDonViTinh.AutoSize = true;
            this.lblDonViTinh.Location = new System.Drawing.Point(310, 36);
            this.lblDonViTinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDonViTinh.Name = "lblDonViTinh";
            this.lblDonViTinh.Size = new System.Drawing.Size(63, 13);
            this.lblDonViTinh.TabIndex = 51;
            this.lblDonViTinh.Text = "Đơn vị tính:";
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(50, 93);
            this.lblDonGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(47, 13);
            this.lblDonGia.TabIndex = 55;
            this.lblDonGia.Text = "Đơn giá:";
            // 
            // lblMaDichVu
            // 
            this.lblMaDichVu.AutoSize = true;
            this.lblMaDichVu.Location = new System.Drawing.Point(50, 36);
            this.lblMaDichVu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaDichVu.Name = "lblMaDichVu";
            this.lblMaDichVu.Size = new System.Drawing.Size(63, 13);
            this.lblMaDichVu.TabIndex = 50;
            this.lblMaDichVu.Text = "Mã dịch vụ:";
            // 
            // dgvDanhMucDichVu
            // 
            this.dgvDanhMucDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMucDichVu.Location = new System.Drawing.Point(27, 218);
            this.dgvDanhMucDichVu.Name = "dgvDanhMucDichVu";
            this.dgvDanhMucDichVu.Size = new System.Drawing.Size(562, 136);
            this.dgvDanhMucDichVu.TabIndex = 72;
            this.dgvDanhMucDichVu.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDanhMucDichVu_CellMouseClick);
            // 
            // txtTimKiemDichVu
            // 
            this.txtTimKiemDichVu.Location = new System.Drawing.Point(136, 187);
            this.txtTimKiemDichVu.Name = "txtTimKiemDichVu";
            this.txtTimKiemDichVu.Size = new System.Drawing.Size(100, 20);
            this.txtTimKiemDichVu.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 73;
            this.label3.Text = "Tìm kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "Số lần sử dụng";
            // 
            // txtSoLanSuDung
            // 
            this.txtSoLanSuDung.Location = new System.Drawing.Point(397, 87);
            this.txtSoLanSuDung.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoLanSuDung.Name = "txtSoLanSuDung";
            this.txtSoLanSuDung.Size = new System.Drawing.Size(76, 20);
            this.txtSoLanSuDung.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 76;
            this.label2.Text = "Hiển thị tất cả";
            // 
            // chkHienThiTatCa
            // 
            this.chkHienThiTatCa.AutoSize = true;
            this.chkHienThiTatCa.Location = new System.Drawing.Point(526, 194);
            this.chkHienThiTatCa.Name = "chkHienThiTatCa";
            this.chkHienThiTatCa.Size = new System.Drawing.Size(15, 14);
            this.chkHienThiTatCa.TabIndex = 75;
            this.chkHienThiTatCa.UseVisualStyleBackColor = true;
            this.chkHienThiTatCa.CheckedChanged += new System.EventHandler(this.chkHienThiTatCa_CheckedChanged);
            // 
            // frmDanhMucDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkHienThiTatCa);
            this.Controls.Add(this.txtTimKiemDichVu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvDanhMucDichVu);
            this.Controls.Add(this.txtSoLanSuDung);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenDichVu);
            this.Controls.Add(this.lblGhiChu);
            this.Controls.Add(this.lblTenDichVu);
            this.Controls.Add(this.btnNhapLai);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtDonViTinh);
            this.Controls.Add(this.txtMaDichVu);
            this.Controls.Add(this.lblDonViTinh);
            this.Controls.Add(this.lblDonGia);
            this.Controls.Add(this.lblMaDichVu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDanhMucDichVu";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frmDanhMucDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucDichVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtTenDichVu;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.Label lblTenDichVu;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.TextBox txtMaDichVu;
        private System.Windows.Forms.Label lblDonViTinh;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblMaDichVu;
        private System.Windows.Forms.DataGridView dgvDanhMucDichVu;
        private System.Windows.Forms.TextBox txtTimKiemDichVu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoLanSuDung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkHienThiTatCa;
    }
}