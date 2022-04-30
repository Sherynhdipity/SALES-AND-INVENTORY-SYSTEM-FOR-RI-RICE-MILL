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
    public partial class frmPrintReceipt : Form
    {
        private static frmPrintReceipt frm;
        public static frmPrintReceipt getform
        {
            get
            {
                if (frm == null)
                {
                    frm = new frmPrintReceipt();
                }
                return frm;
            }
        }
        public frmPrintReceipt()
        {
            InitializeComponent();
        }

        private void PrintReciept_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
        }
    }
}
