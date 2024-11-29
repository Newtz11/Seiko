using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DAO
{
    public class HopDongDAO
    {
        private static HopDongDAO instance;
        public static HopDongDAO Instance
        {
            get { if (instance == null) instance = new HopDongDAO(); return instance; }
            private set { instance = value; }
        }
        private HopDongDAO() { }

        public bool createContract(HopDong hopDong)
        {
            string query = "insert into HOPDONG(MaNV, TenHopDong, TenNguoiDaiDien,NgayKetThuc, GiaTriHD, NoiDungHD, TenNguoiLienHe, DiaChi, SDT, Mail, TienDoHD) " +
                "values ('"+ hopDong.maNV  +"', N'"+ hopDong.tenHD +"', N'"+ hopDong.tenNguoiDaiDien +"','"+ hopDong.ngayKetThuc +"', "+ hopDong.giaTriHD +", N'"+ hopDong.noiDungHD +"', N'"+ hopDong.tenNguoiLienHe +"', N'"+ hopDong.diaChi +"', '"+ hopDong.sDT +"', '"+ hopDong.mail +"', "+ hopDong.tienDoHD +")";
            int rowAffected = DataProvider.Instance.executeNoneQuery(query);
            return rowAffected > 0;
        }

        public DataTable loadContract(NguoiDung user)
        {
            DataTable dt = new DataTable();
            if (user.vaiTro == "Sale")
            {
                string procName = "loadContractTrackingForSale";

                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@MaNV", SqlDbType.NVarChar, 5) { Value = user.maNV } 
                };
                dt = DataProvider.Instance.executeProc(procName, parameters);
            }
            else
            {
                string query = "EXEC loadContractTrackingForAll";
                dt = DataProvider.Instance.executeQuery(query);
                
            }
            
            return dt;
        }

        public DataTable getSeletedContract(string maHD)
        {
            string query = "Select * from HOPDONG where MaHD = '" + maHD +"'";
            DataTable dt = DataProvider.Instance.executeQuery(query);
            return dt;
        }

        public DataTable searchContractList(string name)
        {
            string procName = "searchGlobalOnContractTrackingForSale";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@Keyword", SqlDbType.NVarChar, 50) { Value = name }
            };
            DataTable dt = DataProvider.Instance.executeProc(procName, parameters);

            return dt;
        }

        public DataTable searchContractByTinhTrang(string tinhTrang)
        {
            string procName = "searchTinhTrangHopDongOnContractTrackingForSale";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@TinhTrangHD", SqlDbType.NVarChar, 20) { Value = tinhTrang }
            };
            DataTable dt = DataProvider.Instance.executeProc(procName, parameters);

            return dt;
        }

        public DataTable searchContractByTime(DateTime timeStart, DateTime timeEnd) 
        {
            string procName = "searchContractByTimeOnContractTrackingForSale";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@NgayBatDau", SqlDbType.Date) { Value = (object)timeStart ?? DBNull.Value },
                new SqlParameter("@NgayKetThuc", SqlDbType.Date) { Value = (object)timeEnd ?? DBNull.Value }
            };

            DataTable dt = DataProvider.Instance.executeProc(procName, parameters);

            return dt;
        }




        public DataTable getMaHDMoi()
        {
            string query = "exec getNewestMaHD";
            DataTable dt = DataProvider.Instance.executeQuery(query);
            return dt;
        }


        //

        public DataTable loadContractHistory(NguoiDung user)
        {
            
            DataTable dt = new DataTable();
            if (user.vaiTro == "Sale")
            {
                string procName = "loadContractOnContractHistoryForSale";

                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@MaNV", SqlDbType.NVarChar, 5) { Value = user.maNV }
                };
                dt = DataProvider.Instance.executeProc(procName, parameters);
            }
            else
            {
                string query = "EXEC loadConTractOnContractHistoryForAll";
                dt = DataProvider.Instance.executeQuery(query);

            }

            return dt;
        }


        public DataTable getMaHDMoi()
        {
            string query = "exec getNewestMaHD";
            DataTable dt = DataProvider.Instance.executeQuery(query);
            return dt;
        }

    }
}
