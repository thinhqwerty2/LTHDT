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
    public partial class frmThongKeTheoLoaiBenh : Form
    {
        private static NguoiDungDTO NguoiDung;

        public frmThongKeTheoLoaiBenh(NguoiDungDTO nguoiDung)
        {
            InitializeComponent();
            NguoiDung = nguoiDung;
        }
    }
}
