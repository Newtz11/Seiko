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
    }
}
