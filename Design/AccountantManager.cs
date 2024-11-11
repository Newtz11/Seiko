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
    public partial class AccountantManager : Form
    {
        private Login fLogin;
        public AccountantManager()
        {
            InitializeComponent();
        }
        public AccountantManager(Login fLogin)
        {
            InitializeComponent();
            this.fLogin = fLogin;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            fLogin.Show();
        }

        public void loadForm(object Form)
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

        private void buttonHome_Click(object sender, EventArgs e)
        {
            loadForm(new HomeAccountantManager());
        }

        private void AccountantManager_Load(object sender, EventArgs e)
        {
            loadForm(new HomeAccountantManager());
        }

        private void buttonInfoUser_Click(object sender, EventArgs e)
        {
            loadForm(new AccountantManagerUserInfo());
        }

        private void buttonContractTracking_Click(object sender, EventArgs e)
        {
            
        }
    }
}
