using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThanhToan
    {
        public string maThanhToan {  get; set; }
        public double tienThanhToan { get; set; }
        public DateTime ngayThanhToan { get; set; }
        public string phuongThuc {  get; set; }

        public ThanhToan() { }

        public ThanhToan(string maThanhToan, double tienThanhToan, DateTime ngayThanhToan, string phuongThuc)
        {
            this.maThanhToan = maThanhToan;
            this.tienThanhToan = tienThanhToan;
            this.ngayThanhToan = ngayThanhToan;
            this.phuongThuc = phuongThuc;
        }
    }
}
