using System;
using System.Collections.Generic;
using System.Data;
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
            string query = "insert into HoSoBenhAn (NgayKham,ChanDoan,MaBenh,MaBacSi,MaBenhNhan) values ( @NgayKham , @ChanDoan , @MaBenh , @MaBacSi , @MaBenhNhan )";
            object[] parameter = { ngayKham,chanDoan,maBenh ,maBacSi,maBenhNhan};
            return DataProvider.Instance.ExecuteNonQuery(query, parameter) > 0;
        }

    }
}
