using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.Owner_Modules
{
    public partial class frmShowInventoryButtons : Form
    {
        public frmShowInventoryButtons()
        {
            InitializeComponent();
        }

        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            Owner_Modules.frmOwnerInventoryReport f1 = new Owner_Modules.frmOwnerInventoryReport();
            f1.Show();
            this.Close();
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            Owner_Modules.frmInventoryAdjustmentReport f2 = new Owner_Modules.frmInventoryAdjustmentReport();
            f2.Show();
            this.Close();
        }

        private void btnViewInventoryReports_Click(object sender, EventArgs e)
        {
            Owner_Modules.frmInventoryValuation f3 = new Owner_Modules.frmInventoryValuation();
            f3.Show();
            this.Close();
        }
    }
}
