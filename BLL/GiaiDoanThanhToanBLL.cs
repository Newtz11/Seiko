using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;


namespace BLL
{
    public class GiaiDoanThanhToanBLL
    {
        public static void updateGiaiDoanThanhToan(string hinhThucThanhToan, HopDong hd)
        {
            string[] parts = hinhThucThanhToan.Split('-');
            //parts = newDeck.Take(newDeck.Count() - 1).ToArray();

            foreach (string part in parts) 
            {
                part.Remove(part.Length - 1);
                int phanTramThanhToan = Convert.ToInt32(part);
                GiaiDoanThanhToanDAO.Instance.updateGiaiDoanThanhToan(phanTramThanhToan, hd);
            }
            
        }
    }
}
