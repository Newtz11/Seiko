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
    public partial class SaleManager : Form
    {
        public SaleManager()
        {
            InitializeComponent();
        }

        private void buttonContractApproval_Click(object sender, EventArgs e)
        {
            loadform(new SaleManagerContractApproval());
        }

        private void buttonContractTracking_Click(object sender, EventArgs e)
        {
            loadform(new SaleManagerContracTracking());
        }

        private void buttonContractHistory_Click(object sender, EventArgs e)
        {
            loadform(new SaleManagerContractHistory());
        }

        private void HomeSalesManager_Load(object sender, EventArgs e)
        {
            loadform(new HomeSaleManager());
        }
        public void loadform(object Form)
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

        private void buttonInfoUser_Click(object sender, EventArgs e)
        {
            loadform(new DirectorUserInfo());
        }

        private void buttonProjectAssignment_Click(object sender, EventArgs e)
        {
            loadform(new SaleManagerProjectDelivery());
        }

        private void buttonProjectSchedule_Click(object sender, EventArgs e)
        {
            loadform(new SaleManagerProjectProgress());
        }

        private void buttonPerformanceReport_Click(object sender, EventArgs e)
        {
            loadform(new DirectorPerformanceReport());
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            loadform(new DirectorLogOut());
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            loadform(new HomeSaleManager());
        }
    }
}
