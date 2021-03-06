using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPK.DTO
{
    public class BacSiNhanVienDTO
    {
        private string maBacSiNhanVien;
        public string MaBacSiNhanVien
        {
            get { return maBacSiNhanVien; }
            set { maBacSiNhanVien = value; }
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
        private string trinhDo;
        public string TrinhDo
        {
            get { return trinhDo; }
            set { trinhDo = value; }
        }

        public BacSiNhanVienDTO(DataRow row)
        {
            this.MaBacSiNhanVien = row[0].ToString();
            this.HoTen = row["HoTen"].ToString();
            this.GioiTinh = row["GioiTinh"].ToString();
            this.ChucVu = row["ChucVu"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.SDT = row["SDT"].ToString();
            try
            {
                this.TrinhDo = row["TrinhDo"].ToString();
            }
            catch
            {
            }
        }
    }
}
