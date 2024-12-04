using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.Runtime.InteropServices;

namespace Design
{
    public partial class SuperAdminDecentralization1 : System.Windows.Forms.Form
    {
        public SuperAdminDecentralization1()
        {
            InitializeComponent();
            ApplyRoundedCorners(buttonChucVuNguoiDung);
            ApplyRoundedCorners(buttonDanhSachNguoiDung);
            ApplyRoundedCorners(buttonAdd);
            ApplyRoundedCorners(buttonDelete);
            ApplyRoundedCorners(buttonLuu);
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

        private void buttonDanhSachNguoiDung_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newContent = txtContent.Text.Trim();
            if (!string.IsNullOrEmpty(newContent))
            {
                chkExample.Items.Add(newContent);
                txtContent.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập người dùng!");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Duyệt ngược danh sách để tránh lỗi index khi xóa
            for (int i = chkExample.CheckedIndices.Count - 1; i >= 0; i--)
            {
                chkExample.Items.RemoveAt(chkExample.CheckedIndices[i]);
            }
        }
    }
}
