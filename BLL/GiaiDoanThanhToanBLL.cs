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
        public static DataTable loadPaymentProgress(GiaiDoanThanhToan giaiDoan)
        {
            return GiaiDoanThanhToanDAO.Instance.loadPaymentProgress(giaiDoan);
        }
    }
}
