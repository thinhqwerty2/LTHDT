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
            frmDanhMucNhanVien fDanhMucNhanVien = new frmDanhMucNhanVien();
            fDanhMucNhanVien.TopLevel = false;
            this.pnlXemQuanLyDanhMuc.Controls.Add(fDanhMucNhanVien);
            fDanhMucNhanVien.Show();
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            this.pnlXemQuanLyDanhMuc.Controls.Clear();
            frmDanhMucDichVu fDanhMucDichVu = new frmDanhMucDichVu();
            fDanhMucDichVu.TopLevel = false;
            this.pnlXemQuanLyDanhMuc.Controls.Add(fDanhMucDichVu);
            fDanhMucDichVu.Show();
        }

        private void btnBacSi_Click(object sender, EventArgs e)
        {
            this.pnlXemQuanLyDanhMuc.Controls.Clear();
            frmDanhMucBacSi fDanhMucBacSi = new frmDanhMucBacSi();
            fDanhMucBacSi.TopLevel = false;
            this.pnlXemQuanLyDanhMuc.Controls.Add(fDanhMucBacSi);
            fDanhMucBacSi.Show();
        }

        private void btnBenhNhan_Click(object sender, EventArgs e)
        {
            this.pnlXemQuanLyDanhMuc.Controls.Clear();
            frmDanhMucBenhNhan fDanhMucBenhNhan = new frmDanhMucBenhNhan();
            fDanhMucBenhNhan.TopLevel = false;
            this.pnlXemQuanLyDanhMuc.Controls.Add(fDanhMucBenhNhan);
            fDanhMucBenhNhan.Show();
        }
    }
}
