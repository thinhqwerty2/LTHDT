using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPK.DTO
{
    public class BacSiDTO
    {
        private string maBacSi;
        public string MaBacSi
        {
            get { return maBacSi; }
            set { maBacSi = value; }
        }
        private string hoTen;
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        private string gioiTinh;
        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }
        private string trinhDo;
        public string TrinhDo
        {
            get { return trinhDo; }
            set { trinhDo = value; }
        }
        private string chucVu;
        public string ChucVu
        {
            get { return chucVu; }
            set { chucVu = value; }
        }
        private string diaChi;
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        private string sdt;
        public string SDT
        {
            get { return sdt; }
            set { sdt = value; }
        }



        public BacSiDTO(DataRow row)
        {
            this.MaBacSi = row["MaBacSi"].ToString();
            this.HoTen = row["HoTen"].ToString();
            this.GioiTinh = row["GioiTinh"].ToString();
            this.TrinhDo = row["TrinhDo"].ToString();
            this.ChucVu = row["ChucVu"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.SDT = row["SDT"].ToString();
        }
    }
}
