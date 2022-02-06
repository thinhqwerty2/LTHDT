using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLPK.GUI;
namespace QLPK.GUI.KhamBenh
{
    public partial class frmPhieuDangKyKhamBenh : Form
    {
        public frmPhieuDangKyKhamBenh()
        {
            InitializeComponent();
        }

        private void btnTimKiemBenhNhan_Click(object sender, EventArgs e)
        {
            QuanLyDanhMuc.frmTimKiemBenhNhan fTimKiemBenhNhan = new QuanLyDanhMuc.frmTimKiemBenhNhan();

            fTimKiemBenhNhan.Show();
        }
    }
}
