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
    public partial class Sale : System.Windows.Forms.Form
    {
        private NguoiDung user;
        public Sale(NguoiDung user)
        {
            InitializeComponent();
            ApplyRoundedCorners(buttonInfoUser);
            ApplyRoundedCorners(buttonHome);
            ApplyRoundedCorners(buttonLogout);
            ApplyRoundedCorners(buttonInfoUser);
            ApplyRoundedCorners(buttonProjectProgress);
            ApplyRoundedCorners(buttonContractHistory);
            ApplyRoundedCorners(buttonCommission);
            ApplyRoundedCorners(buttonContractTracking);
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
        private void buttonContractTracking_Click(object sender, EventArgs e)
        {
            loadform(new CreateContract(user));
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            loadform(new Home());
        }

        private void buttonContractHistory_Click(object sender, EventArgs e)
        {
            loadform(new ContractHistory());
        }
        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            System.Windows.Forms.Form f = Form as System.Windows.Forms.Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void buttonInfoUser_Click(object sender, EventArgs e)
        {
            loadform(new PersonalInformation(user));
        }

        private void buttonContractTracking_Click_1(object sender, EventArgs e)
        {
            loadform(new ContractTrackingForSale(user));
        }

        private void buttonProjectSchedule_Click(object sender, EventArgs e)
        {
            loadform(new ProjectProgress(user));
        }

        private void buttonCommission_Click(object sender, EventArgs e)
        {
            loadform(new SaleCommissionView());
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            LogOut logOut = new LogOut();
            logOut.Show();
        }

        private void Sale_Load(object sender, EventArgs e)
        {
            loadform(new Home());
        }
    }
}
