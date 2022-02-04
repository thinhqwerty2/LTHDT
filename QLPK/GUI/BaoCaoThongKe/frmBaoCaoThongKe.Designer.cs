
namespace QLPK.GUI.BaoCaoThongKe
{
    partial class frmBaoCaoThongKe
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
            this.btnHoSoBenhAn = new System.Windows.Forms.Button();
            this.btnThongKeTheoDichVu = new System.Windows.Forms.Button();
            this.btnThongKeLoaiBenhPhoBien = new System.Windows.Forms.Button();
            this.btnThongKeTheoBenhNhan = new System.Windows.Forms.Button();
            this.pnlXemQuanTriHeThong = new System.Windows.Forms.Panel();
            this.pnlNutQuanTriHeThong.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNutQuanTriHeThong
            // 
            this.pnlNutQuanTriHeThong.Controls.Add(this.btnHoSoBenhAn);
            this.pnlNutQuanTriHeThong.Controls.Add(this.btnThongKeTheoDichVu);
            this.pnlNutQuanTriHeThong.Controls.Add(this.btnThongKeLoaiBenhPhoBien);
            this.pnlNutQuanTriHeThong.Controls.Add(this.btnThongKeTheoBenhNhan);
            this.pnlNutQuanTriHeThong.Location = new System.Drawing.Point(3, 2);
            this.pnlNutQuanTriHeThong.Name = "pnlNutQuanTriHeThong";
            this.pnlNutQuanTriHeThong.Size = new System.Drawing.Size(225, 446);
            this.pnlNutQuanTriHeThong.TabIndex = 2;
            // 
            // btnHoSoBenhAn
            // 
            this.btnHoSoBenhAn.Location = new System.Drawing.Point(10, 141);
            this.btnHoSoBenhAn.Name = "btnHoSoBenhAn";
            this.btnHoSoBenhAn.Size = new System.Drawing.Size(212, 50);
            this.btnHoSoBenhAn.TabIndex = 3;
            this.btnHoSoBenhAn.Text = "Hồ sơ bệnh án";
            this.btnHoSoBenhAn.UseVisualStyleBackColor = true;
            // 
            // btnThongKeTheoDichVu
            // 
            this.btnThongKeTheoDichVu.Location = new System.Drawing.Point(10, 74);
            this.btnThongKeTheoDichVu.Name = "btnThongKeTheoDichVu";
            this.btnThongKeTheoDichVu.Size = new System.Drawing.Size(212, 50);
            this.btnThongKeTheoDichVu.TabIndex = 2;
            this.btnThongKeTheoDichVu.Text = "Thống kê dịch vụ";
            this.btnThongKeTheoDichVu.UseVisualStyleBackColor = true;
            // 
            // btnThongKeLoaiBenhPhoBien
            // 
            this.btnThongKeLoaiBenhPhoBien.Location = new System.Drawing.Point(10, 208);
            this.btnThongKeLoaiBenhPhoBien.Name = "btnThongKeLoaiBenhPhoBien";
            this.btnThongKeLoaiBenhPhoBien.Size = new System.Drawing.Size(212, 50);
            this.btnThongKeLoaiBenhPhoBien.TabIndex = 1;
            this.btnThongKeLoaiBenhPhoBien.Text = "Thống kê theo loại bệnh";
            this.btnThongKeLoaiBenhPhoBien.UseVisualStyleBackColor = true;
            // 
            // btnThongKeTheoBenhNhan
            // 
            this.btnThongKeTheoBenhNhan.Location = new System.Drawing.Point(10, 9);
            this.btnThongKeTheoBenhNhan.Name = "btnThongKeTheoBenhNhan";
            this.btnThongKeTheoBenhNhan.Size = new System.Drawing.Size(212, 50);
            this.btnThongKeTheoBenhNhan.TabIndex = 0;
            this.btnThongKeTheoBenhNhan.Text = "Thống kê theo bệnh nhân";
            this.btnThongKeTheoBenhNhan.UseVisualStyleBackColor = true;
            this.btnThongKeTheoBenhNhan.Click += new System.EventHandler(this.btnBenhNhan_Click);
            // 
            // pnlXemQuanTriHeThong
            // 
            this.pnlXemQuanTriHeThong.Location = new System.Drawing.Point(234, 2);
            this.pnlXemQuanTriHeThong.Name = "pnlXemQuanTriHeThong";
            this.pnlXemQuanTriHeThong.Size = new System.Drawing.Size(564, 446);
            this.pnlXemQuanTriHeThong.TabIndex = 3;
            // 
            // frmBaoCaoThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlNutQuanTriHeThong);
            this.Controls.Add(this.pnlXemQuanTriHeThong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBaoCaoThongKe";
            this.Text = "frmBaoCaoThongKe";
            this.pnlNutQuanTriHeThong.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNutQuanTriHeThong;
        private System.Windows.Forms.Button btnHoSoBenhAn;
        private System.Windows.Forms.Button btnThongKeTheoDichVu;
        private System.Windows.Forms.Button btnThongKeLoaiBenhPhoBien;
        private System.Windows.Forms.Button btnThongKeTheoBenhNhan;
        private System.Windows.Forms.Panel pnlXemQuanTriHeThong;
    }
}