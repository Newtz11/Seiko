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
    public partial class ContractDetail : Form
    {
        private NguoiDung user;
        private HopDong hd;
        private Form f;
        public ContractDetail(NguoiDung user, HopDong hd, Form f)
        {
            InitializeComponent();
            ApplyRoundedCorners(buttonSua);
            ApplyRoundedCorners(buttonLuu);
            ApplyRoundedCorners(buttonThemSale);
            ApplyRoundedCorners(buttonXoaSale);
            ApplyRoundedCorners(buttonThemThanhToan);
            ApplyRoundedCorners(buttonXoaThanhToan);
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
            //dataGridViewThongTinThanhToan.Rows.Add("1", "20/9/2024", "40%", "10000000", "Đã thanh toán", "");
            //dataGridViewThongTinThanhToan.Rows.Add("2", "20/10/2024", "60%", "10000000", "Chưa thanh toán", "");
            //dataGridViewThongTinThanhToan.Rows.Add("3", "20/9/2024", "40%", "10000000", "Đã thanh toán", "");
            textBoxMaHopDong.Text = hd.maHD;
            textBoxTenHopDong.Text = hd.tenHD;
            textBoxTenNguoiDaiDien.Text = hd.tenNguoiDaiDien;
            dateTimePickerStart.Value = hd.ngayBatDau;
            dateTimePickerEnd.Value = hd.ngayKetThuc;
            textBoxGiaTriHopDong.Text = hd.giaTriHD.ToString();
            textBoxDaThanhToan.Text = hd.daThanhToan.ToString();
            richTextBoxNoiDungHopDong.Text = hd.noiDungHD;
            comboBoxHinhThucTT.Text = hd.chiaGiaiDoan;
            comboBoxTrangThai.Text = hd.tinhTrangHD;
            textBoxTenNguoiLienHe.Text = hd.tenNguoiLienHe;
            textBoxDiaChi.Text = hd.diaChi;
            textBoxSDT.Text = hd.sDT;
            textBoxEmail.Text = hd.mail;
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
            //neu nguoi dung la ke toan thi cho phep sua hinh thuc thanh toan va them giai doan
            if (user.vaiTro == "Trưởng phòng Kế toán")
            {
                comboBoxHinhThucTT.Enabled = true;

            }
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            //neu nguoi dung la ke toan thi cho phep sua hinh thuc thanh toan va them giai doan
            if (user.vaiTro == "Trưởng phòng Kế toán")
            {

                comboBoxHinhThucTT.Enabled = false;

            }
        }
    }
}
