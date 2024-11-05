using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GiaiDoanHopDong
    {
        public string maGiaiDoan {  get; set; }
        public bool tinhTrangThanhToan { get; set; }
        public int phanTramHD { get; set; }
        public DateTime ngayBatDau { get; set; }
        public DateTime ngayKetThuc { get; set; }
        public string maHD { get; set; }
        public string maThanhToan { get; set; }
        public string maNV { get; set; }

        public GiaiDoanHopDong() { }

        public GiaiDoanHopDong(string maGiaiDoan, bool tinhTrangThanhToan, int phanTramHD, DateTime ngayBatDau, DateTime ngayKetThuc, string maHD, string maThanhToan, string maNV)
        {
            this.maGiaiDoan = maGiaiDoan;
            this.tinhTrangThanhToan = tinhTrangThanhToan;
            this.phanTramHD = phanTramHD;
            this.ngayBatDau = ngayBatDau;
            this.ngayKetThuc = ngayKetThuc;
            this.maHD = maHD;
            this.maThanhToan = maThanhToan;
            this.maNV = maNV;
        }
    }
}
