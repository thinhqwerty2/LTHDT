using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPK.DAO
{
    class KetQuaXetNghiemDAO
    {
        private static KetQuaXetNghiemDAO instance;
        public static KetQuaXetNghiemDAO Instance
        {
            get
            {
                if (instance == null) instance = new KetQuaXetNghiemDAO();
                return instance;
            }
            private set { instance = value; }
        }
        public bool themKetQuaXetNghiem(string maBanKe, string maDichVu,string maBacSi,DateTime ngayKham,string ketQua)
        {
            string query = "insert into KetQuaXetNghiem (MaBanKe,MaDichVu,MaBacSi,NgayKham,KetQua) values ( @MaBanKe , @MaDichVu , @MaBacSi , @NgayKham , @KetQua )";
            object[] parameter = { maBanKe, maDichVu ,maBacSi,ngayKham,ketQua};
            return DataProvider.Instance.ExecuteNonQuery(query, parameter) > 0;
        }
    }
}
