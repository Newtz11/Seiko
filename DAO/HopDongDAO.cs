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
            string query = "insert into HOPDONG(MaNV, TenHopDong, TenNguoiDaiDien, NgayBatDau, NgayKetThuc, GiaTriHD, NoiDungHD, TenNguoiLienHe, DiaChi, SDT, Mail) " +
                "values ('"+ hopDong.maNV  +"', N'"+ hopDong.tenHD +"', N'"+ hopDong.tenNguoiDaiDien +"','"+ hopDong.ngayBatDau +"','"+ hopDong.ngayKetThuc +"', "+ 
                hopDong.giaTriHD +", N'"+ hopDong.noiDungHD +"', N'"+ hopDong.tenNguoiLienHe +"', N'"+ hopDong.diaChi +"', '"+ hopDong.sDT +"', '"+ hopDong.mail +"')";
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

        public DataTable searchContractList(string name, NguoiDung user)
        {
            DataTable dt = new DataTable();
            if (user.vaiTro == "Sale")
            {
                string procName = "searchGlobalOnContractTrackingForSaleOnly";

                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@Keyword", SqlDbType.NVarChar, 50) { Value = name },
                    new SqlParameter("@MaNV", SqlDbType.NVarChar, 5) { Value = user.maNV }
                };
                dt = DataProvider.Instance.executeProc(procName, parameters);
            }
            else
            {
                string procName = "searchGlobalOnContractTrackingForSale";

                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@Keyword", SqlDbType.NVarChar, 50) { Value = name }
                };
                dt = DataProvider.Instance.executeProc(procName, parameters);
            }
            return dt;
        }

        public DataTable searchContractByTinhTrang(string tinhTrang, NguoiDung user)
        {
            DataTable dt = new DataTable();
            if (user.vaiTro == "Sale")
            {
                string procName = "searchTinhTrangHopDongOnContractTrackingForSaleOnly";

                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@TinhTrangHD", SqlDbType.NVarChar, 20) { Value = tinhTrang },
                    new SqlParameter("@MaNV", SqlDbType.NVarChar, 5) { Value = user.maNV }
                };
                dt = DataProvider.Instance.executeProc(procName, parameters);
            }
            else
            {
                string procName = "searchTinhTrangHopDongOnContractTrackingForSale";

                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@TinhTrangHD", SqlDbType.NVarChar, 20) { Value = tinhTrang }
                };
                dt = DataProvider.Instance.executeProc(procName, parameters);
            }

            return dt;
        }

        public DataTable searchContractByTime(DateTime timeStart, DateTime timeEnd, NguoiDung user) 
        {
            DataTable dt = new DataTable();
            if(user.vaiTro == "Sale")
            {
                string procName = "searchContractByTimeOnContractTrackingForSaleOnly";

                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@NgayBatDau", SqlDbType.Date) { Value = (object)timeStart ?? DBNull.Value },
                    new SqlParameter("@NgayKetThuc", SqlDbType.Date) { Value = (object)timeEnd ?? DBNull.Value },
                    new SqlParameter("@MaNV", SqlDbType.NVarChar, 5) { Value = user.maNV }
                };

                dt = DataProvider.Instance.executeProc(procName, parameters);
            }
            else
            {
                string procName = "searchContractByTimeOnContractTrackingForSale";

                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@NgayBatDau", SqlDbType.Date) { Value = (object)timeStart ?? DBNull.Value },
                    new SqlParameter("@NgayKetThuc", SqlDbType.Date) { Value = (object)timeEnd ?? DBNull.Value }
                };

                dt = DataProvider.Instance.executeProc(procName, parameters);
            }

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

        public void delContract(string maHD)
        {
            string query1 = "delete from TIENDOHOPDONG WHERE MaHD = '" + maHD + "'";
            string query2 = "delete from GIAIDOANTHANHTOAN WHERE MaHD = '" + maHD + "'";
            string query3 = "delete from HOPDONG WHERE MaHD = '" + maHD + "'";
            DataTable dt = DataProvider.Instance.executeQuery(query1 + query2 + query3);
        }


        public DataTable loadFinancialReport()
        {
            string query = "exec loadFormFinancialReport";
            DataTable dt = DataProvider.Instance.executeQuery(query);
            return dt;
        }

        public void updateContractState(string maHD) 
        {

            DataTable dt = new DataTable();
            
            string procName = "updateContractDetails";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@MaHD", SqlDbType.NVarChar, 5) { Value = maHD}
            };
            dt = DataProvider.Instance.executeProc(procName, parameters);
            
        }

        public DataTable getChartByMonth(int so)
        {
            DataTable dt = new DataTable();

            string procName = "searchContractByMonth";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@Month", SqlDbType.Int) { Value = so}
            };
            dt = DataProvider.Instance.executeProc(procName, parameters);

            return dt;
        }


        public DataTable getChartByQuy(int so)
        {
            DataTable dt = new DataTable();

            string procName = "searchContractByQuarter";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@Quarter", SqlDbType.Int) { Value = so}
            };
            dt = DataProvider.Instance.executeProc(procName, parameters);

            return dt;
        }

        public DataTable getChartByYear(int so)
        {
            DataTable dt = new DataTable();

            string procName = "searchContractByYear";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@Year", SqlDbType.Int) { Value = so}
            };
            dt = DataProvider.Instance.executeProc(procName, parameters);

            return dt;
        }

        public DataTable getAllYear()
        {
            string query = "exec searchContractBySelectAllYear";
            DataTable dt = DataProvider.Instance.executeQuery(query);
            return dt;
        }

        public DataTable searchHopDongFinancial(string searchHopDong)
        {
            string procName = "searchGlobalOnFinancialReport";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                    new SqlParameter("@Keyword", SqlDbType.NVarChar, 50) { Value = searchHopDong }
                };
            DataTable dt = DataProvider.Instance.executeProc(procName, parameters);
            return dt;
        }

        public DataTable searchConTractHistory(string searchHopDong, NguoiDung user)
        {
            DataTable dt = new DataTable();
            if(user.vaiTro == "Sale")
            {
                string procName = "searchGlobalOnContractHistoryOnlySale";

                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@Keyword", SqlDbType.NVarChar, 50) { Value = searchHopDong },
                    new SqlParameter("@MaNV", SqlDbType.NVarChar, 5) { Value = user.maNV }
                };
                dt = DataProvider.Instance.executeProc(procName, parameters);
            }
            else
            {
                string procName = "searchGlobalOnContractHistory";

                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@Keyword", SqlDbType.NVarChar, 50) { Value = searchHopDong }
                };
                dt = DataProvider.Instance.executeProc(procName, parameters);
            }
            return dt;
        }

        public DataTable getAllHopDong(NguoiDung user)
        {
            string query = "exec layThongTinGiaiDoanThanhToanByMaNV @MaNV = '" + user.maNV + "'";
            DataTable dt = DataProvider.Instance.executeQuery(query);
            return dt;
        }
        public DataTable searchHDGiaiDoan(NguoiDung user, string keyword)
        {
            DataTable dt = new DataTable();

            string procName = "searchGiaiDoanThanhToanGlobal";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@MaNV", SqlDbType.NVarChar, 5) { Value = user.maNV},
                new SqlParameter("@Keyword", SqlDbType.NVarChar, 5) { Value = keyword}
            };
            dt = DataProvider.Instance.executeProc(procName, parameters);

            return dt;
        }

        

    }
}
