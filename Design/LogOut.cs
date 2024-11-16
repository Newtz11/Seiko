﻿using System;
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
    public partial class LogOut : Form
    {
        public LogOut()
        {
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e) 
        {
            Login login = new Login();
            login.Show();

            this.Close();
        }

        private void buttonComeBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
