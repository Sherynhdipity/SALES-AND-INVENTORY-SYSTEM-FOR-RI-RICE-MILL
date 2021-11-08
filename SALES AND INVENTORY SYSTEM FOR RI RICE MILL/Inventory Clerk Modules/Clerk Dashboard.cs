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
    public partial class ucInventoryDashboard : UserControl
    {
        private static ucInventoryDashboard dashboard;
        public static ucInventoryDashboard dashboardInstance
        {
            get
            {
                if (dashboard == null)
                    dashboard = new ucInventoryDashboard();
                return dashboard;
            }
        }
        public ucInventoryDashboard()
        {
            InitializeComponent();
        }

        }

    }

