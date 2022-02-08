using System;
using System.Data;

namespace QLPK.DAO
{
    class LoaiBenhDAO
    {
        private static LoaiBenhDAO instance;
        public static LoaiBenhDAO Instance
        {
            get
            {
                if (instance == null) instance = new LoaiBenhDAO();
                return instance;
            }
            private set { instance = value; }
        }
        public LoaiBenhDAO()
        {
        }
        public bool themLoaiBenh( string loaiBenh, string moTa)
        {
            string maBenh;
            string maxMaBenh = DataProvider.Instance.ExecuteScalar("select max(MaBenh) from Benh").ToString();
            if (maxMaBenh == "")
            {
                maBenh = "BE1";
            }
            else
            {
                maBenh = "BE" + (Convert.ToInt32(maxMaBenh.Substring(2)) + 1);
            }
            string query = "insert into Benh (MaBenh,LoaiBenh,MoTaBenh) values ( @MaBenh , @LoaiBenh , @MoTa )";
            object[] parameter = { maBenh, loaiBenh, moTa };
            return DataProvider.Instance.ExecuteNonQuery(query, parameter) > 0;
        }
        public DataTable hienThiDSLoaiBenh()
        {
            string query = "select MaBenh,LoaiBenh,MoTaBenh from Benh";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool suaLoaiBenh(string loaiBenh, string moTa, string maBenh)
        {
            string query = "update Benh set LoaiBenh= @LoaiBenh ,MoTa= @MoTa where MaBenh= @MaBenh";
            object[] parameter = { loaiBenh, moTa, maBenh };
            return DataProvider.Instance.ExecuteNonQuery(query, parameter) > 0;
        }
        /*
        public bool xoaBenh(string maBenh)
        {
            return DataProvider.Instance.ExecuteNonQuery("update Benh set TrangThai='Nghỉ việc' where TenDangNhap= @MaBenh", new object[] { maBenh }) > 0;
        }
        */
        public DataTable timKiemLoaiBenh(string key)
        {
            key = $"%{key}%";
            string query = "select * from Benh where  MaBenh like @key1 or LoaiBenh like @key2 or MoTaBenh like @key3 ";

            object[] parameter = { key, key,key };
            return DataProvider.Instance.ExecuteQuery(query, parameter);
        }
    }
}
