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
    public partial class PaymentProgress : Form
    {
        public PaymentProgress()
        {
            InitializeComponent();
            ApplyRoundedCorners(buttonSearch);
            ApplyRoundedCorners(buttonSua);
            ApplyRoundedCorners(buttonThem);
            ApplyRoundedCorners(buttonXoa);
            ApplyRoundedCorners(buttonReset);
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

        private void AccountantPaymentCommission_Load(object sender, EventArgs e)
        {
            dataGridViewPaymentProgress.Rows.Add("HD001", "Quay video", "Giai đoạn 1", "12/9/2022", "40","40000000","Đã thanh toán","15/9/2022","Thanh toán giai đoạn 1");
            dataGridViewPaymentProgress.Rows.Add("HD001", "Quay video", "Giai đoạn 2", "12/11/2022", "60", "60000000", "Chờ thanh toán", "", "");
        }
    }
}
