
using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    public class GiaiDoanThanhToanBLL
    {

        public static DataTable loadPaymentProgress()
        {
            return GiaiDoanThanhToanDAO.Instance.loadPaymentProgress();
        }

        public static DataTable SearchGiaiDoan(string searchGiaiDoan, string searchTrangThai, DateTime searchNgayThanhToan, DateTime searchNgayNhanThanhToan)
        {
            DataTable dtGiaiDoan = new DataTable();
            DataTable dtTrangThai = new DataTable();
            DataTable dtTime = new DataTable();
            DataTable mergedDataTable = new DataTable();
            List<DataTable> nonEmptyTables = new List<DataTable>();
            int trangThaiThanhToan;
            if (!string.IsNullOrEmpty(searchGiaiDoan))
            {
                dtGiaiDoan = GiaiDoanThanhToanDAO.Instance.searchPaymentProgressList(searchGiaiDoan);

            }
            if (string.IsNullOrEmpty(searchTrangThai))
            {
                if (searchTrangThai == "Chưa thanh toán") trangThaiThanhToan = 0;
                else trangThaiThanhToan = 1;
                dtTrangThai = GiaiDoanThanhToanDAO.Instance.searchPaymentProgressByTrangThai(trangThaiThanhToan);
            }
            if (searchNgayThanhToan != DateTime.MinValue && searchNgayNhanThanhToan != DateTime.MinValue)
            {
                dtTime = GiaiDoanThanhToanDAO.Instance.searchPaymentProgressByTime(searchNgayThanhToan, searchNgayNhanThanhToan);
            }


            if (dtGiaiDoan.Rows.Count > 0) nonEmptyTables.Add(dtGiaiDoan);
            if (dtTrangThai.Rows.Count > 0) nonEmptyTables.Add(dtTrangThai);
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

        public static int getGiaiDoanMoi(string maHD)
        {
            DataTable dt = new DataTable();
            dt = GiaiDoanThanhToanDAO.Instance.getGiaiDoanMoi(maHD);
            int giaiDoan = Convert.ToInt32(dt.Rows[0][0]);
            return giaiDoan;
        }

        public static bool createGiaiDoan(GiaiDoanThanhToan giaiDoanMoi)
        {
            return GiaiDoanThanhToanDAO.Instance.createGiaiDoan(giaiDoanMoi);
        }

        public static bool updateGiaiDoan(GiaiDoanThanhToan giaidoanMoi)
        {
            return GiaiDoanThanhToanDAO.Instance.updateGiaiDoan(giaidoanMoi);
        }

        public static DataTable loadThongTinThanhToan(string mHD)
        {
            return GiaiDoanThanhToanDAO.Instance.loadThongTinThanhToan(mHD);
        }

        public static void delGiaiDoanTT(string maHD, string giaiDoan)
        {
            GiaiDoanThanhToanDAO.Instance.delGiaiDoanTT(maHD, giaiDoan);
        }

        public static int checkDelGiaiDoan(string maHD)
        {
            DataTable dt = GiaiDoanThanhToanDAO.Instance.checkDelGiaiDoan(maHD);
            return dt.Rows.Count;
        }
    }
}
