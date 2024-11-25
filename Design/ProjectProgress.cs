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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Design
{
    public partial class ProjectProgress : Form
    {
        private NguoiDung user;
        public ProjectProgress(NguoiDung user)
        {
            InitializeComponent();
            ApplyRoundedCorners(buttonSearch);
            ApplyRoundedCorners(buttonTaoTaiKhoan);
            ApplyRoundedCorners(buttonXoa);
            ApplyRoundedCorners(buttonSua);
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

        private void ProjectProgress_Load(object sender, EventArgs e)
        {
            DataTable dt = TienDoHopDongBLL.loadProjectProgress(user);
            foreach (DataRow row in dt.Rows)
            {
                string maHopDong = row["Mã hợp đồng"].ToString();
                string tenHopDong = row["Tên hợp đồng"].ToString();
                string noiDungCV = row["Nội dung công việc"].ToString();
                string tongKhoiLuongCV = row["Khối lượng yêu cầu"].ToString();
                DateTime ngayBatDau = Convert.ToDateTime(row["Ngày bắt đầu"]);
                DateTime ngayHetHan = Convert.ToDateTime(row["Ngày kết thúc"]);
                int KhoiLuongCV = Convert.ToInt32(row["Tiến độ"]);
                string NVThucHienCV = row["Người thực hiện"].ToString();
                string TinhTrangHD = row["Tình trạng"].ToString();
                dataGridViewProjectProgress.Rows.Add(maHopDong, tenHopDong, noiDungCV, tongKhoiLuongCV, ngayBatDau.ToString("dd/MM/yyyy"), ngayHetHan.ToString("dd/MM/yyyy"), KhoiLuongCV, NVThucHienCV, TinhTrangHD);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
