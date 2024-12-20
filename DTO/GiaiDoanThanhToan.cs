﻿using System;
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
        public int giaiDoan { get; set; }
        public string tenHD { get; set; }
        public DateTime ngayThanhToan { get; set; }     // Ngày hạn thanh toán (có lúc tạo CHIA GIAI ĐOẠN)
        public int phanTramThanhToan { get; set; }
        public int giaTriThanhToan { get; set; }
        public bool trangThaiThanhToan { get; set; }
        public DateTime ngayNhanThanhToan { get; set; }
        public string ghiChu {  get; set; }

        public GiaiDoanThanhToan() { }

        public GiaiDoanThanhToan(string maGiaiDoanThanhToan, string maHD, string tenHD, DateTime ngayThanhToan, int phanTramThanhToan, int giaTriThanhToan, bool trangThaiThanhToan, DateTime ngayNhanThanhToan, string ghiChu)
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
        }

        public GiaiDoanThanhToan(int phanTramThanhToan, DateTime ngayThanhToan, DateTime ngayNhanThanhToan, int giaTriThanhToan, string ghiChu, string maHD, int giaiDoan)
        {
            this.phanTramThanhToan = phanTramThanhToan;
            this.ngayThanhToan = ngayThanhToan;
            this.ngayNhanThanhToan = ngayNhanThanhToan;
            this.giaTriThanhToan = giaTriThanhToan;
            this.ghiChu = ghiChu;
            this.maHD = maHD;
            this.giaiDoan = giaiDoan;
        }

        public GiaiDoanThanhToan(int phanTramThanhToan, DateTime ngayThanhToan, DateTime ngayNhanThanhToan, int giaTriThanhToan, bool trangThai,string ghiChu, string maHD, int giaiDoan)
        {
            this.phanTramThanhToan = phanTramThanhToan;
            this.ngayThanhToan = ngayThanhToan;
            this.ngayNhanThanhToan = ngayNhanThanhToan;
            this.giaTriThanhToan = giaTriThanhToan;
            this.trangThaiThanhToan = trangThai;
            this.ghiChu = ghiChu;
            this.maHD = maHD;
            this.giaiDoan = giaiDoan;
        }
    }
}
