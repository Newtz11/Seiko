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
    public partial class SuperAdmin : Form
    {
        private Login fLogin;
        public SuperAdmin(Login fLogin)
        {
            InitializeComponent();
            this.fLogin = fLogin;
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            loadForm(new SuperAdminCreateAccount());

        }

        private void buttonUserList_Click(object sender, EventArgs e)
        {
            loadForm(new SAListUser());
        }



        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            fLogin.Show();
        }

        private void HomeSuperAdmin_Load(object sender, EventArgs e)
        {
            loadForm(new HomeSuperAdmin());
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
            loadForm(new HomeSuperAdmin());
        }

        private void buttonInformation_Click(object sender, EventArgs e)
        {

        }

        private void buttonContractTracking_Click(object sender, EventArgs e)
        {

        }

        private void buttonProjectSchedule_Click(object sender, EventArgs e)
        {

        }

        private void buttonPerformanceReport_Click(object sender, EventArgs e)
        {

        }

        private void buttonFinacialReports_Click(object sender, EventArgs e)
        {

        }

        private void buttonRole_Click(object sender, EventArgs e)
        {

        }
    }
}
