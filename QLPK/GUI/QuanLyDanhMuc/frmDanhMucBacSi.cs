using QLPK.DAO;
using System;
using System.Windows.Forms;

namespace QLPK.GUI.QuanLyDanhMuc
{
    public partial class frmDanhMucBacSi : Form
    {
        public frmDanhMucBacSi()
        {
            InitializeComponent();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMaBacSi.ReadOnly = false;
            txtHoTen.ReadOnly = false;
        }
        public void xoaThongTin()
        {
            txtMaBacSi.Text = "";
            txtHoTen.Text = "";
            txtTrinhDo.Text = "";
            txtChucVu.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            cmbTrangThai.Enabled = true;
            cmbGioiTinh.Enabled = true;
            cmbGioiTinh.SelectedItem = null;
            cmbTrangThai.SelectedItem = null;
            txtMaBacSi.ReadOnly = false;
            txtHoTen.ReadOnly = false;
        }
        bool batLoi()
        {
            if (txtMaBacSi.Text == "" || txtHoTen.Text == "" || cmbGioiTinh.Text == "" || txtTrinhDo.Text == "" || txtChucVu.Text == "" || txtDiaChi.Text == "" || txtSDT.Text == "" || cmbTrangThai.Text == "")
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
                    this.dgvDanhMucBacSi.DataSource = BacSiDAO.Instance.hienThiDSBacSi();
                    break;
                case true:
                    this.dgvDanhMucBacSi.DataSource = BacSiDAO.Instance.hienThiDSTatCaBacSi();
                    break;
            }

        }

        private void frmDanhMucBacSi_Load(object sender, EventArgs e)
        {
            hienThiDS();
            dgvDanhMucBacSi.Columns["MaBacSi"].HeaderText = "Mã bác sĩ";
            dgvDanhMucBacSi.Columns["HoTen"].HeaderText = "Họ và tên";
            dgvDanhMucBacSi.Columns["GioiTinh"].HeaderText = "Giới tính";
            dgvDanhMucBacSi.Columns["TrinhDo"].HeaderText = "Trình độ";
            dgvDanhMucBacSi.Columns["ChucVu"].HeaderText = "Chức vụ";
            dgvDanhMucBacSi.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dgvDanhMucBacSi.Columns["SDT"].HeaderText = "Số điện thoại";
            dgvDanhMucBacSi.Columns["TrangThai"].HeaderText = "Trạng thái";

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (batLoi())
            {
                if (!TaiKhoanDAO.Instance.kiemTraTaiKhoan(txtMaBacSi.Text))
                {
                    BacSiDAO.Instance.themBacSi(txtMaBacSi.Text, txtHoTen.Text, cmbGioiTinh.Text, txtDiaChi.Text, txtSDT.Text, txtTrinhDo.Text, txtChucVu.Text);
                    hienThiDS();
                    MessageBox.Show("Thêm bác sĩ mới thành công!");
                    xoaThongTin();
                }
                else
                {
                    MessageBox.Show("Mã bác sĩ bị trùng!");
                }

            }
            else
            {
                MessageBox.Show("Điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!BacSiDAO.Instance.timBacSi(txtMaBacSi.Text))
            {
                MessageBox.Show("Mã bác sĩ không hợp lệ! Vui lòng kiểm tra lại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!batLoi())
            {
                MessageBox.Show("Điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var kq = MessageBox.Show("Xác nhận sự thay đổi", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (kq == DialogResult.OK)
                {
                    BacSiDAO.Instance.suaBacSi(txtDiaChi.Text, txtSDT.Text, txtTrinhDo.Text, txtChucVu.Text, txtMaBacSi.Text);
                    MessageBox.Show("Thay đổi thông tin mới thành công!");
                }
                hienThiDS();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            var kq = MessageBox.Show("Xác nhận xoá", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (kq == DialogResult.OK)
            {
                BacSiDAO.Instance.xoaBacSi(txtMaBacSi.Text);
                MessageBox.Show("Xoá thành công!");
                btnXoa.Enabled = false;
                xoaThongTin();
            }
            hienThiDS();

        }

        int indexRow = -1;
        private void dgvDanhMucBacSi_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                txtHoTen.ReadOnly = true;
                txtMaBacSi.ReadOnly = true;
                btnSua.Enabled = false;
                btnXoa.Enabled = true;
                cmbTrangThai.Enabled = false;
                cmbGioiTinh.Enabled = false;
                dgvDanhMucBacSi.Rows[e.RowIndex].Selected = true;
                indexRow = e.RowIndex;
                txtMaBacSi.Text = dgvDanhMucBacSi.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtHoTen.Text = dgvDanhMucBacSi.Rows[e.RowIndex].Cells[1].Value.ToString();
                cmbGioiTinh.Text = dgvDanhMucBacSi.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtTrinhDo.Text = dgvDanhMucBacSi.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtChucVu.Text = dgvDanhMucBacSi.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtDiaChi.Text = dgvDanhMucBacSi.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtSDT.Text = dgvDanhMucBacSi.Rows[e.RowIndex].Cells[6].Value.ToString();
                cmbTrangThai.Text = dgvDanhMucBacSi.Rows[e.RowIndex].Cells[7].Value.ToString();

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

        private void chkHienThiTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (txtTimKiemBacSi.Text == "")
            {

                hienThiDS();
            }
            else
            {
                dgvDanhMucBacSi.DataSource = BacSiDAO.Instance.timKiemBacSi(txtTimKiemBacSi.Text, chkHienThiTatCa.Checked);

            }
        }

        private void txt_Validated(object sender, EventArgs e)
        {
            this.btnSua.Enabled = true;
        }

        private void txtTimKiemBacSi_TextChanged(object sender, EventArgs e)
        {

            dgvDanhMucBacSi.DataSource = BacSiDAO.Instance.timKiemBacSi(txtTimKiemBacSi.Text, chkHienThiTatCa.Checked);

        }



    }
}
