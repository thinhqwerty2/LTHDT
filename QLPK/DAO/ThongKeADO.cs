using System;
using System.Collections.Generic;
using System.Data;
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

        public DataTable thongKeBenhNhan(DateTime tuNgay,DateTime denNgay)
        {
            string query = "select MaBenhNhan,TenBenhNhan,GioiTinh,NgayKham,BacSi.HoTen,ThanhTien from BenhNhan,HoSoBenhAn,TongHopChiPhi where NgayKham between @TuNgay and @DenNgay and BenhNhan.MaBenhNhan=HoSoBenhAn.MaBenhNhan ";
            object[] parameter = { tuNgay,denNgay};
            return DataProvider.Instance.ExecuteQuery(query, parameter) ;
        }
        public DataTable thongKeDichVu(DateTime tuNgay, DateTime denNgay)
        {
            string query = "select MaDichVu,TenDichVu,DonGia,SoLanSuDung from DichVu where MaDichVu in (select ChiTietBanKe.MaDichVu from ChiTietBanKe,BanKe where ChiTietBanKe.MaBanKe = BanKe.MaBanKe and NgayLapBanKe between @TuNgay and @DenNgay )";
            object[] parameter = { tuNgay, denNgay };
            return DataProvider.Instance.ExecuteQuery(query, parameter);
        }

        public DataTable thongKeBenhAn(string maBenhNhan)
        {
            string query = "select SoBenhAn,NgayKham,ChanDoan,BacSi.HoTen,LoaiBenh from HoSoBenhAn,BenhNhan,Benh,BacSi where HoSoBenhAn.MaBenhNhan=BenhNhan.MaBenhNhan and HoSoBenhAn.MaBacSi=BacSi.MaBacSi and HoSoBenhAn.MaBenh=Benh.MaBenh and (HoSoBenhAn.MaBenhNhan= @MaBenhNhan )"; 
            object[] parameter = { maBenhNhan };
            return DataProvider.Instance.ExecuteQuery(query, parameter);
        }
    }
}
