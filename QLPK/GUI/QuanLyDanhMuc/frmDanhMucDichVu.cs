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

namespace QLPK.GUI.QuanLyDanhMuc
{
    public partial class frmDanhMucDichVu : Form
    {
        public frmDanhMucDichVu()
        {
            InitializeComponent();
            txtSoLanSuDung.ReadOnly = true;
            btnSua.Enabled = false;
        }

        bool batLoi()
        {
            if (txtMaDichVu.Text == "" || txtTenDichVu.Text == "" || txtDonGia.Text == "" || txtDonViTinh.Text == "" || txtGhiChu.Text == "" ) 
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        void hienThiDS()
        {
            switch (chkHienThiTatCa.Checked)
            {
                case false:
                    this.dgvDanhMucDichVu.DataSource = DichVuDAO.Instance.hienThiDSDichVu();
                    break;
                case true:
                    this.dgvDanhMucDichVu.DataSource = DichVuDAO.Instance.hienThiDSTatCaDichVu();
                    break;
            }

        }


        private void frmDanhMucDichVu_Load(object sender, EventArgs e)
        {
            hienThiDS();
            
            dgvDanhMucDichVu.Columns["MaDichVu"].HeaderText = "Mã dịch vụ";
            dgvDanhMucDichVu.Columns["TenDichVu"].HeaderText = "Tên dịch vụ";
            dgvDanhMucDichVu.Columns["DonGia"].HeaderText = "Đơn giá";
            dgvDanhMucDichVu.Columns["DonViTinh"].HeaderText = "Đơn vị tính";
            dgvDanhMucDichVu.Columns["GhiChu"].HeaderText = "Ghi chú";
            dgvDanhMucDichVu.Columns["SoLanSuDung"].HeaderText = "Số lần sử dụng";

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (batLoi())
            {
                DichVuDAO.Instance.themDichVu(txtMaDichVu.Text, txtTenDichVu.Text, txtDonGia.Text,  txtDonViTinh.Text,txtGhiChu.Text);
                hienThiDS();
            }
            else
            {
                MessageBox.Show("Điền đầy đủ thông tin!!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var kq = MessageBox.Show("Xác nhận sự thay đổi", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (kq == DialogResult.OK)
            {
                DichVuDAO.Instance.suaDichVu(txtTenDichVu.Text,txtDonGia.Text,txtDonViTinh.Text,txtGhiChu.Text,txtMaDichVu.Text);
            }
            hienThiDS();
            btnSua.Enabled = false;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            var kq = MessageBox.Show("Xác nhận xoá", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (kq == DialogResult.OK)
            {
                DichVuDAO.Instance.xoaDichVu(txtMaDichVu.Text);
            }
            hienThiDS();

        }

        int indexRow = -1;
        private void dgvDanhMucDichVu_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                btnSua.Enabled = false;
                dgvDanhMucDichVu.Rows[e.RowIndex].Selected = true;
                indexRow = e.RowIndex;
                txtMaDichVu.Text = dgvDanhMucDichVu.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenDichVu.Text = dgvDanhMucDichVu.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDonGia.Text = dgvDanhMucDichVu.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDonViTinh.Text = dgvDanhMucDichVu.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtGhiChu.Text = dgvDanhMucDichVu.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtSoLanSuDung.Text = dgvDanhMucDichVu.Rows[e.RowIndex].Cells[5].Value.ToString();


            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaDichVu.Text = "";
            txtTenDichVu.Text = "";
            txtDonGia.Text = "";
            txtDonViTinh.Text = "";
            txtGhiChu.Text = "";
            txtSoLanSuDung.Text = "";
        }

        private void txtGhiChu_Validated(object sender, EventArgs e)
        {
            this.btnSua.Enabled = true;
        }

        private void txtTimKiemDichVu_TextChanged(object sender, EventArgs e)
        {
            dgvDanhMucDichVu.DataSource = DichVuDAO.Instance.timKiemDichVu(txtTimKiemDichVu.Text, chkHienThiTatCa.Checked);

        }
        private void chkHienThiTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (txtTimKiemDichVu.Text == "")
            {

                hienThiDS();
            }
            else
            {
                dgvDanhMucDichVu.DataSource = NhanVienDAO.Instance.timKiemNhanVien(txtTimKiemDichVu.Text, chkHienThiTatCa.Checked);

            }
        }
    }
}
