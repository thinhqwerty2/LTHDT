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
            string query = "select * from TaiKhoan where TenDangNhap= @TenDangNhap and MatKhau= @MatKhau";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { tenDangNhap, matKhau }).Rows.Count > 0;
        }
    }
}
