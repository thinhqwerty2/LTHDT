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

namespace QLPK.GUI.ThanhToan
{
    public partial class frmThanhToan : Form
    {
        private static NguoiDungDTO NguoiDung;

        public frmThanhToan(NguoiDungDTO nguoiDung)
        {
            InitializeComponent();
            NguoiDung = nguoiDung;
        }

        private void btnThongTinBanKe_Click(object sender, EventArgs e)
        {
            this.pnlXemThanhToan.Controls.Clear();
            frmThongTinBanKe fThongTinBanKe = new frmThongTinBanKe(NguoiDung);
            fThongTinBanKe.TopLevel = false;
            this.pnlXemThanhToan.Controls.Add(fThongTinBanKe);
            fThongTinBanKe.Show();
        }

        private void btnLapPhieuThuTienTamUng_Click(object sender, EventArgs e)
        {
            this.pnlXemThanhToan.Controls.Clear();
            frmLapPhieuThuTienTamUng fLapPhieuThuTienTamUng = new frmLapPhieuThuTienTamUng(NguoiDung);
            fLapPhieuThuTienTamUng.TopLevel = false;
            this.pnlXemThanhToan.Controls.Add(fLapPhieuThuTienTamUng);
            fLapPhieuThuTienTamUng.Show();
        }

        private void btnTongHopChiPhi_Click(object sender, EventArgs e)
        {
            this.pnlXemThanhToan.Controls.Clear();
            frmTongHopChiPhi fTongHopChiPhi = new frmTongHopChiPhi(NguoiDung);
            fTongHopChiPhi.TopLevel = false;
            this.pnlXemThanhToan.Controls.Add(fTongHopChiPhi);
            fTongHopChiPhi.Show();
        }

        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            this.pnlXemThanhToan.Controls.Clear();
            frmThongTinBanKe fThongTinBanKe = new frmThongTinBanKe(NguoiDung);
            fThongTinBanKe.TopLevel = false;
            this.pnlXemThanhToan.Controls.Add(fThongTinBanKe);
            fThongTinBanKe.Show();
        }
    }
}
