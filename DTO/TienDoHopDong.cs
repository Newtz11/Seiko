using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TienDoHopDong
    {
        public string maTienDoHD {  get; set; }
        public DateTime ngayBatDau { get; set; }
        public DateTime ngayKetThuc { get; set; }
        public string maHD {  get; set; }
        public string maNV { get; set; }
        public string nhanVienThucHienCV { get; set; }
        public string noiDungCV { get; set; }
        public int khoiLuongCV { get; set; }
        public int tongKhoiLuongCV { get; set; }

        public TienDoHopDong() { }
        





        public TienDoHopDong(DateTime ngayBatDau, DateTime ngayKetThuc, string maNV, string nhanVienThucHienCV, string noiDungCV)
        {
            this.ngayBatDau = ngayBatDau;
            this.ngayKetThuc = ngayKetThuc;
            this.maNV = maNV;
            this.nhanVienThucHienCV = nhanVienThucHienCV;
            this.noiDungCV = noiDungCV;
        }
        public TienDoHopDong(string maTienDoHD, DateTime ngayBatDau, DateTime ngayKetThuc,string maHD, string maNV, string nhanVienThucHienCV, string noiDungCV, int khoiLuongCV, int tongKhoiLuongCV)
        {
            this.maTienDoHD = maTienDoHD;
            this.ngayBatDau = ngayBatDau;
            this.ngayKetThuc = ngayKetThuc;
            this.maHD = maHD;
            this.maNV = maNV;
            this.nhanVienThucHienCV = nhanVienThucHienCV;
            this.noiDungCV = noiDungCV;
            this.khoiLuongCV = khoiLuongCV;
            this.tongKhoiLuongCV = tongKhoiLuongCV;
        }
    }
}
