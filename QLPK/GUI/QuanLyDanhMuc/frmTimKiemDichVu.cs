using QLPK.DAO;
using QLPK.DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLPK.GUI.QuanLyDanhMuc
{
    public partial class frmTimKiemDichVu : Form
    {
        public static DichVuDTO dichVu;
        public frmTimKiemDichVu()
        {
            InitializeComponent();

            this.TopMost = true;



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            dataGridView1.DataSource = LoaiBenhDAO.Instance.timKiemLoaiBenh(textBox1.Text);

        }

        private void frmTimKiemDichVu_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = DichVuDAO.Instance.hienThiDSDichVu();
            dataGridView1.Columns["MaDichVu"].HeaderText = "Mã dịch vụ";
            dataGridView1.Columns["TenDichVu"].HeaderText = "Tên dịch vụ";
            dataGridView1.Columns["DonGia"].HeaderText = "Đơn giá";
            dataGridView1.Columns["DonViTinh"].HeaderText = "Đơn vị tính";
            dataGridView1.Columns["GhiChu"].HeaderText = "Ghi chú";
            dataGridView1.Columns["SoLanSuDung"].HeaderText = "Số lần sử dụng";
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView gridView = (DataGridView)sender;


            dichVu = new DichVuDTO(((DataRowView)dataGridView1.Rows[e.RowIndex].DataBoundItem).Row);
            this.Close();

        }
    }
}
