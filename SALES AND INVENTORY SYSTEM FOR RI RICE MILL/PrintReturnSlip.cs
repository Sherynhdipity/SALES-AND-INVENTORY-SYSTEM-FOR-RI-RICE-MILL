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
    public partial class frmPrintReturnSlip : Form
    {
        private static frmPrintReturnSlip frm;
        public static frmPrintReturnSlip getform
        {
            get
            {
                if (frm == null)
                {
                    frm = new frmPrintReturnSlip();
                }
                return frm;
            }
        }
        public frmPrintReturnSlip()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
