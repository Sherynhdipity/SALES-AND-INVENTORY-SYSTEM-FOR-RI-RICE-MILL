
namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL
{
    partial class ucBackupRestore
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucBackupRestore));
            this.btnBackup = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnRestore = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.SuspendLayout();
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBackup.color = System.Drawing.Color.RoyalBlue;
            this.btnBackup.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackup.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnBackup.ForeColor = System.Drawing.Color.White;
            this.btnBackup.Image = global::SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.Properties.Resources.backup;
            this.btnBackup.ImagePosition = 20;
            this.btnBackup.ImageZoom = 50;
            this.btnBackup.LabelPosition = 41;
            this.btnBackup.LabelText = "Backup";
            this.btnBackup.Location = new System.Drawing.Point(366, 250);
            this.btnBackup.Margin = new System.Windows.Forms.Padding(6);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(342, 104);
            this.btnBackup.TabIndex = 0;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRestore.color = System.Drawing.Color.RoyalBlue;
            this.btnRestore.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestore.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnRestore.ForeColor = System.Drawing.Color.White;
            this.btnRestore.Image = global::SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.Properties.Resources.restore;
            this.btnRestore.ImagePosition = 10;
            this.btnRestore.ImageZoom = 50;
            this.btnRestore.LabelPosition = 41;
            this.btnRestore.LabelText = "Restore";
            this.btnRestore.Location = new System.Drawing.Point(366, 391);
            this.btnRestore.Margin = new System.Windows.Forms.Padding(6);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(342, 104);
            this.btnRestore.TabIndex = 1;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Impact", 30F);
            this.bunifuLabel3.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel3.Location = new System.Drawing.Point(366, 105);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(351, 48);
            this.bunifuLabel3.TabIndex = 2;
            this.bunifuLabel3.Text = "BACK UP AND RESTORE";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ucBackupRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnBackup);
            this.Name = "ucBackupRestore";
            this.Size = new System.Drawing.Size(1087, 675);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTileButton btnBackup;
        private Bunifu.Framework.UI.BunifuTileButton btnRestore;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
    }
}
