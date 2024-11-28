using DTO;
using System;
using System.Collections.Generic;
using System.Data;
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
    }
}
