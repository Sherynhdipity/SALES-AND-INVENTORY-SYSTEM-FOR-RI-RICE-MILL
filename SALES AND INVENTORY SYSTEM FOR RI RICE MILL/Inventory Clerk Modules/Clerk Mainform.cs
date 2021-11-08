using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL
{
    public partial class frmMainInventory : Form
    {
        public static SqlConnection con = new SqlConnection(DBConnection.con);
        public static SqlCommand cmd = new SqlCommand();

        public frmMainInventory()
        {
            InitializeComponent();
            con.Open();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            lblUserName.Text = frmLogin.GetUserName.ToString();
            lblUserRole.Text = frmLogin.GetUserRole.ToString();
        }

        public bool isFormMinimized = false;

        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                bunifuPanel1.Visible = true;
            }
        }


        private void btnReports_Click(object sender, EventArgs e)
        {

            if (!panelModule.Controls.Contains(ucInventoryReports.inventoryReportsInstance))
            {
                panelModule.Controls.Add(ucInventoryReports.inventoryReportsInstance);
                ucInventoryReports.inventoryReportsInstance.Dock = DockStyle.Fill;
                ucInventoryReports.inventoryReportsInstance.BringToFront();
            }
            else
            {
                ucInventoryReports.inventoryReportsInstance.BringToFront();
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (!panelModule.Controls.Contains(ucDashboard.dashboardInstance))
            {
                panelModule.Controls.Add(ucDashboard.dashboardInstance);
                ucDashboard.dashboardInstance.Dock = DockStyle.Fill;
                ucDashboard.dashboardInstance.BringToFront();
            }
            else
            {
                ucDashboard.dashboardInstance.BringToFront();
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            if (!panelModule.Controls.Contains(ucBackupRestore.backupRestoreInstance))
            {
                panelModule.Controls.Add(ucBackupRestore.backupRestoreInstance);
                ucBackupRestore.backupRestoreInstance.Dock = DockStyle.Fill;
                ucBackupRestore.backupRestoreInstance.BringToFront();
            }
            else
            {
                ucBackupRestore.backupRestoreInstance.BringToFront();
            }
        }

        private void panelLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to Logout from the System?", "Log-out", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                frmLogin login = new frmLogin();
                this.Hide();
                login.Show();
            }
            else if(dialog == DialogResult.No)
            {

            }
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            if (!panelModule.Controls.Contains(frmInventory.inventoryInstance))
            {
                panelModule.Controls.Add(frmInventory.inventoryInstance);
                frmInventory.inventoryInstance.Dock = DockStyle.Fill;
                frmInventory.inventoryInstance.BringToFront();
            }
            else
            {
                frmInventory.inventoryInstance.BringToFront();
            }
        }
    }
}
