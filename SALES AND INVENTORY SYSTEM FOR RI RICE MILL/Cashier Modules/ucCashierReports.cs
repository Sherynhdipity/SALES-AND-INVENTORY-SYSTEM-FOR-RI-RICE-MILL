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
    public partial class ucCashierReports : UserControl
    {
        private static ucCashierReports cashierReports;
        public static ucCashierReports cashierReportsInstance
        {
            get
            {
                if (cashierReports == null)
                    cashierReports = new ucCashierReports();
                return cashierReports;
            }
        }
        public ucCashierReports()
        {
            InitializeComponent();
        }

        private void btnViewSalesReports_Click(object sender, EventArgs e)
        {
            frmViewSalesReport salesReport = new frmViewSalesReport();
            salesReport.Show();
        }
    }
}
