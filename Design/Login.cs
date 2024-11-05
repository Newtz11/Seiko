using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace Design
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxLogo1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            buttonHidePassword.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxLogo0_Click(object sender, EventArgs e)
        {

        }

        private void textBoxLoginName_TextChanged(object sender, EventArgs e)
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
                    HomeSuperAdmin fHomeSuperAdmin = new HomeSuperAdmin();
                    this.Hide();
                    fHomeSuperAdmin.Show();
                }
                else if (role == "CEO")
                {
                    HomeDirector0 fHomeDirector0 = new HomeDirector0();
                    this.Hide();
                    fHomeDirector0.Show();
                }
                else if (role == "Sale")
                {
                    HomeSale fHomeSale = new HomeSale();
                    this.Hide();
                    fHomeSale.Show();
                }
                else if (role == "Accountant")
                {
                    HomeAccountant fHomeAccountant = new HomeAccountant();
                    this.Hide();
                    fHomeAccountant.Show();
                }
                else if (role == "Sale Manager")
                {
                    HomeHeadOfSales fHomeSaleManager = new HomeHeadOfSales();
                    this.Hide();
                    fHomeSaleManager.Show();
                }
                else if (role == "Accountant Manager")
                {
                    HomeAccountantManager fHomeAccountantManager = new HomeAccountantManager();
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
            textBoxPassword.UseSystemPasswordChar = false;
            buttonShowPassword.Hide();
            buttonHidePassword.Show();
        }

        private void buttonHidePassword_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
            buttonHidePassword.Hide();
            buttonShowPassword.Show();
        }
    }
}
