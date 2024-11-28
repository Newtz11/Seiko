using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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
        public void updateGiaiDoanThanhToan(int phanTramThanhToan, HopDong hd)
        {


            string procName = "insertGiaiDoanThanhToan";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@MaHD", SqlDbType.NVarChar, 5) { Value = hd.maHD },
                new SqlParameter("@PhanTramThanhToan", SqlDbType.Int) { Value = phanTramThanhToan }
            };
            DataTable dt = DataProvider.Instance.executeProc(procName, parameters);

        }
    }
}
