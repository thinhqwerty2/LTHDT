
namespace QLPK.GUI.BaoCaoThongKe
{
    partial class frmThongKeBenhNhan
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
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTongSoBenhNhan = new System.Windows.Forms.Label();
            this.lblNam = new System.Windows.Forms.Label();
            this.lblNu = new System.Windows.Forms.Label();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.lblSoBenhNhanMoi = new System.Windows.Forms.Label();
            this.dgvThongKeBenhNhan = new System.Windows.Forms.DataGridView();
            this.lblTongSoBenhNhan1 = new System.Windows.Forms.Label();
            this.lblTongDoanhThu1 = new System.Windows.Forms.Label();
            this.lblNu1 = new System.Windows.Forms.Label();
            this.lblNam1 = new System.Windows.Forms.Label();
            this.lblSoBenhNhanMoi1 = new System.Windows.Forms.Label();
            this.grpThoiGian = new System.Windows.Forms.GroupBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.grpThongKeBenhNhan = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeBenhNhan)).BeginInit();
            this.grpThoiGian.SuspendLayout();
            this.grpThongKeBenhNhan.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(33, 21);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(200, 22);
            this.dtpTuNgay.TabIndex = 1;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpDenNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(290, 21);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(200, 22);
            this.dtpDenNgay.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "tới";
            // 
            // lblTongSoBenhNhan
            // 
            this.lblTongSoBenhNhan.AutoSize = true;
            this.lblTongSoBenhNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongSoBenhNhan.Location = new System.Drawing.Point(19, 98);
            this.lblTongSoBenhNhan.Name = "lblTongSoBenhNhan";
            this.lblTongSoBenhNhan.Size = new System.Drawing.Size(122, 16);
            this.lblTongSoBenhNhan.TabIndex = 3;
            this.lblTongSoBenhNhan.Text = "Tổng số bệnh nhân";
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNam.Location = new System.Drawing.Point(543, 98);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(36, 16);
            this.lblNam.TabIndex = 3;
            this.lblNam.Text = "Nam";
            // 
            // lblNu
            // 
            this.lblNu.AutoSize = true;
            this.lblNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNu.Location = new System.Drawing.Point(365, 98);
            this.lblNu.Name = "lblNu";
            this.lblNu.Size = new System.Drawing.Size(24, 16);
            this.lblNu.TabIndex = 3;
            this.lblNu.Text = "Nữ";
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongDoanhThu.Location = new System.Drawing.Point(19, 123);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(100, 16);
            this.lblTongDoanhThu.TabIndex = 3;
            this.lblTongDoanhThu.Text = "Tổng doanh thu";
            // 
            // lblSoBenhNhanMoi
            // 
            this.lblSoBenhNhanMoi.AutoSize = true;
            this.lblSoBenhNhanMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoBenhNhanMoi.Location = new System.Drawing.Point(365, 123);
            this.lblSoBenhNhanMoi.Name = "lblSoBenhNhanMoi";
            this.lblSoBenhNhanMoi.Size = new System.Drawing.Size(114, 16);
            this.lblSoBenhNhanMoi.TabIndex = 3;
            this.lblSoBenhNhanMoi.Text = "Số bệnh nhân mới";
            // 
            // dgvThongKeBenhNhan
            // 
            this.dgvThongKeBenhNhan.AllowUserToAddRows = false;
            this.dgvThongKeBenhNhan.AllowUserToDeleteRows = false;
            this.dgvThongKeBenhNhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKeBenhNhan.BackgroundColor = System.Drawing.Color.White;
            this.dgvThongKeBenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKeBenhNhan.Location = new System.Drawing.Point(153, 176);
            this.dgvThongKeBenhNhan.Name = "dgvThongKeBenhNhan";
            this.dgvThongKeBenhNhan.ReadOnly = true;
            this.dgvThongKeBenhNhan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongKeBenhNhan.Size = new System.Drawing.Size(700, 306);
            this.dgvThongKeBenhNhan.TabIndex = 4;
            // 
            // lblTongSoBenhNhan1
            // 
            this.lblTongSoBenhNhan1.AutoSize = true;
            this.lblTongSoBenhNhan1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongSoBenhNhan1.Location = new System.Drawing.Point(156, 98);
            this.lblTongSoBenhNhan1.Name = "lblTongSoBenhNhan1";
            this.lblTongSoBenhNhan1.Size = new System.Drawing.Size(14, 16);
            this.lblTongSoBenhNhan1.TabIndex = 5;
            this.lblTongSoBenhNhan1.Text = "0";
            // 
            // lblTongDoanhThu1
            // 
            this.lblTongDoanhThu1.AutoSize = true;
            this.lblTongDoanhThu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongDoanhThu1.Location = new System.Drawing.Point(156, 123);
            this.lblTongDoanhThu1.Name = "lblTongDoanhThu1";
            this.lblTongDoanhThu1.Size = new System.Drawing.Size(14, 16);
            this.lblTongDoanhThu1.TabIndex = 5;
            this.lblTongDoanhThu1.Text = "0";
            // 
            // lblNu1
            // 
            this.lblNu1.AutoSize = true;
            this.lblNu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNu1.Location = new System.Drawing.Point(454, 98);
            this.lblNu1.Name = "lblNu1";
            this.lblNu1.Size = new System.Drawing.Size(14, 16);
            this.lblNu1.TabIndex = 5;
            this.lblNu1.Text = "0";
            // 
            // lblNam1
            // 
            this.lblNam1.AutoSize = true;
            this.lblNam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNam1.Location = new System.Drawing.Point(638, 98);
            this.lblNam1.Name = "lblNam1";
            this.lblNam1.Size = new System.Drawing.Size(14, 16);
            this.lblNam1.TabIndex = 5;
            this.lblNam1.Text = "0";
            // 
            // lblSoBenhNhanMoi1
            // 
            this.lblSoBenhNhanMoi1.AutoSize = true;
            this.lblSoBenhNhanMoi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoBenhNhanMoi1.Location = new System.Drawing.Point(509, 123);
            this.lblSoBenhNhanMoi1.Name = "lblSoBenhNhanMoi1";
            this.lblSoBenhNhanMoi1.Size = new System.Drawing.Size(14, 16);
            this.lblSoBenhNhanMoi1.TabIndex = 5;
            this.lblSoBenhNhanMoi1.Text = "0";
            // 
            // grpThoiGian
            // 
            this.grpThoiGian.Controls.Add(this.btnThongKe);
            this.grpThoiGian.Controls.Add(this.label2);
            this.grpThoiGian.Controls.Add(this.dtpDenNgay);
            this.grpThoiGian.Controls.Add(this.dtpTuNgay);
            this.grpThoiGian.Location = new System.Drawing.Point(22, 19);
            this.grpThoiGian.Name = "grpThoiGian";
            this.grpThoiGian.Size = new System.Drawing.Size(672, 61);
            this.grpThoiGian.TabIndex = 6;
            this.grpThoiGian.TabStop = false;
            this.grpThoiGian.Text = "Thời gian";
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Location = new System.Drawing.Point(538, 18);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(84, 32);
            this.btnThongKe.TabIndex = 3;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // grpThongKeBenhNhan
            // 
            this.grpThongKeBenhNhan.Controls.Add(this.grpThoiGian);
            this.grpThongKeBenhNhan.Controls.Add(this.lblSoBenhNhanMoi1);
            this.grpThongKeBenhNhan.Controls.Add(this.lblNam1);
            this.grpThongKeBenhNhan.Controls.Add(this.lblNu1);
            this.grpThongKeBenhNhan.Controls.Add(this.lblTongDoanhThu1);
            this.grpThongKeBenhNhan.Controls.Add(this.lblTongSoBenhNhan1);
            this.grpThongKeBenhNhan.Controls.Add(this.lblSoBenhNhanMoi);
            this.grpThongKeBenhNhan.Controls.Add(this.lblTongDoanhThu);
            this.grpThongKeBenhNhan.Controls.Add(this.lblNu);
            this.grpThongKeBenhNhan.Controls.Add(this.lblNam);
            this.grpThongKeBenhNhan.Controls.Add(this.lblTongSoBenhNhan);
            this.grpThongKeBenhNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThongKeBenhNhan.Location = new System.Drawing.Point(153, 6);
            this.grpThongKeBenhNhan.Name = "grpThongKeBenhNhan";
            this.grpThongKeBenhNhan.Size = new System.Drawing.Size(700, 155);
            this.grpThongKeBenhNhan.TabIndex = 7;
            this.grpThongKeBenhNhan.TabStop = false;
            this.grpThongKeBenhNhan.Text = "Thống kê bệnh nhân";
            // 
            // frmThongKeBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 523);
            this.Controls.Add(this.grpThongKeBenhNhan);
            this.Controls.Add(this.dgvThongKeBenhNhan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThongKeBenhNhan";
            this.Text = "frmThongKeBenhNhan";
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeBenhNhan)).EndInit();
            this.grpThoiGian.ResumeLayout(false);
            this.grpThoiGian.PerformLayout();
            this.grpThongKeBenhNhan.ResumeLayout(false);
            this.grpThongKeBenhNhan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTongSoBenhNhan;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.Label lblNu;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.Label lblSoBenhNhanMoi;
        private System.Windows.Forms.DataGridView dgvThongKeBenhNhan;
        private System.Windows.Forms.Label lblTongSoBenhNhan1;
        private System.Windows.Forms.Label lblTongDoanhThu1;
        private System.Windows.Forms.Label lblNu1;
        private System.Windows.Forms.Label lblNam1;
        private System.Windows.Forms.Label lblSoBenhNhanMoi1;
        private System.Windows.Forms.GroupBox grpThoiGian;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.GroupBox grpThongKeBenhNhan;
    }
}