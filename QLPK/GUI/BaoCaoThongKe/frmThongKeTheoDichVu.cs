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
using QLPK.DAO;

namespace QLPK.GUI.BaoCaoThongKe
{
    public partial class frmThongKeDichVu : Form
    {
        private static NguoiDungDTO NguoiDung;

        public frmThongKeDichVu(NguoiDungDTO nguoiDung)
        {
            InitializeComponent();
            NguoiDung = nguoiDung;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ThongKeADO.Instance.thongKeDichVu(dateTimePicker1.Value, dateTimePicker2.Value);
        }

        private void frmThongKeDichVu_Load(object sender, EventArgs e)
        {

        }
    }
}
