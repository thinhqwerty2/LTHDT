
namespace QLPK.GUI.BaoCaoThongKe
{
    partial class frmThongKeDichVu
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
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.dgvThongKeDichVu = new System.Windows.Forms.DataGridView();
            this.lblChiTiet = new System.Windows.Forms.Label();
            this.lblTongTien1 = new System.Windows.Forms.Label();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.grpThongKeDichVu = new System.Windows.Forms.GroupBox();
            this.grpThoiGian = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeDichVu)).BeginInit();
            this.grpThongKeDichVu.SuspendLayout();
            this.grpThoiGian.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "tới";
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpDenNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(323, 31);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(200, 22);
            this.dtpDenNgay.TabIndex = 3;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(38, 30);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(200, 22);
            this.dtpTuNgay.TabIndex = 4;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(37, 117);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(108, 16);
            this.lblTongTien.TabIndex = 6;
            this.lblTongTien.Text = "Tổng tiền dịch vụ";
            // 
            // dgvThongKeDichVu
            // 
            this.dgvThongKeDichVu.AllowUserToAddRows = false;
            this.dgvThongKeDichVu.AllowUserToDeleteRows = false;
            this.dgvThongKeDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKeDichVu.BackgroundColor = System.Drawing.Color.White;
            this.dgvThongKeDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKeDichVu.Location = new System.Drawing.Point(153, 225);
            this.dgvThongKeDichVu.Name = "dgvThongKeDichVu";
            this.dgvThongKeDichVu.ReadOnly = true;
            this.dgvThongKeDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongKeDichVu.Size = new System.Drawing.Size(700, 261);
            this.dgvThongKeDichVu.TabIndex = 7;
            // 
            // lblChiTiet
            // 
            this.lblChiTiet.AutoSize = true;
            this.lblChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTiet.Location = new System.Drawing.Point(150, 196);
            this.lblChiTiet.Name = "lblChiTiet";
            this.lblChiTiet.Size = new System.Drawing.Size(46, 16);
            this.lblChiTiet.TabIndex = 6;
            this.lblChiTiet.Text = "Chi tiết";
            // 
            // lblTongTien1
            // 
            this.lblTongTien1.AutoSize = true;
            this.lblTongTien1.Location = new System.Drawing.Point(148, 117);
            this.lblTongTien1.Name = "lblTongTien1";
            this.lblTongTien1.Size = new System.Drawing.Size(14, 16);
            this.lblTongTien1.TabIndex = 6;
            this.lblTongTien1.Text = "0";
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Location = new System.Drawing.Point(555, 25);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(75, 39);
            this.btnThongKe.TabIndex = 8;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // grpThongKeDichVu
            // 
            this.grpThongKeDichVu.Controls.Add(this.grpThoiGian);
            this.grpThongKeDichVu.Controls.Add(this.lblTongTien1);
            this.grpThongKeDichVu.Controls.Add(this.lblTongTien);
            this.grpThongKeDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThongKeDichVu.Location = new System.Drawing.Point(153, 12);
            this.grpThongKeDichVu.Name = "grpThongKeDichVu";
            this.grpThongKeDichVu.Size = new System.Drawing.Size(700, 159);
            this.grpThongKeDichVu.TabIndex = 9;
            this.grpThongKeDichVu.TabStop = false;
            this.grpThongKeDichVu.Text = "Thống kê dịch vụ";
            // 
            // grpThoiGian
            // 
            this.grpThoiGian.Controls.Add(this.btnThongKe);
            this.grpThoiGian.Controls.Add(this.label2);
            this.grpThoiGian.Controls.Add(this.dtpDenNgay);
            this.grpThoiGian.Controls.Add(this.dtpTuNgay);
            this.grpThoiGian.Location = new System.Drawing.Point(25, 21);
            this.grpThoiGian.Name = "grpThoiGian";
            this.grpThoiGian.Size = new System.Drawing.Size(669, 74);
            this.grpThoiGian.TabIndex = 9;
            this.grpThoiGian.TabStop = false;
            this.grpThoiGian.Text = "Thời gian";
            // 
            // frmThongKeDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 523);
            this.Controls.Add(this.grpThongKeDichVu);
            this.Controls.Add(this.dgvThongKeDichVu);
            this.Controls.Add(this.lblChiTiet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThongKeDichVu";
            this.Text = "frmThongKeTheoDichVu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeDichVu)).EndInit();
            this.grpThongKeDichVu.ResumeLayout(false);
            this.grpThongKeDichVu.PerformLayout();
            this.grpThoiGian.ResumeLayout(false);
            this.grpThoiGian.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.DataGridView dgvThongKeDichVu;
        private System.Windows.Forms.Label lblChiTiet;
        private System.Windows.Forms.Label lblTongTien1;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.GroupBox grpThongKeDichVu;
        private System.Windows.Forms.GroupBox grpThoiGian;
    }
}