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
    public partial class frmTimKiemLoaiBenh : Form
    {
        public static LoaiBenhDTO loaiBenh;
        public frmTimKiemLoaiBenh()
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

        private void frmTimKiemLoaiBenh_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = LoaiBenhDAO.Instance.hienThiDSLoaiBenh();
            dataGridView1.Columns["MaBenh"].HeaderText = "Mã loại bệnh";
            dataGridView1.Columns["LoaiBenh"].HeaderText = "Loại bệnh";
            dataGridView1.Columns["MoTaBenh"].HeaderText = "Mô tả bệnh";
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView gridView = (DataGridView)sender;

                loaiBenh = new LoaiBenhDTO(((DataRowView)dataGridView1.Rows[e.RowIndex].DataBoundItem).Row);
                this.Close();
            
        }
    }
}
