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
