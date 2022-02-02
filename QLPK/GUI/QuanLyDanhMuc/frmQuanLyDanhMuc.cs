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
        public frmQuanLyDanhMuc()
        {
            InitializeComponent();
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
    }
}
