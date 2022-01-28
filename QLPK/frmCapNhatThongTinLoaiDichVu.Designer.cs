namespace QLPK
{
    partial class frmCapNhatThongTinLoaiDichVu
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
            this.lblMaLoaiDichVu = new System.Windows.Forms.Label();
            this.lblTenLoaiDichVu = new System.Windows.Forms.Label();
            this.txtMaLoaiDichVu = new System.Windows.Forms.TextBox();
            this.txtTenLoaiDichVu = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.lsvCapNhatThongTinLoaiDichVu = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lblMaLoaiDichVu
            // 
            this.lblMaLoaiDichVu.AutoSize = true;
            this.lblMaLoaiDichVu.Location = new System.Drawing.Point(88, 95);
            this.lblMaLoaiDichVu.Name = "lblMaLoaiDichVu";
            this.lblMaLoaiDichVu.Size = new System.Drawing.Size(99, 16);
            this.lblMaLoaiDichVu.TabIndex = 0;
            this.lblMaLoaiDichVu.Text = "Mã loại dịch vụ:";
            // 
            // lblTenLoaiDichVu
            // 
            this.lblTenLoaiDichVu.AutoSize = true;
            this.lblTenLoaiDichVu.Location = new System.Drawing.Point(88, 152);
            this.lblTenLoaiDichVu.Name = "lblTenLoaiDichVu";
            this.lblTenLoaiDichVu.Size = new System.Drawing.Size(104, 16);
            this.lblTenLoaiDichVu.TabIndex = 0;
            this.lblTenLoaiDichVu.Text = "Tên loại dịch vụ:";
            // 
            // txtMaLoaiDichVu
            // 
            this.txtMaLoaiDichVu.Location = new System.Drawing.Point(235, 95);
            this.txtMaLoaiDichVu.Name = "txtMaLoaiDichVu";
            this.txtMaLoaiDichVu.Size = new System.Drawing.Size(110, 22);
            this.txtMaLoaiDichVu.TabIndex = 1;
            // 
            // txtTenLoaiDichVu
            // 
            this.txtTenLoaiDichVu.Location = new System.Drawing.Point(235, 149);
            this.txtTenLoaiDichVu.Name = "txtTenLoaiDichVu";
            this.txtTenLoaiDichVu.Size = new System.Drawing.Size(110, 22);
            this.txtTenLoaiDichVu.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(73, 200);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(96, 32);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(207, 200);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(96, 32);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(351, 200);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(96, 32);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(493, 200);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(96, 32);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.Location = new System.Drawing.Point(628, 200);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(96, 32);
            this.btnNhapLai.TabIndex = 2;
            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.UseVisualStyleBackColor = true;
            // 
            // lsvCapNhatThongTinLoaiDichVu
            // 
            this.lsvCapNhatThongTinLoaiDichVu.HideSelection = false;
            this.lsvCapNhatThongTinLoaiDichVu.Location = new System.Drawing.Point(56, 251);
            this.lsvCapNhatThongTinLoaiDichVu.Name = "lsvCapNhatThongTinLoaiDichVu";
            this.lsvCapNhatThongTinLoaiDichVu.Size = new System.Drawing.Size(699, 164);
            this.lsvCapNhatThongTinLoaiDichVu.TabIndex = 3;
            this.lsvCapNhatThongTinLoaiDichVu.UseCompatibleStateImageBehavior = false;
            // 
            // frmCapNhatThongTinLoaiDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lsvCapNhatThongTinLoaiDichVu);
            this.Controls.Add(this.btnNhapLai);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTenLoaiDichVu);
            this.Controls.Add(this.txtMaLoaiDichVu);
            this.Controls.Add(this.lblTenLoaiDichVu);
            this.Controls.Add(this.lblMaLoaiDichVu);
            this.Name = "frmCapNhatThongTinLoaiDichVu";
            this.Text = "Cập nhật thông tin loại dịch vụ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaLoaiDichVu;
        private System.Windows.Forms.Label lblTenLoaiDichVu;
        private System.Windows.Forms.TextBox txtMaLoaiDichVu;
        private System.Windows.Forms.TextBox txtTenLoaiDichVu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.ListView lsvCapNhatThongTinLoaiDichVu;
    }
}