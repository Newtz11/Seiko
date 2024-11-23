using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;

namespace BLL
{
    public class HopDongBLL
    {
        public static bool createContract(HopDong hopDongMoi)
        {
            return HopDongDAO.Instance.createContract(hopDongMoi);
        }

        public static DataTable loadContract(NguoiDung user)
        {
            return HopDongDAO.Instance.loadContract(user);
        }
    }
}
