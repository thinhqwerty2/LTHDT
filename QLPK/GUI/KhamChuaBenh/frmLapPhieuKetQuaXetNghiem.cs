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
    public partial class frmLapPhieuKetQuaXetNghiem : Form
    {
        private static NguoiDungDTO NguoiDung;

        public frmLapPhieuKetQuaXetNghiem(NguoiDungDTO nguoiDung)
        {
            InitializeComponent();
            NguoiDung = nguoiDung;
        }

        DataRowCollection data;
        private void txtTimKiemBenhNhan_Click(object sender, EventArgs e)
        {
            QuanLyDanhMuc.frmTimKiemBenhNhan fTimKiemBenhNhan = new QuanLyDanhMuc.frmTimKiemBenhNhan();
            fTimKiemBenhNhan.ShowDialog();
            if(QuanLyDanhMuc.frmTimKiemBenhNhan.benhNhan!=null)
            { 
            txtTimKiemBenhNhan.Text = QuanLyDanhMuc.frmTimKiemBenhNhan.benhNhan.MaBenhNhan;
            txtHoTen.Text = QuanLyDanhMuc.frmTimKiemBenhNhan.benhNhan.HoTen;
            txtTuoi.Text = (-QuanLyDanhMuc.frmTimKiemBenhNhan.benhNhan.NgaySinh.Year + DateTime.Now.Year).ToString();
            }    
            data = BanKeDAO.Instance.layBanKeCuaBenhNhan(txtTimKiemBenhNhan.Text).Rows;
            cmbMaBanKe.Items.Clear();
            foreach (DataRow row in data)
            {
                cmbMaBanKe.Items.Add(row["MaBanKe"]);
            }
            cmbMaBanKe.Text = cmbMaBanKe.Items[cmbMaBanKe.Items.Count - 1].ToString();
            lblNgayBanKe.Text = data[cmbMaBanKe.Items.Count - 1]["NgayLapBanKe"].ToString();
        }
        private void cmbMaBanKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblNgayBanKe.Text = data[cmbMaBanKe.SelectedIndex]["NgayLapBanKe"].ToString();
        }

        private void txtDichVu_Click(object sender, EventArgs e)
        {
            QuanLyDanhMuc.frmTimKiemDichVu fTimKiemDichVu = new QuanLyDanhMuc.frmTimKiemDichVu();
            fTimKiemDichVu.ShowDialog();
            if (QuanLyDanhMuc.frmTimKiemDichVu.dichVu != null)
            {
                txtDichVu.Text = QuanLyDanhMuc.frmTimKiemDichVu.dichVu.TenDichVu;
                
            }
        }

        private void frmLapPhieuKetQuaXetNghiem_Load(object sender, EventArgs e)
        {
            txtNgayKham.Text = DateTime.Now.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            KetQuaXetNghiemDAO.Instance.themKetQuaXetNghiem(cmbMaBanKe.Text, QuanLyDanhMuc.frmTimKiemDichVu.dichVu.MaDichVu, NguoiDung.TenDangNhap, DateTime.Now, txtKetLuan.Text);
        }
    }
}
