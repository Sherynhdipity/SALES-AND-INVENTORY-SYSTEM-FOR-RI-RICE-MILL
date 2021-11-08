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
    public partial class ucBackupRestore : UserControl
    {
        private static ucBackupRestore backupRestore;
        public static ucBackupRestore backupRestoreInstance
        {
            get
            {
                if (backupRestore == null)
                    backupRestore = new ucBackupRestore();
                return backupRestore;
            }
        }
        public ucBackupRestore()
        {
            InitializeComponent();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            frmBackup backup = new frmBackup();
            backup.Show();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            frmRestore restore = new frmRestore();
            restore.Show();
        }
    }
}
