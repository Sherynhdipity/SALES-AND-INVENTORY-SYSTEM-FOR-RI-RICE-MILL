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
    public partial class frmCustomerLists : Form
    {
        private static frmCustomerLists list;
        public static frmCustomerLists getform
        {
            get
            {
                if (list == null)
                {
                    list = new frmCustomerLists();
                }
                return list;
            }
        }
        public frmCustomerLists()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void frmCustomerLists_Load(object sender, EventArgs e)
        {

        }
    }
}
