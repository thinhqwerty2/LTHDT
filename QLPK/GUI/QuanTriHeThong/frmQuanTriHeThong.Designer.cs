
namespace QLPK.GUI.QuanTriHeThong
{
    partial class frmQuanTriHeThong
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
            this.pnlNutQuanTriHeThong = new System.Windows.Forms.Panel();
            this.btnPhanQuyen = new System.Windows.Forms.Button();
            this.btnTaoTaiKhoan = new System.Windows.Forms.Button();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.btnThongTinTaiKhoan = new System.Windows.Forms.Button();
            this.pnlXemQuanTriHeThong = new System.Windows.Forms.Panel();
            this.pnlNutQuanTriHeThong.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNutQuanTriHeThong
            // 
            this.pnlNutQuanTriHeThong.Controls.Add(this.btnPhanQuyen);
            this.pnlNutQuanTriHeThong.Controls.Add(this.btnTaoTaiKhoan);
            this.pnlNutQuanTriHeThong.Controls.Add(this.btnDoiMatKhau);
            this.pnlNutQuanTriHeThong.Controls.Add(this.btnThongTinTaiKhoan);
            this.pnlNutQuanTriHeThong.Location = new System.Drawing.Point(2, 3);
            this.pnlNutQuanTriHeThong.Name = "pnlNutQuanTriHeThong";
            this.pnlNutQuanTriHeThong.Size = new System.Drawing.Size(225, 446);
            this.pnlNutQuanTriHeThong.TabIndex = 0;
            // 
            // btnPhanQuyen
            // 
            this.btnPhanQuyen.Location = new System.Drawing.Point(10, 220);
            this.btnPhanQuyen.Name = "btnPhanQuyen";
            this.btnPhanQuyen.Size = new System.Drawing.Size(212, 50);
            this.btnPhanQuyen.TabIndex = 3;
            this.btnPhanQuyen.Text = "Phân quyền";
            this.btnPhanQuyen.UseVisualStyleBackColor = true;
            this.btnPhanQuyen.Click += new System.EventHandler(this.btnPhanQuyen_Click);
            // 
            // btnTaoTaiKhoan
            // 
            this.btnTaoTaiKhoan.Location = new System.Drawing.Point(10, 149);
            this.btnTaoTaiKhoan.Name = "btnTaoTaiKhoan";
            this.btnTaoTaiKhoan.Size = new System.Drawing.Size(212, 50);
            this.btnTaoTaiKhoan.TabIndex = 2;
            this.btnTaoTaiKhoan.Text = "Tạo tài khoản";
            this.btnTaoTaiKhoan.UseVisualStyleBackColor = true;
            this.btnTaoTaiKhoan.Click += new System.EventHandler(this.btnTaoTaiKhoan_Click);
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Location = new System.Drawing.Point(10, 77);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(212, 50);
            this.btnDoiMatKhau.TabIndex = 1;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.UseVisualStyleBackColor = true;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // btnThongTinTaiKhoan
            // 
            this.btnThongTinTaiKhoan.Location = new System.Drawing.Point(10, 9);
            this.btnThongTinTaiKhoan.Name = "btnThongTinTaiKhoan";
            this.btnThongTinTaiKhoan.Size = new System.Drawing.Size(212, 50);
            this.btnThongTinTaiKhoan.TabIndex = 0;
            this.btnThongTinTaiKhoan.Text = "Thông tin tài khoản";
            this.btnThongTinTaiKhoan.UseVisualStyleBackColor = true;
            this.btnThongTinTaiKhoan.Click += new System.EventHandler(this.btnThongTinTaiKhoan_Click);
            // 
            // pnlXemQuanTriHeThong
            // 
            this.pnlXemQuanTriHeThong.Location = new System.Drawing.Point(233, 3);
            this.pnlXemQuanTriHeThong.Name = "pnlXemQuanTriHeThong";
            this.pnlXemQuanTriHeThong.Size = new System.Drawing.Size(564, 446);
            this.pnlXemQuanTriHeThong.TabIndex = 1;
            // 
            // frmQuanTriHeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlXemQuanTriHeThong);
            this.Controls.Add(this.pnlNutQuanTriHeThong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanTriHeThong";
            this.Text = "frmQuanTriHeThong";
            this.pnlNutQuanTriHeThong.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNutQuanTriHeThong;
        private System.Windows.Forms.Button btnPhanQuyen;
        private System.Windows.Forms.Button btnTaoTaiKhoan;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.Button btnThongTinTaiKhoan;
        private System.Windows.Forms.Panel pnlXemQuanTriHeThong;
    }
}