using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPK.DTO
{
    public class NguoiDungDTO
    {

        private string tenDangNhap;
        public string TenDangNhap
        {
            get { return tenDangNhap; }
            set { tenDangNhap= value; }
        }
        private string hoTen;
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        private int quyenTruyCap;
        public int QuyenTruyCap
        {
            get { return quyenTruyCap; }
            set { quyenTruyCap = value; }
        }
  
        public NguoiDungDTO(DataRow row)
        {
            this.TenDangNhap = row["TenDangNhap"].ToString();
            //this.HoTen = row["HoTen"].ToString();
            this.QuyenTruyCap = Convert.ToInt32(row["QuyenTruyCap"].ToString());
        }
    }
}
