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
    public partial class ProjectProgress : Form
    {
        private NguoiDung user;
        private DataGridViewRow editRow;
        private DataGridViewCell editCell;
        private string oldValue;
        public ProjectProgress(NguoiDung user)
        {
            InitializeComponent();
            ApplyRoundedCorners(buttonSearch);
            ApplyRoundedCorners(buttonXoa);
            ApplyRoundedCorners(buttonSua);
            ApplyRoundedCorners(buttonReset);
            this.user = user;
            dataGridViewProjectProgress.Columns.Add("Ma Tien Do", "Ma Tien Do");
            dataGridViewProjectProgress.Columns[9].Visible = false;
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
            dataGridViewProjectProgress.ReadOnly = true;
            DataTable dataTable = new DataTable();
       

            dataTable.Columns.Add("maHopDong");
            dataTable.Columns.Add("tenHopDong");
            dataTable.Columns.Add("noiDungCV");
            dataTable.Columns.Add("khoiLuongCV");
            dataTable.Columns.Add("ngayBatDau");
            dataTable.Columns.Add("ngayKetThuc");
            dataTable.Columns.Add("tienDo");
            dataTable.Columns.Add("tenNguoiThucHien");
            dataTable.Columns.Add("tinhTrangHD");
            dataTable.Columns.Add("maTienDo");


            // Populate the DataTable with data from the DataGridView
            foreach (DataGridViewRow row in dataGridViewProjectProgress.Rows)
            {
                DataRow dataRow = dataTable.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dataRow[cell.ColumnIndex] = cell.Value;
                    
                }
                
                dataTable.Rows.Add(dataRow);

            }

            DataTable dt = TienDoHopDongBLL.suaDGVProjectProgress(dataTable);
            dataGridViewProjectProgress.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                string maHopDong = row[0].ToString();
                string tenHopDong = row[1].ToString();
                string noiDungCV = row[2].ToString();
                string khoiLuongCV = row[3].ToString();
                string ngayBatDau = row[4].ToString();
                string ngayKetThuc = row[5].ToString();
                int tienDo = Convert.ToInt32(row[6]);
                string tenNguoiThucHien = row[7].ToString();
                string tinhTrangHD = row[8].ToString();
                string maTienDo = row[9].ToString();
                dataGridViewProjectProgress.Rows.Add(maHopDong, tenHopDong, noiDungCV, khoiLuongCV, ngayBatDau, ngayKetThuc, tienDo, tenNguoiThucHien, tinhTrangHD, maTienDo);
            }
        }
    }
}
