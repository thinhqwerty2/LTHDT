using System;
using System.Collections.Generic;
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

    }
}
