using System;
using System.Data;

namespace QLPK.DTO
{


   public class DichVuDTO
    {
        private string maDichVu;

        public string MaDichVu
        {
            get { return maDichVu; }
            set { maDichVu = value; }
        }

        private string tenDichVu;
        public string TenDichVu
        {
            get { return tenDichVu; }
            set { tenDichVu = value; }
        }
        private double donGia;
        public double DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }
        
        private string donViTinh;
        public string DonViTinh
        {
            get { return donViTinh; }
            set { donViTinh = value; }
        }
        private string ghiChu;
        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }
        private int soLanSuDung;
        public int SoLanSuDung
        {
            get { return soLanSuDung; }
            set { soLanSuDung = value; }
        }
        public DichVuDTO(DataRow row)
        {
            this.MaDichVu = row["MaDichVu"].ToString();
            this.TenDichVu = row["TenDichVu"].ToString();
            this.DonGia =Convert.ToDouble( row["DonGia"].ToString());
            this.DonViTinh = row["DonViTinh"].ToString();
            this.GhiChu = row["GhiChu"].ToString();
            this.SoLanSuDung = Convert.ToInt32(row["SoLanSuDung"].ToString());
        }
    }
}
