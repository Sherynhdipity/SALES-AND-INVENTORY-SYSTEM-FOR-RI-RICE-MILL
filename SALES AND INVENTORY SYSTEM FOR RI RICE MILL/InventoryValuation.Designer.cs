
namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL
{
    partial class frmInventoryValuationReport
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
            this.InventoryValuationViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.InventoryValuation1 = new SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.InventoryValuation();
            this.SuspendLayout();
            // 
            // InventoryValuationViewer
            // 
            this.InventoryValuationViewer.ActiveViewIndex = 0;
            this.InventoryValuationViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InventoryValuationViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.InventoryValuationViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InventoryValuationViewer.Location = new System.Drawing.Point(0, 0);
            this.InventoryValuationViewer.Name = "InventoryValuationViewer";
            this.InventoryValuationViewer.ReportSource = this.InventoryValuation1;
            this.InventoryValuationViewer.Size = new System.Drawing.Size(800, 450);
            this.InventoryValuationViewer.TabIndex = 0;
            // 
            // frmInventoryValuationReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InventoryValuationViewer);
            this.Name = "frmInventoryValuationReport";
            this.Text = "InventoryValuation";
            this.Load += new System.EventHandler(this.frmInventoryValuation_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer InventoryValuationViewer;
        private InventoryValuation InventoryValuation1;
    }
}