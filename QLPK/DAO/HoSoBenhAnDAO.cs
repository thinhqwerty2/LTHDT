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
            string query = "insert into HoSoBenhAn (SoBenhAn,NgayKham,ChanDoan,MaBenh,MaBacSi,MaBenhNhan) values ( @SoBenhBan , @NgayKham , @ChanDoan , @MaBenh , @MaBacSi , @MaBenhNhan )";
            string soBenhAn = maBenhNhan.Substring(0, 2) + (int.Parse(maBenhNhan.Substring(2)) + 1).ToString();
            object[] parameter = { soBenhAn,ngayKham,chanDoan,maBenh ,maBacSi};
            return DataProvider.Instance.ExecuteNonQuery(query, parameter) > 0;
        }
        public DataTable xemHoSoBenhAn(string maBenhNhan)
        {
            string query = "select * from HoSoBenhAn,BenhNhan,MaBenh,BacSi where" +
                "HoSoBenhAn.MaBenhNhan=BenhNhan.MaBenhNhan and HoSoBenhAn.MaBacSi=BacSi.MaBacSi" +
                "HoSoBenhAn.MaBenh=Benh.MaBenh and (MaBenhNhan= @MaBenhNhan )";
            
            object[] parameter = { maBenhNhan };
            return DataProvider.Instance.ExecuteQuery(query, parameter);
        }
    }
}
