using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Design
{
    public partial class ProjectProgress : System.Windows.Forms.Form
    {
        private NguoiDung user;
        private DataTable currentTable;
        private DataGridViewRow previousSelectedRow = null;
        public ProjectProgress(NguoiDung user)
        {
            InitializeComponent();
            ApplyRoundedCorners(buttonSearch);
            ApplyRoundedCorners(buttonXoa);
            ApplyRoundedCorners(buttonSua);
            ApplyRoundedCorners(buttonReset);
            ApplyRoundedCorners(buttonSave);
            ApplyRoundedCorners(buttonThem);
            this.user = user;
            dataGridViewProjectProgress.Columns.Add("Ma Tien Do", "Ma Tien Do");
            dataGridViewProjectProgress.Columns[9].Visible = false;
            // Đăng ký sự kiện CellValidating
            this.dataGridViewProjectProgress.CellValidating += new DataGridViewCellValidatingEventHandler(this.dataGridViewProjectProgress_CellValidating);
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
            dataGridViewProjectProgress.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                string maHopDong = row[0].ToString();
                string tenHopDong = row[1].ToString();
                string noiDungCV = row[2].ToString();
                string tongKhoiLuongCV = row[3].ToString();
                DateTime ngayBatDau = Convert.ToDateTime(row[4]);
                DateTime ngayHetHan = Convert.ToDateTime(row[5]);
                int KhoiLuongCV = Convert.ToInt32(row[6]);
                string NVThucHienCV = row[7].ToString();
                string TinhTrangHD = row[8].ToString();
                string maTienDo = row[9].ToString();
                dataGridViewProjectProgress.Rows.Add(maHopDong, tenHopDong, noiDungCV, tongKhoiLuongCV, ngayBatDau.ToString("dd/MM/yyyy"), ngayHetHan.ToString("dd/MM/yyyy"), KhoiLuongCV, NVThucHienCV, TinhTrangHD, maTienDo);
            }
            currentTable = dt;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchContract = textBoxSearch.Text.ToString();
            string searchTinhTrang = comboBoxTinhTrang.Text.ToString();
            DateTime searchNgayBatDau = dateTimePickerStart.Value;
            DateTime searchNgayKetThuc = dateTimePickerEnd.Value;

            DataTable dt = TienDoHopDongBLL.searchProjectProgressList(searchContract, searchTinhTrang, searchNgayBatDau, searchNgayKetThuc);
            if (dt.Rows.Count == 0 || dt.Columns.Count == 0)
            {
                // DataTable is empty or has no columns
                textBoxSearch.Text = "";

                comboBoxTinhTrang.SelectedIndex = -1;
                comboBoxTinhTrang.Text = "Tình Trạng";
                return;
            }
            else
            {
                dataGridViewProjectProgress.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    string maHopDong = row[0].ToString();
                    string tenHopDong = row[1].ToString();
                    string noiDungCV = row[2].ToString();
                    string khoiLuongCV = row[3].ToString();
                    DateTime ngayBatDau = Convert.ToDateTime(row[4]);
                    DateTime ngayKetThuc = Convert.ToDateTime(row[5]);
                    int tienDo = Convert.ToInt32(row[6]);
                    string tenNguoiThucHien = row[7].ToString();
                    string tinhTrangHD = row[8].ToString();
                    string maTienDo = row[9].ToString();
                    dataGridViewProjectProgress.Rows.Add(maHopDong, tenHopDong, noiDungCV, khoiLuongCV, ngayBatDau.ToString("dd/MM/yyyy"), ngayKetThuc.ToString("dd/MM/yyyy"), tienDo, tenNguoiThucHien, tinhTrangHD, maTienDo);
                }

                textBoxSearch.Text = "";

                comboBoxTinhTrang.SelectedIndex = -1;
                comboBoxTinhTrang.Text = "Tình Trạng";
                currentTable = dt;
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = "";
            comboBoxTinhTrang.SelectedIndex = -1;
            comboBoxTinhTrang.Text = "Tình Trạng";

            dataGridViewProjectProgress.Rows.Clear();
            ProjectProgress_Load(sender, e);
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            dataGridViewProjectProgress.ReadOnly = false;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            if (dataGridViewProjectProgress.SelectedRows.Count > 0)
            {
                dataGridViewProjectProgress.EndEdit();
                previousSelectedRow = null;


                DataGridViewRow selectedRow = dataGridViewProjectProgress.SelectedRows[0];

                string maHopDong = selectedRow.Cells[0].Value.ToString();
                string tenHopDong = selectedRow.Cells[1].Value.ToString();
                string noiDungCV = selectedRow.Cells[2].Value.ToString();
                int khoiLuongCV = Convert.ToInt32(selectedRow.Cells[3].Value.ToString());
                CultureInfo provider = CultureInfo.InvariantCulture;
                DateTime ngayBatDau = DateTime.ParseExact(selectedRow.Cells[4].Value.ToString(), "dd/MM/yyyy", provider);
                DateTime ngayKetThuc = DateTime.ParseExact(selectedRow.Cells[5].Value.ToString(), "dd/MM/yyyy", provider);
                int tienDo = Convert.ToInt32(selectedRow.Cells[6].Value.ToString());
                string tenNguoiThucHien = selectedRow.Cells[7].Value.ToString();
                string maTienDo = selectedRow.Cells[9].Value.ToString();



                TienDoHopDong tiendo = new TienDoHopDong(maTienDo, ngayBatDau, ngayKetThuc, maHopDong, noiDungCV, tienDo, khoiLuongCV, tenNguoiThucHien);
                TienDoHopDongBLL.updateProjectProgress(tiendo);
                MessageBox.Show("Data saved successfully.");


                dataGridViewProjectProgress.ClearSelection();
                dataGridViewProjectProgress.ReadOnly = true;
                ProjectProgress_Load(sender, e);

            }
            else
            {
                MessageBox.Show("Please select a row to edit.");
            }
        }

        private void dataGridViewProjectProgress_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void dataGridViewProjectProgress_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            // Kiểm tra nếu có dữ liệu được nhập vào cột thứ 4 (Khối lượng yêu cầu)
            //if (e.ColumnIndex == 3)  // Cột thứ 4 (Khối lượng yêu cầu)
            //{
            //    if (!string.IsNullOrEmpty(e.FormattedValue.ToString()))
            //    {
            //        // Kiểm tra nếu dữ liệu nhập vào là một số hợp lệ
            //        if (!int.TryParse(e.FormattedValue.ToString(), out int value))
            //        {
            //            // Hiển thị thông báo lỗi nếu không phải là số
            //            MessageBox.Show("Cột này chỉ chấp nhận số nguyên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            e.Cancel = true;  // Ngừng việc nhập dữ liệu
            //            return;
            //        }

            //        // Kiểm tra cột thứ 3 (chỉ số cột là 2) để tính tổng các ký tự số
            //        var column3Value = dataGridViewProjectProgress.Rows[e.RowIndex].Cells[2].Value?.ToString();
            //        if (!string.IsNullOrEmpty(column3Value))
            //        {
            //            // Tính tổng các ký tự số trong cột thứ 3
            //            int sumOfDigits = column3Value.Where(char.IsDigit).Sum(c => c - '0');

            //            // So sánh tổng ký tự số với giá trị người dùng nhập vào cột thứ 4
            //            if (value != sumOfDigits)
            //            {
            //                // Hiển thị thông báo lỗi nếu không khớp
            //                MessageBox.Show($"Tổng các ký tự số trong cột thứ 3 phải bằng {sumOfDigits}!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                e.Cancel = true;  // Ngừng việc nhập dữ liệu
            //            }
            //        }
            //    }
            //}

            //// Kiểm tra nếu là cột thứ 7 (chỉ số cột là 6)
            //if (e.ColumnIndex == 6)  // Cột thứ 7 (chỉ số 6)
            //{
            //    if (!string.IsNullOrEmpty(e.FormattedValue.ToString()))
            //    {
            //        // Kiểm tra nếu dữ liệu nhập vào là một số hợp lệ
            //        if (!int.TryParse(e.FormattedValue.ToString(), out int value))
            //        {
            //            // Hiển thị thông báo lỗi nếu không phải là số
            //            MessageBox.Show("Cột này chỉ chấp nhận số nguyên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            e.Cancel = true;  // Ngừng việc nhập dữ liệu
            //            return;
            //        }

            //        // Lấy giá trị của ô cột thứ 4 (chỉ số cột là 3) cùng hàng
            //        var column4Value = dataGridViewProjectProgress.Rows[e.RowIndex].Cells[3].Value;
            //        if (column4Value != null && int.TryParse(column4Value.ToString(), out int column4Number))
            //        {
            //            // Kiểm tra nếu số nhập vào cột thứ 7 không được lớn hơn số trong cột thứ 4
            //            if (value > column4Number)
            //            {
            //                // Hiển thị thông báo lỗi nếu giá trị trong cột thứ 7 lớn hơn cột thứ 4
            //                MessageBox.Show("Giá trị trong cột thứ 7 không được lớn hơn giá trị trong cột thứ 4!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                e.Cancel = true;  // Ngừng việc nhập dữ liệu
            //            }
            //        }
            //    }
            //}
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            DataGridViewRow selRow = dataGridViewProjectProgress.SelectedRows[0];

            string maHopDong = selRow.Cells[0].Value.ToString();
            string tenHopDong = selRow.Cells[1].Value.ToString();
            string noiDungCV = "";
            int khoiLuongCV = 0;
            string ngayBatDau = selRow.Cells[4].Value.ToString();
            string ngayKetThuc = selRow.Cells[5].Value.ToString();
            int tienDo = 0;
            string tenNguoiThucHien = "";
            string tinhTrangHD = "Chưa thực hiện";
            TienDoHopDongBLL.addTienDo(maHopDong);
            string maTienDo = TienDoHopDongBLL.getMaTienDo(maHopDong);
            dataGridViewProjectProgress.Rows.Add(maHopDong, tenHopDong, noiDungCV, khoiLuongCV, ngayBatDau, ngayKetThuc, tienDo, tenNguoiThucHien, tinhTrangHD, maTienDo);

        }

        private void dataGridViewProjectProgress_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (previousSelectedRow != null && previousSelectedRow != dataGridViewProjectProgress.SelectedRows[0])
            {
                e.Cancel = true;
                MessageBox.Show("Please select only one row at a time.");
            }
            else
            {
                previousSelectedRow = dataGridViewProjectProgress.SelectedRows[0];
            }
        }

        private void dataGridViewProjectProgress_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewProjectProgress.SelectedRows.Count > 1)
            {
                int lastSelectedIndex = dataGridViewProjectProgress.SelectedRows.Count - 1;
                dataGridViewProjectProgress.ClearSelection();
                dataGridViewProjectProgress.Rows[lastSelectedIndex].Selected = true;
            }
        }

        private void dataGridViewProjectProgress_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //previousSelectedRow = null;
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {

        }
    }
}
