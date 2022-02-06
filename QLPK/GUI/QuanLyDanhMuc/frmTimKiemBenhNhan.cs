using QLPK.DAO;
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

namespace QLPK.GUI.QuanLyDanhMuc
{
    public partial class frmTimKiemBenhNhan : Form
    {
        public frmTimKiemBenhNhan()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             dataGridView1.Rows[e.RowIndex].Cells[0].ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
                dataGridView1.DataSource = BenhNhanDAO.Instance.timKiemBenhNhan(textBox1.Text);
            
        }
    }
}
