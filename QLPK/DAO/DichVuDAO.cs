using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPK.DAO
{
    class DichVuDAO
    {
        private static DichVuDAO instance;
        public static DichVuDAO Instance
        {
            get
            {
                if (instance == null) instance = new DichVuDAO();
                return instance;
            }
            private set { instance = value; }
        }
        public DichVuDAO()
        {
        }
        public DataTable hienThiDSDichVu()
        {
            return DataProvider.Instance.ExecuteQuery("select * from DichVu where DonGia<>-1");
        }
        public DataTable hienThiDSTatCaDichVu()
        {
            string query = "select * from DichVu";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable hienThiDSDichVuXetNghiem()
        {
            string query = "select * from DichVu";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable hienThiDSDichVuChuaBenh()
        {
            string query = "select * from DichVu";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        internal bool themDichVu(string maDichVu, string tenDichVu, string donGia, string donViTinh, string ghiChu)
        {
            string query = "insert into DichVu (MaDichVu,TenDichVu,DonGia,DonViTinh,GhiChu,SoLanSuDung) values ( @MaDichVu , @TenDichVu , @DonGia , @DonViTinh , @GhiChu , 0 ";
            object[] parameter = { maDichVu,tenDichVu,donGia,donViTinh,ghiChu };
            return DataProvider.Instance.ExecuteNonQuery(query, parameter)>0;
        }
        public bool suaDichVu( string tenDichVu, string donGia, string donViTinh, string ghiChu,string maDichVu)
        {
            string query = "update DichVu set MaDichVu= @MaDichVu ,TenDichVu= @TenDichVu  ,DonGia= @DonGia ,DonViTinh= @DonViTinh ,GhiChu= @GhiChu where MaDichVu= @MaDichVu";
            object[] parameter = {tenDichVu,donGia,donViTinh,ghiChu, maDichVu };
            return DataProvider.Instance.ExecuteNonQuery(query, parameter) > 0;
        }

        public bool xoaDichVu(string maDichVu)
        {
            return DataProvider.Instance.ExecuteNonQuery("update DichVu set DonGia=-1 where MaDichVu= @MaDichVu", new object[] { maDichVu }) > 0;
        }

        public object timKiemDichVu(string key, bool checkHienThiTatCa)
        {
            key = $"%{key}%";
            string query; 
            if (true)
            {
                query = "select MaDichVu,TenDichVu,DonGia,DonViTinh,GhiChu,SoLanSuDung from DichVu where (TenDichVu like @key1 or MaDichVu like @key2 )";
            }
            else
            {
                query = "select MaDichVu,TenDichVu,DonGia,DonViTinh,GhiChu,SoLanSuDung from DichVu where DonGia<>-1 (TenDichVu like @key1 or MaDichVu like @key2 )";
            }
            object[] parameter = { key, key};
            return DataProvider.Instance.ExecuteQuery(query, parameter);
        }
    }
}
