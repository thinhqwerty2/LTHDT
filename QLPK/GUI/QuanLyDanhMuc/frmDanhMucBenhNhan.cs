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

namespace QLPK.GUI.QuanLyDanhMuc
{
    public partial class frmDanhMucBenhNhan : Form
    {
        public frmDanhMucBenhNhan()
        {
            InitializeComponent();
        }
        void loadData()
        {
           this.dgvDanhMucBenhNhan.DataSource = BenhNhanDAO.Instance.hienThiDSBenhNhan();

        }

        private void frmDanhMucBenhNhan_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
