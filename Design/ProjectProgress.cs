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
    public partial class ProjectProgress : Form
    {
        public ProjectProgress()
        {
            InitializeComponent();
            ApplyRoundedCorners(buttonSearch);
            ApplyRoundedCorners(buttonTaoTaiKhoan);
            ApplyRoundedCorners(buttonXoa);
            ApplyRoundedCorners(buttonSua);
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
        private void dataGridViewListUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProjectProgress_Load(object sender, EventArgs e)
        {
            dataGridViewListUser.Rows.Add("1","HD001", "Quay video", "Quay 50 video", "20-10-2020", "20-11-2023", "Nguyen Van B", "Đang thực hiện");
            dataGridViewListUser.Rows.Add("2","HD002", "Chụp ảnh", "Chụp 100 ảnh", "20-10-2020", "20-11-2023", "Nguyen Van B", "Chưa thực hiện");
            dataGridViewListUser.Rows.Add("3","HD003", "Quay video", "Quay 50 video", "20-10-2020", "20-11-2023", "Nguyen Van B", "Đã xong");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
