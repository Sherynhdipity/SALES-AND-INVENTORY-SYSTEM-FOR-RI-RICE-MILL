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
    public partial class frmRestockReporting : Form
    {
        public frmRestockReporting()
        {
            InitializeComponent();
        }

        private static frmRestockReporting frm;
        public static frmRestockReporting getform
        {
            get
            {
                if (frm == null)
                {
                    frm = new frmRestockReporting();
                }
                return frm;
            }
        }

        private void frmRestockReport_Load(object sender, EventArgs e)
        {

        }
    }
}
