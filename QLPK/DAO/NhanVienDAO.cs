using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QLPK.DAO
{
    class NhanVienDAO
    {

        private static NhanVienDAO instance;
        public static NhanVienDAO Instance
        {
            get
            {
                if (instance == null) instance = new NhanVienDAO();
                return instance;
            }
            private set { instance = value; }
        }
        public NhanVienDAO()
        {
        }
        public DataTable hienThiDSNhanVien()
        {
            string query = "select MaNhanVien,HoTen,GioiTinh,ChucVu,DiaChi,SDT,TrangThai from NhanVien,TaiKhoan where TrangThai=N'Đang làm việc' and NhanVien.MaNhanVien=TaiKhoan.TenDangNhap";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable hienThiDSTatCaNhanVien()
        {
            string query = "select MaNhanVien,HoTen,GioiTinh,ChucVu,DiaChi,SDT,TrangThai from NhanVien,TaiKhoan where NhanVien.MaNhanVien=TaiKhoan.TenDangNhap";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool suaNhanVien(string diaChi, string sdt, string chucVu, string maNhanVien)
        {
            string query = "update NhanVien set DiaChi= @DiaChi ,SDT= @SDT  ,ChucVu= @ChucVu where MaNhanVien= @MaNhanVien";
            object[] parameter = { diaChi, sdt, chucVu, maNhanVien };
            return DataProvider.Instance.ExecuteNonQuery(query, parameter) > 0;
        }
        public bool themNhanVien(string maNhanVien, string hoTen, string gioiTinh, string diaChi, string sdt, string chucVu)
        {
            TaiKhoanDAO.Instance.themTaiKhoan(maNhanVien, "1", 2, "Đang làm việc");
            string query = "insert into NhanVien (MaNhanVien,HoTen,GioiTinh,DiaChi,SDT,ChucVu) values ( @MaNhanVien , @HoTen , @GioiTinh , @DiaChi , @SDT  , @ChucVu )";
            object[] parameter = { maNhanVien, hoTen, gioiTinh, diaChi, sdt, chucVu };
            return DataProvider.Instance.ExecuteNonQuery(query, parameter) > 0;
        }
        public bool xoaNhanVien(string maNhanVien)
        {
            return DataProvider.Instance.ExecuteNonQuery("update TaiKhoan set TrangThai=N'Nghỉ việc' where TenDangNhap= @MaNhanVien", new object[] { maNhanVien }) > 0;
        }
        public DataTable timKiemNhanVien(string key, bool checkTatCa)
        {
            key = $"%{key}%";
            string query;
            if (checkTatCa)
            {
                query = "select MaNhanVien,HoTen,GioiTinh,ChucVu,DiaChi,SDT,TrangThai from NhanVien,TaiKhoan where NhanVien.MaNhanVien=TaiKhoan.TenDangNhap and (MaNhanVien like @key1 or HoTen like @key2 or SDT like @key3 )";

            }
            else
            {
                query = "select MaNhanVien,HoTen,GioiTinh,ChucVu,DiaChi,SDT,TrangThai from NhanVien,TaiKhoan where NhanVien.MaNhanVien=TaiKhoan.TenDangNhap and TrangThai=1 and (MaNhanVien like @key1 or HoTen like @key2 or SDT like @key3 )";
            }
            object[] parameter = { key, key, key };
            return DataProvider.Instance.ExecuteQuery(query, parameter);
        }
    }
}
