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

namespace QLPK.GUI.KhamBenh
{
    public partial class frmPhieuChanDoan : Form
    {
        private static NguoiDungDTO NguoiDung;

        public frmPhieuChanDoan(NguoiDungDTO nguoiDung)
        {
            InitializeComponent();
            NguoiDung = nguoiDung;
        }



        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Xác nhận lưu?","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            { 
            HoSoBenhAnDAO.Instance.themHoSoBenhAn(txtTimKiemBenhNhan.Text, DateTime.Now, txtChanDoan.Text, txtMaBenh.Text,NguoiDung.TenDangNhap);
            }    
        }

        private void txtTimKiemBenhNhan_Click(object sender, EventArgs e)
        {
            QuanLyDanhMuc.frmTimKiemBenhNhan fTimKiemBenhNhan = new QuanLyDanhMuc.frmTimKiemBenhNhan();
            fTimKiemBenhNhan.StartPosition = FormStartPosition.CenterParent;
            fTimKiemBenhNhan.ShowDialog();
            if (QuanLyDanhMuc.frmTimKiemBenhNhan.benhNhan != null)
            {

                txtTimKiemBenhNhan.Text = QuanLyDanhMuc.frmTimKiemBenhNhan.benhNhan.MaBenhNhan;
                txtTuoi.Text = (-QuanLyDanhMuc.frmTimKiemBenhNhan.benhNhan.NgaySinh.Year + DateTime.Now.Year).ToString();
                txtHoTen.Text = QuanLyDanhMuc.frmTimKiemBenhNhan.benhNhan.HoTen;
                txtNgayKham.Text = DateTime.Now.ToString();
            }
        }
    }
}
