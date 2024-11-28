using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Design
{
    public partial class AccountDetail : System.Windows.Forms.Form
    {
        public AccountDetail()
        {
            InitializeComponent();
            ApplyRoundedCorners(buttonLuu);
            ApplyRoundedCorners(buttonChinhSua);
            ApplyRoundedCorners(buttonQuayLai);
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

        private void AccountDetail_Load(object sender, EventArgs e)
        {

        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            /* Validation check điền đủ thông tin chưa */
            // Kiểm tra điền tên đăng nhập
            if (string.IsNullOrEmpty(textBoxTenDangNhap.Text.Trim()))
            {
                errorProviderTenDangNhap.SetError(textBoxTenDangNhap, "Chưa điền Tên đăng nhập");
                return;
            }
            else
            {
                errorProviderTenDangNhap.SetError(textBoxTenDangNhap, string.Empty);
            }
            // Kiểm tra điền Mật Khẩu
            string password = textBoxMatKhau.Text.Trim();

                    // Regex kiểm tra điều kiện mật khẩu
            string patternPass = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\W).{8,}$"; // Ít nhất 1 ký tự thường, 1 ký tự in hoa, 1 ký tự đặc biệt, độ dài >= 8
            if (string.IsNullOrEmpty(password))
            {
                errorProviderMatKhau.SetError(textBoxMatKhau, "Chưa điền mật khẩu");
                return;
            }
            else if (!Regex.IsMatch(password, patternPass))
            {
                MessageBox.Show("Mật khẩu phải chứa ít nhất 8 ký tự, 1 ký tự in hoa, 1 ký tự thường, 1 ký tự đặc biệt.",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            else
            {
                errorProviderMatKhau.SetError(textBoxMatKhau, string.Empty);
            }
            // Kiểm tra chọn trạng thái
            if (comboBoxTrangThai.SelectedIndex == -1)
            {
                errorProviderTrangThai.SetError(comboBoxTrangThai, "Chưa chọn trạng thái tài khoản");
                return;
            }
            else
            {
                errorProviderTrangThai.SetError(comboBoxTrangThai, string.Empty);
            }
            // Kiểm tra điền tên nhân viên
            if (string.IsNullOrEmpty(textBoxTenNhanVien.Text.Trim()))
            {
                errorProviderTenNhanVien.SetError(textBoxTenNhanVien, "Chưa điền Tên nhân viên");
                return;
            }
            else
            {
                errorProviderTenNhanVien.SetError(textBoxTenNhanVien, string.Empty);
            }
            // Kiểm tra điền SDT
            if (string.IsNullOrEmpty(textBoxSDT.Text.Trim()))
            {
                errorProviderSDT.SetError(textBoxSDT, "Chưa điền Số điện thoại");
                return;
            }
            else
            {
                string phoneNumber = textBoxSDT.Text.Trim();
                string patternSDT = @"^\d{10}$"; // Biểu thức kiểm tra số điện thoại phải là 10 chữ số

                if (!Regex.IsMatch(phoneNumber, patternSDT))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ!",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                errorProviderSDT.SetError(textBoxSDT, string.Empty);
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
            // Kiểm tra điền địa chỉ
            if (string.IsNullOrEmpty(textBoxDiaChi.Text.Trim()))
            {
                errorProviderDiaChi.SetError(textBoxDiaChi, "Chưa điền Địa chỉ");
                return;
            }
            else
            {
                errorProviderDiaChi.SetError(textBoxDiaChi, string.Empty);
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
            // Kiểm tra RadioButton Giới Tính
            if (!radioButtonNam.Checked && !radioButtonNu.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("Tạo tài khoản thành công!");
        }
    }
}
