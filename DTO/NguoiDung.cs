﻿using Microsoft.VisualBasic;
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
        public string hoTen { get; set; }
        public int gioiTinh { get; set; }
        public DateTime ngaySinh { get; set; }
        public string matKhau { get; set; }
        public string mail { get; set; }
        public string vaiTro { get; set; }
        public string sDT { get; set; }
        public string phongBan { get; set; }
        public DateTime ngayVaoLam { get; set; }
        public string diaChi { get; set; }

        public NguoiDung(string maNV, string matKhau)
        {
            this.maNV = maNV;
            this.matKhau = matKhau;
        }


        public NguoiDung(string maNV, string hoTen, int gioiTinh, DateTime ngaySinh, string matKhau, string mail, string vaiTro, string sDT, string phongBan, DateTime ngayVaoLam, string diaChi)
        {
            this.maNV = maNV;
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
        }
    }
}
