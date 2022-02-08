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

        private void dtpDenNgay_ValueChanged(object sender, EventArgs e)
        {
            dgvThongKeBenhNhan.DataSource = ThongKeADO.Instance.thongKeBenhNhan(dtpTuNgay.Value, dtpDenNgay.Value);
            DataTable dt = ThongKeADO.Instance.thongKeThongTinChiTietBenhNhan(dtpTuNgay.Value, dtpDenNgay.Value);
        }


    }
}
