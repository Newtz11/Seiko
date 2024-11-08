﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;


namespace DAO
{
    public class NguoiDungDAO
    {
        private static NguoiDungDAO instance;
        public static NguoiDungDAO Instance
        {
            get { if (instance == null) instance = new NguoiDungDAO(); return instance; }
            private set { instance = value; }
        }
        private NguoiDungDAO() { }
        public bool checkTaiKhoanDangNhap(NguoiDung taiKhoan)
        {
            string query = "select * from NGUOIDUNG where MaNV = '" + taiKhoan.maNV + "' and MatKhau = '" + taiKhoan.matKhau + "'";
            DataTable dt = DataProvider.Instance.executeQuery(query);
            return dt.Rows.Count>0;
        }

        public string getVaiTro(NguoiDung taiKhoan) 
        {
            string query = "select VaiTro from NGUOIDUNG where MaNV = '" + taiKhoan.maNV + "' and MatKhau = '" + taiKhoan.matKhau + "'";
            DataTable dt = DataProvider.Instance.executeQuery(query);
            return dt.Rows[0]["VaiTro"].ToString();
        }
        public DataTable searchName(string name)
        {
            string query = "select MaNV as #, HoTen as [Tên Người Dùng], PhongBan as [Phòng Ban]" +
                " from NGUOIDUNG where HoTen LIKE '" + name + "%';";
            DataTable dt = DataProvider.Instance.executeQuery(query);
            return dt;
        }
    }
}
