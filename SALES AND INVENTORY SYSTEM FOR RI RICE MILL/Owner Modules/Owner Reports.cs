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
    public partial class ucReports : UserControl
    {
        private static ucReports reports;
        public static ucReports reportsInstance
        {
            get
            {
                if (reports == null)
                    reports = new ucReports();
                return reports;
            }
        }
        public ucReports()
        {
            InitializeComponent();
        }

        private void btnViewSalesReports_Click(object sender, EventArgs e)
        {
            frmViewSalesReport salesReport = new frmViewSalesReport();
            salesReport.Show();
        }

        private void btnViewInventoryReports_Click(object sender, EventArgs e)
        {
            frmViewInventoryReport inventoryReport = new frmViewInventoryReport();
            inventoryReport.Show();
        }

        private void frmReports_Load(object sender, EventArgs e)
        {

        }
    }
}
