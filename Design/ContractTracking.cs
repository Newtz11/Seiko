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

namespace Design
{
    public partial class ContractTracking : Form
    {
        public ContractTracking()
        {
            InitializeComponent();
            ApplyRoundedCorners(buttonSearch);
            ApplyRoundedCorners(buttonThem);
            ApplyRoundedCorners(buttonXoa);
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

        private void dataGridViewContractTracking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewContractTracking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            CreateContract createContract = new CreateContract();
            createContract.Show();
        }

        private void ContractTracking_Load(object sender, EventArgs e)
        {
            dataGridViewContractTracking.Rows.Add("HD001","HELLO","CTY NESTLE","Nguyen Van A","20-10-2020","20-11-2023","100000000","Nguyen Van B","Đang thực hiện");
            dataGridViewContractTracking.Rows.Add("HD002", "HELLO", "CTY NESTLE", "Nguyen Van A", "20-10-2020", "20-11-2023", "100000000", "Nguyen Van B", "Đang thực hiện");
            dataGridViewContractTracking.Rows.Add("HD003", "HELLO", "CTY NESTLE", "Nguyen Van A", "20-10-2020", "20-11-2023", "100000000", "Nguyen Van B", "Đang thực hiện");
            dataGridViewContractTracking.Rows.Add("HD004", "HELLO", "CTY NESTLE", "Nguyen Van A", "20-10-2020", "20-11-2023", "100000000", "Nguyen Van B", "Đang thực hiện");
            dataGridViewContractTracking.Rows.Add("HD005", "HELLO", "CTY NESTLE", "Nguyen Van A", "20-10-2020", "20-11-2023", "100000000", "Nguyen Van B", "Đang thực hiện");
            dataGridViewContractTracking.Rows.Add("HD006", "HELLO", "CTY NESTLE", "Nguyen Van A", "20-10-2020", "20-11-2023", "100000000", "Nguyen Van B", "Đang thực hiện");
        }
    }
}
