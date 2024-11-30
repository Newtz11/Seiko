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
using System.Windows.Forms.DataVisualization.Charting;

namespace Design
{
    public partial class FinancialReport : System.Windows.Forms.Form
    {
        public FinancialReport()
        {
            InitializeComponent();
            ApplyRoundedCorners(buttonSearch);
            ApplyRoundedCorners(buttonLapThongKe);
            ApplyRoundedCorners(buttonCapNhat);
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

        private void groupBoxListUser_Enter(object sender, EventArgs e)
        {

        }

        private void FinancialReport_Load(object sender, EventArgs e)
        {

        }

        private void radioButtonThang_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Tháng 1");
            comboBox1.Items.Add("Tháng 2");
            comboBox1.Items.Add("Tháng 3");
            comboBox1.Items.Add("Tháng 4");
            comboBox1.Items.Add("Tháng 5");
            comboBox1.Items.Add("Tháng 6");
            comboBox1.Items.Add("Tháng 7");
            comboBox1.Items.Add("Tháng 8");
            comboBox1.Items.Add("Tháng 9");
            comboBox1.Items.Add("Tháng 10");
            comboBox1.Items.Add("Tháng 11");
            comboBox1.Items.Add("Tháng 12");
        }

        private void radioButtonQuy_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Quý 1");
            comboBox1.Items.Add("Quý 2");
            comboBox1.Items.Add("Quý 3");
            comboBox1.Items.Add("Quý 4");
        }

        private void radioButtonNam_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Kế toán");
            comboBox1.Items.Add("Trưởng phòng Kế toán");
        }

        private void buttonLapThongKe_Click(object sender, EventArgs e)
        {
            if (radioButtonThang.Checked)
            {
                //lap thong ke theo thang
            }
            else if (radioButtonNam.Checked) 
            {
                //lap thong ke theo quy
                chartFinancialReport.Series.Add("");
            }
            else
            {
                //lap thong ke theo nam
            }
        }
    }
}
