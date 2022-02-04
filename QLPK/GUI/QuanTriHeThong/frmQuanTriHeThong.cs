﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPK.GUI.QuanTriHeThong
{
    //public static NhanVienDTO NhanVien
    public partial class frmQuanTriHeThong : Form
    {
        public frmQuanTriHeThong()
        {
            InitializeComponent();
        }

        private void btnThongTinTaiKhoan_Click(object sender, EventArgs e)
        {
            this.pnlXemQuanTriHeThong.Controls.Clear();
            frmThongTinTaiKhoan fThongTinTaiKhoan = new frmThongTinTaiKhoan();
            fThongTinTaiKhoan.TopLevel = false;
            this.pnlXemQuanTriHeThong.Controls.Add(fThongTinTaiKhoan);
            fThongTinTaiKhoan.Show();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            this.pnlXemQuanTriHeThong.Controls.Clear();
            frmDoiMatKhau fDoiMatKhau = new frmDoiMatKhau();
            fDoiMatKhau.TopLevel = false;
            this.pnlXemQuanTriHeThong.Controls.Add(fDoiMatKhau);
            fDoiMatKhau.Show();
        }

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            this.pnlXemQuanTriHeThong.Controls.Clear();
            frmDangKyTaiKhoan fDangKyTaiKhoan = new frmDangKyTaiKhoan();
            fDangKyTaiKhoan.TopLevel = false;
            this.pnlXemQuanTriHeThong.Controls.Add(fDangKyTaiKhoan);
            fDangKyTaiKhoan.Show();
        }

        private void btnPhanQuyen_Click(object sender, EventArgs e)
        {
            this.pnlXemQuanTriHeThong.Controls.Clear();
            frmPhanQuyen fPhanQuyen = new frmPhanQuyen();
            fPhanQuyen.TopLevel = false;
            this.pnlXemQuanTriHeThong.Controls.Add(fPhanQuyen);
            fPhanQuyen.Show();
        }
    }
}
