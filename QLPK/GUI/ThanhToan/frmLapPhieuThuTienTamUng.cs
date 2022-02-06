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
    public partial class frmLapPhieuThuTienTamUng : Form
    {
        private static NguoiDungDTO NguoiDung;

        public frmLapPhieuThuTienTamUng(NguoiDungDTO nguoiDung)
        {
            InitializeComponent();
            NguoiDung = nguoiDung;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
