
namespace QLPK
{
    partial class frmChinh
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
            this.btnHeThong = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnDanhMuc = new System.Windows.Forms.Button();
            this.btnKhamBenh = new System.Windows.Forms.Button();
            this.btnChuaBenh = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.pnlChinh = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlXinChao = new System.Windows.Forms.Panel();
            this.lblXinChao = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            this.pnlXinChao.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHeThong
            // 
            this.btnHeThong.Location = new System.Drawing.Point(8, 11);
            this.btnHeThong.Name = "btnHeThong";
            this.btnHeThong.Size = new System.Drawing.Size(126, 44);
            this.btnHeThong.TabIndex = 0;
            this.btnHeThong.Text = "Quản trị hệ thống";
            this.btnHeThong.UseVisualStyleBackColor = true;
            this.btnHeThong.Click += new System.EventHandler(this.btnHeThong_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Location = new System.Drawing.Point(632, 11);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(126, 44);
            this.btnBaoCao.TabIndex = 0;
            this.btnBaoCao.Text = "Báo cáo thống kê";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnDanhMuc
            // 
            this.btnDanhMuc.Location = new System.Drawing.Point(157, 11);
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Size = new System.Drawing.Size(126, 44);
            this.btnDanhMuc.TabIndex = 0;
            this.btnDanhMuc.Text = "Quản lý danh mục";
            this.btnDanhMuc.UseVisualStyleBackColor = true;
            this.btnDanhMuc.Click += new System.EventHandler(this.btnDanhMuc_Click);
            // 
            // btnKhamBenh
            // 
            this.btnKhamBenh.Location = new System.Drawing.Point(318, 11);
            this.btnKhamBenh.Name = "btnKhamBenh";
            this.btnKhamBenh.Size = new System.Drawing.Size(126, 44);
            this.btnKhamBenh.TabIndex = 0;
            this.btnKhamBenh.Text = "Khám bệnh";
            this.btnKhamBenh.UseVisualStyleBackColor = true;
            this.btnKhamBenh.Click += new System.EventHandler(this.btnKhamBenh_Click);
            // 
            // btnChuaBenh
            // 
            this.btnChuaBenh.Location = new System.Drawing.Point(473, 11);
            this.btnChuaBenh.Name = "btnChuaBenh";
            this.btnChuaBenh.Size = new System.Drawing.Size(126, 44);
            this.btnChuaBenh.TabIndex = 0;
            this.btnChuaBenh.Text = "Chữa bệnh";
            this.btnChuaBenh.UseVisualStyleBackColor = true;
            this.btnChuaBenh.Click += new System.EventHandler(this.btnChuaBenh_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(792, 11);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(126, 44);
            this.btnThanhToan.TabIndex = 0;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // pnlChinh
            // 
            this.pnlChinh.Location = new System.Drawing.Point(23, 125);
            this.pnlChinh.Name = "pnlChinh";
            this.pnlChinh.Size = new System.Drawing.Size(930, 397);
            this.pnlChinh.TabIndex = 2;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnBaoCao);
            this.pnlMenu.Controls.Add(this.btnHeThong);
            this.pnlMenu.Controls.Add(this.btnThanhToan);
            this.pnlMenu.Controls.Add(this.btnKhamBenh);
            this.pnlMenu.Controls.Add(this.btnDanhMuc);
            this.pnlMenu.Controls.Add(this.btnChuaBenh);
            this.pnlMenu.Location = new System.Drawing.Point(23, 12);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(931, 69);
            this.pnlMenu.TabIndex = 3;
            // 
            // pnlXinChao
            // 
            this.pnlXinChao.Controls.Add(this.lblXinChao);
            this.pnlXinChao.Location = new System.Drawing.Point(23, 87);
            this.pnlXinChao.Name = "pnlXinChao";
            this.pnlXinChao.Size = new System.Drawing.Size(931, 29);
            this.pnlXinChao.TabIndex = 4;
            // 
            // lblXinChao
            // 
            this.lblXinChao.AutoSize = true;
            this.lblXinChao.Location = new System.Drawing.Point(122, 4);
            this.lblXinChao.Name = "lblXinChao";
            this.lblXinChao.Size = new System.Drawing.Size(52, 13);
            this.lblXinChao.TabIndex = 0;
            this.lblXinChao.Text = "Xin chào:";
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 543);
            this.Controls.Add(this.pnlXinChao);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlChinh);
            this.Name = "frmChinh";
            this.Text = "Hệ thống quản lý phòng khám";
            this.pnlMenu.ResumeLayout(false);
            this.pnlXinChao.ResumeLayout(false);
            this.pnlXinChao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnHeThong;
        private System.Windows.Forms.Button btnKhamBenh;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Button btnDanhMuc;
        private System.Windows.Forms.Button btnChuaBenh;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Panel pnlChinh;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlXinChao;
        private System.Windows.Forms.Label lblXinChao;
    }
}