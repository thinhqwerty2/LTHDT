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

namespace QLPK.GUI.BaoCaoThongKe
{
    public partial class frmBaoCaoThongKe : Form
    {
        private static NguoiDungDTO NguoiDung;

        public frmBaoCaoThongKe(NguoiDungDTO nguoiDung)
        {
            InitializeComponent();
            NguoiDung = nguoiDung;
        }

        private void btnBenhNhan_Click(object sender, EventArgs e)
        {
            this.pnlXemBaoCaoThongKe.Controls.Clear();
            frmThongKeBenhNhan fThongKeBenhNhan = new frmThongKeBenhNhan(NguoiDung);
            fThongKeBenhNhan.TopLevel = false;
            this.pnlXemBaoCaoThongKe.Controls.Add(fThongKeBenhNhan);
            fThongKeBenhNhan.Show();
        }

        private void btnThongKeTheoDichVu_Click(object sender, EventArgs e)
        {
            this.pnlXemBaoCaoThongKe.Controls.Clear();
            frmThongKeDichVu fThongKeDichVu = new frmThongKeDichVu(NguoiDung);
            fThongKeDichVu.TopLevel = false;
            this.pnlXemBaoCaoThongKe.Controls.Add(fThongKeDichVu);
            fThongKeDichVu.Show();
        }

        private void btnHoSoBenhAn_Click(object sender, EventArgs e)
        {
            this.pnlXemBaoCaoThongKe.Controls.Clear();
            frmThongKeBenh fThongKeBenh = new frmThongKeBenh(NguoiDung);
            fThongKeBenh.TopLevel = false;
            this.pnlXemBaoCaoThongKe.Controls.Add(fThongKeBenh);
            fThongKeBenh.Show();
        }

        private void btnThongKeLoaiBenhPhoBien_Click(object sender, EventArgs e)
        {
            this.pnlXemBaoCaoThongKe.Controls.Clear();
            frmThongKeTheoLoaiBenh fThongKeTheoLoaiBenh = new frmThongKeTheoLoaiBenh(NguoiDung);
            fThongKeTheoLoaiBenh.TopLevel = false;
            this.pnlXemBaoCaoThongKe.Controls.Add(fThongKeTheoLoaiBenh);
            fThongKeTheoLoaiBenh.Show();
        }

        private void frmBaoCaoThongKe_Load(object sender, EventArgs e)
        {
            this.pnlXemBaoCaoThongKe.Controls.Clear();
            frmThongKeBenhNhan fThongKeBenhNhan = new frmThongKeBenhNhan(NguoiDung);
            fThongKeBenhNhan.TopLevel = false;
            this.pnlXemBaoCaoThongKe.Controls.Add(fThongKeBenhNhan);
            fThongKeBenhNhan.Show();
        }
    }
}
