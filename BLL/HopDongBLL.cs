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
            int daThanhToan = Convert.ToInt32(row["DaThanhToan"]);
            string noiDungHD = row["NoiDungHD"].ToString();
            string tinhTrangHD = row["TinhTrangHD"].ToString();
            string tenNguoiLienHe = row["TenNguoiLienHe"].ToString();
            string diaChi = row["DiaChi"].ToString();
            string sDT = row["SDT"].ToString();
            string mail = row["Mail"].ToString();
            int tienDoHD = Convert.ToInt32(row["TienDoHD"]);

            HopDong hd = new HopDong(mahd, maNV, tenHopDong, tenNguoiDaiDien, ngayBatDau, ngayKetThuc, giaTriHD, mucHoaHong, daThanhToan, noiDungHD,
                tinhTrangHD, tenNguoiLienHe, diaChi, sDT, mail, tienDoHD);

            return hd;
        }

        public static DataTable searchConTract(string searchHopDong, string searchTinhTrang, DateTime searchTimeStart, DateTime searchTimeEnd)
        {
            DataTable dtHopDong = new DataTable();
            DataTable dtTinhTrang = new DataTable();
            DataTable dtTime = new DataTable();
            DataTable mergedDataTable = new DataTable();
            List<DataTable> nonEmptyTables = new List<DataTable>();

            if (!string.IsNullOrEmpty(searchHopDong))
            {
                dtHopDong = HopDongDAO.Instance.searchContractList(searchHopDong);
                
            }

            if (!string.IsNullOrEmpty(searchTinhTrang)) dtTinhTrang = HopDongDAO.Instance.searchContractByTinhTrang(searchTinhTrang);
            if (searchTimeStart != DateTime.MinValue && searchTimeEnd != DateTime.MinValue)
            {
                dtTime = HopDongDAO.Instance.searchContractByTime(searchTimeStart, searchTimeEnd);
            }

            if (dtHopDong.Rows.Count > 0) nonEmptyTables.Add(dtHopDong);
            if (dtTinhTrang.Rows.Count > 0) nonEmptyTables.Add(dtTinhTrang);
            if (dtTime.Rows.Count > 0) nonEmptyTables.Add(dtTime);

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
        public static DataTable loadContractHistory(NguoiDung user)
        {
            return HopDongDAO.Instance.loadContractHistory(user);
        }
    }
}
