﻿using QLPK.DAO;
using System;
using System.Windows.Forms;

namespace QLPK.GUI.QuanLyDanhMuc
{
    public partial class frmDanhMucBacSi : Form
    {
        public frmDanhMucBacSi()
        {
            InitializeComponent();
            btnSua.Enabled = false;
        }
        bool batLoi()
        {
            if (txtMaBacSi.Text == "" || txtHoTen.Text == "" || cmbGioiTinh.Text == "" || txtTrinhDo.Text == "" || txtChucVu.Text == "" || txtDiaChi.Text == "" || txtSDT.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        void hienThiDS()
        {
            switch (chkHienThiTatCa.Checked)
            {
                case false:
                    this.dgvDanhMucBacSi.DataSource = BacSiDAO.Instance.hienThiDSBacSi();
                    break;
                case true:
                    this.dgvDanhMucBacSi.DataSource = BacSiDAO.Instance.hienThiDSTatCaBacSi();
                    break;
            }

        }

        private void frmDanhMucBacSi_Load(object sender, EventArgs e)
        {
            hienThiDS();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (batLoi())
            {
                BacSiDAO.Instance.themBacSi(txtMaBacSi.Text, txtHoTen.Text, cmbGioiTinh.Text, txtDiaChi.Text, txtSDT.Text, txtTrinhDo.Text, txtChucVu.Text);
                hienThiDS();
            }
            else
            {
                MessageBox.Show("Điền đầy đủ thông tin!!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var kq = MessageBox.Show("Xác nhận sự thay đổi", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (kq == DialogResult.OK)
            {
                BacSiDAO.Instance.suaBacSi(txtDiaChi.Text, txtSDT.Text, txtTrinhDo.Text, txtChucVu.Text, txtMaBacSi.Text);
            }
            hienThiDS();


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            var kq = MessageBox.Show("Xác nhận xoá", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (kq == DialogResult.OK)
            {
                BacSiDAO.Instance.xoaBacSi(txtMaBacSi.Text);
            }
            hienThiDS();

        }

        int indexRow = -1;
        private void dgvDanhMucBacSi_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                btnSua.Enabled = false;
                dgvDanhMucBacSi.Rows[e.RowIndex].Selected = true;
                indexRow = e.RowIndex;
                txtMaBacSi.Text = dgvDanhMucBacSi.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtHoTen.Text = dgvDanhMucBacSi.Rows[e.RowIndex].Cells[1].Value.ToString();
                cmbGioiTinh.Text = dgvDanhMucBacSi.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtTrinhDo.Text = dgvDanhMucBacSi.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtChucVu.Text = dgvDanhMucBacSi.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtDiaChi.Text = dgvDanhMucBacSi.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtSDT.Text = dgvDanhMucBacSi.Rows[e.RowIndex].Cells[6].Value.ToString();

            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaBacSi.Text = "";
            txtHoTen.Text = "";
            cmbGioiTinh.Text = "";
            txtTrinhDo.Text = "";
            txtChucVu.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
        }

        private void chkHienThiTatCa_CheckedChanged(object sender, EventArgs e)
        {
            hienThiDS();
        }

        private void txtDiaChi_Validated(object sender, EventArgs e)
        {
            this.btnSua.Enabled = true;
        }

        private void txtTimKiemBacSi_TextChanged(object sender, EventArgs e)
        {
            dgvDanhMucBacSi.DataSource= BacSiDAO.Instance.timKiemBacSi(txtTimKiemBacSi.Text);
        }

 
    }
}
