namespace QLPK.GUI.QuanTriHeThong
{
    partial class frmDoiMatKhau
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
            this.components = new System.ComponentModel.Container();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txtNhapLaiMatKhau = new System.Windows.Forms.TextBox();
            this.lblNhapLai = new System.Windows.Forms.Label();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.lblMatKhauMoi = new System.Windows.Forms.Label();
            this.txtMatKhauCu = new System.Windows.Forms.TextBox();
            this.lblMatKhauCu = new System.Windows.Forms.Label();
            this.txtHoVaTen = new System.Windows.Forms.TextBox();
            this.lblHoVaTen = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.lblThayDoiMatKhau = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ckbHienThiMatKhau = new System.Windows.Forms.CheckBox();
            this.ckbHienThiMatKhauMoi = new System.Windows.Forms.CheckBox();
            this.ckbNhapLaiMatKhauMoi = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(448, 346);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(82, 33);
            this.btnCapNhat.TabIndex = 15;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtNhapLaiMatKhau
            // 
            this.txtNhapLaiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapLaiMatKhau.Location = new System.Drawing.Point(481, 300);
            this.txtNhapLaiMatKhau.Margin = new System.Windows.Forms.Padding(2);
            this.txtNhapLaiMatKhau.Name = "txtNhapLaiMatKhau";
            this.txtNhapLaiMatKhau.Size = new System.Drawing.Size(189, 22);
            this.txtNhapLaiMatKhau.TabIndex = 10;
            this.txtNhapLaiMatKhau.UseSystemPasswordChar = true;
            this.txtNhapLaiMatKhau.TextChanged += new System.EventHandler(this.txtNhapLaiMatKhau_TextChanged);
            // 
            // lblNhapLai
            // 
            this.lblNhapLai.AutoSize = true;
            this.lblNhapLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapLai.Location = new System.Drawing.Point(313, 303);
            this.lblNhapLai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNhapLai.Name = "lblNhapLai";
            this.lblNhapLai.Size = new System.Drawing.Size(143, 16);
            this.lblNhapLai.TabIndex = 5;
            this.lblNhapLai.Text = "Nhập lại mật khẩu mới:";
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauMoi.Location = new System.Drawing.Point(481, 262);
            this.txtMatKhauMoi.Margin = new System.Windows.Forms.Padding(2);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.Size = new System.Drawing.Size(189, 22);
            this.txtMatKhauMoi.TabIndex = 11;
            this.txtMatKhauMoi.UseSystemPasswordChar = true;
            this.txtMatKhauMoi.Validated += new System.EventHandler(this.txtNhapLaiMatKhau_TextChanged);
            // 
            // lblMatKhauMoi
            // 
            this.lblMatKhauMoi.AutoSize = true;
            this.lblMatKhauMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhauMoi.Location = new System.Drawing.Point(313, 265);
            this.lblMatKhauMoi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMatKhauMoi.Name = "lblMatKhauMoi";
            this.lblMatKhauMoi.Size = new System.Drawing.Size(90, 16);
            this.lblMatKhauMoi.TabIndex = 6;
            this.lblMatKhauMoi.Text = "Mật khẩu mới:";
            // 
            // txtMatKhauCu
            // 
            this.txtMatKhauCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauCu.Location = new System.Drawing.Point(481, 224);
            this.txtMatKhauCu.Margin = new System.Windows.Forms.Padding(2);
            this.txtMatKhauCu.Name = "txtMatKhauCu";
            this.txtMatKhauCu.Size = new System.Drawing.Size(189, 22);
            this.txtMatKhauCu.TabIndex = 12;
            this.txtMatKhauCu.UseSystemPasswordChar = true;
            // 
            // lblMatKhauCu
            // 
            this.lblMatKhauCu.AutoSize = true;
            this.lblMatKhauCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhauCu.Location = new System.Drawing.Point(313, 227);
            this.lblMatKhauCu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMatKhauCu.Name = "lblMatKhauCu";
            this.lblMatKhauCu.Size = new System.Drawing.Size(82, 16);
            this.lblMatKhauCu.TabIndex = 7;
            this.lblMatKhauCu.Text = "Mật khẩu cũ:";
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoVaTen.Location = new System.Drawing.Point(481, 183);
            this.txtHoVaTen.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.ReadOnly = true;
            this.txtHoVaTen.Size = new System.Drawing.Size(189, 22);
            this.txtHoVaTen.TabIndex = 13;
            // 
            // lblHoVaTen
            // 
            this.lblHoVaTen.AutoSize = true;
            this.lblHoVaTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoVaTen.Location = new System.Drawing.Point(313, 183);
            this.lblHoVaTen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoVaTen.Name = "lblHoVaTen";
            this.lblHoVaTen.Size = new System.Drawing.Size(68, 16);
            this.lblHoVaTen.TabIndex = 8;
            this.lblHoVaTen.Text = "Họ và tên:";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.Location = new System.Drawing.Point(481, 144);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.ReadOnly = true;
            this.txtTenDangNhap.Size = new System.Drawing.Size(189, 22);
            this.txtTenDangNhap.TabIndex = 14;
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDangNhap.Location = new System.Drawing.Point(313, 144);
            this.lblTenDangNhap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(102, 16);
            this.lblTenDangNhap.TabIndex = 9;
            this.lblTenDangNhap.Text = "Tên đăng nhập:";
            // 
            // lblThayDoiMatKhau
            // 
            this.lblThayDoiMatKhau.AutoSize = true;
            this.lblThayDoiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThayDoiMatKhau.Location = new System.Drawing.Point(369, 80);
            this.lblThayDoiMatKhau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThayDoiMatKhau.Name = "lblThayDoiMatKhau";
            this.lblThayDoiMatKhau.Size = new System.Drawing.Size(218, 24);
            this.lblThayDoiMatKhau.TabIndex = 4;
            this.lblThayDoiMatKhau.Text = "THAY ĐỔI MẬT KHẨU";
            this.lblThayDoiMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ckbHienThiMatKhau
            // 
            this.ckbHienThiMatKhau.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckbHienThiMatKhau.BackColor = System.Drawing.Color.White;
            this.ckbHienThiMatKhau.BackgroundImage = global::QLPK.Properties.Resources.ShowPassword;
            this.ckbHienThiMatKhau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ckbHienThiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbHienThiMatKhau.Location = new System.Drawing.Point(702, 224);
            this.ckbHienThiMatKhau.Name = "ckbHienThiMatKhau";
            this.ckbHienThiMatKhau.Size = new System.Drawing.Size(32, 22);
            this.ckbHienThiMatKhau.TabIndex = 16;
            this.ckbHienThiMatKhau.UseVisualStyleBackColor = false;
            this.ckbHienThiMatKhau.CheckedChanged += new System.EventHandler(this.ckbHienThiMatKhau_CheckedChanged);
            // 
            // ckbHienThiMatKhauMoi
            // 
            this.ckbHienThiMatKhauMoi.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckbHienThiMatKhauMoi.BackColor = System.Drawing.Color.White;
            this.ckbHienThiMatKhauMoi.BackgroundImage = global::QLPK.Properties.Resources.ShowPassword;
            this.ckbHienThiMatKhauMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ckbHienThiMatKhauMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbHienThiMatKhauMoi.Location = new System.Drawing.Point(702, 262);
            this.ckbHienThiMatKhauMoi.Name = "ckbHienThiMatKhauMoi";
            this.ckbHienThiMatKhauMoi.Size = new System.Drawing.Size(32, 22);
            this.ckbHienThiMatKhauMoi.TabIndex = 16;
            this.ckbHienThiMatKhauMoi.UseVisualStyleBackColor = false;
            this.ckbHienThiMatKhauMoi.CheckedChanged += new System.EventHandler(this.ckbHienThiMatKhauMoi_CheckedChanged);
            // 
            // ckbNhapLaiMatKhauMoi
            // 
            this.ckbNhapLaiMatKhauMoi.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckbNhapLaiMatKhauMoi.BackColor = System.Drawing.Color.White;
            this.ckbNhapLaiMatKhauMoi.BackgroundImage = global::QLPK.Properties.Resources.ShowPassword;
            this.ckbNhapLaiMatKhauMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ckbNhapLaiMatKhauMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbNhapLaiMatKhauMoi.Location = new System.Drawing.Point(702, 300);
            this.ckbNhapLaiMatKhauMoi.Name = "ckbNhapLaiMatKhauMoi";
            this.ckbNhapLaiMatKhauMoi.Size = new System.Drawing.Size(32, 22);
            this.ckbNhapLaiMatKhauMoi.TabIndex = 16;
            this.ckbNhapLaiMatKhauMoi.UseVisualStyleBackColor = false;
            this.ckbNhapLaiMatKhauMoi.CheckedChanged += new System.EventHandler(this.ckbNhapLaiMatKhauMoi_CheckedChanged);
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 523);
            this.Controls.Add(this.ckbNhapLaiMatKhauMoi);
            this.Controls.Add(this.ckbHienThiMatKhauMoi);
            this.Controls.Add(this.ckbHienThiMatKhau);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.txtNhapLaiMatKhau);
            this.Controls.Add(this.lblNhapLai);
            this.Controls.Add(this.txtMatKhauMoi);
            this.Controls.Add(this.lblMatKhauMoi);
            this.Controls.Add(this.txtMatKhauCu);
            this.Controls.Add(this.lblMatKhauCu);
            this.Controls.Add(this.txtHoVaTen);
            this.Controls.Add(this.lblHoVaTen);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.lblTenDangNhap);
            this.Controls.Add(this.lblThayDoiMatKhau);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDoiMatKhau";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmDoiMatKhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txtNhapLaiMatKhau;
        private System.Windows.Forms.Label lblNhapLai;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.Label lblMatKhauMoi;
        private System.Windows.Forms.TextBox txtMatKhauCu;
        private System.Windows.Forms.Label lblMatKhauCu;
        private System.Windows.Forms.TextBox txtHoVaTen;
        private System.Windows.Forms.Label lblHoVaTen;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.Label lblThayDoiMatKhau;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox ckbNhapLaiMatKhauMoi;
        private System.Windows.Forms.CheckBox ckbHienThiMatKhauMoi;
        private System.Windows.Forms.CheckBox ckbHienThiMatKhau;
    }
}