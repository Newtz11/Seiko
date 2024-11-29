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
    public partial class ContractDetail : System.Windows.Forms.Form
    {
        private NguoiDung user;
        private HopDong hd;
        private System.Windows.Forms.Form f;
        private string hinhThucTT;
        public ContractDetail(NguoiDung user, HopDong hd, System.Windows.Forms.Form f)
        {
            InitializeComponent();
            ApplyRoundedCorners(buttonSua);
            ApplyRoundedCorners(buttonLuu);
            ApplyRoundedCorners(buttonThemSale);
            ApplyRoundedCorners(buttonXoaSale);
            ApplyRoundedCorners(buttonQuayLai);
            this.user = user;
            this.hd = hd;
            this.f = f;
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

        private void ContractDetail_Load(object sender, EventArgs e)
        {
            textBoxMaHopDong.Text = hd.maHD;
            textBoxTenHopDong.Text = hd.tenHD;
            textBoxTenNguoiDaiDien.Text = hd.tenNguoiDaiDien;
            dateTimePickerStart.Value = hd.ngayBatDau;
            dateTimePickerEnd.Value = hd.ngayKetThuc;
            textBoxGiaTriHopDong.Text = hd.giaTriHD.ToString();
            textBoxDaThanhToan.Text = hd.daThanhToan.ToString();
            richTextBoxNoiDungHopDong.Text = hd.noiDungHD;
            comboBoxTrangThai.Text = hd.tinhTrangHD;
            textBoxTenNguoiLienHe.Text = hd.tenNguoiLienHe;
            textBoxDiaChi.Text = hd.diaChi;
            textBoxSDT.Text = hd.sDT;
            textBoxEmail.Text = hd.mail;

            // Load data thông tin thanh toán
            dataGridViewThongTinThanhToan.Rows.Clear();
            DataTable dt = GiaiDoanThanhToanBLL.loadThongTinThanhToan();
            foreach (DataRow row in dt.Rows)
            {
                int GiaiDoan = Convert.ToInt32(row[0]);
                DateTime NgayThanhToan = Convert.ToDateTime(row[1]);
                string ngayNhanTT = "";
                if (row[2] != DBNull.Value)
                {
                    DateTime NgayNhanThanhToan = Convert.ToDateTime(row[2]);
                    ngayNhanTT = NgayNhanThanhToan.ToString("dd/MM/yyyy");
                }
                int PhanTramThanhToan = Convert.ToInt32(row[3]);
                int GiaTriThanhToan = Convert.ToInt32(row[4]);
                string trangThaiTT = "";
                bool TrangThai = (bool)row[5];
                if (TrangThai == true) trangThaiTT = "Đã thanh toán";
                else trangThaiTT = "Chưa thanh toán";
                string GhiChu = row[7].ToString();

                dataGridViewThongTinThanhToan.Rows.Add(GiaiDoan, NgayThanhToan.ToString("dd/MM/yyyy"), ngayNhanTT, PhanTramThanhToan, GiaTriThanhToan, trangThaiTT, GhiChu);
            }
        }

        private void dataGridViewThongTinSale_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewThongTinSale.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }

        private void dataGridViewThongTinThanhToan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewThongTinThanhToan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
            f.Show();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBoxHinhThucTT_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Doi hinh thuc thanh toan");
        }
    }
}
