using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPK.DAO
{
    class PhieuThuTienTamUngDAO
    {
        private static PhieuThuTienTamUngDAO instance;
        public static PhieuThuTienTamUngDAO Instance
        {
            get
            {
                if (instance == null) instance = new PhieuThuTienTamUngDAO();
                return instance;
            }
            private set { instance = value; }
        }
        public bool themPhieuThuTienTamUng(double soTienThuTamUng,DateTime ngayThuTienTamUng,string maBanKe,string maNhanVien)
        {
            string query = "insert into PhieuThuTienTamUng (SoTienThuTamUng,NgayThuTienTamUng,MaBanKe,MaNhanVien) values ( @SoTienThuTamUng , @NgayThuTienTamUng , @MaBanKe , @MaNhanVien )";
            object[] parameter = { soTienThuTamUng,ngayThuTienTamUng,maBanKe,maNhanVien};
            return DataProvider.Instance.ExecuteNonQuery(query, parameter) > 0;
        }
    }
}
