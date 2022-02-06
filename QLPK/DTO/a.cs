using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPK.DTO
{
<<<<<<< HEAD:QLPK/DTO/BenhNhanDTO.cs
    public class BenhNhanDTO
    {
        private string maBenhNhan;
        public string MaBenhNhan
        {
            get { return maBenhNhan; }
            set { maBenhNhan = value; }
=======
    public class NhanVienDTO
    {
        private string maNhanVien;
        public string MaNhanVien
        {
            get { return maNhanVien; }
            set { maNhanVien = value; }
>>>>>>> d0acfec9fafe86590bd7d212f714637773f7288a:QLPK/DTO/a.cs
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
        private DateTime ngaySinh;
        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
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

<<<<<<< HEAD:QLPK/DTO/BenhNhanDTO.cs
        public BenhNhanDTO(DataRow row)
        {
            this.MaBenhNhan = row["MaBenhNhan"].ToString();
=======
        public NhanVienDTO(DataRow row)
        {
            this.MaNhanVien = row["MaNhanVien"].ToString();
>>>>>>> d0acfec9fafe86590bd7d212f714637773f7288a:QLPK/DTO/a.cs
            this.HoTen = row["HoTen"].ToString();
            this.GioiTinh = row["GioiTinh"].ToString();
            this.NgaySinh = DateTime.Parse(row["NgaySinh"].ToString());
            this.DiaChi = row["DiaChi"].ToString();
            this.SDT = row["SDT"].ToString();
        }
    }
}
