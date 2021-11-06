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
    public partial class ucDashboard : UserControl
    {
        private static ucDashboard dashboard;
        public static ucDashboard dashboardInstance
        {
            get
            {
                if (dashboard == null)
                    dashboard = new ucDashboard();
                return dashboard;
            }
        }
        public ucDashboard()
        {
            InitializeComponent();
        }

        }

    }

