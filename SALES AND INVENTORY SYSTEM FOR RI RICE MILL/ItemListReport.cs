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
    public partial class frmItemListReport : Form
    {
        public frmItemListReport()
        {
            InitializeComponent();
        }

        private static frmItemListReport list;
        public static frmItemListReport getform
        {
            get
            {
                if (list == null)
                {
                    list = new frmItemListReport();
                }
                return list;
            }
        }

        private void frmItemListReport_Load(object sender, EventArgs e)
        {

        }
    }
}
