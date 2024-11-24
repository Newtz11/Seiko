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
    public class HopDongBLL
    {
        public static bool createContract(HopDong hopDongMoi)
        {
            return HopDongDAO.Instance.createContract(hopDongMoi);
        }

        public static DataTable loadContract(NguoiDung user)
        {
            return HopDongDAO.Instance.loadContract(user);
        }

        public static HopDong getSeletedContract(string maHD) 
        {
            DataTable dt = HopDongDAO.Instance.getSeletedContract(maHD);
            DataRow row = dt.Rows[0];

            string mahd = row["MaHD"].ToString();
            string maNV = row["MaNV"].ToString();
            string tenHopDong = row["TenHopDong"].ToString();
            string tenNguoiDaiDien = row["TenNguoiDaiDien"].ToString();
            DateTime ngayBatDau = (DateTime)row["NgayBatDau"];
            DateTime ngayKetThuc = (DateTime)row["NgayKetThuc"];
            int giaTriHD = Convert.ToInt32(row["GiaTriHD"].ToString());
            int mucHoaHong = Convert.ToInt32(row["MucHoaHong"]);
            string chiaGiaiDoan = row["ChiaGiaiDoan"].ToString();
            int daThanhToan = Convert.ToInt32(row["DaThanhToan"]);
            string noiDungHD = row["NoiDungHD"].ToString();
            string tinhTrangHD = row["TinhTrangHD"].ToString();
            string tenNguoiLienHe = row["TenNguoiLienHe"].ToString();
            string diaChi = row["DiaChi"].ToString();
            string sDT = row["SDT"].ToString();
            string mail = row["Mail"].ToString();
            int tienDoHD = Convert.ToInt32(row["TienDoHD"]);
            string nhanVienThanhToan = row["NhanVienThanhToan"].ToString();

            HopDong hd = new HopDong(mahd, maNV, tenHopDong, tenNguoiDaiDien, ngayBatDau, ngayKetThuc, giaTriHD, mucHoaHong, chiaGiaiDoan, daThanhToan, noiDungHD,
                tinhTrangHD, tenNguoiLienHe, diaChi, sDT, mail, tienDoHD, nhanVienThanhToan);

            return hd;
        }
    }
}
