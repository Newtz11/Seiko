using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NguoiDung
    {
        public string maNV {  get; set; }
        public string tenDangNhap { get; set; }
        public string hoTen { get; set; }
        //gioiTinh = isFemale() -> true la nu, false la nam
        public bool gioiTinh { get; set; }
        public string ngaySinh { get; set; }
        public string matKhau { get; set; }
        public string mail { get; set; }
        public string vaiTro { get; set; }
        public string sDT { get; set; }
        public string phongBan { get; set; }
        public string ngayVaoLam { get; set; }
        public string diaChi { get; set; }
        public bool tinhTrangHoatDong { get; set; } //-> true la đang hoạt động, false la ngưng hoạt động
        
        public byte[] hinhAnh { get; set; } 

        // for empty data only
        public NguoiDung() { }

        public NguoiDung(string tenDangNhap, string matKhau, string hoTen, string ngaySinh, bool gioiTinh, string diaChi, string phongBan, string vaiTro, string mail, string sDT)
        {
            this.tenDangNhap = tenDangNhap;
            this.matKhau = matKhau;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.diaChi = diaChi;
            this.phongBan = phongBan;
            this.vaiTro = vaiTro;
            this.mail = mail;
            this.sDT = sDT;
        }

        public NguoiDung(string tenDangNhap, string matKhau)
        {
            this.tenDangNhap = tenDangNhap;
            this.matKhau = matKhau;
        }

        public NguoiDung(string maNV, string tenDangNhap, string matKhau, string mail)
        {
            this.maNV = maNV;
            this.tenDangNhap =  tenDangNhap ;
            this.matKhau = matKhau;
            this.mail = mail;
        }



        public NguoiDung(string maNV, string tenDangNhap, string hoTen, bool gioiTinh, string ngaySinh, string matKhau, string mail, 
            string vaiTro, string sDT, string phongBan, string ngayVaoLam, string diaChi, bool tinhTrangHoatDong, byte[] hinhAnh)
        {
            this.maNV = maNV;
            this.tenDangNhap = tenDangNhap;
            this.hoTen = hoTen; 
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.matKhau = matKhau;
            this.mail = mail;
            this.vaiTro = vaiTro;
            this.sDT = sDT;
            this.phongBan = phongBan;
            this.ngayVaoLam = ngayVaoLam;
            this.diaChi = diaChi;
            this.tinhTrangHoatDong = tinhTrangHoatDong;
            this.hinhAnh = hinhAnh;
        }
    }
}
