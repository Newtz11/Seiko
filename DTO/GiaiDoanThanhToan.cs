using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GiaiDoanThanhToan
    {
        public string maGiaiDoanThanhToan {  get; set; }
        public string maHD { get; set; }
        public string tenHD { get; set; }
        public DateTime ngayThanhToan { get; set; }     // Ngày hạn thanh toán (có lúc tạo CHIA GIAI ĐOẠN)
        public int phanTramThanhToan { get; set; }
        public int giaTriThanhToan { get; set; }
        public bool trangThaiThanhToan { get; set; }
        public DateTime ngayNhanThanhToan { get; set; }
        public string ghiChu {  get; set; }
        public string nhanVienQuanLy {  get; set; }     // Người quản lý thanh toán (Kế toán)

        public GiaiDoanThanhToan() { }

        public GiaiDoanThanhToan(string maGiaiDoanThanhToan, string maHD, string tenHD, DateTime ngayThanhToan, int phanTramThanhToan, int giaTriThanhToan, bool trangThaiThanhToan, DateTime ngayNhanThanhToan, string ghiChu, string nhanVienQuanLy)
        {
            this.maGiaiDoanThanhToan = maGiaiDoanThanhToan;
            this.maHD = maHD;
            this.tenHD = tenHD;
            this.ngayThanhToan = ngayThanhToan;
            this.phanTramThanhToan = phanTramThanhToan;
            this.giaTriThanhToan = giaTriThanhToan;
            this.trangThaiThanhToan = trangThaiThanhToan;
            this.ngayNhanThanhToan = ngayNhanThanhToan;
            this.ghiChu = ghiChu;
            this.nhanVienQuanLy = nhanVienQuanLy;
        }
    }
}
