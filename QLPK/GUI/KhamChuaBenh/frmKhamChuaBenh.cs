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
            if(NguoiDung.QuyenTruyCap!=1)
            {

                this.pnlXemKhamChuaBenh.Controls.Clear();
                frmPhieuDangKyKhamBenh fPhieuDangKyKhamBenh = new frmPhieuDangKyKhamBenh(NguoiDung);
                fPhieuDangKyKhamBenh.TopLevel = false;
                this.pnlXemKhamChuaBenh.Controls.Add(fPhieuDangKyKhamBenh);
                fPhieuDangKyKhamBenh.Show();
            }   else
            {
                MessageBox.Show("Việc này là của nhân viên!!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void btnLapPhieuDangKyXetNghiem_Click(object sender, EventArgs e)
        {
            if (NguoiDung.QuyenTruyCap != 1)
            {
                this.pnlXemKhamChuaBenh.Controls.Clear();
            frmPhieuSuDungXetNghiem fPhieuSuDungXetNghiem = new frmPhieuSuDungXetNghiem(NguoiDung);
            fPhieuSuDungXetNghiem.TopLevel = false;
            this.pnlXemKhamChuaBenh.Controls.Add(fPhieuSuDungXetNghiem);
            fPhieuSuDungXetNghiem.Show();
            }
            else
            {
                MessageBox.Show("Việc này là của nhân viên!!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnLapPhieuKetQuaXetNghiem_Click(object sender, EventArgs e)
        {
            if(NguoiDung.QuyenTruyCap==1)
            {

            this.pnlXemKhamChuaBenh.Controls.Clear();
            frmLapPhieuKetQuaXetNghiem fLapPhieuKetQuaXetNghiem = new frmLapPhieuKetQuaXetNghiem(NguoiDung);
            fLapPhieuKetQuaXetNghiem.TopLevel = false;
            this.pnlXemKhamChuaBenh.Controls.Add(fLapPhieuKetQuaXetNghiem);
            fLapPhieuKetQuaXetNghiem.Show();
            } else
            {
                MessageBox.Show("Chỉ bác sĩ mới được lập phiếu sử dụng xét nghiệm!!!","Cảnh báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }    
        }

        private void btnChanDoan_Click(object sender, EventArgs e)
        {
            if(NguoiDung.QuyenTruyCap==1)
            {
                
            this.pnlXemKhamChuaBenh.Controls.Clear();
            frmPhieuChanDoan fPhieuChanDoan = new frmPhieuChanDoan(NguoiDung);
            fPhieuChanDoan.TopLevel = false;
            this.pnlXemKhamChuaBenh.Controls.Add(fPhieuChanDoan);
            fPhieuChanDoan.Show();
            }    else
            {
                MessageBox.Show("Chỉ bác sĩ mới được chẩn đoán!!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLapPhieuSuDungDichVu_Click(object sender, EventArgs e)
        {
            this.pnlXemKhamChuaBenh.Controls.Clear();
            frmPhieuSuDungDichVuChuaBenh fPhieuSuDungDichVuChuaBenh = new frmPhieuSuDungDichVuChuaBenh(NguoiDung);
            fPhieuSuDungDichVuChuaBenh.TopLevel = false;
            this.pnlXemKhamChuaBenh.Controls.Add(fPhieuSuDungDichVuChuaBenh);
            fPhieuSuDungDichVuChuaBenh.Show();
        }

        private void frmKhamChuaBenh_Load(object sender, EventArgs e)
        {
            if(NguoiDung.QuyenTruyCap!=1)
            {

            this.pnlXemKhamChuaBenh.Controls.Clear();
            frmPhieuDangKyKhamBenh fPhieuDangKyKhamBenh = new frmPhieuDangKyKhamBenh(NguoiDung);
            fPhieuDangKyKhamBenh.TopLevel = false;
            this.pnlXemKhamChuaBenh.Controls.Add(fPhieuDangKyKhamBenh);
            fPhieuDangKyKhamBenh.Show();
            }   
            else
            {
                this.pnlXemKhamChuaBenh.Controls.Clear();
                frmLapPhieuKetQuaXetNghiem fLapPhieuKetQuaXetNghiem = new frmLapPhieuKetQuaXetNghiem(NguoiDung);
                fLapPhieuKetQuaXetNghiem.TopLevel = false;
                this.pnlXemKhamChuaBenh.Controls.Add(fLapPhieuKetQuaXetNghiem);
                fLapPhieuKetQuaXetNghiem.Show();
            }    
        }
    }
}
