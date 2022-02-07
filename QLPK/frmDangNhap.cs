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
using QLPK.DTO;

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
                NguoiDungDTO nguoiDung = NguoiDungDAO.Instance.layThongTinNguoiDung(this.txtTenDangNhap.Text);
                frmChinh fChinh = new frmChinh(nguoiDung);
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn thực sự muốn thoát?","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            {
                Application.Exit();
            }   
        }

        private void ckbHienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbHienThiMatKhau.Checked)
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

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
           
        }
    }
}
