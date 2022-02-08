using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPK.DAO
{
    class ChiTietBanKeDAO
    {
        private static ChiTietBanKeDAO instance;
        public static ChiTietBanKeDAO Instance
        {
            get
            {
                if (instance == null) instance = new ChiTietBanKeDAO();
                return instance;
            }
            private set { instance = value; }
        }
        public bool themChiTietBanKe(string maBanKe,string maDichVu)
        {
            string query = "insert into ChiTietBanKe (MaBanKe,MaDichVu) values ( @MaBanKe , @MaDichVu )";
            object[] parameter = { maBanKe,maDichVu };
            return DataProvider.Instance.ExecuteNonQuery(query, parameter) > 0;
        }

        public DataTable xemChiTietBanKe(string maBanKe)
        {
            string query = "select ChiTietBanKe.MaDichVu,TenDichVu,DonViTinh,DonGia from ChiTietBanKe,DichVu where ChiTietBanKe.MaDichVu=DichVu.MaDichVu and ChiTietBanKe.MaBanKe= @MaBanKe ";
            object[] parameter = { maBanKe};
            return DataProvider.Instance.ExecuteQuery(query, parameter) ;
        }
    }
}
