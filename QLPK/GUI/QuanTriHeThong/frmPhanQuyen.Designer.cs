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
            this.txtHoVaTen = new System.Windows.Forms.TextBox();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.lblHoVaTen = new System.Windows.Forms.Label();
            this.lblPhanQuyenTruyCap = new System.Windows.Forms.Label();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.lblPhanQuyen = new System.Windows.Forms.Label();
            this.grpTimKiem = new System.Windows.Forms.GroupBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.lblTuKhoa = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpThongTin.SuspendLayout();
            this.grpTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.cmbPhanQuyen);
            this.grpThongTin.Controls.Add(this.txtTenDangNhap);
            this.grpThongTin.Controls.Add(this.txtHoVaTen);
            this.grpThongTin.Controls.Add(this.lblTenDangNhap);
            this.grpThongTin.Controls.Add(this.lblChucVu);
            this.grpThongTin.Controls.Add(this.lblHoVaTen);
            this.grpThongTin.Controls.Add(this.lblPhanQuyenTruyCap);
            this.grpThongTin.Controls.Add(this.txtChucVu);
            this.grpThongTin.Location = new System.Drawing.Point(20, 47);
            this.grpThongTin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpThongTin.Size = new System.Drawing.Size(548, 110);
            this.grpThongTin.TabIndex = 0;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin";
            // 
            // cmbPhanQuyen
            // 
            this.cmbPhanQuyen.FormattingEnabled = true;
            this.cmbPhanQuyen.Location = new System.Drawing.Point(397, 68);
            this.cmbPhanQuyen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbPhanQuyen.Name = "cmbPhanQuyen";
            this.cmbPhanQuyen.Size = new System.Drawing.Size(140, 21);
            this.cmbPhanQuyen.TabIndex = 7;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(114, 29);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.ReadOnly = true;
            this.txtTenDangNhap.Size = new System.Drawing.Size(140, 20);
            this.txtTenDangNhap.TabIndex = 6;
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.Location = new System.Drawing.Point(114, 69);
            this.txtHoVaTen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.ReadOnly = true;
            this.txtHoVaTen.Size = new System.Drawing.Size(140, 20);
            this.txtHoVaTen.TabIndex = 5;
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDangNhap.Location = new System.Drawing.Point(10, 29);
            this.lblTenDangNhap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(93, 15);
            this.lblTenDangNhap.TabIndex = 4;
            this.lblTenDangNhap.Text = "Tên đăng nhập:";
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucVu.Location = new System.Drawing.Point(284, 29);
            this.lblChucVu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(53, 15);
            this.lblChucVu.TabIndex = 4;
            this.lblChucVu.Text = "Chức vụ:";
            // 
            // lblHoVaTen
            // 
            this.lblHoVaTen.AutoSize = true;
            this.lblHoVaTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoVaTen.Location = new System.Drawing.Point(10, 69);
            this.lblHoVaTen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoVaTen.Name = "lblHoVaTen";
            this.lblHoVaTen.Size = new System.Drawing.Size(61, 15);
            this.lblHoVaTen.TabIndex = 3;
            this.lblHoVaTen.Text = "Họ và tên:";
            // 
            // lblPhanQuyenTruyCap
            // 
            this.lblPhanQuyenTruyCap.AutoSize = true;
            this.lblPhanQuyenTruyCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhanQuyenTruyCap.Location = new System.Drawing.Point(284, 69);
            this.lblPhanQuyenTruyCap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhanQuyenTruyCap.Name = "lblPhanQuyenTruyCap";
            this.lblPhanQuyenTruyCap.Size = new System.Drawing.Size(120, 15);
            this.lblPhanQuyenTruyCap.TabIndex = 4;
            this.lblPhanQuyenTruyCap.Text = "Phân quyền truy cập:";
            // 
            // txtChucVu
            // 
            this.txtChucVu.Location = new System.Drawing.Point(397, 29);
            this.txtChucVu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.ReadOnly = true;
            this.txtChucVu.Size = new System.Drawing.Size(140, 20);
            this.txtChucVu.TabIndex = 6;
            // 
            // lblPhanQuyen
            // 
            this.lblPhanQuyen.AutoSize = true;
            this.lblPhanQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhanQuyen.Location = new System.Drawing.Point(220, 19);
            this.lblPhanQuyen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhanQuyen.Name = "lblPhanQuyen";
            this.lblPhanQuyen.Size = new System.Drawing.Size(170, 26);
            this.lblPhanQuyen.TabIndex = 8;
            this.lblPhanQuyen.Text = "PHÂN QUYỀN";
            this.lblPhanQuyen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpTimKiem
            // 
            this.grpTimKiem.Controls.Add(this.btnCapNhat);
            this.grpTimKiem.Controls.Add(this.btnTimKiem);
            this.grpTimKiem.Controls.Add(this.txtTuKhoa);
            this.grpTimKiem.Controls.Add(this.lblTuKhoa);
            this.grpTimKiem.Location = new System.Drawing.Point(20, 178);
            this.grpTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpTimKiem.Size = new System.Drawing.Size(548, 51);
            this.grpTimKiem.TabIndex = 0;
            this.grpTimKiem.TabStop = false;
            this.grpTimKiem.Text = "Tìm kiếm";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(346, 17);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(76, 27);
            this.btnCapNhat.TabIndex = 9;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(275, 25);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(56, 19);
            this.btnTimKiem.TabIndex = 9;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Location = new System.Drawing.Point(114, 27);
            this.txtTuKhoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(140, 20);
            this.txtTuKhoa.TabIndex = 8;
            this.txtTuKhoa.TextChanged += new System.EventHandler(this.txtTuKhoa_TextChanged);
            // 
            // lblTuKhoa
            // 
            this.lblTuKhoa.AutoSize = true;
            this.lblTuKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuKhoa.Location = new System.Drawing.Point(52, 27);
            this.lblTuKhoa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTuKhoa.Name = "lblTuKhoa";
            this.lblTuKhoa.Size = new System.Drawing.Size(54, 15);
            this.lblTuKhoa.TabIndex = 4;
            this.lblTuKhoa.Text = "Từ khoá:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 234);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(548, 122);
            this.dataGridView1.TabIndex = 9;
            // 
            // frmPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblPhanQuyen);
            this.Controls.Add(this.grpTimKiem);
            this.Controls.Add(this.grpThongTin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPhanQuyen";
            this.Text = "Form1";
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.TextBox txtHoVaTen;
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
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Label lblTuKhoa;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}