using QLPK.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPK.DAO
{
    class NguoiDungDAO
    {
        private static NguoiDungDAO instance;
        public static NguoiDungDAO Instance
        {
            get
            {
                if (instance == null) instance = new NguoiDungDAO();
                return instance;
            }
            private set { instance = value; }
        }
        public NguoiDungDTO layThongTinNguoiDung(string tenDangNhap)
        {
            string query = "(select TenDangNhap,HoTen,QuyenTruyCap from TaiKhoan,Bacsi where TaiKhoan.TenDangNhap=BacSi.MaBacSi and  MaBacSi = @TenDangNhap1 )union(select TenDangNhap,HoTen,QuyenTruyCap from TaiKhoan,NhanVien where TaiKhoan.TenDangNhap=NhanVien.MaNhanVien and  MaNhanVien= @TenDangNhap2 )";
            object[] parameter = { tenDangNhap,tenDangNhap};
            return new NguoiDungDTO( DataProvider.Instance.ExecuteQuery(query, parameter).Rows[0]);
        }
    }
}
