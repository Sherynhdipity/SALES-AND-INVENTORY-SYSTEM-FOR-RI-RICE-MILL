using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL
{
    public partial class frmvoidauth : Form
    {
        public string adminPassword { get; set; }
        public frmvoidauth()
        {
            InitializeComponent();
        }

        private void txtAdminPw_KeyDown(object sender, KeyEventArgs e)
        {
            //frmSalesManagement sales = new frmSalesManagement();
            if(e.KeyCode == Keys.Enter)
            {
                adminPassword = txtAdminPw.Text;
                this.Close();
            }
        }

        private void txtAdminPw_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
