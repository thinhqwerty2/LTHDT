using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPK.DAO
{
    class HoSoBenhAnDAO
    {
        private static HoSoBenhAnDAO instance;
        public static HoSoBenhAnDAO Instance
        {
            get
            {
                if (instance == null) instance = new HoSoBenhAnDAO();
                return instance;
            }
            private set { instance = value; }
        }
        public bool themHoSoBenhAn(string maBenhNhan,DateTime ngayKham,string chanDoan,string maBenh,string maBacSi)
        {
            string query = "insert into HoSoBenhAn (SoBenhAn,NgayKham,ChanDoan,MaBenh,MaBacSi) values ( @SoBenhBan , @NgayKham , @ChanDoan , @MaBenh , @MaBacSi )";
            string soBenhAn = maBenh.Substring(0, 2) + (int.Parse(maBenh.Substring(2)) + 1).ToString();
            object[] parameter = { soBenhAn,ngayKham,chanDoan,maBenh ,maBacSi};
            return DataProvider.Instance.ExecuteNonQuery(query, parameter) > 0;
        }
    }
}
