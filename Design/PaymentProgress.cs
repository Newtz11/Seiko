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
    public partial class PaymentProgress : System.Windows.Forms.Form
    {

        private NguoiDung user;
        //private int action = 0; //0 -> ko lam gi ca, 1->them, 2-> sua
        public PaymentProgress(NguoiDung user)
        {
            InitializeComponent();
            ApplyRoundedCorners(buttonSearch);
            ApplyRoundedCorners(buttonSua);
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

        private void PaymentProgress_Load(object sender, EventArgs e)
        {
            dataGridViewPaymentProgress.Rows.Clear();
            DataTable dt = GiaiDoanThanhToanBLL.loadPaymentProgress();
            foreach (DataRow row in dt.Rows)
            {
                string MaHopDong = row[0].ToString();
                string TenHopDong = row[1].ToString();
                int GiaiDoan = Convert.ToInt32(row[2]);
                DateTime NgayThanhToan = Convert.ToDateTime(row[3]);
                int PhanTramThanhToan = Convert.ToInt32(row[4]);
                int GiaTriThanhToan = Convert.ToInt32(row[5]);
                string trangThaiTT = "";
                bool TrangThai = (bool)row[6];
                if (TrangThai == true) trangThaiTT = "Đã thanh toán";
                else trangThaiTT = "Chưa thanh toán";
                string ngayNhanTT = "";
                if (row[7] != DBNull.Value)
                {
                    DateTime NgayNhanThanhToan = Convert.ToDateTime(row[7]);
                    ngayNhanTT = NgayNhanThanhToan.ToString("dd/MM/yyyy");
                }
                string GhiChu = row[8].ToString();

                dataGridViewPaymentProgress.Rows.Add(MaHopDong, TenHopDong, GiaiDoan, NgayThanhToan.ToString("dd/MM/yyyy"), PhanTramThanhToan, GiaTriThanhToan, trangThaiTT, ngayNhanTT, GhiChu);
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (user.vaiTro == "Kế toán")
            {
                string maHD = this.dataGridViewPaymentProgress.CurrentRow.Cells[0].Value.ToString();
                string tenHD = this.dataGridViewPaymentProgress.CurrentRow.Cells[1].Value.ToString();
                string giaiDoan = this.dataGridViewPaymentProgress.CurrentRow.Cells[2].Value.ToString();
                DateTime ngayThanhToan;
                if (!DateTime.TryParseExact(this.dataGridViewPaymentProgress.CurrentRow.Cells[3].Value.ToString(),
                    "dd/MM/yyyy", // Định dạng ngày của bạn
                    System.Globalization.CultureInfo.InvariantCulture,
                    System.Globalization.DateTimeStyles.None,
                    out ngayThanhToan))
                {
                    MessageBox.Show("Ngày thanh toán không hợp lệ");
                    return;
                }
                int phanTramThanhToan = Convert.ToInt32(this.dataGridViewPaymentProgress.CurrentRow.Cells[4].Value);
                int giaTriThanhToan = Convert.ToInt32(this.dataGridViewPaymentProgress.CurrentRow.Cells[5].Value);
                string trangThai = this.dataGridViewPaymentProgress.CurrentRow.Cells[6].Value.ToString();
                bool trangThaiTT = false;
                if (trangThai.Equals("Đã thanh toán"))
                {
                    trangThaiTT = true;
                }
                DateTime ngayNhanThanhToan;
                if (!DateTime.TryParseExact(this.dataGridViewPaymentProgress.CurrentRow.Cells[7].Value.ToString(),
                    "dd/MM/yyyy", // Định dạng ngày của bạn
                    System.Globalization.CultureInfo.InvariantCulture,
                    System.Globalization.DateTimeStyles.None,
                    out ngayNhanThanhToan))
                {
                    MessageBox.Show("Ngày nhận thanh toán không hợp lệ");
                    return;
                }
                string ghiChu = this.dataGridViewPaymentProgress.CurrentRow.Cells[8].Value.ToString();
                int action = 2;
                PaymentProgressEdit paymentProgressEdit = new PaymentProgressEdit(maHD, action, tenHD, giaiDoan, ngayThanhToan, phanTramThanhToan, giaTriThanhToan, trangThaiTT, ngayNhanThanhToan, ghiChu);
                paymentProgressEdit.ShowDialog();
            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (user.vaiTro == "Kế toán")
            {
                string maHD = this.dataGridViewPaymentProgress.CurrentRow.Cells[0].Value.ToString();
                string tenHD = this.dataGridViewPaymentProgress.CurrentRow.Cells[1].Value.ToString();
                string giaiDoan = this.dataGridViewPaymentProgress.CurrentRow.Cells[2].Value.ToString();


                int action = 1;
                PaymentProgressEdit paymentProgressEdit = new PaymentProgressEdit(maHD, action, tenHD, giaiDoan);

                paymentProgressEdit.ShowDialog();
            }


        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchGiaiDoan = textBoxSearch.Text.ToString().Trim();
            string searchTrangThai = comboBoxTrangThai.Text.ToString();
            DateTime searchNgayThanhToan = dateTimePickerNgayThanhToan.Value;
            DateTime searchNgayNhanThanhToan = dateTimePickerNgayNhanThanhToan.Value;
            DataTable dt = GiaiDoanThanhToanBLL.SearchGiaiDoan(searchGiaiDoan, searchTrangThai, searchNgayThanhToan, searchNgayNhanThanhToan);
            if (dt.Rows.Count == 0 || dt.Columns.Count == 0)
            {
                // DataTable is empty or has no columns
                textBoxSearch.Text = "";
                comboBoxTrangThai.SelectedIndex = -1;
                comboBoxTrangThai.Text = "Trạng thái";
                return;
            }
            else
            {

                dataGridViewPaymentProgress.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {

                    string MaHopDong = row[0].ToString();
                    string TenHopDong = row[1].ToString();
                    int GiaiDoan = Convert.ToInt32(row[2]);
                    DateTime NgayThanhToan = Convert.ToDateTime(row[3]);
                    int PhanTramThanhToan = Convert.ToInt32(row[4]);
                    int GiaTriThanhToan = Convert.ToInt32(row[5]);
                    string trangThaiTT = "";
                    bool TrangThai = (bool)row[6];
                    if (TrangThai == true) trangThaiTT = "Đã thanh toán";
                    else trangThaiTT = "Chưa thanh toán";
                    string ngayNhanTT = "";
                    if (row[7] != DBNull.Value)
                    {
                        DateTime NgayNhanThanhToan = Convert.ToDateTime(row[7]);
                        ngayNhanTT = NgayNhanThanhToan.ToString("dd/MM/yyyy");
                    }
                    string GhiChu = row[8].ToString();
                    dataGridViewPaymentProgress.Rows.Add(MaHopDong, TenHopDong, GiaiDoan, NgayThanhToan.ToString("dd/MM/yyyy"), PhanTramThanhToan, GiaTriThanhToan, trangThaiTT, ngayNhanTT, GhiChu);
                }

                textBoxSearch.Text = "";

                comboBoxTrangThai.SelectedIndex = -1;
                comboBoxTrangThai.Text = "Trạng thái";

            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = "";
            comboBoxTrangThai.SelectedIndex = -1;
            comboBoxTrangThai.Text = "Trạng thái";

            dataGridViewPaymentProgress.Rows.Clear();
            PaymentProgress_Load(sender, e);
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (dataGridViewPaymentProgress.SelectedRows.Count > 0) 
            {

                string maHD = this.dataGridViewPaymentProgress.CurrentRow.Cells[0].Value.ToString();
                string giaiDoan = this.dataGridViewPaymentProgress.CurrentRow.Cells[2].Value.ToString();
                GiaiDoanThanhToanBLL.delGiaiDoanTT(maHD, giaiDoan);

                MessageBox.Show("Xóa thành công!");
            }
            else
            {
                MessageBox.Show("Xóa không thành công!");
            }
        }
    }
}
