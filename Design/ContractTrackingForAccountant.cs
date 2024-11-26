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
    public partial class ContractTrackingForAccountant : Form
    {
        private NguoiDung user;
        private bool isEditing = false;
        private int selectedRowIndex = -1;
        private bool enableDoubleClick;

        public ContractTrackingForAccountant(NguoiDung user)
        {
            InitializeComponent();
            ApplyRoundedCorners(button1);
            ApplyRoundedCorners(button2);
            ApplyRoundedCorners(button3);
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

        //button them
        private void button2_Click(object sender, EventArgs e)
        {
            //them nhan vien phu trach 

            //dataGridViewContractTracking.Rows[selectedRowIndex].Cells[8].ReadOnly = false;
            dataGridViewContractTracking.ReadOnly = false;

            //this.PhuTrachThanhToan.Items.Add("NhanVien 1");
            //this.PhuTrachThanhToan.Items.Add("NhanVien 2");

            DataTable dt = NguoiDungBLL.getAccountant();
            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine(row[0].ToString());
                this.PhuTrachThanhToan.Items.Add(row[0].ToString());
            }
            isEditing = true;




        }

        private void dataGridViewContractTracking_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {



            string maHD = this.dataGridViewContractTracking.CurrentRow.Cells[0].Value.ToString();
            HopDong selectedContract = HopDongBLL.getSeletedContract(maHD);
            ContractDetail fContractDetail = new ContractDetail(user, selectedContract, this);
            fContractDetail.Show();



        }

        private void ContractTrackingForAccountant_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dataGridViewContractTracking.Rows.Clear();
            dt = HopDongBLL.loadContract(user);
            foreach (DataRow row in dt.Rows)
            {
                string maHopDong = row[0].ToString();
                string tenHopDong = row[1].ToString();
                string tenCongTyCaNhan = row[2].ToString();
                string nguoiLienHe = row[3].ToString();
                DateTime ngayBatDau = Convert.ToDateTime(row[4]);
                DateTime ngayHetHan = Convert.ToDateTime(row[5]);
                int giaTriHopDong = Convert.ToInt32(row[6]);
                string tinhTrangHopDong = row[7].ToString();
                //string phuTrachQuanLy = row[8].ToString();
                dataGridViewContractTracking.Rows.Add(maHopDong, tenHopDong, tenCongTyCaNhan, nguoiLienHe, ngayBatDau.ToString("dd/MM/yyyy"), ngayHetHan.ToString("dd/MM/yyyy"), giaTriHopDong, tinhTrangHopDong);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                // Save the edited row to the database
                // ... (your database saving logic here)

                // Reset the editing state
                dataGridViewContractTracking.Rows[selectedRowIndex].ReadOnly = true;
                isEditing = false;
                selectedRowIndex = -1;
            }
        }

        private void dataGridViewContractTracking_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                // Store the selected row index
                selectedRowIndex = e.RowIndex;
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {


        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            List<List<string>> lst = new List<List<string>>();

            foreach (DataGridViewRow row in dataGridViewContractTracking.Rows)
            {
                List<string> tempList = new List<string>();

                if (row.Cells[0] != null && row.Cells[0].Value != null)
                {
                    tempList.Add(row.Cells[0].Value.ToString());
                }

                if (row.Cells[8] != null && row.Cells[8].Value != null)
                {
                    tempList.Add(row.Cells[8].Value.ToString());
                }

                lst.Add(tempList);
            }

            HopDongBLL.updatePayment(lst);
            dataGridViewContractTracking.ReadOnly = true;
        }
    }
}
