using BLL;
using DTO;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class ContractHistory : System.Windows.Forms.Form
    {
        NguoiDung user;
        public ContractHistory(NguoiDung user)
        {
            InitializeComponent();
            ApplyRoundedCorners(buttonTimKiem);
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


        private void ContractHistory_Load(object sender, EventArgs e)
        {
            dataGridViewContractHistory.Rows.Clear();
            DataTable dt = HopDongBLL.loadContract(user);
            foreach (DataRow row in dt.Rows)
            {
                string maHopDong = row[0].ToString();
                string tenHopDong = row[1].ToString();
                string tenCongTyCaNhan = row[2].ToString();
                string nguoiLienHe = row[3].ToString();
                DateTime ngayBatDau = Convert.ToDateTime(row[4]);
                DateTime ngayHetHan = Convert.ToDateTime(row[5]);
                int giaTriHopDong = Convert.ToInt32(row[6]);
                string tenSale = row[7].ToString();
                string tinhTrangHopDong = row[8].ToString();
                dataGridViewContractHistory.Rows.Add(maHopDong, tenHopDong, tenCongTyCaNhan, nguoiLienHe, ngayBatDau.ToString("dd/MM/yyyy"), ngayHetHan.ToString("dd/MM/yyyy"), giaTriHopDong, tenSale, tinhTrangHopDong);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = "";

            dataGridViewContractHistory.Rows.Clear();
            ContractHistory_Load(sender, e);
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            string searchHopDong = textBoxSearch.Text.ToString().Trim();
            DataTable dt = HopDongBLL.searchContractHistory(searchHopDong, user);
            if (dt.Rows.Count == 0 || dt.Columns.Count == 0)
            {
                // DataTable is empty or has no columns
                textBoxSearch.Text = "";
                return;
            }
            else
            {
                dataGridViewContractHistory.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    string maHopDong = row[0].ToString();
                    string tenHopDong = row[1].ToString();
                    string tenCongTyCaNhan = row[2].ToString();
                    string nguoiLienHe = row[3].ToString();
                    DateTime ngayBatDau = Convert.ToDateTime(row[4]);
                    DateTime ngayHetHan = Convert.ToDateTime(row[5]);
                    int giaTriHopDong = Convert.ToInt32(row[6]);
                    string tenSale = row[7].ToString();
                    string tinhTrangHopDong = row[8].ToString();
                    dataGridViewContractHistory.Rows.Add(maHopDong, tenHopDong, tenCongTyCaNhan, nguoiLienHe, ngayBatDau.ToString("dd/MM/yyyy"), ngayHetHan.ToString("dd/MM/yyyy"), giaTriHopDong, tenSale, tinhTrangHopDong);
                }
                textBoxSearch.Text = "";
            }
        }
    }
}
