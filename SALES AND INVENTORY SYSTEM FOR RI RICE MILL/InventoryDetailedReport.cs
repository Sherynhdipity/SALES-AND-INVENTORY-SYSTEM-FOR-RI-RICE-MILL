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
    public partial class frmInventoryDetailed : Form
    {
        public frmInventoryDetailed()
        {
            InitializeComponent();
        }

        private static frmInventoryDetailed det;
        public static frmInventoryDetailed getform
        {
            get
            {
                if (det == null)
                {
                    det = new frmInventoryDetailed();
                }
                return det;
            }
        }

        private void frmInventoryDetailedReport_Load(object sender, EventArgs e)
        {

        }
    }
}
