﻿using System;
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
    public partial class ListUser : Form
    {
        public ListUser()
        {
            InitializeComponent();
            ApplyRoundedCorners(buttonSearch);
            ApplyRoundedCorners(buttonTaoTaiKhoan);
            ApplyRoundedCorners(buttonXoa);
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


        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }

        private void buttonTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            CreateAccount createAccount = new CreateAccount();
            createAccount.Show();
        }

        private void dataGridViewListUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListUser_Load(object sender, EventArgs e)
        {
            //dataGridViewListUser.Rows.Add(1, "nv001", "nv001@gmail.com", "Nguyen van C", "NV001", "Sale", "Nhân viên Sale", "Đang hoạt động");
            //dataGridViewListUser.Rows.Add(1, "nv001", "nv001@gmail.com", "Nguyen van C", "NV001", "Sale", "Nhân viên Sale", "Đang hoạt động");
            dataGridViewListUser.Rows.Add(1, "nv001", "nv001@gmail.com", "Nguyen van C", "NV001", "Sale", "Nhân viên Sale", "Đang hoạt động");
            dataGridViewListUser.Rows.Add(1, "nv001", "nv001@gmail.com", "Nguyen van C", "NV001", "Sale", "Nhân viên Sale", "Đang hoạt động");
        }
    }
}
