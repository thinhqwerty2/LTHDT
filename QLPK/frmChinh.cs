using QLPK.DTO;
using QLPK.GUI.BaoCaoThongKe;
using QLPK.GUI.KhamBenh;
using QLPK.GUI.QuanLyDanhMuc;
using QLPK.GUI.QuanTriHeThong;
using QLPK.GUI.ThanhToan;
using System;
using System.Windows.Forms;
using QLPK.DAO;

namespace QLPK
{
    public partial class frmChinh : Form
    {
        private static NguoiDungDTO NguoiDung;
        public frmChinh(NguoiDungDTO nguoiDung)
        {
            InitializeComponent();
            NguoiDung = nguoiDung;
            this.lblName.Text = nguoiDung.HoTen;

        }
        private void btnHeThong_Click(object sender, EventArgs e)
        {
            
            this.pnlChinh.Controls.Clear();
            frmQuanTriHeThong fQuanTriHeThong = new frmQuanTriHeThong(NguoiDung);
            fQuanTriHeThong.TopLevel = false;
            this.pnlChinh.Controls.Add(fQuanTriHeThong);
            fQuanTriHeThong.Show();
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            this.pnlChinh.Controls.Clear();
            frmQuanLyDanhMuc fQuanLyDanhMuc = new frmQuanLyDanhMuc(NguoiDung);
            fQuanLyDanhMuc.TopLevel = false;
            this.pnlChinh.Controls.Add(fQuanLyDanhMuc);
            fQuanLyDanhMuc.Show();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            this.pnlChinh.Controls.Clear();
            frmBaoCaoThongKe fBaoCaoThongKe = new frmBaoCaoThongKe(NguoiDung);
            fBaoCaoThongKe.TopLevel = false;
            this.pnlChinh.Controls.Add(fBaoCaoThongKe);
            fBaoCaoThongKe.Show();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            this.pnlChinh.Controls.Clear();
            frmThanhToan fThanhToan = new frmThanhToan(NguoiDung);
            fThanhToan.TopLevel = false;
            this.pnlChinh.Controls.Add(fThanhToan);
            fThanhToan.Show();
        }


        private void btnKhamBenh_Click(object sender, EventArgs e)
        {
            this.pnlChinh.Controls.Clear();
            frmKhamChuaBenh fKhamBenh = new frmKhamChuaBenh(NguoiDung);
            fKhamBenh.TopLevel = false;
            this.pnlChinh.Controls.Add(fKhamBenh);
            fKhamBenh.Show();
        }

        private void frmChinh_Load(object sender, EventArgs e)
        {
            this.pnlChinh.Controls.Clear();
            frmQuanTriHeThong fQuanTriHeThong = new frmQuanTriHeThong(NguoiDung);
            fQuanTriHeThong.TopLevel = false;
            this.pnlChinh.Controls.Add(fQuanTriHeThong);
            fQuanTriHeThong.Show();
        }
    }
}
