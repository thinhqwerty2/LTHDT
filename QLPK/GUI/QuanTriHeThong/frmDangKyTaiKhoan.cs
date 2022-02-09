using QLPK.DAO;
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

namespace QLPK.GUI.QuanTriHeThong
{
    public partial class frmDangKyTaiKhoan : Form
    {
        public frmDangKyTaiKhoan()
        {
            InitializeComponent();
            btnDangKy.Enabled = false;
        }

        private void txt_Validated(object sender, EventArgs e)
        {
            btnDangKy.Enabled=true;
        }

        bool batLoi()
        {
            if (txtTenDangNhap.Text == "" || txtMatKhau.Text == "" || txtNhapLaiMatKhau.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (batLoi() && txtMatKhau.Text==txtNhapLaiMatKhau.Text)
            {
                if (!TaiKhoanDAO.Instance.kiemTraTaiKhoan(txtTenDangNhap.Text)) 
                {
                    TaiKhoanDAO.Instance.themTaiKhoanAdmin(txtTenDangNhap.Text, txtMatKhau.Text, 0, "Đang làm việc");
                    MessageBox.Show("Thêm tài khoản Admin mới thành công!");
                    btnDangKy.Enabled = false;
                    txtTenDangNhap.Text = "";
                    txtMatKhau.Text = "";
                    txtNhapLaiMatKhau.Text = "";
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập bị trùng, mời bạn chọn tên khác!");
                }
            }
            else
            {
                MessageBox.Show("Không được để trống!");
            }
        }

        private void txtNhapLaiMatKhau_TextChanged(object sender, EventArgs e)
        {
            if (txtNhapLaiMatKhau.Text != txtMatKhau.Text)
            {
                errorProvider1.SetError(txtNhapLaiMatKhau, "Không trùng khớp mật khẩu!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void ckbHienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbHienThiMatKhau.Checked)
            {
                this.ckbHienThiMatKhau.BackgroundImage = global::QLPK.Properties.Resources.HidePassword;
                this.txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                this.ckbHienThiMatKhau.BackgroundImage = global::QLPK.Properties.Resources.ShowPassword;
                this.txtMatKhau.UseSystemPasswordChar = true;
            }
        }

        private void ckbHienThiXacNhanMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbHienThiXacNhanMatKhau.Checked)
            {
                this.ckbHienThiMatKhau.BackgroundImage = global::QLPK.Properties.Resources.HidePassword;
                this.txtNhapLaiMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                this.ckbHienThiMatKhau.BackgroundImage = global::QLPK.Properties.Resources.ShowPassword;
                this.txtNhapLaiMatKhau.UseSystemPasswordChar = true;
            }
        }
    }
}
