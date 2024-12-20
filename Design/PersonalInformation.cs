﻿using BLL;
using DTO;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design
{
    public partial class PersonalInformation : System.Windows.Forms.Form
    {
        private NguoiDung user;

        public PersonalInformation(NguoiDung user)
        {
            InitializeComponent();
            ApplyRoundedCorners(buttonLuu);
            ApplyRoundedCorners(buttonThayAnhDaiDien);
            ApplyRoundedCorners(buttonDoiMatKhau);
            this.user = user;
        }

        // Hàm để tạo vùng hình chữ nhật có góc bo tròn
        [DllImport("gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, // Tọa độ x của góc trên bên trái
            int nTopRect,  // Tọa độ y của góc trên bên trái
            int nRightRect, // Tọa độ x của góc dưới bên phải
            int nBottomRect, // Tọa độ y của góc dưới bên phải
            int nWidthEllipse, // Bán kính bo tròn theo chiều ngang
            int nHeightEllipse // Bán kính bo tròn theo chiều dọc
        );

        // Hàm áp dụng bo góc cho nút
        private void ApplyRoundedCorners(Button button)
        {
            // Loại bỏ viền mặc định của nút
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;

            // Tạo vùng hình chữ nhật có góc bo tròn
            IntPtr hRgn = CreateRoundRectRgn(0, 0, button.Width, button.Height, 15, 15);
            button.Region = Region.FromHrgn(hRgn);
        }

        private void PersonalInformation_Load(object sender, EventArgs e)
        {

            textBoxTenDangNhap.Text = user.tenDangNhap.ToString();
            textBoxMatKhau.Text = user.matKhau.ToString();
            string gioiTinh = user.gioiTinh ? "Nữ" : "Nam";
            string trangThaiHoatDong = user.tinhTrangHoatDong ? "Đang hoạt động" : "Ngưng hoạt động";
            dataGridViewThongTinCaNhan.Rows.Add(user.maNV, user.hoTen, user.ngaySinh, gioiTinh, user.sDT, user.diaChi, user.mail);
            dataGridViewThongTinCongViec.Rows.Add(user.vaiTro, user.phongBan, user.ngayVaoLam, trangThaiHoatDong);
            if (user.hinhAnh != null) pictureBoxAnhDaiDien.Image = showImage(user.hinhAnh);

        }

        private void buttonDoiMatKhau_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword(user, this);
            changePassword.Show();

        }

        private void buttonThayAnhDaiDien_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxAnhDaiDien.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            byte[] image = getImage();
            this.user.hinhAnh = image;
            NguoiDungBLL.updateUserImage(user, image);
        }


        private byte[] getImage()
        {
            MemoryStream stream = new MemoryStream();
            pictureBoxAnhDaiDien.Image.Save(stream, pictureBoxAnhDaiDien.Image.RawFormat);
            return stream.GetBuffer();
        }

        private void pictureBoxAnhDaiDien_Click(object sender, EventArgs e)
        {

        }

        private Image showImage(byte[] img)
        {
            MemoryStream memoryStream = new MemoryStream(img);
            return Image.FromStream(memoryStream);
        }
    }
}
