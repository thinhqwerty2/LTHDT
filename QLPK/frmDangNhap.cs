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

namespace QLPK
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (DangNhapDAO.Instance.DangNhap(txtTenDangNhap.Text, txtMatKhau.Text))
            {
                //NhanVienDTO nhanVien = NhanVienDAO.Instance.getNVByID(txtUserName.Text);
                frmChinh fChinh = new frmChinh();
                this.Hide();
                fChinh.ShowDialog();
                txtTenDangNhap.Text = txtMatKhau.Text = "";
                this.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
