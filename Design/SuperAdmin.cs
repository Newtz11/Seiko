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
    public partial class SuperAdmin : Form
    {
        private NguoiDung user;
        public SuperAdmin(NguoiDung user)
        {
            InitializeComponent();
            ApplyRoundedCorners(buttonHome);
            ApplyRoundedCorners(buttonInformation);
            ApplyRoundedCorners(buttonUserList);
            ApplyRoundedCorners(buttonContractTracking);
            ApplyRoundedCorners(buttonProjectProgress);
            ApplyRoundedCorners(buttonPerformanceReport);
            ApplyRoundedCorners(buttonFinacialReport);
            ApplyRoundedCorners(buttonRole);
            ApplyRoundedCorners(buttonContractHistory);
            ApplyRoundedCorners(buttonLogout);
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

        private void buttonUserList_Click(object sender, EventArgs e)
        {
            loadForm(new ListUser(user));
        }


        private void buttonLogout_Click(object sender, EventArgs e)
        {
            LogOut logOut = new LogOut();
            logOut.Show();
        }

        public void loadForm(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            loadForm(new Home());
        }

        private void buttonInformation_Click(object sender, EventArgs e)
        {
            loadForm(new PersonalInformation(user));
        }

        private void buttonContractTracking_Click(object sender, EventArgs e)
        {
            loadForm(new ContractTrackingForSale(user));
        }

        private void buttonRole_Click(object sender, EventArgs e)
        {
            loadForm(new SuperAdminDecentralization());
        }

        private void buttonFinacialReport_Click(object sender, EventArgs e)
        {
            loadForm(new FinancialReport());
        }

        private void buttonProjectProgress_Click(object sender, EventArgs e)
        {
            loadForm(new ProjectProgress(user));
        }

        private void buttonPerformanceReport_Click(object sender, EventArgs e)
        {
            loadForm(new PerformanceReport());
        }

        private void buttonContractHistory_Click(object sender, EventArgs e)
        {
            loadForm(new ContractHistory());
        }

        private void SuperAdmin_Load(object sender, EventArgs e)
        {
            loadForm(new Home());
        }
    }
}
