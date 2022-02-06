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
using QLPK.DAO;

namespace QLPK.GUI.QuanTriHeThong
{
    public partial class frmThongTinTaiKhoan : Form
    {
        private static BacSiNhanVienDTO NguoiDung;
        public frmThongTinTaiKhoan(NguoiDungDTO nguoiDung)
        {
            InitializeComponent();
            NguoiDung=TaiKhoanDAO.Instance.layThongTinBacSiNhanVien(nguoiDung.TenDangNhap, nguoiDung.QuyenTruyCap);
            btnLuuThayDoi.Enabled = false;
        }

        private void frmThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Text = NguoiDung.MaBacSiNhanVien;
            txtHoTen.Text = NguoiDung.HoTen;
            cmbGioiTinh.Text = NguoiDung.GioiTinh;
            txtSDT.Text = NguoiDung.SDT;
            txtChucVu.Text = NguoiDung.ChucVu;
            txtDiaChi.Text = NguoiDung.DiaChi;
        }

        bool batLoi()
        {
            if (txtSDT.Text == "" || txtDiaChi.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btnLuuThayDoi_Click(object sender, EventArgs e)
        {
            var kq = MessageBox.Show("Xác nhận sự thay đổi", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (kq == DialogResult.OK)
            {
                NguoiDung.SDT = txtSDT.Text;
                NguoiDung.DiaChi = txtDiaChi.Text;
                if (txtTenDangNhap.Text.Contains("BS"))
                {
                    BacSiDAO.Instance.suaBacSi(txtDiaChi.Text, txtSDT.Text, NguoiDung.TrinhDo, txtChucVu.Text, txtTenDangNhap.Text);
                }
                else
                {
                    NhanVienDAO.Instance.suaNhanVien(txtDiaChi.Text, txtSDT.Text, txtChucVu.Text, txtTenDangNhap.Text);
                }
            }
        }

        private void txt_Validated(object sender, EventArgs e)
        {
            this.btnLuuThayDoi.Enabled = true;
        }
    }
}
