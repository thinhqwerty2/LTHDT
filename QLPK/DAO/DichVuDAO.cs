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
            return DataProvider.Instance.ExecuteQuery("select * from DichVu");
        }
    }
}
