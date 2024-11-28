using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design
{
    public partial class CreateAccount : System.Windows.Forms.Form
    {
        public CreateAccount()
        {
            InitializeComponent();
            ApplyRoundedCorners(buttonTaoTaiKhoan);
            ApplyRoundedCorners(buttonHuyBo);
            comboBoxPhongBan.Items.Add("Kế toán");
            comboBoxPhongBan.Items.Add("Sale");
            comboBoxPhongBan.Items.Add("Giám đốc");

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

        private void buttonTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            /* Validation check điền đủ thông tin chưa */
            // Kiểm tra điền tên đăng nhập
            if (string.IsNullOrEmpty(textBoxUserName.Text.Trim()))
            {
                errorProviderTenDangNhap.SetError(textBoxUserName, "Chưa điền Tên đăng nhập");
                return;
            }
            else
            {
                errorProviderTenDangNhap.SetError(textBoxUserName, string.Empty);
            }
            // Kiểm tra điền họ tên người dùng
            if (string.IsNullOrEmpty(textBoxFullName.Text.Trim()))
            {
                errorProviderHoTenNguoiDung.SetError(textBoxFullName, "Chưa điền họ tên người dùng");
                return;
            }
            else
            {
                errorProviderHoTenNguoiDung.SetError(textBoxFullName, string.Empty);
            }
            // Kiểm tra điền địa chỉ
            if (string.IsNullOrEmpty(textBoxDiaChi.Text.Trim()))
            {
                errorProviderDiaChi.SetError(textBoxDiaChi, "Chưa điền địa chỉ");
                return;
            }
            else
            {
                errorProviderDiaChi.SetError(textBoxDiaChi, string.Empty);
            }
            // Kiểm tra chọn phòng ban
            if (comboBoxPhongBan.SelectedIndex == -1)
            {
                errorProviderPhongBan.SetError(comboBoxPhongBan, "Chưa chọn phòng ban");
                return;
            }
            else
            {
                errorProviderPhongBan.SetError(comboBoxPhongBan, string.Empty);
            }
            // Kiểm tra chọn chức vụ 
            if (comboBoxChucVu.SelectedIndex == -1)
            {
                errorProviderChucVu.SetError(comboBoxChucVu, "Chưa chọn chức vụ");
                return;
            }
            else
            {
                errorProviderChucVu.SetError(comboBoxChucVu, string.Empty);
            }
            // Kiểm tra điền Email
            if (string.IsNullOrEmpty(textBoxEmail.Text.Trim()))
            {
                errorProviderEmail.SetError(textBoxEmail, "Chưa điền Email");
                return;
            }
            else
            {
                string email = textBoxEmail.Text.Trim();

                // Kiểm tra xem email có kết thúc bằng @gmail.com không
                if (!email.EndsWith("@gmail.com"))
                {
                    MessageBox.Show("Email không hợp lệ!.",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                errorProviderEmail.SetError(textBoxEmail, string.Empty);
            }
            // Kiểm tra điền SDT
            if (string.IsNullOrEmpty(textBoxPhoneNumber.Text.Trim()))
            {
                errorProviderSDT.SetError(textBoxPhoneNumber, "Chưa điền Số điện thoại");
                return;
            }
            else
            {
                string phoneNumber = textBoxPhoneNumber.Text.Trim();
                string patternSDT = @"^\d{10}$"; // Biểu thức kiểm tra số điện thoại phải là 10 chữ số

                if (!Regex.IsMatch(phoneNumber, patternSDT))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ!",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                errorProviderSDT.SetError(textBoxPhoneNumber, string.Empty);
            }
            // Kiểm tra RadioButton Giới Tính
            if (!radioButtonNam.Checked && !radioButtonNu.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string TenDangNhap = textBoxUserName.Text.ToString().Trim();
            string HoTen = textBoxFullName.Text.ToString().Trim();
            string NgaySinh = dateTimePickerNgaySinh.Text.ToString().Trim();
            bool GioiTinh = (radioButtonNam.Checked);
            string DiaChi = textBoxDiaChi.Text.ToString().Trim();
            string PhongBan = comboBoxPhongBan.Text.ToString().Trim();
            string VaiTro = comboBoxChucVu.Text.ToString().Trim();
            string Mail = textBoxEmail.Text.ToString().Trim();
            string SDT = textBoxPhoneNumber.Text.ToString().Trim();
            string matKhau = GenerateRandomPassword(6);
            NguoiDung newAccount = new NguoiDung(TenDangNhap, matKhau, HoTen, NgaySinh, GioiTinh, DiaChi, PhongBan, VaiTro, Mail, SDT);
            // check xem mail co ton tai trong he thong hay khong

            bool checkMail = NguoiDungBLL.checkMailTrung(newAccount);

            if (checkMail)
            {
                MessageBox.Show("Mail bị trùng!");

            }

            bool createAcc = NguoiDungBLL.createAccount(newAccount);
            if (createAcc)
            {
                // gui mail xac nhan tai khoan
                //send mail here
                // gui mail xac nhan tai khoan
                string to, from, pass;
                to = Mail;
                from = "seikoapplication@gmail.com";
                pass = "kxff xduw vtgt xecl";
                MailMessage mess = new MailMessage();
                mess.To.Add(to);
                mess.From = new MailAddress(from);
                mess.Subject = "Seiko - Confirm create account sucess";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);
                try
                {
                    mess.Body = "Your account is: " + TenDangNhap + "\n" + "Your password is: " + matKhau;
                    smtp.Send(mess);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                MessageBox.Show("Tạo tài khoản thành công!");
                this.Close();
            }
            else MessageBox.Show("Tên đăng nhập bị trùng!");
        }

        private void labelCreateAccount_Click(object sender, EventArgs e)
        {

        }

        private void buttonHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void comboBoxPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string phongBan = comboBoxPhongBan.Text.ToString();
            if (phongBan == "Kế toán")
            {
                comboBoxChucVu.Items.Clear();
                comboBoxChucVu.Items.Add("Kế toán");
                comboBoxChucVu.Items.Add("Trưởng phòng Kế toán ");
            }
            else if (phongBan == "Sale")
            {
                comboBoxChucVu.Items.Clear();
                comboBoxChucVu.Items.Add("Sale");
                comboBoxChucVu.Items.Add("Trưởng phòng Sale");
            }
            else
            {
                comboBoxChucVu.Items.Clear();
                comboBoxChucVu.Items.Add("Giám đốc");
            }
        }

        public static string GenerateRandomPassword(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            Random random = new Random();
            char[] password = new char[length];

            for(int i = 0; i < length; i++)
            {
                password[i] = chars[random.Next(chars.Length)];
            }

            return new string(password);
        }
    }
}
