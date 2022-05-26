
namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL
{
    partial class frmItemListReport
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
            this.ItemListViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ItemListReport1 = new SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.ItemListReport();
            this.SuspendLayout();
            // 
            // ItemListViewer
            // 
            this.ItemListViewer.ActiveViewIndex = 0;
            this.ItemListViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemListViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.ItemListViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemListViewer.Location = new System.Drawing.Point(0, 0);
            this.ItemListViewer.Name = "ItemListViewer";
            this.ItemListViewer.ReportSource = this.ItemListReport1;
            this.ItemListViewer.Size = new System.Drawing.Size(800, 450);
            this.ItemListViewer.TabIndex = 0;
            // 
            // frmItemListReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ItemListViewer);
            this.Name = "frmItemListReport";
            this.Text = "ItemListReport";
            this.Load += new System.EventHandler(this.frmItemListReport_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private ItemListReport ItemListReport1;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer ItemListViewer;
    }
}