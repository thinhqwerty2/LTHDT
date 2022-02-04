using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPK.DAO
{
    class DangNhapDAO
    {
        private static DangNhapDAO instance;
        public static DangNhapDAO Instance
        {
            get
            {
                if (instance == null) instance = new DangNhapDAO();
                return instance;
            }
            private set { instance = value; }
        }
        public DangNhapDAO()
        {
        }
        public bool DangNhap(string tenDangNhap, string matKhau)
        {
            string query = "insert into TaiKhoan values ( @TenDangNhap , @MatKhau , 0 , 1 )";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenDangNhap, matKhau }) > 0;
        }
    }
}
