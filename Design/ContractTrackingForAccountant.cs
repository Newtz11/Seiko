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
            dataGridViewContractTracking.ReadOnly = false;

        }

        private void dataGridViewContractTracking_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridViewContractTracking.Rows[e.RowIndex];

            // Check if the last cell is empty
            int lastColumnIndex = dataGridViewContractTracking.Columns.Count - 1;
            DataGridViewCell lastCell = selectedRow.Cells[lastColumnIndex];

            if (lastCell.Value == null || string.IsNullOrEmpty(lastCell.Value.ToString()))
            {
                // Last cell is empty, show a message or take other actions
                MessageBox.Show("Hợp đồng này chưa có nhân viên quản lý thanh toán");
            }
            else
            {
                // Last cell is not empty, open the ContractDetail form
                //ContractDetail fContractDetail = new ContractDetail(user);
                // ... other actions ...
            }
        }

        private void ContractTrackingForAccountant_Load(object sender, EventArgs e)
        {
            
        }
    }
}
