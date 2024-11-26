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

        public static DataTable searchProjectProgressList(string searchContract, string searchTinhTrang, DateTime searchNgayBatDau, DateTime searchNgayKetThuc)
        {
            DataTable dtHopDong = new DataTable();
            DataTable dtTinhTrang = new DataTable();
            DataTable dtNguoiThucHien = new DataTable();
            DataTable dtTime = new DataTable();
            DataTable mergedDataTable = new DataTable();
            List<DataTable> nonEmptyTables = new List<DataTable>();
            if (!string.IsNullOrEmpty(searchContract))
            {
                dtHopDong = TienDoHopDongDAO.Instance.searchContractList(searchContract);
            }
            if (!string.IsNullOrEmpty(searchTinhTrang)) dtTinhTrang = TienDoHopDongDAO.Instance.searchContractListByTinhTrang(searchTinhTrang);
            if (searchNgayBatDau != DateTime.MinValue && searchNgayKetThuc != DateTime.MinValue)
            {
                dtTime = TienDoHopDongDAO.Instance.searchContractListByTime(searchNgayBatDau, searchNgayKetThuc);
            }

            if (dtHopDong.Rows.Count > 0) nonEmptyTables.Add(dtHopDong);
            if (dtTinhTrang.Rows.Count > 0) nonEmptyTables.Add(dtTinhTrang);
            if (dtNguoiThucHien.Rows.Count > 0) nonEmptyTables.Add(dtNguoiThucHien);
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


        public static DataTable suaDGVProjectProgress(DataTable dtNew)
        {
            DataTable dtOld = TienDoHopDongDAO.Instance.suaDGVProjectProgress();
            DataTable dt =  new DataTable();
            foreach (DataRow row in dtOld.Rows) 
            {
                foreach(DataRow row2 in dtNew.Rows)
                {
                    if (row[0] == row2[9])
                    {
                        //trung lay du lieu tu bang moi va luu vao database
                        string maTienDo = row2[9].ToString();
                        string nvThucHienCV = row2[7].ToString().Trim();
                        int khoiLuongCV = Convert.ToInt32(row2[3].ToString());
                        int tienDo = Convert.ToInt32(row2[6].ToString());
                        TienDoHopDongDAO.Instance.updateProjectProgress(maTienDo, nvThucHienCV, khoiLuongCV, tienDo);
                    }
                }

            }




            return dtNew;
        }
    }
}
