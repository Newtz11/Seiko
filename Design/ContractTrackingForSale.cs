using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace Design
{
    public partial class ContractTrackingForSale : Form
    {
        NguoiDung user;
        public ContractTrackingForSale(NguoiDung user)
        {
            InitializeComponent();
            ApplyRoundedCorners(buttonSearch);
            ApplyRoundedCorners(buttonThem);
            ApplyRoundedCorners(buttonXoa);
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
            MessageBox.Show(comboBoxTinhTrang.SelectedValue.ToString());
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            CreateContract createContract = new CreateContract(user);
            createContract.Show();
        }

        private void ContractTracking_Load(object sender, EventArgs e)
        {
            DataTable dt = HopDongBLL.loadContract(user);

            foreach (DataRow row in dt.Rows)
            {
                string maHopDong = row["Mã hợp đồng"].ToString();
                string tenHopDong = row["Tên hợp đồng"].ToString();
                string tenCongTyCaNhan = row["Tên Công ty/Cá nhân"].ToString();
                string nguoiLienHe = row["Người liên hệ"].ToString();
                DateTime ngayBatDau = Convert.ToDateTime(row["Ngày bắt đầu"]);
                DateTime ngayHetHan = Convert.ToDateTime(row["Ngày hết hạn"]);
                int giaTriHopDong = Convert.ToInt32(row["Giá trị hợp đồng"]);
                string tinhTrangHopDong = row["Tình trạng hợp đồng"].ToString();
                string phuTrachQuanLy = row["Phụ trách quản lý"].ToString();
                dataGridViewContractTracking.Rows.Add(maHopDong, tenHopDong, tenCongTyCaNhan, nguoiLienHe, ngayBatDau.ToString("yyyy/MM/dd"), ngayHetHan.ToString("yyyy/MM/dd"), giaTriHopDong, tinhTrangHopDong, phuTrachQuanLy);
            }
        }

        private void dataGridViewContractTracking_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            

            string maHD = this.dataGridViewContractTracking.CurrentRow.Cells[0].Value.ToString();
            HopDong selectedContract = HopDongBLL.getSeletedContract(maHD);
            ContractDetail fContractDetail = new ContractDetail(user, selectedContract, this);
            fContractDetail.Show();
        }
    }
}
