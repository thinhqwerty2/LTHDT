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

namespace QLPK.GUI.QuanLyDanhMuc
{
    public partial class frmQuanLyDanhMuc : Form
    {
        private static NguoiDungDTO NguoiDung;

        public frmQuanLyDanhMuc(NguoiDungDTO nguoiDung)
        {
            InitializeComponent();
            NguoiDung = nguoiDung;
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            this.pnlXemQuanLyDanhMuc.Controls.Clear();
            frmDanhMucNhanVien fDanhMucNhanVien = new frmDanhMucNhanVien(NguoiDung);
            fDanhMucNhanVien.TopLevel = false;
            this.pnlXemQuanLyDanhMuc.Controls.Add(fDanhMucNhanVien);
            fDanhMucNhanVien.Show();
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            this.pnlXemQuanLyDanhMuc.Controls.Clear();
            frmDanhMucDichVu fDanhMucDichVu = new frmDanhMucDichVu(NguoiDung);
            fDanhMucDichVu.TopLevel = false;
            this.pnlXemQuanLyDanhMuc.Controls.Add(fDanhMucDichVu);
            fDanhMucDichVu.Show();
        }

        private void btnBacSi_Click(object sender, EventArgs e)
        {
            this.pnlXemQuanLyDanhMuc.Controls.Clear();
            frmDanhMucBacSi fDanhMucBacSi = new frmDanhMucBacSi(NguoiDung);
            fDanhMucBacSi.TopLevel = false;
            this.pnlXemQuanLyDanhMuc.Controls.Add(fDanhMucBacSi);
            fDanhMucBacSi.Show();
        }

        private void btnBenhNhan_Click(object sender, EventArgs e)
        {
            this.pnlXemQuanLyDanhMuc.Controls.Clear();
            frmDanhMucBenhNhan fDanhMucBenhNhan = new frmDanhMucBenhNhan(NguoiDung);
            fDanhMucBenhNhan.TopLevel = false;
            this.pnlXemQuanLyDanhMuc.Controls.Add(fDanhMucBenhNhan);
            fDanhMucBenhNhan.Show();
        }

        private void frmQuanLyDanhMuc_Load(object sender, EventArgs e)
        {
            this.pnlXemQuanLyDanhMuc.Controls.Clear();
            frmDanhMucBenhNhan fDanhMucBenhNhan = new frmDanhMucBenhNhan(NguoiDung);
            fDanhMucBenhNhan.TopLevel = false;
            this.pnlXemQuanLyDanhMuc.Controls.Add(fDanhMucBenhNhan);
            fDanhMucBenhNhan.Show();
        }

        private void btnBenh_Click(object sender, EventArgs e)
        {
            this.pnlXemQuanLyDanhMuc.Controls.Clear();
            frmDanhMucBenh fDanhMucBenh = new frmDanhMucBenh(NguoiDung);
            fDanhMucBenh.TopLevel = false;
            this.pnlXemQuanLyDanhMuc.Controls.Add(fDanhMucBenh);
            fDanhMucBenh.Show();
        }
    }
}
