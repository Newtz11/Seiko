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
    }
}
