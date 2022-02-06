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
                frmPhieuDangKyKhamBenh fPhieuDangKyKhamBenh = new frmPhieuDangKyKhamBenh();
                fPhieuDangKyKhamBenh.TopLevel = false;
                this.pnlXemKhamChuaBenh.Controls.Add(fPhieuDangKyKhamBenh);
                fPhieuDangKyKhamBenh.Show();
            
        }
    }
}
