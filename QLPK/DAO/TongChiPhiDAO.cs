using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPK.DAO
{
    class TongChiPhiDAO
    {
        private static TongChiPhiDAO instance;
        public static TongChiPhiDAO Instance
        {
            get
            {
                if (instance == null) instance = new TongChiPhiDAO();
                return instance;
            }
            private set { instance = value; }
        }
    }
}
