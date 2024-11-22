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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
            ApplyRoundedCorners(buttonSavePassword);
            ApplyRoundedCorners(buttonBack);
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void labelNewPassword_Click(object sender, EventArgs e)
        {

        }

        private void buttonShowPassword1_Click(object sender, EventArgs e)
        {
            buttonShowPassword1.Hide();
            buttonHidePassword1.Show();
            textBoxChangePassword.UseSystemPasswordChar = false;
        }
        private void buttonHidePassword1_Click(object sender, EventArgs e)
        {
            buttonHidePassword1.Hide();
            buttonShowPassword1.Show();
            textBoxChangePassword.UseSystemPasswordChar = true;
        }

        private void buttonShowPassword2_Click(object sender, EventArgs e)
        {
            buttonShowPassword2.Hide();
            buttonHidePassword2.Show();
            textBoxNewPassword.UseSystemPasswordChar = false;
        }
        private void buttonHidePassword2_Click(object sender, EventArgs e)
        {
            buttonHidePassword2.Hide();
            buttonShowPassword2.Show();
            textBoxNewPassword.UseSystemPasswordChar = true;
        }

        private void buttonShowPassword3_Click(object sender, EventArgs e)
        {
            buttonShowPassword3.Hide();
            buttonHidePassword3.Show();
            textBoxConfirmPassword.UseSystemPasswordChar = false;
        }
        private void buttonHidePassword3_Click(object sender, EventArgs e)
        {
            buttonHidePassword3.Hide();
            buttonShowPassword3.Show();
            textBoxConfirmPassword.UseSystemPasswordChar = true;
        }

        private void textBoxChangePassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            buttonHidePassword1.Hide();
            buttonShowPassword1.Show();
            textBoxChangePassword.UseSystemPasswordChar = true;

            buttonHidePassword2.Hide();
            buttonShowPassword2.Show();
            textBoxNewPassword.UseSystemPasswordChar = true;

            buttonHidePassword3.Hide();
            buttonShowPassword3.Show();
            textBoxConfirmPassword.UseSystemPasswordChar = true;
        }
    }
}
