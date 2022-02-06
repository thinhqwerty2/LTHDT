using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLPK.DTO;

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
        public BacSiNhanVienDTO layThongTinBacSiNhanVien(string tenDangNhap,int quyenDangNhap)
        {
            string bang;
            string nguoiDung;
            switch (quyenDangNhap)
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

            string query = "select @NguoiDung ,HoTen,GioiTinh,SDT,ChucVu,DiaChi from @Bang where @TenDangNhap = @NguoiDung1 ";
            object[] parameter = { nguoiDung,bang,tenDangNhap,nguoiDung };
            return new BacSiNhanVienDTO(DataProvider.Instance.ExecuteQuery(query, parameter).Rows[0]);
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
        public NguoiDungDTO layThongTinNguoiDung(string tenDangNhap)
        {
            string query = "(select TenDangNhap,HoTen,QuyenTruyCap,ChucVu from TaiKhoan,Bacsi where TaiKhoan.TenDangNhap=BacSi.MaBacSi and  MaBacSi = @TenDangNhap1 )union(select TenDangNhap,HoTen,QuyenTruyCap,ChucVu from TaiKhoan,NhanVien where TaiKhoan.TenDangNhap=NhanVien.MaNhanVien and  MaNhanVien= @TenDangNhap2 )";
            object[] parameter = { tenDangNhap, tenDangNhap };
            return new NguoiDungDTO(DataProvider.Instance.ExecuteQuery(query, parameter).Rows[0]);
        }
    }
}
