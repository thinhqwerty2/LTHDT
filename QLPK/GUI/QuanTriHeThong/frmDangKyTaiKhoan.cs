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
                string query = "insert into TaiKhoan (TenDangNhap,MatKhau,QuyenTruyCap,TrangThai) values ( @tendangnhap , @matkhau , 0,N'Đang làm việc')";
                string query1 = "insert into NhanVien (MaNhanVien,HoTen,GioiTinh,ChucVu,DiaChi,SDT) values ( @tendangnhap ,'admin',N'Nam','admin','0000000000')";
                object[] parameter = { txtTenDangNhap.Text,txtMatKhau.Text };
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
    }
}
