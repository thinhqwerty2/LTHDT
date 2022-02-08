
namespace QLPK.GUI.BaoCaoThongKe
{
    partial class frmThongKeBenh
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
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTuoi = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.dgvHoSoBenhAn = new System.Windows.Forms.DataGridView();
            this.txtTimKiemBenhNhan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoSoBenhAn)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(364, 54);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(34, 16);
            this.label.TabIndex = 78;
            this.label.Text = "Tuổi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 79;
            this.label1.Text = "Tên";
            // 
            // txtTuoi
            // 
            this.txtTuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuoi.Location = new System.Drawing.Point(455, 51);
            this.txtTuoi.Name = "txtTuoi";
            this.txtTuoi.ReadOnly = true;
            this.txtTuoi.Size = new System.Drawing.Size(188, 22);
            this.txtTuoi.TabIndex = 75;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(455, 21);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(188, 22);
            this.txtHoTen.TabIndex = 76;
            // 
            // dgvHoSoBenhAn
            // 
            this.dgvHoSoBenhAn.AllowUserToAddRows = false;
            this.dgvHoSoBenhAn.AllowUserToDeleteRows = false;
            this.dgvHoSoBenhAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoSoBenhAn.BackgroundColor = System.Drawing.Color.White;
            this.dgvHoSoBenhAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoSoBenhAn.Location = new System.Drawing.Point(153, 142);
            this.dgvHoSoBenhAn.Name = "dgvHoSoBenhAn";
            this.dgvHoSoBenhAn.ReadOnly = true;
            this.dgvHoSoBenhAn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoSoBenhAn.Size = new System.Drawing.Size(700, 324);
            this.dgvHoSoBenhAn.TabIndex = 80;
            // 
            // txtTimKiemBenhNhan
            // 
            this.txtTimKiemBenhNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemBenhNhan.Location = new System.Drawing.Point(120, 21);
            this.txtTimKiemBenhNhan.Name = "txtTimKiemBenhNhan";
            this.txtTimKiemBenhNhan.Size = new System.Drawing.Size(188, 22);
            this.txtTimKiemBenhNhan.TabIndex = 82;
            this.txtTimKiemBenhNhan.Click += new System.EventHandler(this.txtTimKiemBenhNhan_Click);
            this.txtTimKiemBenhNhan.TextChanged += new System.EventHandler(this.txtTimKiemBenhNhan_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 81;
            this.label2.Text = "Mã bệnh nhân";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTimKiemBenhNhan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTuoi);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(153, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 98);
            this.groupBox1.TabIndex = 83;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(150, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 84;
            this.label3.Text = "Hồ sơ bệnh án:";
            // 
            // frmThongKeBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 523);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvHoSoBenhAn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThongKeBenh";
            this.Text = "frmThongKeBenh";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoSoBenhAn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTuoi;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.DataGridView dgvHoSoBenhAn;
        private System.Windows.Forms.TextBox txtTimKiemBenhNhan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
    }
}