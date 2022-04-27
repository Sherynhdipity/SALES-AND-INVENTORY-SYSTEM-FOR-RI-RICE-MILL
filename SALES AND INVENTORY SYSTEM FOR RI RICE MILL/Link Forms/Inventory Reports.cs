using Microsoft.Reporting.WinForms;
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
    public partial class frmViewInventoryReport : Form
    {
        public frmViewInventoryReport()
        {
            InitializeComponent();

            BindingSource bs = (BindingSource)dgvInventoryReport.DataSource;//You should first convert DataSourse into Binding Sourse
          
        }

        public class Inventory 
        { 
            public int ProductCode { get; set; }
            public string ProductName { get; set; }
            public string ProductVariety { get; set; }

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

        private void btnExReport_Click(object sender, EventArgs e)
        {
            //ReportViewer inventoryReport = new ReportViewer(); //Your ReportViewer Control
            //ReportDataSource rds = new ReportDataSource("DataSet1_Customers_DataTable1", dt); // ReportViewerDataSource : ReportViewer is to be bind to this DataSource
            //inventoryReport.LocalReport.DataSources.Clear(); // Clear the Previous DataSource of ReportViewer
            //inventoryReport.LocalReport.DataSources.Add(rds); //bind ReportViewer1 to the new datasource(Which you wish)
            //inventoryReport.LocalReport.Refresh(); // Refresh the ReportViewer Control, ReportViewer1 in this case
        }
    }
}
