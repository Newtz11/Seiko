using BLL;
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
    public partial class SAListUser : Form
    {
        public int searchCounter = 0;
        public SAListUser()
        {
            InitializeComponent();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string hoTen = textBoxSearch.Text;
            searchCounter++;
            if (searchCounter > 3)
            {
                searchCounter = 0;
                DataTable dt = NguoiDungBLL.searchName(hoTen);
                dataGridViewListUser.DataSource = dt;
            }
        }
    }
}
