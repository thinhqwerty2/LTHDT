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
using QLPK.GUI;
using QLPK.DAO;

namespace QLPK.GUI.ThanhToan
{
    public partial class frmLapPhieuThuTienTamUng : Form
    {
        private static NguoiDungDTO NguoiDung;
        public static string MaBenhNhan;

        public frmLapPhieuThuTienTamUng(NguoiDungDTO nguoiDung)
        {
            InitializeComponent();
            NguoiDung = nguoiDung;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtTimKiemBenhNhan_Click(object sender, EventArgs e)
        {
            QuanLyDanhMuc.frmTimKiemBenhNhan.benhNhan = BenhNhanDAO.Instance.layThongTinBenhNhan(MaBenhNhan);
            /* QuanLyDanhMuc.frmTimKiemBenhNhan fTimKiemBenhNhan = new QuanLyDanhMuc.frmTimKiemBenhNhan();
             fTimKiemBenhNhan.ShowDialog();
             if (QuanLyDanhMuc.frmTimKiemBenhNhan.benhNhan != null)
             {
                 txtTimKiemBenhNhan.Text = QuanLyDanhMuc.frmTimKiemBenhNhan.benhNhan.MaBenhNhan;
                 txtHoTen.Text = QuanLyDanhMuc.frmTimKiemBenhNhan.benhNhan.HoTen;
                 txtTuoi.Text = (-QuanLyDanhMuc.frmTimKiemBenhNhan.benhNhan.NgaySinh.Year + DateTime.Now.Year).ToString();

             }
            */
            txtTimKiemBenhNhan.Text = QuanLyDanhMuc.frmTimKiemBenhNhan.benhNhan.MaBenhNhan;
            txtHoTen.Text = QuanLyDanhMuc.frmTimKiemBenhNhan.benhNhan.HoTen;
            txtTuoi.Text = (-QuanLyDanhMuc.frmTimKiemBenhNhan.benhNhan.NgaySinh.Year + DateTime.Now.Year).ToString();

            int tongTien = 0;
            var dataView = KhamBenh.frmPhieuSuDungXetNghiem.tableDichVuDaChon;
            dataGridView1.Rows.Clear();
            for (int i = 0; i < dataView.Rows.Count; i++)
            {
                
                    DataGridViewRow row = (DataGridViewRow)dataView.Rows[i].Clone();
                    row.Cells[0].Value = dataView.Rows[i].Cells[0].Value;
                    row.Cells[1].Value = dataView.Rows[i].Cells[1].Value;
                    row.Cells[2].Value = dataView.Rows[i].Cells[2].Value;
                    row.Cells[3].Value = dataView.Rows[i].Cells[3].Value;
                    row.Cells[4].Value = dataView.Rows[i].Cells[4].Value;
                    row.Cells[5].Value = dataView.Rows[i].Cells[5].Value;
                    dataGridView1.Rows.Add(row);
                    tongTien+= Convert.ToInt32(dataView.Rows[i].Cells[2].Value);
                    
            }
            lblTongTien.Text = tongTien.ToString();
            txtTienTamUng.Text = (tongTien / 2).ToString();
            

        }

        private void frmLapPhieuThuTienTamUng_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("MaDichVu", "Mã dịch vụ");
            dataGridView1.Columns.Add("TenDichVu", "Tên dịch vụ");
            dataGridView1.Columns.Add("DonGia", "Đơn giá");
            dataGridView1.Columns.Add("DonViTinh", "Đơn vị tính");
            dataGridView1.Columns.Add("GhiChu", "Ghi chú");
            dataGridView1.Columns.Add("SoLanSuDung", "Số lần sử dụng");
            dataGridView1.Columns["SoLanSuDung"].Visible = false;

            QuanLyDanhMuc.frmTimKiemBenhNhan.benhNhan = BenhNhanDAO.Instance.layThongTinBenhNhan(MaBenhNhan);
            txtTimKiemBenhNhan.Text = QuanLyDanhMuc.frmTimKiemBenhNhan.benhNhan.MaBenhNhan;
            txtHoTen.Text = QuanLyDanhMuc.frmTimKiemBenhNhan.benhNhan.HoTen;
            txtTuoi.Text = (-QuanLyDanhMuc.frmTimKiemBenhNhan.benhNhan.NgaySinh.Year + DateTime.Now.Year).ToString();

            int tongTien = 0;
            var dataView = KhamBenh.frmPhieuSuDungXetNghiem.tableDichVuDaChon;
            dataGridView1.Rows.Clear();
            for (int i = 0; i < dataView.Rows.Count; i++)
            {

                DataGridViewRow row = (DataGridViewRow)dataView.Rows[i].Clone();
                row.Cells[0].Value = dataView.Rows[i].Cells[0].Value;
                row.Cells[1].Value = dataView.Rows[i].Cells[1].Value;
                row.Cells[2].Value = dataView.Rows[i].Cells[2].Value;
                row.Cells[3].Value = dataView.Rows[i].Cells[3].Value;
                row.Cells[4].Value = dataView.Rows[i].Cells[4].Value;
                row.Cells[5].Value = dataView.Rows[i].Cells[5].Value;
                dataGridView1.Rows.Add(row);
                tongTien += Convert.ToInt32(dataView.Rows[i].Cells[2].Value);

            }
            lblTongTien.Text = tongTien.ToString();
            txtTienTamUng.Text = (tongTien / 2).ToString();

            
        }
    }
}
