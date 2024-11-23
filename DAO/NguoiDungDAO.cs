using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
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
            string query = "select * from NGUOIDUNG where TenDangNhap = '" + taiKhoan.tenDangNhap + "' and MatKhau = '" + taiKhoan.matKhau + "'";
            DataTable dt = DataProvider.Instance.executeQuery(query);
            return dt.Rows.Count>0;
        }

        public string getVaiTro(NguoiDung taiKhoan) 
        {
            string query = "select VaiTro from NGUOIDUNG where TenDangNhap = '" + taiKhoan.tenDangNhap + "' and MatKhau = '" + taiKhoan.matKhau + "'";
            DataTable dt = DataProvider.Instance.executeQuery(query);
            return dt.Rows[0]["VaiTro"].ToString();
        }

        public DataTable getUser(NguoiDung taiKhoan)
        {
            string query = "select * from NGUOIDUNG where TenDangNhap = '" + taiKhoan.tenDangNhap + "' and MatKhau = '" + taiKhoan.matKhau + "'";
            DataTable dt = DataProvider.Instance.executeQuery(query);
            return dt;
        }


        public DataTable searchName(string name)
        {
            string query = "select MaNV as #, HoTen as [Tên Người Dùng], PhongBan as [Phòng Ban]" +
                " from NGUOIDUNG where HoTen LIKE '" + name + "%';";
            DataTable dt = DataProvider.Instance.executeQuery(query);
            return dt;
        }

        public DataTable loadUser()
        {
            string query = "select TenDangNhap as [Tên Đăng Nhập], mail as [Email], HoTen as [Tên người dùng]," +
                "MaNV as [Mã người dùng], PhongBan as [Phòng ban], VaiTro as [Chức vụ], TinhTrangHoatDong as [Tình trạng] from NGUOIDUNG";
            DataTable dt = DataProvider.Instance.executeQuery(query);
            return dt;
        }
    }
}
