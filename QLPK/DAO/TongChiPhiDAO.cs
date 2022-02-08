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
        public double tinhTongTien(string maBanKe)
        {
           return (double)DataProvider.Instance.ExecuteScalar("select sum(DonGia) from ChiTietBanKe,DichVu where ChiTietBanKe.MaDichVu=DichVu.MaDichVu and ChiTietBanKe.MaBanKe= @MaBanKe ", new object[] {maBanKe});
        }
        public double tinhTienTamUng(string maBanKe)
        {
            return (double)DataProvider.Instance.ExecuteQuery("select SoTienThuTamUng from PhieuThuTienTamUng,BanKe where BanKe.MaBanKe=PhieuThuTienTamUng.MaBanKe ", new object[] { maBanKe }).Rows[0][0];
        }
        public bool themTongHopChiPhi(double thanhTien,DateTime ngayThanhToan,string maPhieuThuTienTamUng,string maNhanVien)
        {
            string query = "insert into TongHopChiPhi (MaPhieuThuTienTamUng,MaNhanVien,ThanhTien,NgayThanhToan) values ( @MaPhieuThuTienTamUng , @MaNhanVien , @ThanhTien , @NgayThanhToan )";
            object[] parameter = { maPhieuThuTienTamUng,maNhanVien,thanhTien,ngayThanhToan };
            return DataProvider.Instance.ExecuteNonQuery(query, parameter) > 0;
        }
        public string layMaPhieuThuTienTamUng(string maBanKe)
        {
            return DataProvider.Instance.ExecuteQuery("select MaPhieuThuTienTamUng from PhieuThuTienTamUng,BanKe where BanKe.MaBanKe=PhieuThuTienTamUng.MaBanKe ", new object[] { maBanKe }).Rows[0][0].ToString();

        }
    }
}
