﻿using QLPK.DTO;
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
    public partial class frmPhieuSuDungDichVuChuaBenh : Form
    {
        private static NguoiDungDTO NguoiDung;

        public frmPhieuSuDungDichVuChuaBenh(NguoiDungDTO nguoiDung)
        {
            InitializeComponent();
            NguoiDung = nguoiDung;
        }

        private void txtTimKiemBenhNhan_Click(object sender, EventArgs e)
        {

        }
    }
}
