using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public bool themBenh(string maBenh,string loaiBenh,string moTa)
        {
            string query = "insert into Benh (MaBenh,LoaiBenh,MoTaBenh) values ( @MaBenh , @LoaiBenh , @MoTa )";
            object[] parameter = { maBenh,loaiBenh,moTa};
            return DataProvider.Instance.ExecuteNonQuery(query, parameter) > 0;
        }
        public DataTable hienThiDSBenh()
        {
            string query = "select MaBenh,LoaiBenh,MoTaBenh from Benh";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        
        public bool suaBenh(string loaiBenh, string moTa,string maBenh)
        {
            string query = "update Benh set LoaiBenh= @LoaiBenh ,MoTa= @MoTa where MaBenh= @MaBenh";
            object[] parameter = { loaiBenh,moTa, maBenh };
            return DataProvider.Instance.ExecuteNonQuery(query, parameter) > 0;
        }
        public bool xoaBenh(string maBenh)
        {
            return DataProvider.Instance.ExecuteNonQuery("update TaiKhoan set TrangThai='Nghỉ việc' where TenDangNhap= @MaBenh", new object[] { maBenh }) > 0;
        }

    }
}
