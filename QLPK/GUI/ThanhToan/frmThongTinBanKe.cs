using QLPK.DAO;
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

namespace QLPK.GUI.ThanhToan
{
    public partial class frmThongTinBanKe : Form
    {
        private static NguoiDungDTO NguoiDung;
        private static string maPhieuThuTienTamUng;
        

        public frmThongTinBanKe(NguoiDungDTO nguoiDung)
        {
            InitializeComponent();
            NguoiDung = nguoiDung;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count!=0)
            {

            maPhieuThuTienTamUng = TongChiPhiDAO.Instance.layMaPhieuThuTienTamUng(cmbMaBanKe.Text);
            TongChiPhiDAO.Instance.themTongHopChiPhi(Convert.ToDouble(lblTongTien.Text), DateTime.Now, maPhieuThuTienTamUng, NguoiDung.TenDangNhap);
            MessageBox.Show("Thanh toán thành công");
            }    
        }
        DataRowCollection data;
        private void txtTimKiemBenhNhan_Click(object sender, EventArgs e)
        {
            QuanLyDanhMuc.frmTimKiemBenhNhan fTimKiemBenhNhan = new QuanLyDanhMuc.frmTimKiemBenhNhan();
            fTimKiemBenhNhan.ShowDialog();
            if (QuanLyDanhMuc.frmTimKiemBenhNhan.benhNhan != null)
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


            dataGridView1.DataSource = ChiTietBanKeDAO.Instance.xemChiTietBanKe( cmbMaBanKe.Text);
            //Tính tiền
            lblTongTien.Text = TongChiPhiDAO.Instance.tinhTongTien(cmbMaBanKe.Text).ToString();
            lblSoTienDaTamUng.Text = TongChiPhiDAO.Instance.tinhTienTamUng(cmbMaBanKe.Text).ToString();
            lblSoTienPhaiTraThem.Text = (Convert.ToDouble(lblTongTien.Text) - Convert.ToDouble(lblSoTienDaTamUng.Text)).ToString();
        }
        private void cmbMaBanKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblNgayBanKe.Text = data[cmbMaBanKe.SelectedIndex]["NgayLapBanKe"].ToString();
            dataGridView1.DataSource = ChiTietBanKeDAO.Instance.xemChiTietBanKe(cmbMaBanKe.Text);
            //Tính tiền
            lblTongTien.Text = TongChiPhiDAO.Instance.tinhTongTien(cmbMaBanKe.Text).ToString();
            lblSoTienDaTamUng.Text = TongChiPhiDAO.Instance.tinhTienTamUng(cmbMaBanKe.Text).ToString();
            lblSoTienPhaiTraThem.Text = (Convert.ToDouble(lblTongTien.Text) - Convert.ToDouble(lblSoTienDaTamUng.Text)).ToString();

        }

        private void txtSoTienBenhNhanDua_TextChanged(object sender, EventArgs e)
        {
            if(txtSoTienBenhNhanDua.Text!="")
            {

            lblSoTienPhaiTra.Text = (Convert.ToDouble(txtSoTienBenhNhanDua.Text)-Convert.ToDouble(lblSoTienPhaiTraThem.Text)).ToString();
            }    
            else
            {
                lblSoTienPhaiTra.Text = "0";
            }    
        }
    }
}
