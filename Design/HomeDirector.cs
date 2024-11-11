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
    public partial class HomeDirector : Form
    {
        public HomeDirector()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxSecurity_Click(object sender, EventArgs e)
        {

        }

        private void HomeDirector0_Load(object sender, EventArgs e)
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

        private void buttonContractTracking_Click(object sender, EventArgs e)
        {
            loadform(new GDContractTracking());
        }

        private void buttonProjectSchedule_Click(object sender, EventArgs e)
        {
            loadform(new ProjectSchedule());
        }

        private void buttonPerformanceReport_Click(object sender, EventArgs e)
        {
            loadform(new GDPerformanceReport());
        }

        private void buttonFinacialReports_Click(object sender, EventArgs e)
        {
            loadform(new GDFinancialReport());
        }

        private void buttonContractHistory_Click(object sender, EventArgs e)
        {
            loadform(new GDContractHistory());
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            loadform(new GDLogOut());
        }
    }
}
