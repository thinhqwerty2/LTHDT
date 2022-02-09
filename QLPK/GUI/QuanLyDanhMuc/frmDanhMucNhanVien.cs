using QLPK.DAO;
using QLPK.DTO;
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
        private static NguoiDungDTO NguoiDung;

        public frmDanhMucNhanVien(NguoiDungDTO nguoiDung)
        {
            InitializeComponent();
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            txtMaNhanVien.Enabled = false;
            NguoiDung = nguoiDung;
            if(NguoiDung.QuyenTruyCap!=0)
            {
                pnlDanhMucNhanVien.Enabled = false;
            }   
            cmbTrangThai.Enabled = false;
            cmbTrangThai.SelectedItem = "Đang làm việc";
        }
        bool batLoi()
        {
            if ( txtHoTen.Text == "" || cmbGioiTinh.Text == "" || txtChucVu.Text == "" || txtDiaChi.Text == "" || txtSDT.Text == "" || cmbTrangThai.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        void xoaThongTin()
        {
            txtMaNhanVien.Text = "";
            txtHoTen.Text = "";
            cmbGioiTinh.SelectedItem = null;
            txtChucVu.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            cmbTrangThai.Enabled = false;
            cmbTrangThai.SelectedItem = "Đang làm việc";
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
                if (NhanVienDAO.Instance.themNhanVien(txtHoTen.Text, cmbGioiTinh.Text, txtDiaChi.Text, txtSDT.Text, txtChucVu.Text))
                {
                    MessageBox.Show("Thêm nhân viên mới thành công");
                    hienThiDS();
                    xoaThongTin();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!NhanVienDAO.Instance.timNhanVien(txtMaNhanVien.Text))
            {
                MessageBox.Show("Mã nhân viên không hợp lệ! Vui lòng kiểm tra lại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!batLoi())
            {
                MessageBox.Show("Điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var kq = MessageBox.Show("Xác nhận sự thay đổi", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (kq == DialogResult.OK)
                {
                    NhanVienDAO.Instance.suaNhanVien(txtDiaChi.Text, txtSDT.Text, txtChucVu.Text, txtMaNhanVien.Text);
                }
                hienThiDS();
                MessageBox.Show("Cập nhật thông tin thành công!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            var kq = MessageBox.Show("Xác nhận xoá", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (kq == DialogResult.OK)
            {
                NhanVienDAO.Instance.xoaNhanVien(txtMaNhanVien.Text);
            }
            hienThiDS();
            btnXoa.Enabled = false;
            xoaThongTin();
        }

        int indexRow = -1;
        private void dgvDanhMucNhanVien_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                btnSua.Enabled = false;
                btnXoa.Enabled = true;
                dgvDanhMucNhanVien.Rows[e.RowIndex].Selected = true;
                indexRow = e.RowIndex;
                txtMaNhanVien.Text = dgvDanhMucNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtHoTen.Text = dgvDanhMucNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                cmbGioiTinh.Text = dgvDanhMucNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtChucVu.Text = dgvDanhMucNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDiaChi.Text = dgvDanhMucNhanVien.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtSDT.Text = dgvDanhMucNhanVien.Rows[e.RowIndex].Cells[5].Value.ToString();
                cmbTrangThai.Text = dgvDanhMucNhanVien.Rows[e.RowIndex].Cells[6].Value.ToString();

            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            xoaThongTin();
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
