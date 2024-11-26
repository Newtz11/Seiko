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
    public class TienDoHopDongDAO
    {

        private static TienDoHopDongDAO instance;
        public static TienDoHopDongDAO Instance
        {
            get { if (instance == null) instance = new TienDoHopDongDAO(); return instance; }
            private set { instance = value; }
        }
        private TienDoHopDongDAO() { }

        public void createContractProcess(TienDoHopDong td)
        {
            DataTable dt = new DataTable();
            string procName = "insertProgress";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@NgayBatDau", SqlDbType.Date) { Value = td.ngayBatDau },
                new SqlParameter("@NgayKetThuc", SqlDbType.Date) { Value = td.ngayKetThuc },
                new SqlParameter("@MaNV", SqlDbType.NVarChar, 5) { Value = td.maNV },
                new SqlParameter("@NVThucHienCV", SqlDbType.NVarChar, 50) { Value = td.nhanVienThucHienCV },
                new SqlParameter("@NoiDungCV", SqlDbType.NVarChar, 50) { Value = td.noiDungCV }
            };
            dt = DataProvider.Instance.executeProc(procName, parameters); 
            
        }

        public DataTable loadProjectProgress(NguoiDung user)
        {
            DataTable dt = new DataTable();
            if (user.vaiTro == "Sale")
            {
                string procName = "loadProjectProgressForSale";

                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@MaNV", SqlDbType.NVarChar, 5) { Value = user.maNV } 
                };
                dt = DataProvider.Instance.executeProc(procName, parameters);
            }
            else
            {
                string query = "EXEC loadProjectProgressForAll";
                dt = DataProvider.Instance.executeQuery(query);
            }
            
            return dt;
        }

        public DataTable searchContractList(string searchContract)
        {
            string procName = "searchGlobalOnProjectProgress";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@Keyword", SqlDbType.NVarChar, 50) { Value = searchContract }
            };
            DataTable dt = DataProvider.Instance.executeProc(procName, parameters);

            return dt;
        }

        public DataTable searchContractListByTinhTrang(string searchTinhTrang)
        {
            string procName = "searchTinhTrangHopDongOnProjectProgress";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@TinhTrangHD", SqlDbType.NVarChar, 20) { Value = searchTinhTrang }
            };
            DataTable dt = DataProvider.Instance.executeProc(procName, parameters);

            return dt;
        }

        public DataTable searchContractListByTime(DateTime searchNgayBatDau, DateTime searchNgayKetThuc)
        {
            string procName = "searchTimeOnProjectProgress";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@NgayBatDau", SqlDbType.Date) { Value = (object)searchNgayBatDau ?? DBNull.Value },
                new SqlParameter("@NgayKetThuc", SqlDbType.Date) { Value = (object)searchNgayKetThuc ?? DBNull.Value }
            };

            DataTable dt = DataProvider.Instance.executeProc(procName, parameters);

            return dt;
        }


        public DataTable suaDGVProjectProgress()
        {
            string query = "select MaTienDoHopDong from TienDoHopDong";
            DataTable dt = DataProvider.Instance.executeQuery(query);
            return dt;
        }

        public void updateProjectProgress(string maTienDo, string nvThucHienCV, int tongKL, int tienDo)
        {
            string procName = "changeProjectProgress";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@MaTienDoHopDong", SqlDbType.NVarChar, 5) { Value = maTienDo },
                new SqlParameter("@NVThucHienCV", SqlDbType.NVarChar, 50) { Value = nvThucHienCV },
                new SqlParameter("@KhoiLuongCV", SqlDbType.Int) { Value = tienDo},
                new SqlParameter("@TongKhoiLuongCV", SqlDbType.Int) { Value = tongKL}
                
            };

            DataProvider.Instance.executeProc(procName, parameters);

        }
    }
}
