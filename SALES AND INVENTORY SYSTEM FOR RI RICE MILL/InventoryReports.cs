﻿using System;
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
    public partial class frmInventoryReport : Form
    {

        private static frmInventoryReport frm;
        public static frmInventoryReport getform
        {
            get
            {
                if (frm == null)
                {
                    frm = new frmInventoryReport();
                }
                return frm;
            }
        }
        public frmInventoryReport()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}