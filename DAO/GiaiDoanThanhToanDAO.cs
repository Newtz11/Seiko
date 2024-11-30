
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using DTO;



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

        public DataTable loadPaymentProgress()
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

        public DataTable getGiaiDoanMoi(string maHD)
        {
            string procName = "getNewStage";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@MaHD", SqlDbType.NVarChar, 5) { Value = maHD }
            };
            DataTable dt = DataProvider.Instance.executeProc(procName, parameters);
            return  dt;
        }

        public bool createGiaiDoan(GiaiDoanThanhToan giaiDoanMoi)
        {
            bool result = false;
            try
            {
                string procName = "createPaymentProgress";

                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@MaHD", SqlDbType.NVarChar, 5) { Value = giaiDoanMoi.maHD },
                    new SqlParameter("@GiaiDoan", SqlDbType.Int) { Value = giaiDoanMoi.giaiDoan },
                    new SqlParameter("@NgayThanhToan", SqlDbType.Date) { Value = giaiDoanMoi.ngayThanhToan },
                    new SqlParameter("@PhanTramThanhToan", SqlDbType.Int) { Value = giaiDoanMoi.phanTramThanhToan },
                    new SqlParameter("@GiaTriThanhToan", SqlDbType.Int) { Value = giaiDoanMoi.giaTriThanhToan },
                    new SqlParameter("@NgayNhanThanhToan", SqlDbType.Date) { Value = giaiDoanMoi.ngayNhanThanhToan },
                    new SqlParameter("@GhiChu", SqlDbType.NVarChar, 100) { Value = giaiDoanMoi.ghiChu },
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

        public bool updateGiaiDoan(GiaiDoanThanhToan giaidoanMoi)
        {
            bool result = false;
            try
            {
                string procName = "updatePaymentProgress";

                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@MaHD", SqlDbType.NVarChar, 5) { Value = giaidoanMoi.maHD },
                    new SqlParameter("@GiaiDoan", SqlDbType.Int) { Value = giaidoanMoi.giaiDoan },
                    new SqlParameter("@NgayThanhToan", SqlDbType.Date) { Value = giaidoanMoi.ngayThanhToan },
                    new SqlParameter("@PhanTramThanhToan", SqlDbType.Int) { Value = giaidoanMoi.phanTramThanhToan },
                    new SqlParameter("@GiaTriThanhToan", SqlDbType.Int) { Value = giaidoanMoi.giaTriThanhToan },
                    new SqlParameter("@TrangThaiThanhToan", SqlDbType.Bit) { Value = giaidoanMoi.trangThaiThanhToan },
                    new SqlParameter("@NgayNhanThanhToan", SqlDbType.Date) { Value = giaidoanMoi.ngayNhanThanhToan },
                    new SqlParameter("@GhiChu", SqlDbType.NVarChar, 100) { Value = giaidoanMoi.ghiChu },
                };
                DataTable dt = DataProvider.Instance.executeProc(procName, parameters);
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
                Console.WriteLine(ex.Message);
            }

            return result;
        }

        public DataTable loadThongTinThanhToan(string mHD)
        {
            DataTable dt = new DataTable();
            string query = "EXEC loadThongTinThanhToan @MaHD = '" + mHD + "'";
            dt = DataProvider.Instance.executeQuery(query);
            return dt;
        }

        public void delGiaiDoanTT(string maHD, string giaiDoan)
        {
            string procName = "delGiaiDoan";

            List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@MaHD", SqlDbType.NVarChar, 5) { Value = maHD },
                    new SqlParameter("@GiaiDoan", SqlDbType.Int) { Value = giaiDoan }
                };
            DataTable dt = DataProvider.Instance.executeProc(procName, parameters);
        }

        public DataTable checkDelGiaiDoan(string maHD)
        {
            string query = "select * from GIAIDOANTHANHTOAN where MaHD = '" + maHD + "'";
            DataTable dt = DataProvider.Instance.executeQuery(query);
            return dt;
        }
    }
}
