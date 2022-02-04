using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPK.DAO
{
    public class BenhNhanDAO
    {
        private static BenhNhanDAO instance;
        public static BenhNhanDAO Instance
        {
            get
            {
                if (instance == null) instance = new BenhNhanDAO();
                return instance;
            }
            private set { instance = value; }
        }
        public BenhNhanDAO()
        {
        }
        public DataTable hienThiDSBenhNhan()
        {
            return DataProvider.Instance.ExecuteQuery("select MaBenhNhan from BenhNhan");
        }

    }
}
