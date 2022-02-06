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

namespace QLPK.GUI.KhamBenh
{
    public partial class frmKhamChuaBenh : Form
    {
        private static NguoiDungDTO NguoiDung;
        
        public frmKhamChuaBenh(NguoiDungDTO nguoiDung)
        {
            InitializeComponent();
            NguoiDung = nguoiDung;
        }

        private void btnLapPhieuDangKiKhamBenh_Click(object sender, EventArgs e)
        {
            
                this.pnlXemKhamChuaBenh.Controls.Clear();
                frmPhieuDangKyKhamBenh fPhieuDangKyKhamBenh = new frmPhieuDangKyKhamBenh(NguoiDung);
                fPhieuDangKyKhamBenh.TopLevel = false;
                this.pnlXemKhamChuaBenh.Controls.Add(fPhieuDangKyKhamBenh);
                fPhieuDangKyKhamBenh.Show();
            
        }

        private void btnLapPhieuDangKyXetNghiem_Click(object sender, EventArgs e)
        {
            this.pnlXemKhamChuaBenh.Controls.Clear();
            frmPhieuSuDungXetNghiem fPhieuSuDungXetNghiem = new frmPhieuSuDungXetNghiem(NguoiDung);
            fPhieuSuDungXetNghiem.TopLevel = false;
            this.pnlXemKhamChuaBenh.Controls.Add(fPhieuSuDungXetNghiem);
            fPhieuSuDungXetNghiem.Show();
        }

        private void btnLapPhieuKetQuaXetNghiem_Click(object sender, EventArgs e)
        {
            this.pnlXemKhamChuaBenh.Controls.Clear();
            frmLapPhieuKetQuaXetNghiem fLapPhieuKetQuaXetNghiem = new frmLapPhieuKetQuaXetNghiem(NguoiDung);
            fLapPhieuKetQuaXetNghiem.TopLevel = false;
            this.pnlXemKhamChuaBenh.Controls.Add(fLapPhieuKetQuaXetNghiem);
            fLapPhieuKetQuaXetNghiem.Show();
        }

        private void btnChanDoan_Click(object sender, EventArgs e)
        {
            this.pnlXemKhamChuaBenh.Controls.Clear();
            frmPhieuChanDoan fPhieuChanDoan = new frmPhieuChanDoan(NguoiDung);
            fPhieuChanDoan.TopLevel = false;
            this.pnlXemKhamChuaBenh.Controls.Add(fPhieuChanDoan);
            fPhieuChanDoan.Show();
        }

        private void btnLapPhieuSuDungDichVu_Click(object sender, EventArgs e)
        {
            this.pnlXemKhamChuaBenh.Controls.Clear();
            frmPhieuSuDungDichVuChuaBenh fPhieuSuDungDichVuChuaBenh = new frmPhieuSuDungDichVuChuaBenh(NguoiDung);
            fPhieuSuDungDichVuChuaBenh.TopLevel = false;
            this.pnlXemKhamChuaBenh.Controls.Add(fPhieuSuDungDichVuChuaBenh);
            fPhieuSuDungDichVuChuaBenh.Show();
        }
    }
}
