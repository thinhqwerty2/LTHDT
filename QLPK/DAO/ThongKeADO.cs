using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPK.DAO
{
    class ThongKeADO
    {
        private static ThongKeADO instance;
        public static ThongKeADO Instance
        {
            get
            {
                if (instance == null) instance = new ThongKeADO();
                return instance;
            }
            private set { instance = value; }
        }

        public DataTable thongKeBenhNhan(DateTime tuNgay,DateTime denNgay)
        {
            string query = "select * from BenhNhan,HoSoBenhAn where NgayKham between @TuNgay and @DenNgay and BenhNhan.MaBenhNhan=HoSoBenhAn.MaBenhNhan ";
            object[] parameter = { tuNgay,denNgay};
            return DataProvider.Instance.ExecuteQuery(query, parameter) ;
        }
        public DataTable thongKeDichVu(DateTime tuNgay, DateTime denNgay)
        {
            string query = "select * from BenhNhan,HoSoBenhAn where NgayKham between @TuNgay and @DenNgay and BenhNhan.MaBenhNhan=HoSoBenhAn.MaBenhNhan ";
            object[] parameter = { tuNgay, denNgay };
            return DataProvider.Instance.ExecuteQuery(query, parameter);
        }
    }
}
