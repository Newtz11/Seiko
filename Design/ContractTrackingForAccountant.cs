using DTO;
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
    public partial class ContractTrackingForAccountant : Form
    {
        private NguoiDung user;
        public ContractTrackingForAccountant(NguoiDung user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewContractTracking_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //ContractDetail fContractDetail = new ContractDetail(user);
        }
    }
}
