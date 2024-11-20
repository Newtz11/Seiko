using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DTO;
using BLL;
   

namespace Design
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            ApplyRoundedCorners(buttonLogin);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            buttonHidePassword.Hide();
            buttonShowPassword.Show();
            textBoxPassword.UseSystemPasswordChar = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxLogo0_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string taiKhoan = textBoxLoginName.Text.ToString();
            string matKhau = textBoxPassword.Text.ToString();
            NguoiDung loginAccount = new NguoiDung(taiKhoan, matKhau);
            bool login = NguoiDungBLL.checkTaiKhoan(loginAccount);
            if (login)
            {
                string role = NguoiDungBLL.getVaiTro(loginAccount);
                if (role == "Admin")
                {
                    SuperAdmin fSuperAdmin = new SuperAdmin(this);
                    this.Hide();
                    fSuperAdmin.Show();
                }
                else if (role == "CEO")
                {
                    Director fHomeDirector0 = new Director();
                    this.Hide();
                    fHomeDirector0.Show();
                }
                else if (role == "Sale")
                {
                    Sale fSale = new Sale();
                    this.Hide();
                    fSale.Show();
                }
                else if (role == "Accountant")
                {
                    Accountant fHomeAccountant = new Accountant();
                    this.Hide();
                    fHomeAccountant.Show();
                }
                else if (role == "Sale Manager")
                {
                    SaleManager fHomeSaleManager = new SaleManager();
                    this.Hide();
                    fHomeSaleManager.Show();
                }
                else if (role == "Accountant Manager")
                {
                    AccountantManager fHomeAccountantManager = new AccountantManager(this);
                    this.Hide();
                    fHomeAccountantManager.Show();
                }
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu đăng nhập sai. Vui lòng thử lại!");
                textBoxLoginName.Text = "";
                textBoxPassword.Text = "";
            }
        }

        private void buttonShowPassword_Click(object sender, EventArgs e)
        {
            buttonShowPassword.Hide();
            buttonHidePassword.Show();
            textBoxPassword.UseSystemPasswordChar = false;
        }

        private void buttonHidePassword_Click(object sender, EventArgs e)
        {
            buttonHidePassword.Hide();
            buttonShowPassword.Show();
            textBoxPassword.UseSystemPasswordChar = true;
        }

        private void linkLabelForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();
        }
    }
}
