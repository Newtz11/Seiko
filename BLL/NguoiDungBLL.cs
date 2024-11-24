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


        public static DataTable loadUser()
        {
            return NguoiDungDAO.Instance.loadUser();
        }

        public static NguoiDung checkEmail(string checkMail)
        {
            DataTable dt = NguoiDungDAO.Instance.checkMail(checkMail);
            NguoiDung user = new NguoiDung();
            try
            {
                DataRow row = dt.Rows[0];
                string maNV = row["MaNV"].ToString();
                string tenDangNhap = row["TenDangNhap"].ToString();
                string matKhau = row["MatKhau"].ToString();
                string mail = row["Mail"].ToString();
                user = new NguoiDung(maNV, tenDangNhap, matKhau, mail);
            }
            catch (Exception e)
            {
                user = null;
            }
            return user;
        }

        public static bool changePassword(NguoiDung user,string password)
        {
            return NguoiDungDAO.Instance.changePassword(user, password);
        }

        public static DataTable searchUserList(string ten, string phongBan, string chucVu, string tinhTrang)
        {

            DataTable dtTen = new DataTable();
            DataTable dtPhongBan = new DataTable();
            DataTable dtChucVu = new DataTable();
            DataTable dtTinhTrang = new DataTable();
            DataTable mergedDataTable = new DataTable();
            List<DataTable> nonEmptyTables = new List<DataTable>();
            int tinhTrangHd;
            if (!string.IsNullOrEmpty(ten)) dtTen = NguoiDungDAO.Instance.searchUserListByName(ten);
            if (!string.IsNullOrEmpty(phongBan)) dtPhongBan = NguoiDungDAO.Instance.searchUserListByphongBan(phongBan);
            if (!string.IsNullOrEmpty(chucVu)) dtChucVu = NguoiDungDAO.Instance.searchUserListByChucVu(chucVu);
            if (string.IsNullOrEmpty(tinhTrang))
            {
                if (tinhTrang == "Ngưng hoạt động") tinhTrangHd = 0;
                else tinhTrangHd = 1;
                dtTinhTrang = NguoiDungDAO.Instance.searchUserListByTinhTrang(tinhTrangHd);
            }

            if (dtTen.Rows.Count > 0) nonEmptyTables.Add(dtTen);
            if (dtPhongBan.Rows.Count > 0) nonEmptyTables.Add(dtPhongBan);
            if (dtChucVu.Rows.Count > 0) nonEmptyTables.Add(dtChucVu);
            if (dtTinhTrang.Rows.Count > 0) nonEmptyTables.Add(dtTinhTrang);

            // Merge the non-empty DataTables
            if (nonEmptyTables.Count > 0)
            {
                mergedDataTable = nonEmptyTables[0].Clone(); // Clone the structure of the first non-empty DataTable

                foreach (DataRow row in nonEmptyTables[0].Rows)
                {
                    bool isInAllTables = true;
                    foreach (DataTable table in nonEmptyTables.Skip(1))
                    {
                        var matchingRows = table.AsEnumerable().Where(r => r.ItemArray.SequenceEqual(row.ItemArray)).ToArray();
                        if (matchingRows.Length == 0)
                        {
                            isInAllTables = false;
                            break;
                        }
                    }

                    if (isInAllTables)
                    {
                        mergedDataTable.Rows.Add(row.ItemArray);
                    }
                }
            }
            return mergedDataTable;
        }

        //public static bool createAccount(NguoiDung newAccount)
        //{
        //    return NguoiDungDAO.Instance.createAccount(newAccount);
        //}
    }
}
