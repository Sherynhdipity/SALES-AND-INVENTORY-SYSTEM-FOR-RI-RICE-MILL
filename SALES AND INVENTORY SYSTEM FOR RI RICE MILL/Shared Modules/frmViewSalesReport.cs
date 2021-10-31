using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL
{
    public partial class frmViewSalesReport : Form
    {
        public frmViewSalesReport()
        {
            InitializeComponent();
        }
        void PopulateMonth()
        {
            try
            {

                //clear all data from combobox
                drpMonth.Items.Clear();
                //add default item
                drpMonth.Items.Add("Select");
                //fill array from System.Globalization.DateTimeFormatInfo.InvariantInfo
                var Months = System.Globalization.DateTimeFormatInfo.InvariantInfo.MonthNames;
                //loop array for add items
                foreach (string sm in Months)
                {
                    if (sm != "")
                        drpMonth.Items.Add(sm);
                }
                //set selected item for display on startup
                drpMonth.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Now.Month);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        void PopulateYear()
        {
            try
            {
                //clear all data from combobox
                drpYear.Items.Clear();
                //add default item
                drpYear.Items.Add("Select");
                //loop array for add items
                for (int i = DateTime.Now.Year; i < DateTime.Now.Year + 15; i++)
                {
                    drpYear.Items.Add(i);
                }
                //set selected item for display on startup
                drpYear.Text = DateTime.Now.Year.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void FrmViewSalesReport_Load(object sender, EventArgs e)
        {
            PopulateMonth();
            PopulateYear();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
