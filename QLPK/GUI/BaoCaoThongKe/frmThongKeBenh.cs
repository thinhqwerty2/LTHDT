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

namespace QLPK.GUI.BaoCaoThongKe
{
    public partial class frmThongKeBenh : Form
    {
        private static NguoiDungDTO NguoiDung;

        public frmThongKeBenh(NguoiDungDTO nguoiDung)
        {
            InitializeComponent();
            NguoiDung = nguoiDung;
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
            }
        }

        private void txtTimKiemBenhNhan_TextChanged(object sender, EventArgs e)
        {
            dgvHoSoBenhAn.DataSource= ThongKeDAO.Instance.thongKeBenhAn(txtTimKiemBenhNhan.Text);
            dgvHoSoBenhAn.Columns["SoBenhAn"].HeaderText = "Số bệnh án";
            dgvHoSoBenhAn.Columns["NgayKham"].HeaderText = "Ngày khám";
            dgvHoSoBenhAn.Columns["ChanDoan"].HeaderText = "Chẩn đoán";
            dgvHoSoBenhAn.Columns["HoTen"].HeaderText = "Bác sĩ chẩn đoán";
            dgvHoSoBenhAn.Columns["LoaiBenh"].HeaderText = "Loại bệnh";
        }
    }
}
