using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HopDong
    {
        // Thông tin hợp đồng
        public string maHD {  get; set; }
        public string maNV { get; set; }
        public string tenHD { get; set; }
        public string tenNguoiDaiDien { get; set; }
        public DateTime ngayBatDau { get; set; }
        public DateTime ngayKetThuc { get; set; }
        public int giaTriHD { get; set; }
        public int mucHoaHong { get; set; }
        public string chiaGiaiDoan { get; set; }
        public int daThanhToan {  get; set; }
        public string noiDungHD { get; set; }
        public string tinhTrangHD { get; set; }
        // Thông tin người liên hệ
        public string tenNguoiLienHe {  get; set; }
        public string diaChi {  get; set; }
        public string sDT {  get; set; }
        public string mail {  get; set; }
        public int tienDoHD { get; set; }   // Số tiến độ hợp đồng CẮT CHUỖI NỘI DUNG HỢP ĐỒNG

        public HopDong() { }

        public HopDong(string maHD, string maNV, string tenHD, string tenNguoiDaiDien, DateTime ngayBatDau, DateTime ngayKetThuc, int giaTriHD, int mucHoaHong, string chiaGiaiDoan, int daThanhToan, string noiDungHD, string tinhTrangHD, string tenNguoiLienHe, string diaChi, string sDT, string mail, int tienDoHD)
        {
            this.maHD = maHD;
            this.maNV = maNV;
            this.tenHD = tenHD;
            this.tenNguoiDaiDien = tenNguoiDaiDien;
            this.ngayBatDau = ngayBatDau;
            this.ngayKetThuc = ngayKetThuc;
            this.giaTriHD = giaTriHD;
            this.mucHoaHong = mucHoaHong;
            this.chiaGiaiDoan = chiaGiaiDoan;
            this.daThanhToan = daThanhToan;
            this.noiDungHD = noiDungHD;
            this.tinhTrangHD = tinhTrangHD;
            this.tenNguoiLienHe = tenNguoiLienHe;
            this.diaChi = diaChi;
            this.sDT = sDT;
            this.mail = mail;
            this.tienDoHD = tienDoHD;
        }
    }
}
