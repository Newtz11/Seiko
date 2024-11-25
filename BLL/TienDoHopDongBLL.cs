using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;


namespace BLL
{
    public class TienDoHopDongBLL
    {
        public static void createContractProcess(TienDoHopDong td)
        {
            TienDoHopDongDAO.Instance.createContractProcess(td);
        }

        public static DataTable loadProjectProgress(NguoiDung user)
        {
            return TienDoHopDongDAO.Instance.loadProjectProgress(user);
        }

        public static DataTable searchProjectProgressList(string searchContract, string searchTinhTrang, string searchNguoiThucHien, DateTime searchNgayBatDau, DateTime searchNgayKetThuc)
        {
            DataTable dtHopDong = new DataTable();
            DataTable dtTinhTrang = new DataTable();
            DataTable dtNguoiThucHien = new DataTable();
            DataTable dtTime = new DataTable();
            DataTable mergedDataTable = new DataTable();
            //List<DataTable> nonEmptyTables = new List<DataTable>();
            //int tinhTrangHd;
            //if (!string.IsNullOrEmpty(searchContract))
            //{
            //    dtHopDong = NguoiDungDAO.Instance.searchUserListByName(searchContract);
            //}
            //if (!string.IsNullOrEmpty(phongBan)) dtPhongBan = NguoiDungDAO.Instance.searchUserListByPhongBan(phongBan);
            //if (!string.IsNullOrEmpty(chucVu)) dtChucVu = NguoiDungDAO.Instance.searchUserListByChucVu(chucVu);
            //if (string.IsNullOrEmpty(tinhTrang))
            //{
            //    if (tinhTrang == "Ngưng hoạt động") tinhTrangHd = 0;
            //    else tinhTrangHd = 1;
            //    dtTinhTrang = NguoiDungDAO.Instance.searchUserListByTinhTrang(tinhTrangHd);
            //}

            //if (dtTen.Rows.Count > 0) nonEmptyTables.Add(dtTen);
            //if (dtPhongBan.Rows.Count > 0) nonEmptyTables.Add(dtPhongBan);
            //if (dtChucVu.Rows.Count > 0) nonEmptyTables.Add(dtChucVu);
            //if (dtTinhTrang.Rows.Count > 0) nonEmptyTables.Add(dtTinhTrang);

            //// Merge the non-empty DataTables
            //if (nonEmptyTables.Count > 0)
            //{
            //    mergedDataTable = nonEmptyTables[0].Clone(); // Clone the structure of the first non-empty DataTable

            //    foreach (DataRow row in nonEmptyTables[0].Rows)
            //    {
            //        bool isInAllTables = true;
            //        foreach (DataTable table in nonEmptyTables.Skip(1))
            //        {
            //            var matchingRows = table.AsEnumerable().Where(r => r.ItemArray.SequenceEqual(row.ItemArray)).ToArray();
            //            if (matchingRows.Length == 0)
            //            {
            //                isInAllTables = false;
            //                break;
            //            }
            //        }

            //        if (isInAllTables)
            //        {
            //            mergedDataTable.Rows.Add(row.ItemArray);
            //        }
            //    }
            //}
            return mergedDataTable;
        }
    }
}
