
namespace QLPK.GUI.QuanLyDanhMuc
{
    partial class frmDanhMucBenh
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
            this.pnlDanhMucBacSi = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTimKiemLoaiBenh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDanhMucLoaiBenh = new System.Windows.Forms.DataGridView();
            this.txtMoTaBenh = new System.Windows.Forms.TextBox();
            this.txtLoaiBenh = new System.Windows.Forms.TextBox();
            this.txtMaBenh = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblMaBacSi = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnlDanhMucBacSi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucLoaiBenh)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDanhMucBacSi
            // 
            this.pnlDanhMucBacSi.Controls.Add(this.btnXoa);
            this.pnlDanhMucBacSi.Controls.Add(this.btnNhapLai);
            this.pnlDanhMucBacSi.Controls.Add(this.btnSua);
            this.pnlDanhMucBacSi.Controls.Add(this.btnThem);
            this.pnlDanhMucBacSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDanhMucBacSi.Location = new System.Drawing.Point(204, 210);
            this.pnlDanhMucBacSi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlDanhMucBacSi.Name = "pnlDanhMucBacSi";
            this.pnlDanhMucBacSi.Size = new System.Drawing.Size(933, 76);
            this.pnlDanhMucBacSi.TabIndex = 100;
            // 
            // btnXoa
            // 
            this.btnXoa.Enabled = false;
            this.btnXoa.Location = new System.Drawing.Point(311, 2);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(115, 60);
            this.btnXoa.TabIndex = 41;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.Location = new System.Drawing.Point(752, 2);
            this.btnNhapLai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(115, 60);
            this.btnNhapLai.TabIndex = 40;
            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.UseVisualStyleBackColor = true;
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(469, 2);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(115, 60);
            this.btnSua.TabIndex = 40;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(133, 2);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(115, 60);
            this.btnThem.TabIndex = 44;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTimKiemLoaiBenh
            // 
            this.txtTimKiemLoaiBenh.Location = new System.Drawing.Point(147, 18);
            this.txtTimKiemLoaiBenh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTimKiemLoaiBenh.Name = "txtTimKiemLoaiBenh";
            this.txtTimKiemLoaiBenh.Size = new System.Drawing.Size(777, 26);
            this.txtTimKiemLoaiBenh.TabIndex = 97;
            this.txtTimKiemLoaiBenh.TextChanged += new System.EventHandler(this.txtTimKiemLoaiBenh_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 96;
            this.label1.Text = "Từ khoá";
            // 
            // dgvDanhMucLoaiBenh
            // 
            this.dgvDanhMucLoaiBenh.AllowUserToAddRows = false;
            this.dgvDanhMucLoaiBenh.AllowUserToDeleteRows = false;
            this.dgvDanhMucLoaiBenh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhMucLoaiBenh.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhMucLoaiBenh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMucLoaiBenh.Location = new System.Drawing.Point(204, 367);
            this.dgvDanhMucLoaiBenh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDanhMucLoaiBenh.Name = "dgvDanhMucLoaiBenh";
            this.dgvDanhMucLoaiBenh.ReadOnly = true;
            this.dgvDanhMucLoaiBenh.RowHeadersWidth = 51;
            this.dgvDanhMucLoaiBenh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhMucLoaiBenh.Size = new System.Drawing.Size(933, 262);
            this.dgvDanhMucLoaiBenh.TabIndex = 94;
            this.dgvDanhMucLoaiBenh.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDanhMucLoaiBenh_CellMouseClick);
            // 
            // txtMoTaBenh
            // 
            this.txtMoTaBenh.Location = new System.Drawing.Point(147, 66);
            this.txtMoTaBenh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMoTaBenh.Multiline = true;
            this.txtMoTaBenh.Name = "txtMoTaBenh";
            this.txtMoTaBenh.Size = new System.Drawing.Size(777, 90);
            this.txtMoTaBenh.TabIndex = 89;
            this.txtMoTaBenh.TextChanged += new System.EventHandler(this.txtDiaChi_Validated);
            // 
            // txtLoaiBenh
            // 
            this.txtLoaiBenh.Location = new System.Drawing.Point(624, 25);
            this.txtLoaiBenh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLoaiBenh.Name = "txtLoaiBenh";
            this.txtLoaiBenh.Size = new System.Drawing.Size(300, 26);
            this.txtLoaiBenh.TabIndex = 88;
            this.txtLoaiBenh.TextChanged += new System.EventHandler(this.txtDiaChi_Validated);
            // 
            // txtMaBenh
            // 
            this.txtMaBenh.Location = new System.Drawing.Point(147, 25);
            this.txtMaBenh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaBenh.Name = "txtMaBenh";
            this.txtMaBenh.Size = new System.Drawing.Size(300, 26);
            this.txtMaBenh.TabIndex = 87;
            this.txtMaBenh.TextChanged += new System.EventHandler(this.txtDiaChi_Validated);
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(513, 28);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(87, 20);
            this.lblSDT.TabIndex = 82;
            this.lblSDT.Text = "Loại bệnh:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(32, 70);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(97, 20);
            this.lblHoTen.TabIndex = 86;
            this.lblHoTen.Text = "Mô tả bệnh:";
            // 
            // lblMaBacSi
            // 
            this.lblMaBacSi.AutoSize = true;
            this.lblMaBacSi.Location = new System.Drawing.Point(24, 28);
            this.lblMaBacSi.Name = "lblMaBacSi";
            this.lblMaBacSi.Size = new System.Drawing.Size(109, 20);
            this.lblMaBacSi.TabIndex = 81;
            this.lblMaBacSi.Text = "Mã loại bệnh:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMoTaBenh);
            this.groupBox1.Controls.Add(this.txtLoaiBenh);
            this.groupBox1.Controls.Add(this.txtMaBenh);
            this.groupBox1.Controls.Add(this.lblSDT);
            this.groupBox1.Controls.Add(this.lblHoTen);
            this.groupBox1.Controls.Add(this.lblMaBacSi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(204, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(933, 164);
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTimKiemLoaiBenh);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(204, 305);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(933, 54);
            this.groupBox2.TabIndex = 102;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // frmDanhMucBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 644);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlDanhMucBacSi);
            this.Controls.Add(this.dgvDanhMucLoaiBenh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDanhMucBenh";
            this.Text = "frmDanhMucBenh";
            this.Load += new System.EventHandler(this.frmDanhMucBenh_Load);
            this.pnlDanhMucBacSi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucLoaiBenh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlDanhMucBacSi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTimKiemLoaiBenh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDanhMucLoaiBenh;
        private System.Windows.Forms.TextBox txtMoTaBenh;
        private System.Windows.Forms.TextBox txtLoaiBenh;
        private System.Windows.Forms.TextBox txtMaBenh;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblMaBacSi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}