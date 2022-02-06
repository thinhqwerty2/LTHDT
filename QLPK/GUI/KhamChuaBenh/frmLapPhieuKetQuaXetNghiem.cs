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
    public partial class frmLapPhieuKetQuaXetNghiem : Form
    {
        private static NguoiDungDTO NguoiDung;

        public frmLapPhieuKetQuaXetNghiem(NguoiDungDTO nguoiDung)
        {
            InitializeComponent();
            NguoiDung = nguoiDung;
        }
    }
}
