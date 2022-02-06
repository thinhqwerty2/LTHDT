
namespace QLPK.GUI.QuanLyDanhMuc
{
    partial class frmDanhMucBacSi
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.pnlDanhMucBacSi = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.chkHienThiTatCa = new System.Windows.Forms.CheckBox();
            this.txtTimKiemBacSi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbGioiTinh = new System.Windows.Forms.ComboBox();
            this.dgvDanhMucBacSi = new System.Windows.Forms.DataGridView();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTrinhDo = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtMaBacSi = new System.Windows.Forms.TextBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblMaBacSi = new System.Windows.Forms.Label();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblTrinhDo = new System.Windows.Forms.Label();
            this.pnlDanhMucBacSi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucBacSi)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 79;
            this.label3.Text = "Trạng thái";
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.Location = new System.Drawing.Point(344, 23);
            this.btnNhapLai.Margin = new System.Windows.Forms.Padding(2);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(62, 28);
            this.btnNhapLai.TabIndex = 40;
            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.UseVisualStyleBackColor = true;
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Location = new System.Drawing.Point(290, 117);
            this.txtTrangThai.Margin = new System.Windows.Forms.Padding(2);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(76, 20);
            this.txtTrangThai.TabIndex = 80;
            this.txtTrangThai.Validated += new System.EventHandler(this.txtDiaChi_Validated);
            // 
            // pnlDanhMucBacSi
            // 
            this.pnlDanhMucBacSi.Controls.Add(this.btnXoa);
            this.pnlDanhMucBacSi.Controls.Add(this.btnNhapLai);
            this.pnlDanhMucBacSi.Controls.Add(this.btnSua);
            this.pnlDanhMucBacSi.Controls.Add(this.btnThem);
            this.pnlDanhMucBacSi.Location = new System.Drawing.Point(221, 184);
            this.pnlDanhMucBacSi.Name = "pnlDanhMucBacSi";
            this.pnlDanhMucBacSi.Size = new System.Drawing.Size(435, 68);
            this.pnlDanhMucBacSi.TabIndex = 78;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(146, 23);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(62, 28);
            this.btnXoa.TabIndex = 41;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(247, 23);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(62, 28);
            this.btnSua.TabIndex = 40;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(38, 23);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(62, 28);
            this.btnThem.TabIndex = 44;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(556, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 77;
            this.label2.Text = "Hiển thị tất cả";
            // 
            // chkHienThiTatCa
            // 
            this.chkHienThiTatCa.AutoSize = true;
            this.chkHienThiTatCa.Location = new System.Drawing.Point(641, 274);
            this.chkHienThiTatCa.Name = "chkHienThiTatCa";
            this.chkHienThiTatCa.Size = new System.Drawing.Size(15, 14);
            this.chkHienThiTatCa.TabIndex = 76;
            this.chkHienThiTatCa.UseVisualStyleBackColor = true;
            this.chkHienThiTatCa.CheckedChanged += new System.EventHandler(this.chkHienThiTatCa_CheckedChanged);
            // 
            // txtTimKiemBacSi
            // 
            this.txtTimKiemBacSi.Location = new System.Drawing.Point(250, 271);
            this.txtTimKiemBacSi.Name = "txtTimKiemBacSi";
            this.txtTimKiemBacSi.Size = new System.Drawing.Size(100, 20);
            this.txtTimKiemBacSi.TabIndex = 75;
            this.txtTimKiemBacSi.TextChanged += new System.EventHandler(this.txtTimKiemBacSi_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 74;
            this.label1.Text = "Tìm kiếm";
            // 
            // cmbGioiTinh
            // 
            this.cmbGioiTinh.FormattingEnabled = true;
            this.cmbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cmbGioiTinh.Location = new System.Drawing.Point(277, 139);
            this.cmbGioiTinh.Name = "cmbGioiTinh";
            this.cmbGioiTinh.Size = new System.Drawing.Size(121, 21);
            this.cmbGioiTinh.TabIndex = 73;
            this.cmbGioiTinh.Validated += new System.EventHandler(this.txtDiaChi_Validated);
            // 
            // dgvDanhMucBacSi
            // 
            this.dgvDanhMucBacSi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMucBacSi.Location = new System.Drawing.Point(178, 312);
            this.dgvDanhMucBacSi.Name = "dgvDanhMucBacSi";
            this.dgvDanhMucBacSi.ReadOnly = true;
            this.dgvDanhMucBacSi.RowHeadersWidth = 51;
            this.dgvDanhMucBacSi.Size = new System.Drawing.Size(565, 145);
            this.dgvDanhMucBacSi.TabIndex = 72;
            this.dgvDanhMucBacSi.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDanhMucBacSi_CellMouseClick);
            // 
            // txtChucVu
            // 
            this.txtChucVu.Location = new System.Drawing.Point(551, 88);
            this.txtChucVu.Margin = new System.Windows.Forms.Padding(2);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(76, 20);
            this.txtChucVu.TabIndex = 71;
            this.txtChucVu.Validated += new System.EventHandler(this.txtDiaChi_Validated);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(552, 144);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(76, 20);
            this.txtDiaChi.TabIndex = 69;
            this.txtDiaChi.Validated += new System.EventHandler(this.txtDiaChi_Validated);
            // 
            // txtTrinhDo
            // 
            this.txtTrinhDo.Location = new System.Drawing.Point(552, 114);
            this.txtTrinhDo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTrinhDo.Name = "txtTrinhDo";
            this.txtTrinhDo.Size = new System.Drawing.Size(76, 20);
            this.txtTrinhDo.TabIndex = 68;
            this.txtTrinhDo.Validated += new System.EventHandler(this.txtDiaChi_Validated);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(290, 88);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(76, 20);
            this.txtHoTen.TabIndex = 67;
            this.txtHoTen.Validated += new System.EventHandler(this.txtDiaChi_Validated);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(551, 61);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(76, 20);
            this.txtSDT.TabIndex = 66;
            this.txtSDT.Validated += new System.EventHandler(this.txtDiaChi_Validated);
            // 
            // txtMaBacSi
            // 
            this.txtMaBacSi.Location = new System.Drawing.Point(290, 61);
            this.txtMaBacSi.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaBacSi.Name = "txtMaBacSi";
            this.txtMaBacSi.Size = new System.Drawing.Size(76, 20);
            this.txtMaBacSi.TabIndex = 65;
            this.txtMaBacSi.Validated += new System.EventHandler(this.txtDiaChi_Validated);
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(204, 145);
            this.lblGioiTinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(50, 13);
            this.lblGioiTinh.TabIndex = 62;
            this.lblGioiTinh.Text = "Giới tính:";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(464, 61);
            this.lblSDT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(32, 13);
            this.lblSDT.TabIndex = 60;
            this.lblSDT.Text = "SĐT:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(204, 92);
            this.lblHoTen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(42, 13);
            this.lblHoTen.TabIndex = 64;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // lblMaBacSi
            // 
            this.lblMaBacSi.AutoSize = true;
            this.lblMaBacSi.Location = new System.Drawing.Point(204, 61);
            this.lblMaBacSi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaBacSi.Name = "lblMaBacSi";
            this.lblMaBacSi.Size = new System.Drawing.Size(59, 13);
            this.lblMaBacSi.TabIndex = 59;
            this.lblMaBacSi.Text = "Mã bác sĩ:";
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Location = new System.Drawing.Point(464, 88);
            this.lblChucVu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(50, 13);
            this.lblChucVu.TabIndex = 70;
            this.lblChucVu.Text = "Chức vụ:";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(466, 147);
            this.lblDiaChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(43, 13);
            this.lblDiaChi.TabIndex = 63;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // lblTrinhDo
            // 
            this.lblTrinhDo.AutoSize = true;
            this.lblTrinhDo.Location = new System.Drawing.Point(464, 117);
            this.lblTrinhDo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTrinhDo.Name = "lblTrinhDo";
            this.lblTrinhDo.Size = new System.Drawing.Size(50, 13);
            this.lblTrinhDo.TabIndex = 61;
            this.lblTrinhDo.Text = "Trình độ:";
            // 
            // frmDanhMucBacSi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 508);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTrangThai);
            this.Controls.Add(this.pnlDanhMucBacSi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkHienThiTatCa);
            this.Controls.Add(this.txtTimKiemBacSi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbGioiTinh);
            this.Controls.Add(this.dgvDanhMucBacSi);
            this.Controls.Add(this.txtChucVu);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTrinhDo);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtMaBacSi);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblMaBacSi);
            this.Controls.Add(this.lblChucVu);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblTrinhDo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDanhMucBacSi";
            this.Text = "Cập nhật thông tin bác sĩ";
            this.Load += new System.EventHandler(this.frmDanhMucBacSi_Load);
            this.pnlDanhMucBacSi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucBacSi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.Panel pnlDanhMucBacSi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkHienThiTatCa;
        private System.Windows.Forms.TextBox txtTimKiemBacSi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGioiTinh;
        private System.Windows.Forms.DataGridView dgvDanhMucBacSi;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTrinhDo;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtMaBacSi;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblMaBacSi;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblTrinhDo;
    }
}