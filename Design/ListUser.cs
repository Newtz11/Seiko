using BLL;
using DTO;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design
{
    public partial class ListUser : System.Windows.Forms.Form
    {
        private NguoiDung user;
        public ListUser(NguoiDung user)
        {
            InitializeComponent();
            ApplyRoundedCorners(buttonSearch);
            ApplyRoundedCorners(buttonTaoTaiKhoan);
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
            int counter = 1;

            comboBoxPhongBan.Items.Clear();
            comboBoxPhongBan.Items.Add("Chọn phòng ban");
            comboBoxPhongBan.Items.Add("Kế toán");
            comboBoxPhongBan.Items.Add("Sale");
            comboBoxPhongBan.Items.Add("Giám đốc");
            foreach (DataRow row in dt.Rows)
            {
                string tenDangNhap = row[0].ToString();
                if (tenDangNhap == "admin") continue;
                string mail = row[1].ToString();
                string tenNguoiDung = row[2].ToString();
                string maNguoiDung = row[3].ToString();
                string phongBan = row[4].ToString();
                string vaiTro = row[5].ToString();
                bool trangThai = (bool)row[6];
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
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string tenDangNhap = dt.Rows[i][0].ToString();
                if (tenDangNhap == "admin") dt.Rows[i].Delete();
            }
            if (dt.Rows.Count == 0 || dt.Columns.Count == 0)
            {
                // DataTable is empty or has no columns
                textBoxSearch.Text = "";

                comboBoxPhongBan.SelectedIndex = -1;
                comboBoxChucVu.SelectedIndex = -1;
                comboBoxChucVu.SelectedIndex = -1;

                comboBoxPhongBan.Text = "Phòng ban";
                comboBoxChucVu.Text = "Chức vụ";
                comboBoxTinhTrang.Text = "Tình trạng";
                return;
            }
            else
            {
                int counter = 1;
                dataGridViewListUser.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    string tenDangNhap = row[0].ToString();
                    if (tenDangNhap == "admin") continue;
                    string mail = row[1].ToString();
                    string tenNguoiDung = row[2].ToString();
                    string maNguoiDung = row[3].ToString();
                    string phongBan = row[4].ToString();
                    string vaiTro = row[5].ToString();
                    bool trangThai = (bool)row[6];
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
            textBoxSearch.Text = "";

            comboBoxPhongBan.SelectedIndex = -1;
            comboBoxChucVu.SelectedIndex = -1;
            comboBoxChucVu.SelectedIndex = -1;

            comboBoxPhongBan.Text = "Phòng ban";
            comboBoxChucVu.Text = "Chức vụ";
            comboBoxTinhTrang.Text = "Tình trạng";
            dataGridViewListUser.Rows.Clear();
            textBoxSearch.Text = "";

            comboBoxPhongBan.SelectedIndex = -1;
            comboBoxChucVu.SelectedIndex = -1;
            comboBoxChucVu.SelectedIndex = -1;

            comboBoxPhongBan.Text = "Phòng ban";
            comboBoxChucVu.Text = "Chức vụ";
            comboBoxTinhTrang.Text = "Tình trạng";
            ListUser_Load(sender, e);
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
        }

        private void comboBoxPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string phongBan = comboBoxPhongBan.Text.ToString();
            if (phongBan == "Kế toán")
            {
                comboBoxChucVu.Items.Clear();
                comboBoxChucVu.Items.Add("-- Chọn chức vụ --");
                comboBoxChucVu.Items.Add("Kế toán");
                comboBoxChucVu.Items.Add("Trưởng phòng Kế toán");

            }
            else if (phongBan == "Sale")
            {
                comboBoxChucVu.Items.Clear();
                comboBoxChucVu.Items.Add("-- Chọn chức vụ --");
                comboBoxChucVu.Items.Add("Sale");
                comboBoxChucVu.Items.Add("Trưởng phòng Sale");
            }
            else
            {
                comboBoxChucVu.Items.Clear();
                comboBoxChucVu.Items.Add("-- Chọn chức vụ --");
                comboBoxChucVu.Items.Add("Giám đốc");
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
