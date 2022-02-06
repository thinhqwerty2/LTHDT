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
            
        }

        private void frmThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Text = NguoiDung.MaBacSiNhanVien;
            txtHoTen.Text = NguoiDung.HoTen;
            txtGioiTinh.Text = NguoiDung.GioiTinh;
            txtSDT.Text = NguoiDung.SDT;
            txtChucVu.Text = NguoiDung.ChucVu;
            txtDiaChi.Text = NguoiDung.DiaChi;
        }
    }
}
