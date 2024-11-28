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
using System.Net;
using System.Net.Mail;
using DTO;
using BLL;


namespace Design
{
    public partial class CreatePassword : System.Windows.Forms.Form
    {
        NguoiDung user;
        public CreatePassword(NguoiDung user)
        {
            InitializeComponent();
            ApplyRoundedCorners(buttonSavePassword);
            ApplyRoundedCorners(buttonCancel);
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

        private void labelCreatePassword_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSavePassword_Click(object sender, EventArgs e)
        {
            string newPass = textBoxConfirmPassword.Text.ToString();


            //check trung
            string newPassword = textBoxNewPassword.Text.ToString();
            string confirmPassword = textBoxConfirmPassword.Text.ToString();
            if (newPassword.Equals(confirmPassword))
            {
                //doi mat khau
                bool change = NguoiDungBLL.changePassword(user, newPass);
                if (change)
                {
                    MessageBox.Show("Đã thay đổi mật khẩu thành công! Vui lòng đăng nhập lại");
                    Application.Restart();
                }
            }
            else
            {
                MessageBox.Show("Xác nhận lại mật khẩu phải trùng với mật khẩu mới");
            }
        }

        private void buttonShowPassword1_Click(object sender, EventArgs e)
        {
            buttonShowPassword1.Hide();
            buttonHidePassword1.Show();
            textBoxNewPassword.UseSystemPasswordChar = false;
        }

        private void buttonHidePassword1_Click(object sender, EventArgs e)
        {
            buttonHidePassword1.Hide();
            buttonShowPassword1.Show();
            textBoxNewPassword.UseSystemPasswordChar = true;
        }

        private void buttonShowPassword2_Click(object sender, EventArgs e)
        {
            buttonShowPassword2.Hide();
            buttonHidePassword2.Show();
            textBoxConfirmPassword.UseSystemPasswordChar = false;
        }

        private void buttonHidePassword2_Click(object sender, EventArgs e)
        {
            buttonHidePassword2.Hide();
            buttonShowPassword2.Show();
            textBoxConfirmPassword.UseSystemPasswordChar = true;
        }

        private void CreatePassword_Load(object sender, EventArgs e)
        {
            buttonHidePassword1.Hide();
            buttonShowPassword1.Show();
            textBoxNewPassword.UseSystemPasswordChar = true;

            buttonHidePassword2.Hide();
            buttonShowPassword2.Show();
            textBoxConfirmPassword.UseSystemPasswordChar = true;
        }
    }
}