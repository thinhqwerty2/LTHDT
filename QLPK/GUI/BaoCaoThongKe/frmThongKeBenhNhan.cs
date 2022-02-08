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

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            dgvThongKeBenhNhan.DataSource = ThongKeDAO.Instance.thongKeBenhNhan(dtpTuNgay.Value, dtpDenNgay.Value);
            DataTable dt = ThongKeDAO.Instance.thongKeThongTinChiTietBenhNhan(dtpTuNgay.Value, dtpDenNgay.Value);
            lblTongSoBenhNhan1.Text = dt.Rows[0][0].ToString();
            lblNam1.Text = dt.Rows[0][1].ToString();
            lblNu1.Text = dt.Rows[0][2].ToString();
            lblTongDoanhThu1.Text = dt.Rows[0][3].ToString();
            lblSoBenhNhanMoi1.Text = ThongKeDAO.Instance.thongKeBenhNhanMoi(dtpTuNgay.Value,dtpDenNgay.Value).ToString();
        }
    }
}
