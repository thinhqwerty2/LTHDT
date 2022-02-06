using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPK.DAO
{
    class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;
        public static TaiKhoanDAO Instance
        {
            get
            {
                if (instance == null) instance = new TaiKhoanDAO();
                return instance;
            }
            private set { instance = value; }
        }
        public DataTable layThongTinNguoiDung(string tenDangNhap,int quyenTruyCap)
        {
            string bang;
            string nguoiDung;
            switch (quyenTruyCap)
            {
                case 1:
                    bang = "BacSi";
                    nguoiDung = "MaBacSi";
                    break;
                case 2:
                    bang = "NhanVien";
                    nguoiDung = "MaNhanVien";
                    break;
                default:
                    bang = "NhanVien";
                    nguoiDung = "MaNhanVien";
                    break;
            }
            string query = "select @NguoiDung ,HoTen,GioiTinh,SDT,ChucVu,DiaChi from @Bang where @NguoiDung1 =@TenDangNhap";
            object[] parameter = { nguoiDung,nguoiDung,tenDangNhap };
            return DataProvider.Instance.ExecuteQuery(query, parameter);
        }
        public bool themTaiKhoan(string tenDangNhap, string matKhau, int quyenTruyCap, string trangThai)
        {
            string query = "insert into TaiKhoan (TenDangNhap,MatKhau,QuyenTruyCap,TrangThai) values ( @TenDangNhap , @MatKhau , @QuyenTruyCap , @TrangThai )";
            object[] parameter = { tenDangNhap,matKhau,quyenTruyCap,trangThai};
            return DataProvider.Instance.ExecuteNonQuery(query, parameter) > 0;
        }
        public bool kiemTraMatKhauTrungKhop(string tenDangNhap, string matKhau)
        {
            string query = "select MatKhau from TaiKhoan where TenDangNhap= @TenDangNhap ";
            object[] parameter = { tenDangNhap};
            return matKhau== DataProvider.Instance.ExecuteQuery(query, parameter).Rows[0][0].ToString();
        }
        public bool capNhatMatKhauMoi(string tenDangNhap, string matKhauMoi)
        {
            string query = "update TaiKhoan set MatKhau = @MatKhauMoi where TenDangNhap= @TenDangNhap ";
            object[] parameter = { matKhauMoi,tenDangNhap };
            return  DataProvider.Instance.ExecuteNonQuery(query, parameter)>0;

        }
    }
}
