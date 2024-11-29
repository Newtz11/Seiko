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
using DTO;
using BLL;
using System.Globalization;

namespace Design
{
    public partial class CreateContract : System.Windows.Forms.Form
    {
        NguoiDung user;
        private int soChuSo = 0;
        public CreateContract(NguoiDung user)
        {
            InitializeComponent();
            ApplyRoundedCorners(buttonTao);
            ApplyRoundedCorners(buttonQuayLai);
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


        private void CreateContract_Load(object sender, EventArgs e)
        {

        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTao_Click(object sender, EventArgs e)
        {
            /* Validation check điền đủ thông tin chưa */
            // Kiểm tra điền tên hợp đồng
            if (string.IsNullOrEmpty(textBoxTenHopDong.Text.Trim()))
            {
                errorProviderTenHopDong.SetError(textBoxTenHopDong, "Chưa điền Tên hợp đồng");
                return;
            }
            else
            {
                errorProviderTenHopDong.SetError(textBoxTenHopDong, string.Empty);
            }
            // Kiểm tra điền tên người đại diện
            if (string.IsNullOrEmpty(textBoxTenNguoiDaiDien.Text.Trim()))
            {
                errorProviderTenNguoiDaiDien.SetError(textBoxTenNguoiDaiDien, "Chưa điền Tên người đại diện");
                return;
            }
            else
            {
                errorProviderTenNguoiDaiDien.SetError(textBoxTenNguoiDaiDien, string.Empty);
            }
            // Kiểm tra điền giá trị hợp đồng
            if (string.IsNullOrEmpty(textBoxGiaTri.Text.Trim()))
            {
                errorProviderGiaTriHopDong.SetError(textBoxGiaTri, "Chưa điền Giá trị hợp đồng");
                return;
            }
            else
            {
                // Kiểm tra nếu giá trị không phải là số hoặc là số âm
                if (!decimal.TryParse(textBoxGiaTri.Text.Trim(), out decimal giaTri) || giaTri < 0)
                {
                    errorProviderGiaTriHopDong.SetError(textBoxGiaTri, "Giá trị không hợp lệ");
                    return;
                }
                else
                {
                    errorProviderGiaTriHopDong.SetError(textBoxGiaTri, string.Empty);
                }
            }
            // Kiểm tra điền nội dung hợp đồng
            if (string.IsNullOrEmpty(richTextBoxNoiDung.Text.Trim()))
            {
                errorProviderNoiDungHopDong.SetError(richTextBoxNoiDung, "Chưa điền Nội dung hợp đồng");
                return;
            }
            else
            {
                errorProviderNoiDungHopDong.SetError(richTextBoxNoiDung, string.Empty);
            }
            // Kiểm tra điền tên người liên hệ
            if (string.IsNullOrEmpty(textBoxTenNguoiLienHe.Text.Trim()))
            {
                errorProviderTenNguoiLienHe.SetError(textBoxTenNguoiLienHe, "Chưa điền Tên người liên hệ");
                return;
            }
            else
            {
                errorProviderTenNguoiLienHe.SetError(textBoxTenNguoiLienHe, string.Empty);
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
            // Kiểm tra điền email
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
            // Kiểm tra ngày bắt đầu và ngày kết thúc
            if (dateTimePickerEnd.Value <= dateTimePickerStart.Value)
            {
                errorProviderEndDate.SetError(dateTimePickerEnd, "Ngày kết thúc không hợp lệ");
                return;
            }
            else
            {
                errorProviderEndDate.SetError(dateTimePickerEnd, string.Empty);
            }

            string tenHopDong = (textBoxTenHopDong.Text.Trim()).ToString();
            string tenNguoiDaiDien = (textBoxTenNguoiDaiDien.Text.Trim()).ToString();
            DateTime ngayBatDau = dateTimePickerStart.Value;
            DateTime ngayKetThuc = dateTimePickerEnd.Value;
            string input = textBoxGiaTri.Text.Trim();
            string numberWithoutCommas = input.Replace(",", "");
            int giaTriHopDong = Convert.ToInt32(numberWithoutCommas);

            string noiDungHopDong = (richTextBoxNoiDung.Text.Trim()).ToString();
            string tenNguoiLienHe = (textBoxTenNguoiLienHe.Text.Trim()).ToString();
            string diaChi = (textBoxDiaChi.Text.Trim()).ToString();
            string sDT = (textBoxSDT.Text.Trim()).ToString();
            string mail = (textBoxEmail.Text.Trim()).ToString();
            HopDong hopDongMoi = new HopDong(tenHopDong, tenNguoiDaiDien, ngayBatDau, ngayKetThuc, giaTriHopDong, noiDungHopDong, tenNguoiLienHe, diaChi, sDT, mail, user.maNV);


            bool success = HopDongBLL.createContract(hopDongMoi);
            string maHD = HopDongBLL.getMaHDMoi();
            TienDoHopDongBLL.addTienDo(maHD);

            if (success)
            {
                MessageBox.Show("Tạo hợp đồng thành công");
                this.Close();
            }
            else MessageBox.Show("Tạo hợp đồng không thành công");
        }

        private void textBoxGiaTri_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxGiaTri.Text))
                return;

            string input = textBoxGiaTri.Text;
            decimal number;

            if (decimal.TryParse(input, NumberStyles.Number, CultureInfo.InvariantCulture, out number))
            {
                // Format the number with commas for thousands separators
                string formattedNumber = number.ToString("N0", CultureInfo.InvariantCulture); // "N0" for no decimals
                textBoxGiaTri.Text = formattedNumber;
                textBoxGiaTri.Select(formattedNumber.Length, 0); // Set the cursor to the end
            }
        }
    }
}
