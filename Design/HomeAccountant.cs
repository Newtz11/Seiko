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
    public partial class HomeAccountant : Form
    {
        private Login fLogin;
        public HomeAccountant(Login fLogin)
        {
            InitializeComponent();
            this.fLogin = fLogin;
        }

        private void buttonContractHistory_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            fLogin.Show();
        }
    }
}
