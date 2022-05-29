
namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL
{
    partial class frmInventoryDetailed
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InventoryDetailedViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.InventoryDetailed1 = new SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.InventoryDetailed();
            this.SuspendLayout();
            // 
            // InventoryDetailedViewer
            // 
            this.InventoryDetailedViewer.ActiveViewIndex = 0;
            this.InventoryDetailedViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InventoryDetailedViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.InventoryDetailedViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InventoryDetailedViewer.Location = new System.Drawing.Point(0, 0);
            this.InventoryDetailedViewer.Name = "InventoryDetailedViewer";
            this.InventoryDetailedViewer.ReportSource = this.InventoryDetailed1;
            this.InventoryDetailedViewer.Size = new System.Drawing.Size(800, 450);
            this.InventoryDetailedViewer.TabIndex = 0;
            // 
            // frmInventoryDetailed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InventoryDetailedViewer);
            this.Name = "frmInventoryDetailed";
            this.Text = "InventoryDetailedReport";
            this.Load += new System.EventHandler(this.frmInventoryDetailedReport_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private InventoryDetailed InventoryDetailed1;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer InventoryDetailedViewer;
    }
}