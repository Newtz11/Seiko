using System;
using System.Collections.Generic;
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
    }
}
