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
    public partial class HomeSuperAdmin : Form
    {
        private Login fLogin;
        public HomeSuperAdmin(Login fLogin)
        {
            InitializeComponent();
            this.fLogin = fLogin;
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            SuperAdminCreateAccount fsuperAdminCreateAccount = new SuperAdminCreateAccount();
            this.Hide();
            fsuperAdminCreateAccount.Show();

        }

        private void buttonUserList_Click(object sender, EventArgs e)
        {
            SAListUser fSAListUser = new SAListUser();
            this.Hide();
            fSAListUser.Show();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            fLogin.Show();

        }
    }
}
