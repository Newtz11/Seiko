using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design
{
    public partial class HomeHeadOfSales : Form
    {
        public HomeHeadOfSales()
        {
            InitializeComponent();
            SetButtonEvents();
        }

        private void buttonContractApproval_Click(object sender, EventArgs e)
        {
            loadform(new TPSContractApproval());
        }

        private void buttonContractTracking_Click(object sender, EventArgs e)
        {
            loadform(new TPSContracTracking());
        }

        private void buttonContractHistory_Click(object sender, EventArgs e)
        {
            loadform(new TPSContractHistory());
        }

        private void HomeHeadOfSales_Load(object sender, EventArgs e)
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
            loadform(new GDUserInfo());
        }

        private void buttonProjectAssignment_Click(object sender, EventArgs e)
        {
            loadform(new TPSProjectDelivery());
        }

        private void buttonProjectSchedule_Click(object sender, EventArgs e)
        {
            loadform(new TPSProjectProgress());
        }

        private void buttonPerformanceReport_Click(object sender, EventArgs e)
        {
            loadform(new GDPerformanceReport());
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            loadform(new GDLogOut());
        }
        private void SetButtonEvents()
        {
            // Duyệt qua các nút và thêm sự kiện cho mỗi nút
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button button)
                {
                    button.BackColor = Color.Gray; // Màu nền mặc định là xám
                    button.Click += Button_Click; // Thêm sự kiện Click
                    button.MouseEnter += Button_MouseEnter; // Thêm sự kiện MouseEnter
                    button.MouseLeave += Button_MouseLeave; // Thêm sự kiện MouseLeave
                }
            }
        }

        // Xử lý sự kiện Click: thay đổi màu khi nhấn và giữ nguyên màu đã chọn
        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            // Đặt lại màu của nút đã chọn trước đó thành xám
            if (selectedButton != null && selectedButton != clickedButton)
            {
                selectedButton.BackColor = Color.Gray;
            }

            // Cập nhật nút đã chọn mới và đổi màu sang trắng
            selectedButton = clickedButton;
            selectedButton.BackColor = Color.White;
        }

        // Xử lý sự kiện MouseEnter: chỉ thay đổi màu nếu nút chưa được chọn
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button hoveredButton = sender as Button;
            if (hoveredButton != selectedButton)
            {
                hoveredButton.BackColor = Color.LightGray;
            }
        }

        // Xử lý sự kiện MouseLeave: trả lại màu xám nếu nút chưa được chọn
        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button hoveredButton = sender as Button;
            if (hoveredButton != selectedButton)
            {
                hoveredButton.BackColor = Color.Gray;
            }
        }
        private Button selectedButton;
    }
}
