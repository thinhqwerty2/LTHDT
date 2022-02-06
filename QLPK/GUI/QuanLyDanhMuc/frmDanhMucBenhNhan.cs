﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLPK.DAO;

namespace QLPK.GUI.QuanLyDanhMuc
{
    public partial class frmDanhMucBenhNhan : Form
    {
        public frmDanhMucBenhNhan()
        {
            InitializeComponent();
            btnSua.Enabled = false;
        }

        bool batLoi()
        {
            if (txtMaBenhNhan.Text == "" || txtHoTen.Text == "" || cmbGioiTinh.Text == "" || txtDiaChi.Text == "" || txtSDT.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void frmDanhMucBenhNhan_Load(object sender, EventArgs e)
        {
            this.dgvDanhMucBenhNhan.DataSource = BenhNhanDAO.Instance.hienThiDSBenhNhan();
            dgvDanhMucBenhNhan.Columns["MaBenhNhan"].HeaderText = "Mã bệnh nhân";
            dgvDanhMucBenhNhan.Columns["HoTen"].HeaderText = "Họ và tên";
            dgvDanhMucBenhNhan.Columns["GioiTinh"].HeaderText = "Giới tính";
            dgvDanhMucBenhNhan.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dgvDanhMucBenhNhan.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dgvDanhMucBenhNhan.Columns["SDT"].HeaderText = "Số điện thoại";
        }

        void hienThiDS()
        {
            this.dgvDanhMucBenhNhan.DataSource = BenhNhanDAO.Instance.hienThiDSBenhNhan();
        }

        /*private void btnThem_Click(object sender, EventArgs e)
        {
            if (batLoi())
            {
                BenhNhanDAO.Instance.themBenhNhan(txtMaBenhNhan.Text, txtHoTen.Text, cmbGioiTinh.Text, txtDiaChi.Text, txtSDT.Text, txtTrinhDo.Text, txtChucVu.Text);
                hienThiDS();
            }
            else
            {
                MessageBox.Show("Điền đầy đủ thông tin!!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }*/

        private void btnSua_Click(object sender, EventArgs e)
        {
            var kq = MessageBox.Show("Xác nhận sự thay đổi", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (kq == DialogResult.OK)
            {
                BenhNhanDAO.Instance.suaBenhNhan(txtMaBenhNhan.Text,txtHoTen.Text,cmbGioiTinh.Text,dtpNgaySinh.Value,txtDiaChi.Text,txtSDT.Text);
            }
            hienThiDS();
        }

        int indexRow = -1;
        private void dgvDanhMucBenhNhan_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                btnSua.Enabled = false;
                dgvDanhMucBenhNhan.Rows[e.RowIndex].Selected = true;
                indexRow = e.RowIndex;
                txtMaBenhNhan.Text = dgvDanhMucBenhNhan.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtHoTen.Text = dgvDanhMucBenhNhan.Rows[e.RowIndex].Cells[1].Value.ToString();
                cmbGioiTinh.Text = dgvDanhMucBenhNhan.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpNgaySinh.Text = dgvDanhMucBenhNhan.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDiaChi.Text = dgvDanhMucBenhNhan.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtSDT.Text = dgvDanhMucBenhNhan.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_Validated(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaBenhNhan.Text = "";
            txtHoTen.Text = "";
            cmbGioiTinh.Text = "";
            dtpNgaySinh.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
        }

        private void txtTimKiemBenhNhan_TextChanged(object sender, EventArgs e)
        {

            dgvDanhMucBenhNhan.DataSource = BenhNhanDAO.Instance.timKiemBenhNhan(txtTimKiemBenhNhan.Text);
        }
    }
}
