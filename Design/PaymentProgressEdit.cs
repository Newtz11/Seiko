using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design
{
    public partial class PaymentProgressEdit : Form
    {

        private string maHD;
        private int action;
        private string tenHD;
        private int giaiDoan;
        private int phanTramThanhToan;
        private DateTime ngayThanhToan;
        private DateTime ngayNhanThanhToan;
        private int giaTriThanhToan;
        private string ghiChu;
        private bool trangThaiTT;

        // Danh cho sua
        public PaymentProgressEdit(string maHD, int action, string tenHD, string giaiDoan, DateTime ngayThanhToan, int phanTramThanhToan, int giaTriThanhToan, bool trangThaiTT, DateTime ngayNhanThanhToan, string ghiChu)
        {
            InitializeComponent();
            ApplyRoundedCorners(buttonLuu);
            ApplyRoundedCorners(buttonHuy);
            this.maHD = maHD;
            this.action = action;
            this.tenHD = tenHD;
            this.giaiDoan = Convert.ToInt32(giaiDoan);
            this.phanTramThanhToan = phanTramThanhToan;
            this.ngayThanhToan = ngayThanhToan;
            this.ngayNhanThanhToan = ngayNhanThanhToan;
            this.giaTriThanhToan = giaTriThanhToan;
            this.ghiChu = ghiChu;
            this.trangThaiTT = trangThaiTT;

        }

        // Danh cho them
        public PaymentProgressEdit(string maHD, int action, string tenHD, string giaiDoan)
        {
            InitializeComponent();
            ApplyRoundedCorners(buttonLuu);
            ApplyRoundedCorners(buttonHuy);
            this.maHD = maHD;
            this.action = action;
            this.tenHD = tenHD;
            this.giaiDoan = Convert.ToInt32(giaiDoan);

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


        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PaymentProgressEdit_Load(object sender, EventArgs e)
        {

            textBoxMaHopDong.Text = maHD;
            int giaiDoan = this.giaiDoan;
            if (action == 1)
            {
                // hanh dong them
                giaiDoan = GiaiDoanThanhToanBLL.getGiaiDoanMoi(maHD) + 1;
            }
            else
            {
                //hanh dong sua
                //khong lam gi ca
            }

            textBoxGiaiDoan.Text = giaiDoan.ToString();
            textBoxTenHopDong.Text = tenHD;
            textBoxGiaTriThanhToan.Text = giaTriThanhToan.ToString();
            textBoxPhanTramThanhToan.Text = phanTramThanhToan.ToString();
            textBoxGhiChu.Text = ghiChu;
            comboBoxTrangThaiThanhToan.Text = trangThaiTT.ToString();


            if (trangThaiTT) comboBoxTrangThaiThanhToan.Text = "Đã thanh toán";
            else comboBoxTrangThaiThanhToan.Text = "Chưa thanh toán";

        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            if (action == 1)
            {
                // hanh dong them
                comboBoxTrangThaiThanhToan.Enabled = false;
                int phanTramThanhToan = Convert.ToInt32(textBoxPhanTramThanhToan.Text.Trim().ToString());
                DateTime ngayThanhToan = dateTimePickerNgayThanhToan.Value;
                DateTime ngayNhanThanhToan = dateTimePickerNgayNhanThanhToan.Value;
                int giaTriThanhToan = Convert.ToInt32(textBoxGiaTriThanhToan.Text.Trim().ToString());
                string ghiChu = textBoxGhiChu.Text.Trim().ToString();
                int giaiDoan = Convert.ToInt32(textBoxGiaiDoan.Text.Trim().ToString());
                GiaiDoanThanhToan giaidoanMoi = new GiaiDoanThanhToan(phanTramThanhToan, ngayThanhToan, ngayNhanThanhToan, giaTriThanhToan, ghiChu, maHD, giaiDoan);

                bool success = GiaiDoanThanhToanBLL.createGiaiDoan(giaidoanMoi);

                if (success)
                {
                    MessageBox.Show("Thêm giai đoạn thành công");
                    this.Close();
                }
                else MessageBox.Show("Thêm giai đoạn không thành công");
            }
            else
            {
                //hanh dong sua
                int phanTramThanhToan = Convert.ToInt32(textBoxPhanTramThanhToan.Text.Trim().ToString());
                DateTime ngayThanhToan = dateTimePickerNgayThanhToan.Value;
                DateTime ngayNhanThanhToan = dateTimePickerNgayNhanThanhToan.Value;
                string input = textBoxGiaTriThanhToan.Text.Trim();
                string numberWithoutCommas = input.Replace(",", "");
                int giaTriThanhToan = Convert.ToInt32(numberWithoutCommas);
                int giaiDoan = Convert.ToInt32(textBoxGiaiDoan.Text.Trim().ToString());
                string maHD = textBoxMaHopDong.Text.Trim().ToString();
                string trangthai = comboBoxTrangThaiThanhToan.Text.ToString().Trim();
                bool trangThai = false;
                if (trangthai.Equals("Đã thanh toán"))
                {
                    trangThai = true;
                }
                string ghiChu = textBoxGhiChu.Text.Trim().ToString();
                GiaiDoanThanhToan giaidoanMoi = new GiaiDoanThanhToan(phanTramThanhToan, ngayThanhToan, ngayNhanThanhToan, giaTriThanhToan, trangThai, ghiChu, maHD, giaiDoan);

                bool success = GiaiDoanThanhToanBLL.updateGiaiDoan(giaidoanMoi);

                if (success)
                {
                    MessageBox.Show("Chỉnh sửa giai đoạn thành công");
                    this.Close();
                }
                else MessageBox.Show("Chỉnh sửa giai đoạn không thành công");
            }
        }

        private void textBoxGiaTriThanhToan_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxGiaTriThanhToan.Text))
                return;

            string input = textBoxGiaTriThanhToan.Text;
            decimal number;

            if (decimal.TryParse(input, NumberStyles.Number, CultureInfo.InvariantCulture, out number))
            {
                // Format the number with commas for thousands separators
                string formattedNumber = number.ToString("N0", CultureInfo.InvariantCulture); // "N0" for no decimals
                textBoxGiaTriThanhToan.Text = formattedNumber;
                textBoxGiaTriThanhToan.Select(formattedNumber.Length, 0); // Set the cursor to the end
            }
        }
    }
}
