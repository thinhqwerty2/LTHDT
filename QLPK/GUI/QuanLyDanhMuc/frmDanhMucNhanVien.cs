using QLPK.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPK.GUI.QuanLyDanhMuc
{
    public partial class frmDanhMucNhanVien : Form
    {
        public frmDanhMucNhanVien()
        {
            InitializeComponent();


        }
        bool batLoi()
        {
            if (txtMaNhanVien.Text == "" || txtHoTen.Text == "" || cmbGioiTinh.Text == "" || txtChucVu.Text == "" || txtDiaChi.Text == "" || txtSDT.Text == "" || txtTrangThai.Text == "")
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
                    this.dgvDanhMucNhanVien.DataSource = NhanVienDAO.Instance.hienThiDSNhanVien();
                    break;
                case true:
                    this.dgvDanhMucNhanVien.DataSource = NhanVienDAO.Instance.hienThiDSTatCaNhanVien();
                    break;
            }

        }

        private void frmDanhMucNhanVien_Load(object sender, EventArgs e)
        {
            hienThiDS();
            dgvDanhMucNhanVien.Columns["MaNhanVien"].HeaderText = "Mã nhân viên";
            dgvDanhMucNhanVien.Columns["HoTen"].HeaderText = "Họ và tên";
            dgvDanhMucNhanVien.Columns["GioiTinh"].HeaderText = "Giới tính";
            dgvDanhMucNhanVien.Columns["ChucVu"].HeaderText = "Chức vụ";
            dgvDanhMucNhanVien.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dgvDanhMucNhanVien.Columns["SDT"].HeaderText = "Số điện thoại";
            dgvDanhMucNhanVien.Columns["TrangThai"].HeaderText = "Trạng thái";

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (batLoi())
            {
                NhanVienDAO.Instance.themNhanVien(txtMaNhanVien.Text, txtHoTen.Text, cmbGioiTinh.Text, txtDiaChi.Text, txtSDT.Text, txtChucVu.Text);
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
                NhanVienDAO.Instance.suaNhanVien(txtDiaChi.Text, txtSDT.Text, txtChucVu.Text, txtMaNhanVien.Text);
            }
            hienThiDS();


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            var kq = MessageBox.Show("Xác nhận xoá", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (kq == DialogResult.OK)
            {
                NhanVienDAO.Instance.xoaNhanVien(txtMaNhanVien.Text);
            }
            hienThiDS();

        }

        int indexRow = -1;
        private void dgvDanhMucNhanVien_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                btnSua.Enabled = false;
                dgvDanhMucNhanVien.Rows[e.RowIndex].Selected = true;
                indexRow = e.RowIndex;
                txtMaNhanVien.Text = dgvDanhMucNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtHoTen.Text = dgvDanhMucNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                cmbGioiTinh.Text = dgvDanhMucNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtChucVu.Text = dgvDanhMucNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDiaChi.Text = dgvDanhMucNhanVien.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtSDT.Text = dgvDanhMucNhanVien.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtTrangThai.Text = dgvDanhMucNhanVien.Rows[e.RowIndex].Cells[6].Value.ToString();

            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaNhanVien.Text = "";
            txtHoTen.Text = "";
            cmbGioiTinh.Text = "";
            txtChucVu.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtTrangThai.Text = "";
        }

        private void chkHienThiTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (txtTimKiemNhanVien.Text == "")
            {

                hienThiDS();
            }
            else
            {
                dgvDanhMucNhanVien.DataSource = NhanVienDAO.Instance.timKiemNhanVien(txtTimKiemNhanVien.Text, chkHienThiTatCa.Checked);

            }
        }

        private void txtDiaChi_Validated(object sender, EventArgs e)
        {
            this.btnSua.Enabled = true;
        }

        private void txtTimKiemNhanVien_TextChanged(object sender, EventArgs e)
        {
            dgvDanhMucNhanVien.DataSource = NhanVienDAO.Instance.timKiemNhanVien(txtTimKiemNhanVien.Text, chkHienThiTatCa.Checked);

        }



    }
}
