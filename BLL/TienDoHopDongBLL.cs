using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;


namespace BLL
{
    public class TienDoHopDongBLL
    {
        public static void createContractProcess(TienDoHopDong td)
        {
            TienDoHopDongDAO.Instance.createContractProcess(td);
        }
    }
}
