using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPK.DAO
{
    class BanKeDAO
    {
        private static BanKeDAO instance;
        public static BanKeDAO Instance
        {
            get
            {
                if (instance == null) instance = new BanKeDAO();
                return instance;
            }
            private set { instance = value; }
        }
        public BanKeDAO()
        {
        }
        public bool themBanKe(DateTime ngayLapBanKe,string maBenhNhan,string maNhanVien)
        {
            string query = "insert into BanKe (NgayLapBanKe,MaBenhNhan,MaNhanVien) values ( @NgayLapBanKe , @MaBenhNhan , @MaNhanVien )";
            object[] parameter = { ngayLapBanKe,maBenhNhan,maNhanVien};
            return DataProvider.Instance.ExecuteNonQuery(query, parameter) > 0;
        }
        public DataTable layBanKeCuaBenhNhan(string maBenhNhan)
        {
            string query = "select * from BanKe where MaBenhNhan = @MaBenhNhan ";
            object[] parameter = { maBenhNhan};
            return DataProvider.Instance.ExecuteQuery(query, parameter);
        }
        public bool timBanKe(DateTime ngayLapBanKe, string maBenhNhan)
        {
            string query = "select * from BanKe where NgayLapBanKe= @ngayLapBanKe and MaBenhNhan = @maBenhNhan ";
            object[] parameter = { ngayLapBanKe, maBenhNhan };
            return DataProvider.Instance.ExecuteQuery(query, parameter).Rows.Count > 0;
        }
    }
}
