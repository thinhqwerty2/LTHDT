using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLPK.DAO;

namespace QLPK.DAO
{
    class BacSiDAO
    {
        private static BacSiDAO instance;
        public static BacSiDAO Instance
        {
            get
            {
                if (instance == null) instance = new BacSiDAO();
                return instance;
            }
            private set { instance = value; }
        }
        public BacSiDAO()
        {
        }
        public DataTable hienThiDSBacSi()
        {
            string query = "select MaBacSi,HoTen,GioiTinh,TrinhDo,ChucVu,DiaChi,SDT,TrangThai from BacSi,TaiKhoan where TrangThai= N'Đang làm việc' and BacSi.MaBacSi=TaiKhoan.TenDangNhap";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable hienThiDSTatCaBacSi()
        {
            string query = "select MaBacSi,HoTen,GioiTinh,TrinhDo,ChucVu,DiaChi,SDT,TrangThai from BacSi,TaiKhoan where BacSi.MaBacSi=TaiKhoan.TenDangNhap";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool suaBacSi( string diaChi, string sdt, string trinhDo, string chucVu, string maBacSi)
        {
            string query = "update BacSi set DiaChi= @DiaChi ,SDT= @SDT ,TrinhDo= @TrinhDo ,ChucVu= @ChucVu where MaBacSi= @MaBacSi";
            object[] parameter = { diaChi, sdt, trinhDo, chucVu, maBacSi };
            return DataProvider.Instance.ExecuteNonQuery(query, parameter) > 0;
        }
        public bool themBacSi(string maBacSi, string hoTen, string gioiTinh, string diaChi, string sdt, string trinhDo, string chucVu)
        {
            TaiKhoanDAO.Instance.themTaiKhoan(maBacSi, "1", 1, "Đang làm việc");
            string query = "insert into BacSi (MaBacSi,HoTen,GioiTinh,DiaChi,SDT,TrinhDo,ChucVu) values ( @MaBacSi , @HoTen , @GioiTinh , @DiaChi , @SDT , @TrinhDo , @ChucVu )";
            object[] parameter = { maBacSi, hoTen, gioiTinh, diaChi, sdt, trinhDo, chucVu };
            return DataProvider.Instance.ExecuteNonQuery(query, parameter) > 0;
        }
        public bool xoaBacSi(string maBacSi)
        {
            return DataProvider.Instance.ExecuteNonQuery("update TaiKhoan set TrangThai='Nghỉ việc' where TenDangNhap= @MaBacSi", new object[] { maBacSi }) > 0;
        }
        public DataTable timKiemBacSi(string key, bool checkTatCa)
        {
            key = $"%{key}%";
            string query;
            if (checkTatCa)
            {
                query = "select MaBacSi,HoTen,GioiTinh,TrinhDo,ChucVu,DiaChi,SDT,TrangThai from BacSi,TaiKhoan where BacSi.MaBacSi=TaiKhoan.TenDangNhap and (MaBacSi like @key1 or HoTen like @key2 or SDT like @key3 )";

            }
            else
            {
                query = "select MaBacSi,HoTen,GioiTinh,TrinhDo,ChucVu,DiaChi,SDT,TrangThai from BacSi,TaiKhoan where BacSi.MaBacSi=TaiKhoan.TenDangNhap and TrangThai=N'Đang làm việc' and (MaBacSi like @key1 or HoTen like @key2 or SDT like @key3 )";
            }
            object[] parameter = { key, key, key };
            return DataProvider.Instance.ExecuteQuery(query, parameter);
        }
    }
}
