using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design
{
    public partial class ListUser : Form
    {
        private NguoiDung user;
        public ListUser(NguoiDung user)
        {
            InitializeComponent();
            ApplyRoundedCorners(buttonSearch);
            ApplyRoundedCorners(buttonTaoTaiKhoan);
            ApplyRoundedCorners(buttonXoa);
            ApplyRoundedCorners(buttonReset);
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




        private void buttonTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            CreateAccount createAccount = new CreateAccount();
            createAccount.Show();
        }

        private void dataGridViewListUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListUser_Load(object sender, EventArgs e)
        {
            dataGridViewListUser.Rows.Clear();
            DataTable dt = NguoiDungBLL.loadUser();
            int counter = 0;
            foreach (DataRow row in dt.Rows)
            {
                if (counter == 0)
                {
                    counter++;
                    continue;
                }
                string tenDangNhap = row["Tên Đăng Nhập"].ToString();
                string mail = row["Email"].ToString();
                string tenNguoiDung = row["Tên người dùng"].ToString();
                string maNguoiDung = row["Mã người dùng"].ToString();
                string phongBan = row["Phòng ban"].ToString();
                string vaiTro = row["Chức vụ"].ToString();
                bool trangThai = (bool)row["Tình trạng"];
                string tinhTrang = trangThai ? "Đang hoạt động" : "Ngưng hoạt động";
                dataGridViewListUser.Rows.Add(counter, tenDangNhap, mail, tenNguoiDung, maNguoiDung, phongBan, vaiTro, tinhTrang);
                counter++;
            }



        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

            string searchTen = textBoxSearch.Text.ToString();
            string searchPhongBan = comboBoxPhongBan.Text.ToString();
            string searchChucVu = comboBoxChucVu.Text.ToString();
            string searchTinhTrang = comboBoxTinhTrang.Text.ToString();
            DataTable dt = NguoiDungBLL.searchUserList(searchTen, searchPhongBan, searchChucVu, searchTinhTrang);
            if (dt.Rows.Count == 0 || dt.Columns.Count == 0)
            {
                // DataTable is empty or has no columns
                return;
            }
            else
            {
                int counter = 1;
                dataGridViewListUser.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {

                    string tenDangNhap = row["Tên đăng nhập"].ToString();
                    string mail = row["Email"].ToString();
                    string tenNguoiDung = row["Tên người dùng"].ToString();
                    string maNguoiDung = row["Mã người dùng"].ToString();
                    string phongBan = row["Phòng ban"].ToString();
                    string vaiTro = row["Chức vụ"].ToString();
                    bool trangThai = (bool)row["Tình trạng"];
                    string tinhTrang = trangThai ? "Đang hoạt động" : "Ngưng hoạt động";
                    dataGridViewListUser.Rows.Add(counter, tenDangNhap, mail, tenNguoiDung, maNguoiDung, phongBan, vaiTro, tinhTrang);
                    counter++;
                }

                textBoxSearch.Text = "";

                comboBoxPhongBan.SelectedIndex = -1;
                comboBoxChucVu.SelectedIndex = -1;
                comboBoxChucVu.SelectedIndex = -1;

                comboBoxPhongBan.Text = "Phòng ban";
                comboBoxChucVu.Text = "Chức vụ";
                comboBoxTinhTrang.Text = "Tình trạng"; 
            }



        }

        private void dataGridViewListUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            dataGridViewListUser.Rows.Clear();
            ListUser_Load(sender, e);
        }
    }
}
