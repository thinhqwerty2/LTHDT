namespace QLPK.GUI.QuanLyDanhMuc
{
    partial class frmDanhMucNhanVien
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
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblMaNhanVien = new System.Windows.Forms.Label();
            this.dgvDanhMucNhanVien = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbGioiTinh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkHienThiTatCa = new System.Windows.Forms.CheckBox();
            this.txtTimKiemNhanVien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbTrangThai = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucNhanVien)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtChucVu
            // 
            this.txtChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChucVu.Location = new System.Drawing.Point(465, 57);
            this.txtChucVu.Margin = new System.Windows.Forms.Padding(2);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(173, 22);
            this.txtChucVu.TabIndex = 49;
            this.txtChucVu.Validated += new System.EventHandler(this.txtDiaChi_Validated);
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucVu.Location = new System.Drawing.Point(379, 60);
            this.lblChucVu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(57, 16);
            this.lblChucVu.TabIndex = 47;
            this.lblChucVu.Text = "Chức vụ:";
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.Location = new System.Drawing.Point(587, 12);
            this.btnNhapLai.Margin = new System.Windows.Forms.Padding(2);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(73, 28);
            this.btnNhapLai.TabIndex = 43;
            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.UseVisualStyleBackColor = true;
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(484, 12);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(62, 28);
            this.btnLuu.TabIndex = 42;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(386, 12);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(62, 28);
            this.btnXoa.TabIndex = 41;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(227, 12);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(62, 28);
            this.btnSua.TabIndex = 40;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(63, 12);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(62, 28);
            this.btnThem.TabIndex = 44;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(465, 89);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(173, 22);
            this.txtDiaChi.TabIndex = 39;
            this.txtDiaChi.Validated += new System.EventHandler(this.txtDiaChi_Validated);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(143, 57);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(174, 22);
            this.txtHoTen.TabIndex = 36;
            this.txtHoTen.Validated += new System.EventHandler(this.txtDiaChi_Validated);
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(465, 20);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(174, 22);
            this.txtSDT.TabIndex = 35;
            this.txtSDT.Validated += new System.EventHandler(this.txtDiaChi_Validated);
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhanVien.Location = new System.Drawing.Point(143, 20);
            this.txtMaNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(174, 22);
            this.txtMaNhanVien.TabIndex = 34;
            this.txtMaNhanVien.Validated += new System.EventHandler(this.txtDiaChi_Validated);
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.Location = new System.Drawing.Point(379, 92);
            this.lblDiaChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(50, 16);
            this.lblDiaChi.TabIndex = 32;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.Location = new System.Drawing.Point(35, 92);
            this.lblGioiTinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(57, 16);
            this.lblGioiTinh.TabIndex = 31;
            this.lblGioiTinh.Text = "Giới tính:";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.Location = new System.Drawing.Point(379, 23);
            this.lblSDT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(37, 16);
            this.lblSDT.TabIndex = 29;
            this.lblSDT.Text = "SĐT:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(35, 60);
            this.lblHoTen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(49, 16);
            this.lblHoTen.TabIndex = 33;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // lblMaNhanVien
            // 
            this.lblMaNhanVien.AutoSize = true;
            this.lblMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNhanVien.Location = new System.Drawing.Point(35, 23);
            this.lblMaNhanVien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaNhanVien.Name = "lblMaNhanVien";
            this.lblMaNhanVien.Size = new System.Drawing.Size(89, 16);
            this.lblMaNhanVien.TabIndex = 28;
            this.lblMaNhanVien.Text = "Mã nhân viên:";
            // 
            // dgvDanhMucNhanVien
            // 
            this.dgvDanhMucNhanVien.AllowUserToAddRows = false;
            this.dgvDanhMucNhanVien.AllowUserToDeleteRows = false;
            this.dgvDanhMucNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhMucNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhMucNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMucNhanVien.Location = new System.Drawing.Point(154, 311);
            this.dgvDanhMucNhanVien.Name = "dgvDanhMucNhanVien";
            this.dgvDanhMucNhanVien.ReadOnly = true;
            this.dgvDanhMucNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhMucNhanVien.Size = new System.Drawing.Size(700, 200);
            this.dgvDanhMucNhanVien.TabIndex = 50;
            this.dgvDanhMucNhanVien.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDanhMucNhanVien_CellMouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNhapLai);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(154, 194);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 52);
            this.panel1.TabIndex = 51;
            // 
            // cmbGioiTinh
            // 
            this.cmbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGioiTinh.FormattingEnabled = true;
            this.cmbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cmbGioiTinh.Location = new System.Drawing.Point(143, 92);
            this.cmbGioiTinh.Name = "cmbGioiTinh";
            this.cmbGioiTinh.Size = new System.Drawing.Size(174, 24);
            this.cmbGioiTinh.TabIndex = 52;
            this.cmbGioiTinh.Validated += new System.EventHandler(this.txtDiaChi_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Trạng thái";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(584, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 59;
            this.label2.Text = "Hiển thị tất cả";
            // 
            // chkHienThiTatCa
            // 
            this.chkHienThiTatCa.AutoSize = true;
            this.chkHienThiTatCa.Location = new System.Drawing.Point(678, 26);
            this.chkHienThiTatCa.Name = "chkHienThiTatCa";
            this.chkHienThiTatCa.Size = new System.Drawing.Size(15, 14);
            this.chkHienThiTatCa.TabIndex = 58;
            this.chkHienThiTatCa.UseVisualStyleBackColor = true;
            this.chkHienThiTatCa.CheckedChanged += new System.EventHandler(this.chkHienThiTatCa_CheckedChanged);
            // 
            // txtTimKiemNhanVien
            // 
            this.txtTimKiemNhanVien.Location = new System.Drawing.Point(98, 21);
            this.txtTimKiemNhanVien.Name = "txtTimKiemNhanVien";
            this.txtTimKiemNhanVien.Size = new System.Drawing.Size(480, 22);
            this.txtTimKiemNhanVien.TabIndex = 57;
            this.txtTimKiemNhanVien.TextChanged += new System.EventHandler(this.txtTimKiemNhanVien_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 56;
            this.label3.Text = "Từ khoá";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTimKiemNhanVien);
            this.groupBox1.Controls.Add(this.chkHienThiTatCa);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(154, 252);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(699, 53);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbTrangThai);
            this.groupBox2.Controls.Add(this.cmbGioiTinh);
            this.groupBox2.Controls.Add(this.txtChucVu);
            this.groupBox2.Controls.Add(this.lblChucVu);
            this.groupBox2.Controls.Add(this.txtDiaChi);
            this.groupBox2.Controls.Add(this.txtHoTen);
            this.groupBox2.Controls.Add(this.txtSDT);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtMaNhanVien);
            this.groupBox2.Controls.Add(this.lblDiaChi);
            this.groupBox2.Controls.Add(this.lblGioiTinh);
            this.groupBox2.Controls.Add(this.lblSDT);
            this.groupBox2.Controls.Add(this.lblHoTen);
            this.groupBox2.Controls.Add(this.lblMaNhanVien);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(153, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(700, 167);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // cmbTrangThai
            // 
            this.cmbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTrangThai.FormattingEnabled = true;
            this.cmbTrangThai.Items.AddRange(new object[] {
            "Đang làm việc",
            "Nghỉ việc"});
            this.cmbTrangThai.Location = new System.Drawing.Point(143, 132);
            this.cmbTrangThai.Name = "cmbTrangThai";
            this.cmbTrangThai.Size = new System.Drawing.Size(174, 24);
            this.cmbTrangThai.TabIndex = 53;
            // 
            // frmDanhMucNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 523);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDanhMucNhanVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDanhMucNhanVien";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frmDanhMucNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucNhanVien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblMaNhanVien;
        private System.Windows.Forms.DataGridView dgvDanhMucNhanVien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbGioiTinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkHienThiTatCa;
        private System.Windows.Forms.TextBox txtTimKiemNhanVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbTrangThai;
    }
}