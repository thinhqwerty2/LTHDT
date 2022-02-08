
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTrangThai = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnlDanhMucBacSi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucBacSi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 79;
            this.label3.Text = "Trạng thái";
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.Location = new System.Drawing.Point(533, 12);
            this.btnNhapLai.Margin = new System.Windows.Forms.Padding(2);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(113, 40);
            this.btnNhapLai.TabIndex = 40;
            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.UseVisualStyleBackColor = true;
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
            // 
            // pnlDanhMucBacSi
            // 
            this.pnlDanhMucBacSi.Controls.Add(this.btnXoa);
            this.pnlDanhMucBacSi.Controls.Add(this.btnNhapLai);
            this.pnlDanhMucBacSi.Controls.Add(this.btnSua);
            this.pnlDanhMucBacSi.Controls.Add(this.btnThem);
            this.pnlDanhMucBacSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDanhMucBacSi.Location = new System.Drawing.Point(153, 184);
            this.pnlDanhMucBacSi.Name = "pnlDanhMucBacSi";
            this.pnlDanhMucBacSi.Size = new System.Drawing.Size(700, 68);
            this.pnlDanhMucBacSi.TabIndex = 78;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(214, 12);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 40);
            this.btnXoa.TabIndex = 41;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(385, 12);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(95, 40);
            this.btnSua.TabIndex = 40;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(37, 12);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 40);
            this.btnThem.TabIndex = 44;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(586, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 77;
            this.label2.Text = "Hiển thị tất cả";
            // 
            // chkHienThiTatCa
            // 
            this.chkHienThiTatCa.AutoSize = true;
            this.chkHienThiTatCa.Location = new System.Drawing.Point(679, 24);
            this.chkHienThiTatCa.Name = "chkHienThiTatCa";
            this.chkHienThiTatCa.Size = new System.Drawing.Size(15, 14);
            this.chkHienThiTatCa.TabIndex = 76;
            this.chkHienThiTatCa.UseVisualStyleBackColor = true;
            this.chkHienThiTatCa.CheckedChanged += new System.EventHandler(this.chkHienThiTatCa_CheckedChanged);
            // 
            // txtTimKiemBacSi
            // 
            this.txtTimKiemBacSi.Location = new System.Drawing.Point(108, 19);
            this.txtTimKiemBacSi.Name = "txtTimKiemBacSi";
            this.txtTimKiemBacSi.Size = new System.Drawing.Size(472, 22);
            this.txtTimKiemBacSi.TabIndex = 75;
            this.txtTimKiemBacSi.TextChanged += new System.EventHandler(this.txtTimKiemBacSi_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 74;
            this.label1.Text = "Từ khoá";
            // 
            // cmbGioiTinh
            // 
            this.cmbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGioiTinh.FormattingEnabled = true;
            this.cmbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cmbGioiTinh.Location = new System.Drawing.Point(122, 112);
            this.cmbGioiTinh.Name = "cmbGioiTinh";
            this.cmbGioiTinh.Size = new System.Drawing.Size(187, 24);
            this.cmbGioiTinh.TabIndex = 73;
            this.cmbGioiTinh.Validated += new System.EventHandler(this.txt_Validated);
            // 
            // dgvDanhMucBacSi
            // 
            this.dgvDanhMucBacSi.AllowUserToAddRows = false;
            this.dgvDanhMucBacSi.AllowUserToDeleteRows = false;
            this.dgvDanhMucBacSi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhMucBacSi.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhMucBacSi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMucBacSi.Location = new System.Drawing.Point(153, 311);
            this.dgvDanhMucBacSi.Name = "dgvDanhMucBacSi";
            this.dgvDanhMucBacSi.ReadOnly = true;
            this.dgvDanhMucBacSi.RowHeadersWidth = 51;
            this.dgvDanhMucBacSi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhMucBacSi.Size = new System.Drawing.Size(700, 200);
            this.dgvDanhMucBacSi.TabIndex = 72;
            this.dgvDanhMucBacSi.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDanhMucBacSi_CellMouseClick);
            // 
            // txtChucVu
            // 
            this.txtChucVu.Location = new System.Drawing.Point(462, 51);
            this.txtChucVu.Margin = new System.Windows.Forms.Padding(2);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(184, 22);
            this.txtChucVu.TabIndex = 71;
            this.txtChucVu.Validated += new System.EventHandler(this.txt_Validated);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(462, 112);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(184, 22);
            this.txtDiaChi.TabIndex = 69;
            this.txtDiaChi.Validated += new System.EventHandler(this.txt_Validated);
            // 
            // txtTrinhDo
            // 
            this.txtTrinhDo.Location = new System.Drawing.Point(462, 80);
            this.txtTrinhDo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTrinhDo.Name = "txtTrinhDo";
            this.txtTrinhDo.Size = new System.Drawing.Size(184, 22);
            this.txtTrinhDo.TabIndex = 68;
            this.txtTrinhDo.Validated += new System.EventHandler(this.txt_Validated);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(123, 51);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(186, 22);
            this.txtHoTen.TabIndex = 67;
            this.txtHoTen.Validated += new System.EventHandler(this.txt_Validated);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(462, 21);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(184, 22);
            this.txtSDT.TabIndex = 66;
            this.txtSDT.Validated += new System.EventHandler(this.txt_Validated);
            // 
            // txtMaBacSi
            // 
            this.txtMaBacSi.Location = new System.Drawing.Point(123, 21);
            this.txtMaBacSi.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaBacSi.Name = "txtMaBacSi";
            this.txtMaBacSi.Size = new System.Drawing.Size(186, 22);
            this.txtMaBacSi.TabIndex = 65;
            this.txtMaBacSi.Validated += new System.EventHandler(this.txt_Validated);
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(37, 117);
            this.lblGioiTinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(58, 16);
            this.lblGioiTinh.TabIndex = 62;
            this.lblGioiTinh.Text = "Giới tính:";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(355, 24);
            this.lblSDT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(89, 16);
            this.lblSDT.TabIndex = 60;
            this.lblSDT.Text = "Số điện thoại:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(37, 54);
            this.lblHoTen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(50, 16);
            this.lblHoTen.TabIndex = 64;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // lblMaBacSi
            // 
            this.lblMaBacSi.AutoSize = true;
            this.lblMaBacSi.Location = new System.Drawing.Point(37, 24);
            this.lblMaBacSi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaBacSi.Name = "lblMaBacSi";
            this.lblMaBacSi.Size = new System.Drawing.Size(71, 16);
            this.lblMaBacSi.TabIndex = 59;
            this.lblMaBacSi.Text = "Mã bác sĩ:";
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Location = new System.Drawing.Point(355, 54);
            this.lblChucVu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(58, 16);
            this.lblChucVu.TabIndex = 70;
            this.lblChucVu.Text = "Chức vụ:";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(355, 115);
            this.lblDiaChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(51, 16);
            this.lblDiaChi.TabIndex = 63;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // lblTrinhDo
            // 
            this.lblTrinhDo.AutoSize = true;
            this.lblTrinhDo.Location = new System.Drawing.Point(355, 83);
            this.lblTrinhDo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTrinhDo.Name = "lblTrinhDo";
            this.lblTrinhDo.Size = new System.Drawing.Size(60, 16);
            this.lblTrinhDo.TabIndex = 61;
            this.lblTrinhDo.Text = "Trình độ:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbTrangThai);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbGioiTinh);
            this.groupBox1.Controls.Add(this.txtChucVu);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtTrinhDo);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtMaBacSi);
            this.groupBox1.Controls.Add(this.lblGioiTinh);
            this.groupBox1.Controls.Add(this.lblSDT);
            this.groupBox1.Controls.Add(this.lblHoTen);
            this.groupBox1.Controls.Add(this.lblMaBacSi);
            this.groupBox1.Controls.Add(this.lblChucVu);
            this.groupBox1.Controls.Add(this.lblDiaChi);
            this.groupBox1.Controls.Add(this.lblTrinhDo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(153, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 153);
            this.groupBox1.TabIndex = 81;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // cmbTrangThai
            // 
            this.cmbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrangThai.FormattingEnabled = true;
            this.cmbTrangThai.Items.AddRange(new object[] {
            "Đang làm việc",
            "Nghỉ việc"});
            this.cmbTrangThai.Location = new System.Drawing.Point(123, 82);
            this.cmbTrangThai.Name = "cmbTrangThai";
            this.cmbTrangThai.Size = new System.Drawing.Size(187, 24);
            this.cmbTrangThai.TabIndex = 81;
            this.cmbTrangThai.Validated += new System.EventHandler(this.txt_Validated);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.chkHienThiTatCa);
            this.groupBox2.Controls.Add(this.txtTimKiemBacSi);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(153, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(700, 48);
            this.groupBox2.TabIndex = 82;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // frmDanhMucBacSi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 523);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlDanhMucBacSi);
            this.Controls.Add(this.dgvDanhMucBacSi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDanhMucBacSi";
            this.Text = "Cập nhật thông tin bác sĩ";
            this.Load += new System.EventHandler(this.frmDanhMucBacSi_Load);
            this.pnlDanhMucBacSi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucBacSi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNhapLai;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.ComboBox cmbTrangThai;
    }
}