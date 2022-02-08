using QLPK.DAO;
using QLPK.DTO;
using System;
using System.Windows.Forms;

namespace QLPK.GUI.QuanTriHeThong
{
    public partial class frmDoiMatKhau : Form
    {
        private static NguoiDungDTO NguoiDung;
        public frmDoiMatKhau(NguoiDungDTO nguoiDung)
        {
            InitializeComponent();
            NguoiDung = nguoiDung;
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Text = NguoiDung.TenDangNhap;
            txtHoVaTen.Text = NguoiDung.HoTen;
        }

        bool batLoi()
        {
            if (txtMatKhauCu.Text == "" || txtMatKhauMoi.Text=="" || txtNhapLaiMatKhau.Text =="")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void txtNhapLaiMatKhau_TextChanged(object sender, EventArgs e)
        {
            if (txtNhapLaiMatKhau.Text != txtMatKhauMoi.Text)
            {
                errorProvider1.SetError(txtNhapLaiMatKhau, "Không trùng khớp mật khẩu!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (!TaiKhoanDAO.Instance.kiemTraMatKhauTrungKhop(NguoiDung.TenDangNhap, txtMatKhauCu.Text))
            {
                MessageBox.Show("Mật khẩu cũ không chính xác!");
            }
            else if (batLoi()==false)
            {
                MessageBox.Show("Không được để trống!");
            }
            else if (txtNhapLaiMatKhau.Text == txtMatKhauMoi.Text && batLoi()==true)
            {
                if (MessageBox.Show("Xác nhận thay đổi mật khẩu?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    TaiKhoanDAO.Instance.capNhatMatKhauMoi(NguoiDung.TenDangNhap, txtMatKhauMoi.Text);
                }
            }
        }

        private void ckbHienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            
                if (ckbHienThiMatKhau.Checked)
                {
                    this.ckbHienThiMatKhau.BackgroundImage = global::QLPK.Properties.Resources.HidePassword;
                    this.txtMatKhauCu.UseSystemPasswordChar = false;
                }
                else
                {
                    this.ckbHienThiMatKhau.BackgroundImage = global::QLPK.Properties.Resources.ShowPassword;
                    this.txtMatKhauCu.UseSystemPasswordChar = true;
                }


            
        }

        private void ckbHienThiMatKhauMoi_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbHienThiMatKhauMoi.Checked)
            {
                this.ckbHienThiMatKhauMoi.BackgroundImage = global::QLPK.Properties.Resources.HidePassword;
                this.txtMatKhauMoi.UseSystemPasswordChar = false;
            }
            else
            {
                this.ckbHienThiMatKhauMoi.BackgroundImage = global::QLPK.Properties.Resources.ShowPassword;
                this.txtMatKhauMoi.UseSystemPasswordChar = true;
            }
        }

        private void ckbNhapLaiMatKhauMoi_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbNhapLaiMatKhauMoi.Checked)
            {
                this.ckbNhapLaiMatKhauMoi.BackgroundImage = global::QLPK.Properties.Resources.HidePassword;
                this.txtNhapLaiMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                this.ckbNhapLaiMatKhauMoi.BackgroundImage = global::QLPK.Properties.Resources.ShowPassword;
                this.txtNhapLaiMatKhau.UseSystemPasswordChar = true;
            }
        }
    }
}
