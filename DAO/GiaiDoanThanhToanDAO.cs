using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class GiaiDoanThanhToanDAO
    {
        private static GiaiDoanThanhToanDAO instance;
        public static GiaiDoanThanhToanDAO Instance
        {
            get { if (instance == null) instance = new GiaiDoanThanhToanDAO(); return instance; }
            private set { instance = value; }
        }
        private GiaiDoanThanhToanDAO() { }

        public DataTable loadPaymentProgress(GiaiDoanThanhToan giaiDoan)
        {
            DataTable dt = new DataTable();
            string query = "EXEC loadPaymentProgress";
            dt = DataProvider.Instance.executeQuery(query);
            return dt;
        }

        public DataTable searchPaymentProgressList(string searchGiaiDoan)
        {
            string procName = "searchGlobalOnPaymentProgress";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@Keyword", SqlDbType.NVarChar, 50) { Value = searchGiaiDoan }
            };
            DataTable dt = DataProvider.Instance.executeProc(procName, parameters);

            return dt;
        }

        public DataTable searchPaymentProgressByTrangThai(int searchTrangThai)
        {
            string procName = "searchTrangThaiOnPaymentProgress";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@TrangThaiThanhToan", SqlDbType.Bit) { Value = searchTrangThai }
            };
            DataTable dt = DataProvider.Instance.executeProc(procName, parameters);

            return dt;
        }

        public DataTable searchPaymentProgressByTime(DateTime searchNgayThanhToan, DateTime searchNgayNhanThanhToan)
        {
            string procName = "searchTimeOnPaymentProgress";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@NgayThanhToan", SqlDbType.Date) { Value = (object)searchNgayThanhToan ?? DBNull.Value },
                new SqlParameter("@NgayNhanThanhToan", SqlDbType.Date) { Value = (object)searchNgayNhanThanhToan ?? DBNull.Value }
            };

            DataTable dt = DataProvider.Instance.executeProc(procName, parameters);

            return dt;
        }
    }
}
