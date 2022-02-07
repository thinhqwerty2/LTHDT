﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLPK.DAO;
using QLPK.DTO;

namespace QLPK.DAO
{
    class BenhNhanDAO
    {
        private static BenhNhanDAO instance;
        public static BenhNhanDAO Instance
        {
            get
            {
                if (instance == null) instance = new BenhNhanDAO();
                return instance;
            }
            private set { instance = value; }
        }
        public BenhNhanDAO()
        {
        }
        public DataTable hienThiDSBenhNhan()
        {
            string query = "select MaBenhNhan,HoTen,GioiTinh,NgaySinh,DiaChi,SDT from BenhNhan";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool suaBenhNhan(string maBenhNhan, string hoTen, string gioiTinh, DateTime ngaySinh, string diaChi, string sdt)
        {
            string query = "update BenhNhan set HoTen = @HoTen ,GioiTinh = @GioiTinh ,NgaySinh = @NgaySinh ,DiaChi = @DiaChi , SDT = @SDT where MaBenhNhan= @MaBenhNhan";
            object[] parameter = { hoTen, gioiTinh, ngaySinh, diaChi, sdt, maBenhNhan };
            return DataProvider.Instance.ExecuteNonQuery(query, parameter) > 0;
        }
        public bool themBenhNhan(string maBenhNhan, string hoTen, string gioiTinh, DateTime ngaySinh, string diaChi, string sdt)
        {
            string query = "insert into BenhNhan (MaBenhNhan,HoTen,GioiTinh,NgaySinh,DiaChi,SDT) values ( @MaBenhNhan , @HoTen , @GioiTinh , @NgaySinh , @DiaChi , @SDT )";
            object[] parameter = { maBenhNhan, hoTen, gioiTinh, ngaySinh,diaChi, sdt };
            return DataProvider.Instance.ExecuteNonQuery(query, parameter) > 0;
        }
        public DataTable timKiemBenhNhan(string key)
        {
            key = $"%{key}%";
            string query= "select MaBenhNhan,HoTen,GioiTinh,NgaySinh,DiaChi,SDT from BenhNhan where (MaBenhNhan like @key1 or HoTen like @key2 or SDT like @key3 )";
            object[] parameter = { key, key, key };
            return DataProvider.Instance.ExecuteQuery(query, parameter);
        }
        public BenhNhanDTO layThongTinBenhNhan(string maBenhNhan)
        {
            return new BenhNhanDTO(DataProvider.Instance.ExecuteQuery("select * from BenhNhan where MaBenhNhan= @MaBenhNhan ",new object[] { maBenhNhan }).Rows[0]);
        }
    }
}
