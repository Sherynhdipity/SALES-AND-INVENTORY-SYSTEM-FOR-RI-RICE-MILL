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
    public partial class frmCashier_Report : Form
    {
        public frmCashier_Report()
        {
            InitializeComponent();
        }
        private static frmCashier_Report list;
        public static frmCashier_Report  getform
        {
            get
            {
                if (list == null)
                {
                    list = new frmCashier_Report();
                }
                return list;
            }
        }
    }
}
