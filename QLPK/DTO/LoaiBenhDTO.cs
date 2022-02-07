using System;
using System.Data;

namespace QLPK.DTO
{


    public class LoaiBenhDTO
    {
        private string maBenh;

        public string MaBenh
        {
            get { return maBenh; }
            set { maBenh = value; }
        }

        private string loaiBenh;
        public string LoaiBenh
        {
            get { return loaiBenh; }
            set { loaiBenh = value; }
        }
        private string moTaBenh;
        public string MoTaBenh
        {
            get { return moTaBenh; }
            set { moTaBenh = value; }
        }

        public LoaiBenhDTO(DataRow row)
        {
            this.MaBenh = row["MaBenh"].ToString();
            this.LoaiBenh = row["LoaiBenh"].ToString();
            this.MoTaBenh = row["MoTaBenh"].ToString();

        }
    }
}
