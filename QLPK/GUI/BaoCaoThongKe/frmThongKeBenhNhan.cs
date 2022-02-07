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
using QLPK.DAO;

namespace QLPK.GUI.BaoCaoThongKe
{
    public partial class frmThongKeBenhNhan : Form
    {
        private static NguoiDungDTO NguoiDung;

        public frmThongKeBenhNhan(NguoiDungDTO nguoiDung)
        {
            InitializeComponent();
            NguoiDung = nguoiDung;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void dtpDenNgay_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ThongKeADO.Instance.thongKeBenhNhan(dtpTuNgay.Value, dtpDenNgay.Value);
        }


    }
}
