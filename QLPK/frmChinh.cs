using QLPK.GUI.BaoCaoThongKe;
using QLPK.GUI.ChuaBenh;
using QLPK.GUI.QuanLyDanhMuc;
using QLPK.GUI.QuanTriHeThong;
using QLPK.GUI.ThanhToan;
using QLPK.GUI.KhamBenh;
using System;
using System.Windows.Forms;

namespace QLPK
{
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }
        private void btnHeThong_Click(object sender, EventArgs e)
        {
            this.pnlChinh.Controls.Clear();
            frmQuanTriHeThong fQuanTriHeThong = new frmQuanTriHeThong();
            fQuanTriHeThong.TopLevel = false;
            this.pnlChinh.Controls.Add(fQuanTriHeThong);
            fQuanTriHeThong.Show();
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            this.pnlChinh.Controls.Clear();
            frmQuanLyDanhMuc fQuanLyDanhMuc = new frmQuanLyDanhMuc();
            fQuanLyDanhMuc.TopLevel = false;
            this.pnlChinh.Controls.Add(fQuanLyDanhMuc);
            fQuanLyDanhMuc.Show();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            this.pnlChinh.Controls.Clear();
            frmBaoCaoThongKe fBaoCaoThongKe = new frmBaoCaoThongKe();
            fBaoCaoThongKe.TopLevel = false;
            this.pnlChinh.Controls.Add(fBaoCaoThongKe);
            fBaoCaoThongKe.Show();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            this.pnlChinh.Controls.Clear();
            frmThanhToan fThanhToan = new frmThanhToan();
            fThanhToan.TopLevel = false;
            this.pnlChinh.Controls.Add(fThanhToan);
            fThanhToan.Show();
        }

        private void btnChuaBenh_Click(object sender, EventArgs e)
        {
            this.pnlChinh.Controls.Clear();
            frmChuaBenh fChuaBenh = new frmChuaBenh();
            fChuaBenh.TopLevel = false;
            this.pnlChinh.Controls.Add(fChuaBenh);
            fChuaBenh.Show();
        }

        private void btnKhamBenh_Click(object sender, EventArgs e)
        {
            this.pnlChinh.Controls.Clear();
            frmKhamBenh fKhamBenh = new frmKhamBenh();
            fKhamBenh.TopLevel = false;
            this.pnlChinh.Controls.Add(fKhamBenh);
            fKhamBenh.Show();
        }
    }
}
