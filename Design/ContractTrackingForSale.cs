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


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchHopDong = textBoxSearch.Text.ToString().Trim();
            string searchTinhTrang = comboBoxTinhTrang.Text.ToString();
            DateTime searchTimeStart = dateTimePickerStart.Value;
            DateTime searchTimeEnd = dateTimePickerEnd.Value;
            DataTable dt = HopDongBLL.searchConTract(searchHopDong, searchTinhTrang, searchTimeStart, searchTimeEnd);
            if (dt.Rows.Count == 0 || dt.Columns.Count == 0)
            {
                // DataTable is empty or has no columns
                textBoxSearch.Text = "";
                comboBoxTinhTrang.SelectedIndex = -1;
                comboBoxTinhTrang.Text = "Tình trạng";
                return;
            }
            else
            {

                dataGridViewContractTracking.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {

                    string maHopDong = row[0].ToString();
                    string tenHopDong = row[1].ToString();
                    string tenNguoiDaiDien = row[2].ToString();
                    string tenNguoiLienHe = row[3].ToString();
                    DateTime ngayBatDau = (DateTime)row[4];
                    DateTime ngayKetThuc = (DateTime)row[5];
                    int giaTriHopDong = Convert.ToInt32(row[6]);
                    string tinhTrangHD = row[7].ToString();
                    string phuTrachQuanLy = row[8].ToString();
                    dataGridViewContractTracking.Rows.Add(maHopDong, tenHopDong, tenNguoiDaiDien, tenNguoiLienHe, ngayBatDau.ToString("dd/MM/yyyy"), ngayKetThuc.ToString("dd/MM/yyyy"), giaTriHopDong, tinhTrangHD, phuTrachQuanLy);
                }

                textBoxSearch.Text = "";

                comboBoxTinhTrang.SelectedIndex = -1;
                comboBoxTinhTrang.Text = "Tình trạng";
            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            CreateContract createContract = new CreateContract(user);
            createContract.Show();
        }

        private void ContractTracking_Load(object sender, EventArgs e)
        {
            dataGridViewContractTracking.Rows.Clear();
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
                dataGridViewContractTracking.Rows.Add(maHopDong, tenHopDong, tenCongTyCaNhan, nguoiLienHe, ngayBatDau.ToString("dd/MM/yyyy"), ngayHetHan.ToString("dd/MM/yyyy"), giaTriHopDong, tinhTrangHopDong, phuTrachQuanLy);
            }
        }

        private void dataGridViewContractTracking_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string maHD = this.dataGridViewContractTracking.CurrentRow.Cells[0].Value.ToString();
            HopDong selectedContract = HopDongBLL.getSeletedContract(maHD);
            ContractDetail fContractDetail = new ContractDetail(user, selectedContract, this);
            fContractDetail.Show();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = "";
            comboBoxTinhTrang.SelectedIndex = -1;
            comboBoxTinhTrang.Text = "Tình trạng";

            dataGridViewContractTracking.Rows.Clear();
            ContractTracking_Load(sender, e);
        }

        private void dataGridViewContractTracking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
