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
                MessageBox.Show("Chỉnh sửa tiến độ thành công.");


                dataGridViewProjectProgress.ClearSelection();
                dataGridViewProjectProgress.ReadOnly = true;
                ProjectProgress_Load(sender, e);

            }
            else
            {
                MessageBox.Show("Hãy chọn hàng thông tin bạn muốn sửa.");
            }
        }

        private void dataGridViewProjectProgress_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void dataGridViewProjectProgress_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            
            
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
                MessageBox.Show("Chỉ được chọn một hàng duy nhất bạn muốn sửa.");
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
            if (dataGridViewProjectProgress.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewProjectProgress.SelectedRows[0];
                string maTienDo = selectedRow.Cells[9].Value.ToString();
                int soTienDoCuaHD = TienDoHopDongBLL.checkDelTienDo(maTienDo);
                if (soTienDoCuaHD <= 1)
                {
                    MessageBox.Show("Tiến độ duy nhất của hợp đồng không thể xóa!");
                    return;

                }
                TienDoHopDongBLL.delTienDo(maTienDo);
                MessageBox.Show("Xóa thành công tiến độ");
            }
            else
            {
                MessageBox.Show("Xóa không thành công tiến độ");
            }
        }
    }
}
