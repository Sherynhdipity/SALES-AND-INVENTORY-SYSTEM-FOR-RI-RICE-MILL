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
    public partial class frmClerkSummaryRep : Form
    {
        public frmClerkSummaryRep()
        {
            InitializeComponent();
        }

        private static frmClerkSummaryRep list;
        public static frmClerkSummaryRep getform
        {
            get
            {
                if (list == null)
                {
                    list = new frmClerkSummaryRep();
                }
                return list;
            }
        }

        private void frmClerkSummaryRep_Load(object sender, EventArgs e)
        {

        }
    }
}
