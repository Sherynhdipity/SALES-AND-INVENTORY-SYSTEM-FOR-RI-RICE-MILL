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
    public partial class frmInventoryValuationReport : Form
    {
        public frmInventoryValuationReport()
        {
            InitializeComponent();
        }
        private static frmInventoryValuationReport frm;
        public static frmInventoryValuationReport getform
        {
            get
            {
                if (frm == null)
                {
                    frm = new frmInventoryValuationReport();
                }
                return frm;
            }
        }

        private void frmInventoryValuation_Load(object sender, EventArgs e)
        {

        }
    }
}
