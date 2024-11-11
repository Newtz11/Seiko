using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TienDoDuAn
    {
        public string maTienDo {  get; set; }
        public int mucTienDo { get; set; }
        public string noiDungCongViec {  get; set; }
        public string maHD {  get; set; }
        public string maNV { get; set; }

        public TienDoDuAn() { }

        public TienDoDuAn(string maTienDo, int mucTienDo, string noiDungCongViec, string maHD, string maNV)
        {
            this.maTienDo = maTienDo;
            this.mucTienDo = mucTienDo;
            this.noiDungCongViec = noiDungCongViec;
            this.maHD = maHD;
            this.maNV = maNV;
        }
    }
}
