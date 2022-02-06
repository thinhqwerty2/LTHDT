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

namespace QLPK.GUI.BaoCaoThongKe
{
    public partial class frmBaoCaoThongKe : Form
    {
        private static NguoiDungDTO NguoiDung;

        public frmBaoCaoThongKe(NguoiDungDTO nguoiDung)
        {
            InitializeComponent();
            NguoiDung = nguoiDung;
        }

        private void btnBenhNhan_Click(object sender, EventArgs e)
        {

        }
    }
}
