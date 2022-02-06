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

        private void txtNhapLaiMatKhau_TextChanged(object sender, EventArgs e)
        {
            if (txtNhapLaiMatKhau.Text != txtMatKhauMoi.Text)
            {
                errorProvider1.SetError(txtNhapLaiMatKhau, "Không trùng khớp mật khẩu");
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
                MessageBox.Show("Mật khẩu cũ không chính xác");
            }
            else if (txtNhapLaiMatKhau.Text == txtMatKhauMoi.Text)
            {
                if (MessageBox.Show("Xác nhận thay đổi mật khẩu?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    TaiKhoanDAO.Instance.capNhatMatKhauMoi(NguoiDung.TenDangNhap, txtMatKhauMoi.Text);
                }
            }



        }
    }
}
