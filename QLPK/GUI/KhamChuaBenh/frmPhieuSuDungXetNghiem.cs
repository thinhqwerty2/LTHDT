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
            cmbMaBanKe.Items.Clear();
            foreach (DataRow row in data)
            {
                cmbMaBanKe.Items.Add(row["MaBanKe"]);
            }
            cmbMaBanKe.Text = cmbMaBanKe.Items[cmbMaBanKe.Items.Count - 1].ToString();
            lblNgayBanKe.Text = data[cmbMaBanKe.Items.Count-1]["NgayLapBanKe"].ToString();
                
        }


        private void cmbMaBanKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblNgayBanKe.Text = data[cmbMaBanKe.SelectedIndex]["NgayLapBanKe"].ToString();
        }

        private void frmPhieuSuDungXetNghiem_Load(object sender, EventArgs e)
        {
            dgvDichVu.DataSource = DichVuDAO.Instance.hienThiDSDichVuXetNghiem();
            dgvDichVuDuocChon.Columns.Add("MaDichVu", "Mã dịch vụ");
            dgvDichVuDuocChon.Columns.Add("TenDichVu", "Tên dịch vụ");
            dgvDichVuDuocChon.Columns.Add("DonGia", "Đơn giá");
            dgvDichVuDuocChon.Columns.Add("DonViTinh", "Đơn vị tính");
            dgvDichVuDuocChon.Columns.Add("GhiChu", "Ghi chú");
            dgvDichVuDuocChon.Columns.Add("SoLanSuDung", "Số lần sử dụng");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i=0; i<dgvDichVu.Rows.Count; i++)
            {
                if (dgvDichVu.Rows[i].Selected==true)
                {
                    DataGridViewRow row = (DataGridViewRow)dgvDichVu.Rows[i].Clone();
                    row.Cells[0].Value = dgvDichVu.Rows[i].Cells[0].Value;
                    row.Cells[1].Value = dgvDichVu.Rows[i].Cells[1].Value;
                    row.Cells[2].Value = dgvDichVu.Rows[i].Cells[2].Value;
                    row.Cells[3].Value = dgvDichVu.Rows[i].Cells[3].Value;
                    row.Cells[4].Value = dgvDichVu.Rows[i].Cells[4].Value;
                    row.Cells[5].Value = dgvDichVu.Rows[i].Cells[5].Value;
                    dgvDichVuDuocChon.Rows.Add(row);
                }
            }
        }
        private void dgvDichVu_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                dgvDichVu.Rows[e.RowIndex].Selected = true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvDichVuDuocChon.Rows.Count; i++)
            {
                if (dgvDichVuDuocChon.Rows[i].Selected == true)
                {
                    dgvDichVuDuocChon.Rows.RemoveAt(dgvDichVuDuocChon.Rows[i].Index);
                }
            }
        }

        private void dgvDichVuDuocChon_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                dgvDichVuDuocChon.Rows[e.RowIndex].Selected = true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dgvDichVu.SelectedRows)
            {

                dgvDichVuDuocChon.Rows.Add(item);
            }
        }
    }
}
