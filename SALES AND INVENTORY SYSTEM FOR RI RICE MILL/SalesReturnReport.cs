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
    public partial class frmSalesReturnReport : Form
    {
        public frmSalesReturnReport()
        {
            InitializeComponent();
        }

        private static frmSalesReturnReport list;
        public static frmSalesReturnReport getform
        {
            get
            {
                if (list == null)
                {
                    list = new frmSalesReturnReport();
                }
                return list;
            }
        }

        private void frmSalesReturnReport_Load(object sender, EventArgs e)
        {

        }
    }
}
