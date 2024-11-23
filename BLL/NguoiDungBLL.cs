using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;


namespace BLL
{
    public class NguoiDungBLL
    {
        public static bool checkTaiKhoan(NguoiDung taiKhoan)
        {
            return NguoiDungDAO.Instance.checkTaiKhoanDangNhap(taiKhoan);
        }

        public static string getVaiTro(NguoiDung taiKhoan)
        {
            return NguoiDungDAO.Instance.getVaiTro(taiKhoan);
        }

        public static NguoiDung getUser(NguoiDung taiKhoan)
        {
            DataTable userInfo = NguoiDungDAO.Instance.getUser(taiKhoan);
            DataRow row = userInfo.Rows[0];
            string maNV = row["MaNV"].ToString();
            string tenDangNhap = row["TenDangNhap"].ToString();
            string hoTen = row["HoTen"].ToString();
            bool gioiTinh = (bool)row["GioiTinh"];
            DateTime rawNgaySinh = (DateTime)row["NgaySinh"];
            string ngaySinh = rawNgaySinh.ToString("dd/MM/yyyy"); 
            string matKhau = row["MatKhau"].ToString();
            string mail = row["Mail"].ToString();
            string vaiTro = row["VaiTro"].ToString();
            string sDT = row["SDT"].ToString();
            string phongBan = row["PhongBan"].ToString();
            DateTime rawNgayVaoLam = (DateTime)row["NgayVaoLam"];
            string ngayVaoLam = rawNgayVaoLam.ToString("dd/MM/yyyy");
            string diaChi = row["DiaChi"].ToString();
            bool tinhTrangHoatDong = (bool)row["TinhTrangHoatDong"];
            NguoiDung user = new NguoiDung(maNV, tenDangNhap, hoTen, gioiTinh, ngaySinh, matKhau, mail, vaiTro, sDT, 
                phongBan, ngayVaoLam, diaChi, tinhTrangHoatDong);
            return user;
        }

        public static DataTable searchName(string hoTen)
        {
            return NguoiDungDAO.Instance.searchName(hoTen);
        }


        public static DataTable searchUser()
        {
            return NguoiDungDAO.Instance.searchUser();
        }
    }
}
