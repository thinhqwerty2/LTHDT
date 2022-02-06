using QLPK.DAO;
using System;
using System.Windows.Forms;
using QLPK.DTO;
using System.Data;

namespace QLPK.GUI.QuanLyDanhMuc
{
    public partial class frmTimKiemBenhNhan : Form
    {
        public static BenhNhanDTO benhNhan;
        public frmTimKiemBenhNhan()
        {
            InitializeComponent();
         
            this.TopMost = true;


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            benhNhan = new BenhNhanDTO( ((DataRowView)dataGridView1.Rows[e.RowIndex].DataBoundItem).Row);
            this.Close();
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            dataGridView1.DataSource = BenhNhanDAO.Instance.timKiemBenhNhan(textBox1.Text);

        }

        private void frmTimKiemBenhNhan_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = BenhNhanDAO.Instance.hienThiDSBenhNhan();
            dataGridView1.Columns["MaBenhNhan"].HeaderText = "Mã bệnh nhân";
            dataGridView1.Columns["HoTen"].HeaderText = "Họ và tên";
            dataGridView1.Columns["GioiTinh"].HeaderText = "Giới tính";
            dataGridView1.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dataGridView1.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dataGridView1.Columns["SDT"].HeaderText = "Số điện thoại";
        }
    }
}
