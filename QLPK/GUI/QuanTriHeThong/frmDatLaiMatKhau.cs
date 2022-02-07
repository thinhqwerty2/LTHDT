using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using QLPK.DAO;

namespace QLPK.GUI.QuanTriHeThong
{
    public partial class frmDatLaiMatKhau : Form
    {
        DataRowCollection data;
        public frmDatLaiMatKhau()
        {
            InitializeComponent();
            btnDatLai.Enabled = false;
            data = TaiKhoanDAO.Instance.danhSachNguoiDung().Rows;
            foreach (DataRow row in data)
            {
                cmbTenDangNhap.Items.Add(row["TenDangNhap"]);
            }
        }
        private void btnDatLai_Click(object sender, EventArgs e)
        {
            if (TaiKhoanDAO.Instance.datLaiMatKhau(txtHoVaTen.Text))
            {
                MessageBox.Show("Đặt lại mật khẩu thành công! Mật khẩu mới của tài khoản là 1");
            }
            else
            {
                MessageBox.Show("Không thành công, vui lòng kiểm tra lại!");
            }
        }

        private void cmbTenDangNhap_Validated(object sender, EventArgs e)
        {
            if (cmbTenDangNhap.Items.Contains(cmbTenDangNhap.Text))
            {
                btnDatLai.Enabled = true;
                txtHoVaTen.Text = TaiKhoanDAO.Instance.layThongTinBacSiNhanVien(cmbTenDangNhap.Text).HoTen;
            }
            else
            {
                btnDatLai.Enabled = false;
                txtHoVaTen.Text = "";
                MessageBox.Show("Không có tên đăng nhập này trong hệ thống!");
            }
        }
    }
}
