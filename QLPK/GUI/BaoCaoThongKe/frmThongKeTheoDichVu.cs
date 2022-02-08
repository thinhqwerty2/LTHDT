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
    public partial class frmThongKeDichVu : Form
    {
        private static NguoiDungDTO NguoiDung;

        public frmThongKeDichVu(NguoiDungDTO nguoiDung)
        {
            InitializeComponent();
            NguoiDung = nguoiDung;
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            dgvThongKeDichVu.DataSource = ThongKeDAO.Instance.thongKeDichVu(dtpTuNgay.Value, dtpDenNgay.Value);
            lblTongTien1.Text = ThongKeDAO.Instance.thongKeTongTienDichVu(dtpTuNgay.Value, dtpDenNgay.Value).ToString();
        }
    }
}
