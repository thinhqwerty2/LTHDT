using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLPK.DAO;
using QLPK.DTO;

namespace QLPK.GUI.QuanTriHeThong
{
    public partial class frmPhanQuyen : Form
    {
        private static NguoiDungDTO NguoiDung;
        public frmPhanQuyen(NguoiDungDTO nguoiDung)
        {
            InitializeComponent();
            NguoiDung = TaiKhoanDAO.Instance.layThongTinNguoiDung(nguoiDung.TenDangNhap);
            btnCapNhat.Enabled = false;
        }
        void hienThiDS()
        {

            this.dgvPhanQuyen.DataSource = TaiKhoanDAO.Instance.danhSachNguoiDung();
        }
        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
            hienThiDS();
            txtTenDangNhap.Text = NguoiDung.TenDangNhap.ToString();
            txtHoTen.Text = NguoiDung.HoTen.ToString();
            txtChucVu.Text = NguoiDung.ChucVu.ToString();
            cmbPhanQuyen.Text = NguoiDung.QuyenTruyCap.ToString();
        }
        int indexRow = -1;
        private void dgvPhanQuyen_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                btnCapNhat.Enabled = false;
                dgvPhanQuyen.Rows[e.RowIndex].Selected = true;
                indexRow = e.RowIndex;
                txtTenDangNhap.Text = dgvPhanQuyen.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtHoTen.Text = dgvPhanQuyen.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtChucVu.Text = dgvPhanQuyen.Rows[e.RowIndex].Cells[2].Value.ToString();
                cmbPhanQuyen.Text = dgvPhanQuyen.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtTuKhoa_TextChanged(object sender, EventArgs e)
        {
            if (txtTuKhoa.Text == "")
            {
                hienThiDS();
            }
            else
            {
                dgvPhanQuyen.DataSource = TaiKhoanDAO.Instance.timKiemNguoiDung(txtTuKhoa.Text);
            }
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {

        }
        private void cmbPhanQuyen_Validated(object sender, EventArgs e)
        {
            btnCapNhat.Enabled = true;
        }
        private void btnCapNhat_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận thay đổi quyền truy cập?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                TaiKhoanDAO.Instance.capNhatQuyenTruyCap(txtTenDangNhap.Text, Int32.Parse(cmbPhanQuyen.Text));
                hienThiDS();
                MessageBox.Show("Thay đổi quyền truy cập thành công!");
            }
        }
    }
}
