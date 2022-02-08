
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
            this.pnlXemBaoCaoThongKe = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNutQuanTriHeThong.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNutQuanTriHeThong
            // 
            this.pnlNutQuanTriHeThong.BackColor = System.Drawing.Color.DarkCyan;
            this.pnlNutQuanTriHeThong.Controls.Add(this.btnHoSoBenhAn);
            this.pnlNutQuanTriHeThong.Controls.Add(this.btnThongKeTheoDichVu);
            this.pnlNutQuanTriHeThong.Controls.Add(this.btnThongKeLoaiBenhPhoBien);
            this.pnlNutQuanTriHeThong.Controls.Add(this.btnThongKeTheoBenhNhan);
            this.pnlNutQuanTriHeThong.Location = new System.Drawing.Point(-5, -8);
            this.pnlNutQuanTriHeThong.Name = "pnlNutQuanTriHeThong";
            this.pnlNutQuanTriHeThong.Size = new System.Drawing.Size(160, 543);
            this.pnlNutQuanTriHeThong.TabIndex = 2;
            // 
            // btnHoSoBenhAn
            // 
            this.btnHoSoBenhAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoSoBenhAn.Location = new System.Drawing.Point(10, 152);
            this.btnHoSoBenhAn.Name = "btnHoSoBenhAn";
            this.btnHoSoBenhAn.Size = new System.Drawing.Size(140, 60);
            this.btnHoSoBenhAn.TabIndex = 3;
            this.btnHoSoBenhAn.Text = "Hồ sơ bệnh án";
            this.btnHoSoBenhAn.UseVisualStyleBackColor = true;
            this.btnHoSoBenhAn.Click += new System.EventHandler(this.btnHoSoBenhAn_Click);
            // 
            // btnThongKeTheoDichVu
            // 
            this.btnThongKeTheoDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeTheoDichVu.Location = new System.Drawing.Point(10, 86);
            this.btnThongKeTheoDichVu.Name = "btnThongKeTheoDichVu";
            this.btnThongKeTheoDichVu.Size = new System.Drawing.Size(140, 60);
            this.btnThongKeTheoDichVu.TabIndex = 1;
            this.btnThongKeTheoDichVu.Text = "Thống kê dịch vụ";
            this.btnThongKeTheoDichVu.UseVisualStyleBackColor = true;
            this.btnThongKeTheoDichVu.Click += new System.EventHandler(this.btnThongKeTheoDichVu_Click);
            // 
            // btnThongKeLoaiBenhPhoBien
            // 
            this.btnThongKeLoaiBenhPhoBien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeLoaiBenhPhoBien.Location = new System.Drawing.Point(10, 218);
            this.btnThongKeLoaiBenhPhoBien.Name = "btnThongKeLoaiBenhPhoBien";
            this.btnThongKeLoaiBenhPhoBien.Size = new System.Drawing.Size(140, 60);
            this.btnThongKeLoaiBenhPhoBien.TabIndex = 4;
            this.btnThongKeLoaiBenhPhoBien.Text = "Thống kê theo loại bệnh";
            this.btnThongKeLoaiBenhPhoBien.UseVisualStyleBackColor = true;
            this.btnThongKeLoaiBenhPhoBien.Visible = false;
            this.btnThongKeLoaiBenhPhoBien.Click += new System.EventHandler(this.btnThongKeLoaiBenhPhoBien_Click);
            // 
            // btnThongKeTheoBenhNhan
            // 
            this.btnThongKeTheoBenhNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeTheoBenhNhan.Location = new System.Drawing.Point(10, 20);
            this.btnThongKeTheoBenhNhan.Name = "btnThongKeTheoBenhNhan";
            this.btnThongKeTheoBenhNhan.Size = new System.Drawing.Size(140, 60);
            this.btnThongKeTheoBenhNhan.TabIndex = 0;
            this.btnThongKeTheoBenhNhan.Text = "Thống kê theo bệnh nhân";
            this.btnThongKeTheoBenhNhan.UseVisualStyleBackColor = true;
            this.btnThongKeTheoBenhNhan.Click += new System.EventHandler(this.btnBenhNhan_Click);
            // 
            // pnlXemBaoCaoThongKe
            // 
            this.pnlXemBaoCaoThongKe.Location = new System.Drawing.Point(176, 3);
            this.pnlXemBaoCaoThongKe.Name = "pnlXemBaoCaoThongKe";
            this.pnlXemBaoCaoThongKe.Size = new System.Drawing.Size(1000, 523);
            this.pnlXemBaoCaoThongKe.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Location = new System.Drawing.Point(151, -8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 572);
            this.panel1.TabIndex = 5;
            // 
            // frmBaoCaoThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 528);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlXemBaoCaoThongKe);
            this.Controls.Add(this.pnlNutQuanTriHeThong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBaoCaoThongKe";
            this.Text = "frmBaoCaoThongKe";
            this.Load += new System.EventHandler(this.frmBaoCaoThongKe_Load);
            this.pnlNutQuanTriHeThong.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNutQuanTriHeThong;
        private System.Windows.Forms.Button btnHoSoBenhAn;
        private System.Windows.Forms.Button btnThongKeTheoDichVu;
        private System.Windows.Forms.Button btnThongKeLoaiBenhPhoBien;
        private System.Windows.Forms.Button btnThongKeTheoBenhNhan;
        private System.Windows.Forms.Panel pnlXemBaoCaoThongKe;
        private System.Windows.Forms.Panel panel1;
    }
}