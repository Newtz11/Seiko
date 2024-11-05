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
    public partial class HomeDirector0 : Form
    {
        private Login fLogin;

        public HomeDirector0(Login fLogin)
        {
            InitializeComponent();
            this.fLogin = fLogin;   
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxSecurity_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            fLogin.Show();
        }
    }
}
