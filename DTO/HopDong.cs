using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HopDong
    {
        public string maHD {  get; set; }
        public string maNV { get; set; }
        public string tenKhachHang { get; set; }
        public string giaTriHD { get; set; }
        public string ngayBatDau { get; set; }
        public string ngayKetThuc { get; set; }
        public string tenDuAn { get; set; }
        public string mucHoaHong { get; set; }
        public string chiaGiaiDoan { get; set; }
        public HopDong() { }

        public HopDong(string maHD, string maNV, string tenKhachHang, string giaTriHD, string ngayBatDau, string ngayKetThuc, string tenDuAn, string mucHoaHong, string chiaGiaiDoan)
        {
            this.maHD = maHD;
            this.maNV = maNV;
            this.tenKhachHang = tenKhachHang;
            this.giaTriHD = giaTriHD;
            this.ngayBatDau = ngayBatDau;
            this.ngayKetThuc = ngayKetThuc;
            this.tenDuAn = tenDuAn;
            this.mucHoaHong = mucHoaHong;
            this.chiaGiaiDoan = chiaGiaiDoan;
        }
    }
}
