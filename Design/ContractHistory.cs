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
    public partial class ContractHistory : Form
    {
        public ContractHistory()
        {
            InitializeComponent();
        }


        private void ContractHistory_Load(object sender, EventArgs e)
        {
            dataGridViewContractHistory.Rows.Add("HD001", "Quay video", "CTY NESTLE", "Nguyen Van A", "20-10-2020", "20-11-2023", "100000000", "Nguyen Van B", "Đã xong");
            dataGridViewContractHistory.Rows.Add("HD002", "Chụp ảnh", "CTY NESTLE", "Nguyen Van A", "20-10-2020", "20-11-2023", "100000000", "Nguyen Van B", "Đã xong");
            dataGridViewContractHistory.Rows.Add("HD003", "Quay video", "CTY NESTLE", "Nguyen Van A", "20-10-2020", "20-11-2023", "100000000", "Nguyen Van B", "Đã xong");
            dataGridViewContractHistory.Rows.Add("HD004", "Chụp ảnh", "CTY NESTLE", "Nguyen Van A", "20-10-2020", "20-11-2023", "100000000", "Nguyen Van B", "Đã xong");
            dataGridViewContractHistory.Rows.Add("HD005", "Quay video", "CTY NESTLE", "Nguyen Van A", "20-10-2020", "20-11-2023", "100000000", "Nguyen Van B", "Đã xong");
            dataGridViewContractHistory.Rows.Add("HD006", "Chụp ảnh", "CTY NESTLE", "Nguyen Van A", "20-10-2020", "20-11-2023", "100000000", "Nguyen Van B", "Đã xong");
        }
    }
}
