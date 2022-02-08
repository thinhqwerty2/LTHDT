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
using QLPK.DTO;

namespace QLPK.GUI.QuanLyDanhMuc
{
    public partial class frmDanhMucDichVu : Form
    {
        private static NguoiDungDTO NguoiDung;
        public frmDanhMucDichVu(NguoiDungDTO nguoiDung)
        {
            InitializeComponent();
            txtSoLanSuDung.ReadOnly = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtSoLanSuDung.Text = "0";
            txtMaDichVu.ReadOnly = false;
            NguoiDung = nguoiDung;
            txtMaDichVu.Enabled = false;
            if(nguoiDung.QuyenTruyCap!=0)
            {
                pnlDanhMucDichVu.Enabled = false;
            }    
        }

        bool batLoi()
        {
            if ( txtTenDichVu.Text == "" || txtDonGia.Text == "" || txtDonViTinh.Text == "" || txtGhiChu.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        void xoaThongTin()
        {
            txtMaDichVu.Text = "";
            txtTenDichVu.Text = "";
            txtDonGia.Text = "";
            txtDonViTinh.Text = "";
            txtGhiChu.Text = "";
            txtSoLanSuDung.Text = "";
            txtSoLanSuDung.Text = "0";
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMaDichVu.ReadOnly = false;
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
                if (!DichVuDAO.Instance.timDichVu(txtMaDichVu.Text))
                {
                    if (double.TryParse(txtDonGia.Text, out double result))
                    {
                        DichVuDAO.Instance.themDichVu( txtTenDichVu.Text, txtDonGia.Text, txtDonViTinh.Text, txtGhiChu.Text);
                        hienThiDS();
                        xoaThongTin();
                    }
                    else
                    {
                        MessageBox.Show("Đơn giá phải là số!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Mã dịch vụ bị trùng! Xin nhập lại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var kq = MessageBox.Show("Xác nhận sự thay đổi", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (kq == DialogResult.OK && DichVuDAO.Instance.timDichVu(txtMaDichVu.Text))
            {
                if (double.TryParse(txtDonGia.Text, out double result))
                {
                    DichVuDAO.Instance.suaDichVu(txtTenDichVu.Text, txtDonGia.Text, txtDonViTinh.Text, txtGhiChu.Text, txtMaDichVu.Text);
                    hienThiDS();
                    btnSua.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Đơn giá phải là số!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            var kq = MessageBox.Show("Xác nhận xoá", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (kq == DialogResult.OK)
            {
                DichVuDAO.Instance.xoaDichVu(txtMaDichVu.Text);
            }
            hienThiDS();
            xoaThongTin();
        }

        int indexRow = -1;
        private void dgvDanhMucDichVu_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                txtMaDichVu.ReadOnly = true;
                btnXoa.Enabled = true;
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
            xoaThongTin();
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
                dgvDanhMucDichVu.DataSource = DichVuDAO.Instance.timKiemDichVu(txtTimKiemDichVu.Text, chkHienThiTatCa.Checked);
            }
        }

        private void txt_Validated(object sender, EventArgs e)
        {
            if (batLoi() & DichVuDAO.Instance.timDichVu(txtMaDichVu.Text))
            {
                this.btnSua.Enabled = true;
            }
        }
    }
}
