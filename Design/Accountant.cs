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
    public partial class Accountant : Form
    {
        public Accountant()
        {
            InitializeComponent();

        }
        private void buttonContractHistory_Click(object sender, EventArgs e)
        {
            loadform(new AccountantContractHistory());
        }

        private void HomeAccountant_Load(object sender, EventArgs e)
        {
            loadform(new HomeAccoutant());
        }
        public void loadform(object Form)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(f);
            this.panel1.Tag = f;
            f.Show();
        }
        private void buttonInfoUser_Click(object sender, EventArgs e)
        {
            loadform(new AccountantUserInfo());

        }

        private void buttonPaymentHistory_Click(object sender, EventArgs e)
        {
            loadform(new AccountantPaymentHistory());
        }

        private void buttonContractTracking_Click(object sender, EventArgs e)
        {
            loadform(new AccountantContractTracking());
        }

        private void buttonCommissionCalculation_Click(object sender, EventArgs e)
        {
            loadform(new AccountantCommission());
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            loadform(new DirectorLogOut());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void buttonHome_Click(object sender, EventArgs e)
        {
            loadform(new HomeAccoutant());
        }
    }
}