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
        private static NguoiDungDTO NguoiDung;
        public frmThongTinTaiKhoan(NguoiDungDTO nguoiDung)
        {
            InitializeComponent();
            TaiKhoanDAO.Instance.layThongTinNguoiDung(nguoiDung.TenDangNhap,nguoiDung.QuyenTruyCap)

        }

        private void frmThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Text = NguoiDung.TenDangNhap;
            txtHoTen.Text = NguoiDung.HoTen;

        }
    }
}
