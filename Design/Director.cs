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
    public partial class Director : Form
    {
        public Director()
        {
            InitializeComponent();
            ApplyRoundedCorners(buttonHome);
            ApplyRoundedCorners(buttonInfoUser);
            ApplyRoundedCorners(buttonContractTracking);
            ApplyRoundedCorners(buttonProjectProgress);
            ApplyRoundedCorners(buttonPerformanceReport);
            ApplyRoundedCorners(buttonFinacialReports);
            ApplyRoundedCorners(buttonContractHistory);
            ApplyRoundedCorners(buttonLogout);
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

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxSecurity_Click(object sender, EventArgs e)
        {

        }

        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void buttonInfoUser_Click(object sender, EventArgs e)
        {
            loadform(new PersonalInformation());
        }

        private void buttonContractTracking_Click(object sender, EventArgs e)
        {
            loadform(new ContractTracking());
        }

        private void buttonProjectSchedule_Click(object sender, EventArgs e)
        {
            loadform(new ProjectProgress());
        }

        private void buttonPerformanceReport_Click(object sender, EventArgs e)
        {
            loadform(new PerformanceReport());
        }

        private void buttonFinacialReports_Click(object sender, EventArgs e)
        {
            loadform(new FinancialReport());
        }

        private void buttonContractHistory_Click(object sender, EventArgs e)
        {
            loadform(new ContractHistory());
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            LogOut logOut = new LogOut();
            logOut.Show();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            loadform(new Home());
        }

        private void Director_Load(object sender, EventArgs e)
        {
            loadform(new Home());
        }
    }
}
