using QLPK.DAO;
using System;
using System.Windows.Forms;

namespace QLPK.GUI.QuanLyDanhMuc
{
    public partial class frmDanhMucBenh : Form
    {
        public frmDanhMucBenh()
        {
            InitializeComponent();
        }
        bool batLoi()
        {
            if (txtMaBenh.Text == "" || txtMoTaBenh.Text == "" || txtLoaiBenh.Text == "")
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

            this.dgvDanhMucLoaiBenh.DataSource = LoaiBenhDAO.Instance.hienThiDSLoaiBenh();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (batLoi())
            {
                LoaiBenhDAO.Instance.themLoaiBenh(txtMaBenh.Text, txtLoaiBenh.Text, txtMoTaBenh.Text);
                hienThiDS();
                MessageBox.Show("Thêm loại bệnh mới thành công!");
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
                LoaiBenhDAO.Instance.suaLoaiBenh(txtLoaiBenh.Text, txtMoTaBenh.Text, txtMaBenh.Text);
                MessageBox.Show("Thay đổi thông tin mới thành công!");
            }
            hienThiDS();

        }
        /*
        private void btnXoa_Click(object sender, EventArgs e)
        {

            var kq = MessageBox.Show("Xác nhận xoá", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (kq == DialogResult.OK)
            {
                LoaiBenhDAO.Instance.xoaLoaiBenh(txtMaBenh.Text);
                MessageBox.Show("Xoá thành công!");
            }
            hienThiDS();

        }
        */

        int indexRow = -1;
        private void dgvDanhMucLoaiBenh_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                btnSua.Enabled = false;
                dgvDanhMucLoaiBenh.Rows[e.RowIndex].Selected = true;
                indexRow = e.RowIndex;
                txtMaBenh.Text = dgvDanhMucLoaiBenh.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtLoaiBenh.Text = dgvDanhMucLoaiBenh.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtMoTaBenh.Text = dgvDanhMucLoaiBenh.Rows[e.RowIndex].Cells[2].Value.ToString();


            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaBenh.Text = "";
            txtMoTaBenh.Text = "";
            txtLoaiBenh.Text = "";

        }



        private void txtDiaChi_Validated(object sender, EventArgs e)
        {
            this.btnSua.Enabled = true;
        }

        private void txtTimKiemLoaiBenh_TextChanged(object sender, EventArgs e)
        {

            dgvDanhMucLoaiBenh.DataSource = LoaiBenhDAO.Instance.timKiemLoaiBenh(txtTimKiemLoaiBenh.Text);

        }

        private void frmDanhMucBenh_Load(object sender, EventArgs e)
        {
            hienThiDS();
            dgvDanhMucLoaiBenh.Columns["MaBenh"].HeaderText = "Mã loại bệnh";
            dgvDanhMucLoaiBenh.Columns["LoaiBenh"].HeaderText = "Loại bệnh";
            dgvDanhMucLoaiBenh.Columns["MoTaBenh"].HeaderText = "Mô tả bệnh";

        }
    }
}
