using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

        public DataTable checkMail(string mail) 
        {
            string query = "select MaNV, TenDangNhap, MatKhau, Mail from NGUOIDUNG where Mail = '" + mail + "'";
            DataTable dt = DataProvider.Instance.executeQuery(query);
            return dt;
        }

        public bool changePassword(NguoiDung user, string password) 
        {
            
            bool result = false;
            try
            {
                string procName = "changePassword";

                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@MaNV", SqlDbType.NVarChar, 5) { Value = user.maNV },
                    new SqlParameter("@MatKhauMoi", SqlDbType.NVarChar, 20) { Value = password }
                };
                DataTable dt = DataProvider.Instance.executeProc(procName, parameters);
                result = true;
            }
            catch (Exception ex) 
            {
                result = false;
            }
            
            return result;
        }

        public DataTable searchUserListByName(string name)
        {
            string procName = "searchNameOnListUser";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@MaNV", SqlDbType.NVarChar, 5) { Value = name },
                new SqlParameter("@HoTen", SqlDbType.NVarChar, 50) { Value = name },
                new SqlParameter("@Mail", SqlDbType.NVarChar, 50) { Value = name },
                new SqlParameter("@TenDangNhap", SqlDbType.NVarChar, 50) { Value = name }

            };
            DataTable dt = DataProvider.Instance.executeProc(procName, parameters);

            return dt;
        }

        public DataTable searchUserListByphongBan(string phongBan)
        {
            string procName = "searchPhongBanOnListUser";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@PhongBan", SqlDbType.NVarChar, 20) { Value = phongBan }

            };
            DataTable dt = DataProvider.Instance.executeProc(procName, parameters);

            return dt;
        }

        public DataTable searchUserListByChucVu(string chucVu)
        {
            string procName = "searchChucVuOnListUser";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@VaiTro", SqlDbType.NVarChar, 20) { Value = chucVu }

            };
            DataTable dt = DataProvider.Instance.executeProc(procName, parameters);

            return dt;
        }


        public DataTable searchUserListByTinhTrang(int tinhTrang)
        {
            string procName = "searchTinhTrangHoatDongOnListUser";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@VaiTro", SqlDbType.Bit) { Value = tinhTrang }

            };
            DataTable dt = DataProvider.Instance.executeProc(procName, parameters);

            return dt;
        }
    }
}
