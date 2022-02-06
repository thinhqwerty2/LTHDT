namespace QLPK.GUI.QuanTriHeThong
{
    partial class frmPhanQuyen
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
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.cmbPhanQuyen = new System.Windows.Forms.ComboBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.lblHoVaTen = new System.Windows.Forms.Label();
            this.lblPhanQuyenTruyCap = new System.Windows.Forms.Label();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.lblPhanQuyen = new System.Windows.Forms.Label();
            this.grpTimKiem = new System.Windows.Forms.GroupBox();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.lblTuKhoa = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.dgvPhanQuyen = new System.Windows.Forms.DataGridView();
            this.grpThongTin.SuspendLayout();
            this.grpTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanQuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.cmbPhanQuyen);
            this.grpThongTin.Controls.Add(this.txtTenDangNhap);
            this.grpThongTin.Controls.Add(this.txtHoTen);
            this.grpThongTin.Controls.Add(this.lblTenDangNhap);
            this.grpThongTin.Controls.Add(this.lblChucVu);
            this.grpThongTin.Controls.Add(this.lblHoVaTen);
            this.grpThongTin.Controls.Add(this.lblPhanQuyenTruyCap);
            this.grpThongTin.Controls.Add(this.txtChucVu);
            this.grpThongTin.Location = new System.Drawing.Point(27, 58);
            this.grpThongTin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpThongTin.Size = new System.Drawing.Size(731, 135);
            this.grpThongTin.TabIndex = 0;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin";
            // 
            // cmbPhanQuyen
            // 
            this.cmbPhanQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPhanQuyen.FormattingEnabled = true;
            this.cmbPhanQuyen.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.cmbPhanQuyen.Location = new System.Drawing.Point(539, 84);
            this.cmbPhanQuyen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPhanQuyen.Name = "cmbPhanQuyen";
            this.cmbPhanQuyen.Size = new System.Drawing.Size(185, 24);
            this.cmbPhanQuyen.TabIndex = 7;
            this.cmbPhanQuyen.Validated += new System.EventHandler(this.cmbPhanQuyen_Validated);
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(152, 36);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.ReadOnly = true;
            this.txtTenDangNhap.Size = new System.Drawing.Size(185, 22);
            this.txtTenDangNhap.TabIndex = 6;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(152, 85);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(185, 22);
            this.txtHoTen.TabIndex = 5;
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDangNhap.Location = new System.Drawing.Point(13, 36);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(109, 18);
            this.lblTenDangNhap.TabIndex = 4;
            this.lblTenDangNhap.Text = "Tên đăng nhập:";
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucVu.Location = new System.Drawing.Point(379, 36);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(66, 18);
            this.lblChucVu.TabIndex = 4;
            this.lblChucVu.Text = "Chức vụ:";
            // 
            // lblHoVaTen
            // 
            this.lblHoVaTen.AutoSize = true;
            this.lblHoVaTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoVaTen.Location = new System.Drawing.Point(13, 85);
            this.lblHoVaTen.Name = "lblHoVaTen";
            this.lblHoVaTen.Size = new System.Drawing.Size(75, 18);
            this.lblHoVaTen.TabIndex = 3;
            this.lblHoVaTen.Text = "Họ và tên:";
            // 
            // lblPhanQuyenTruyCap
            // 
            this.lblPhanQuyenTruyCap.AutoSize = true;
            this.lblPhanQuyenTruyCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhanQuyenTruyCap.Location = new System.Drawing.Point(379, 85);
            this.lblPhanQuyenTruyCap.Name = "lblPhanQuyenTruyCap";
            this.lblPhanQuyenTruyCap.Size = new System.Drawing.Size(145, 18);
            this.lblPhanQuyenTruyCap.TabIndex = 4;
            this.lblPhanQuyenTruyCap.Text = "Phân quyền truy cập:";
            // 
            // txtChucVu
            // 
            this.txtChucVu.Location = new System.Drawing.Point(539, 36);
            this.txtChucVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.ReadOnly = true;
            this.txtChucVu.Size = new System.Drawing.Size(185, 22);
            this.txtChucVu.TabIndex = 6;
            // 
            // lblPhanQuyen
            // 
            this.lblPhanQuyen.AutoSize = true;
            this.lblPhanQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhanQuyen.Location = new System.Drawing.Point(293, 23);
            this.lblPhanQuyen.Name = "lblPhanQuyen";
            this.lblPhanQuyen.Size = new System.Drawing.Size(209, 32);
            this.lblPhanQuyen.TabIndex = 8;
            this.lblPhanQuyen.Text = "PHÂN QUYỀN";
            this.lblPhanQuyen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpTimKiem
            // 
            this.grpTimKiem.Controls.Add(this.txtTuKhoa);
            this.grpTimKiem.Controls.Add(this.lblTuKhoa);
            this.grpTimKiem.Location = new System.Drawing.Point(27, 234);
            this.grpTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpTimKiem.Size = new System.Drawing.Size(731, 48);
            this.grpTimKiem.TabIndex = 0;
            this.grpTimKiem.TabStop = false;
            this.grpTimKiem.Text = "Tìm kiếm";
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Location = new System.Drawing.Point(152, 24);
            this.txtTuKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(185, 22);
            this.txtTuKhoa.TabIndex = 8;
            this.txtTuKhoa.TextChanged += new System.EventHandler(this.txtTuKhoa_TextChanged);
            // 
            // lblTuKhoa
            // 
            this.lblTuKhoa.AutoSize = true;
            this.lblTuKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuKhoa.Location = new System.Drawing.Point(69, 24);
            this.lblTuKhoa.Name = "lblTuKhoa";
            this.lblTuKhoa.Size = new System.Drawing.Size(66, 18);
            this.lblTuKhoa.TabIndex = 4;
            this.lblTuKhoa.Text = "Từ khoá:";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(636, 195);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(99, 35);
            this.btnCapNhat.TabIndex = 9;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click_1);
            // 
            // dgvPhanQuyen
            // 
            this.dgvPhanQuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhanQuyen.Location = new System.Drawing.Point(27, 288);
            this.dgvPhanQuyen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPhanQuyen.Name = "dgvPhanQuyen";
            this.dgvPhanQuyen.ReadOnly = true;
            this.dgvPhanQuyen.RowHeadersWidth = 51;
            this.dgvPhanQuyen.RowTemplate.Height = 24;
            this.dgvPhanQuyen.Size = new System.Drawing.Size(731, 240);
            this.dgvPhanQuyen.TabIndex = 9;
            this.dgvPhanQuyen.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPhanQuyen_CellMouseClick);
            // 
            // frmPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 565);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.dgvPhanQuyen);
            this.Controls.Add(this.lblPhanQuyen);
            this.Controls.Add(this.grpTimKiem);
            this.Controls.Add(this.grpThongTin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPhanQuyen";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmPhanQuyen_Load);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanQuyen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblHoVaTen;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.Label lblPhanQuyenTruyCap;
        private System.Windows.Forms.ComboBox cmbPhanQuyen;
        private System.Windows.Forms.Label lblPhanQuyen;
        private System.Windows.Forms.GroupBox grpTimKiem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Label lblTuKhoa;
        private System.Windows.Forms.DataGridView dgvPhanQuyen;
    }
}