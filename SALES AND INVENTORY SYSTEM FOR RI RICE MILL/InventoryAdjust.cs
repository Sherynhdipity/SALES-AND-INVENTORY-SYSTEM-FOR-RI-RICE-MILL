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
    public partial class frmInventoryAdjust : Form
    {
        public frmInventoryAdjust()
        {
            InitializeComponent();
        }
        private static frmInventoryAdjust det;
        public static frmInventoryAdjust getform
        {
            get
            {
                if (det == null)
                {
                    det = new frmInventoryAdjust();
                }
                return det;
            }
        }
        private void frmInventoryAdjust_Load(object sender, EventArgs e)
        {

        }
    }
}
