using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLPK.GUI;
using QLPK.DAO;
using QLPK.DTO;
namespace QLPK.GUI.KhamBenh
{
    public partial class frmPhieuDangKyKhamBenh : Form
    {
        private static NguoiDungDTO NguoiDung;


        public frmPhieuDangKyKhamBenh(NguoiDungDTO nguoiDung)
        {
            InitializeComponent();
            NguoiDung = nguoiDung;
            btnThem.Enabled = false;
            btnIn.Enabled = false; 
        }

        private void txtTimKiemBenhNhan_Click(object sender, EventArgs e)
        {
            QuanLyDanhMuc.frmTimKiemBenhNhan fTimKiemBenhNhan = new QuanLyDanhMuc.frmTimKiemBenhNhan();
            fTimKiemBenhNhan.StartPosition = FormStartPosition.CenterParent;
            fTimKiemBenhNhan.ShowDialog();
            if (QuanLyDanhMuc.frmTimKiemBenhNhan.benhNhan != null)
            {
                txtTimKiemBenhNhan.Text = QuanLyDanhMuc.frmTimKiemBenhNhan.benhNhan.MaBenhNhan;
                txtDiaChi.Text = QuanLyDanhMuc.frmTimKiemBenhNhan.benhNhan.DiaChi;
                txtSDT.Text = QuanLyDanhMuc.frmTimKiemBenhNhan.benhNhan.SDT;
                txtGioiTinh.Text = QuanLyDanhMuc.frmTimKiemBenhNhan.benhNhan.GioiTinh;
                txtNgaySinh.Text = QuanLyDanhMuc.frmTimKiemBenhNhan.benhNhan.NgaySinh.ToString();
                txtHoTen.Text = QuanLyDanhMuc.frmTimKiemBenhNhan.benhNhan.HoTen;
                btnThem.Enabled = true;
                btnIn.Enabled = true;
            }
        }

        private void btnThemBenhNhan_Click(object sender, EventArgs e)
        {
            QuanLyDanhMuc.frmDanhMucBenhNhan fDanhMucBenhNhan = new QuanLyDanhMuc.frmDanhMucBenhNhan(NguoiDung);
            fDanhMucBenhNhan.FormBorderStyle = FormBorderStyle.Sizable;
            fDanhMucBenhNhan.btnSua.Visible = false;
            fDanhMucBenhNhan.btnThem.Visible = true;
            fDanhMucBenhNhan.btnNhapLai.Visible = true;
            fDanhMucBenhNhan.btnNhapLai.Location = new System.Drawing.Point(470, 26);
            fDanhMucBenhNhan.btnThem.Location = new System.Drawing.Point(257, 26);
            fDanhMucBenhNhan.txtHoTen.Enabled = true;
            fDanhMucBenhNhan.txtMaBenhNhan.Enabled = true;
            fDanhMucBenhNhan.txtDiaChi.Enabled = true;
            fDanhMucBenhNhan.txtSDT.Enabled = true;
            fDanhMucBenhNhan.dtpNgaySinh.Enabled = true;
            fDanhMucBenhNhan.cmbGioiTinh.Enabled = true;
            fDanhMucBenhNhan.txtMaBenhNhan.ReadOnly = false;
            fDanhMucBenhNhan.ShowDialog();
            fDanhMucBenhNhan.btnSua.Visible = true;
            fDanhMucBenhNhan.FormBorderStyle = FormBorderStyle.None;
            fDanhMucBenhNhan.btnThem.Visible = false;
            fDanhMucBenhNhan.btnNhapLai.Visible = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            BanKeDAO.Instance.themBanKe(DateTime.Now, txtTimKiemBenhNhan.Text, NguoiDung.TenDangNhap);
            MessageBox.Show("Đăng ký khám bệnh thành công!", "Thông báo", MessageBoxButtons.OK);
        }
    }
}
