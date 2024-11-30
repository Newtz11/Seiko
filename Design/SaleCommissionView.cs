using BLL;
using DTO;
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
    public partial class SaleCommissionView : System.Windows.Forms.Form
    {
        private NguoiDung user;
        public SaleCommissionView(NguoiDung user)
        {
            InitializeComponent();
            ApplyRoundedCorners(buttonSearch);
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

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            ulong tongHoaHong = 0;
            dataGridViewCommissionView.Rows.Clear();
            string keyword = textBoxSearch.Text.ToString().Trim();
            DataTable dt = HopDongBLL.searchHDGiaiDoan(user, keyword);
            foreach (DataRow dr in dt.Rows)
            {
                string maHD = dr[0].ToString();
                string tenHD = dr[1].ToString();
                string giaiDoanTT = dr[2].ToString();
                string maNV = dr[3].ToString();
                string tenNV = dr[4].ToString();
                string ngayNhanTT = ((DateTime)dr[5]).ToString("dd/MM/yyyy");
                string giaTriTT = dr[6].ToString();
                string hoaHong = "5";
                decimal giaTri = Convert.ToDecimal(dr[6]);
                decimal tienHoaHong = (giaTri * 5) / 100;
                tongHoaHong += (ulong)tienHoaHong;
                dataGridViewCommissionView.Rows.Add(maHD, tenHD, giaiDoanTT, maNV, tenNV, ngayNhanTT, giaTriTT, hoaHong, tienHoaHong.ToString("N2"));
            }
            dataGridViewTongHoaHong.Rows.Add(tongHoaHong.ToString("N2"));
        }

        private void SaleCommissionView_Load(object sender, EventArgs e)
        {
            ulong tongHoaHong = 0;
            dataGridViewCommissionView.Rows.Clear();
            DataTable dt = HopDongBLL.getAllHopDong(user);
            foreach (DataRow dr in dt.Rows)
            {
                string maHD = dr[0].ToString();
                string tenHD = dr[1].ToString();
                string giaiDoanTT = dr[2].ToString();
                string maNV = dr[3].ToString();
                string tenNV = dr[4].ToString();
                string ngayNhanTT = ((DateTime)dr[5]).ToString("dd/MM/yyyy");
                string giaTriTT = dr[6].ToString();
                string hoaHong = "5";
                decimal giaTri = Convert.ToDecimal(dr[6]);
                decimal tienHoaHong = (giaTri * 5) / 100;
                tongHoaHong += (ulong)tienHoaHong;
                dataGridViewCommissionView.Rows.Add(maHD, tenHD, giaiDoanTT, maNV, tenNV, ngayNhanTT, giaTriTT, hoaHong, tienHoaHong.ToString("N2"));
            }
            dataGridViewTongHoaHong.Rows.Add(tongHoaHong.ToString("N2"));
        }
    }
}
