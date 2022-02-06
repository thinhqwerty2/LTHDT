using QLPK.DAO;
using QLPK.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace QLPK.GUI.KhamBenh
{
    public partial class frmPhieuSuDungXetNghiem : Form
    {
        private static NguoiDungDTO NguoiDung;
        private static List<int> listDichVuDangChon;

        public frmPhieuSuDungXetNghiem(NguoiDungDTO nguoiDung)
        {
            InitializeComponent();
            NguoiDung = nguoiDung;
        }



        DataRowCollection data;
        private void txtTimKiemBenhNhan_Click(object sender, EventArgs e)
        {
            QuanLyDanhMuc.frmTimKiemBenhNhan fTimKiemBenhNhan = new QuanLyDanhMuc.frmTimKiemBenhNhan();
            fTimKiemBenhNhan.ShowDialog();
            txtTimKiemBenhNhan.Text = QuanLyDanhMuc.frmTimKiemBenhNhan.benhNhan.MaBenhNhan;
            txtHoTen.Text = QuanLyDanhMuc.frmTimKiemBenhNhan.benhNhan.HoTen;
            txtTuoi.Text = (-QuanLyDanhMuc.frmTimKiemBenhNhan.benhNhan.NgaySinh.Year + DateTime.Now.Year).ToString();
            data = BanKeDAO.Instance.layBanKeCuaBenhNhan(txtTimKiemBenhNhan.Text).Rows ;
            foreach (DataRow row in data)
            {
                cmbMaBanKe.Items.Add(row["MaBanKe"]);
            }
            cmbMaBanKe.Text = cmbMaBanKe.Items[cmbMaBanKe.Items.Count - 1].ToString();
            lblNgayBanKe.Text = data[cmbMaBanKe.Items.Count-1]["NgayLapBanKe"].ToString();
        }

        private void frmPhieuSuDungXetNghiem_Load(object sender, EventArgs e)
        {
            dgvDichVu.DataSource = DichVuDAO.Instance.hienThiDSDichVu();
        }


        private void cmbMaBanKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblNgayBanKe.Text = data[cmbMaBanKe.SelectedIndex]["NgayLapBanKe"].ToString();
        }
    }
}
