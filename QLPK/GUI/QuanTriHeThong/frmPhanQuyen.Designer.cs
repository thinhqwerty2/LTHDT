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
            this.lblTuKhoa = new System.Windows.Forms.Label();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
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
            this.grpThongTin.Location = new System.Drawing.Point(26, 58);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(730, 136);
            this.grpThongTin.TabIndex = 0;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin";
            // 
            // cmbPhanQuyen
            // 
            this.cmbPhanQuyen.FormattingEnabled = true;
            this.cmbPhanQuyen.Location = new System.Drawing.Point(529, 84);
            this.cmbPhanQuyen.Name = "cmbPhanQuyen";
            this.cmbPhanQuyen.Size = new System.Drawing.Size(185, 24);
            this.cmbPhanQuyen.TabIndex = 7;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(152, 36);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.ReadOnly = true;
            this.txtTenDangNhap.Size = new System.Drawing.Size(185, 22);
            this.txtTenDangNhap.TabIndex = 6;
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.Location = new System.Drawing.Point(152, 85);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.ReadOnly = true;
            this.txtHoVaTen.Size = new System.Drawing.Size(185, 22);
            this.txtHoVaTen.TabIndex = 5;
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDangNhap.Location = new System.Drawing.Point(14, 36);
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
            this.lblHoVaTen.Location = new System.Drawing.Point(14, 85);
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
            this.txtChucVu.Location = new System.Drawing.Point(529, 36);
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
            this.grpTimKiem.Controls.Add(this.btnCapNhat);
            this.grpTimKiem.Controls.Add(this.btnTimKiem);
            this.grpTimKiem.Controls.Add(this.txtTuKhoa);
            this.grpTimKiem.Controls.Add(this.lblTuKhoa);
            this.grpTimKiem.Location = new System.Drawing.Point(26, 219);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Size = new System.Drawing.Size(730, 63);
            this.grpTimKiem.TabIndex = 0;
            this.grpTimKiem.TabStop = false;
            this.grpTimKiem.Text = "Tìm kiếm";
            // 
            // lblTuKhoa
            // 
            this.lblTuKhoa.AutoSize = true;
            this.lblTuKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuKhoa.Location = new System.Drawing.Point(69, 33);
            this.lblTuKhoa.Name = "lblTuKhoa";
            this.lblTuKhoa.Size = new System.Drawing.Size(66, 18);
            this.lblTuKhoa.TabIndex = 4;
            this.lblTuKhoa.Text = "Từ khoá:";
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Location = new System.Drawing.Point(152, 33);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(185, 22);
            this.txtTuKhoa.TabIndex = 8;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(367, 31);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 9;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(461, 31);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 9;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(730, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // frmPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblPhanQuyen);
            this.Controls.Add(this.grpTimKiem);
            this.Controls.Add(this.grpThongTin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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