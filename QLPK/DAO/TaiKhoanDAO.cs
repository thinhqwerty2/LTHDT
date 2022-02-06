using System;
using System.Collections.Generic;
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
        public bool themTaiKhoan(string tenDangNhap, string matKhau, int quyenTruyCap, string trangThai)
        {
            string query = "insert into TaiKhoan (TenDangNhap,MatKhau,QuyenTruyCap,TrangThai) values ( @TenDangNhap , @MatKhau , @QuyenTruyCap , @TrangThai )";
            object[] parameter = { tenDangNhap,matKhau,quyenTruyCap,trangThai};
            return DataProvider.Instance.ExecuteNonQuery(query, parameter) > 0;
        }
    }
}
