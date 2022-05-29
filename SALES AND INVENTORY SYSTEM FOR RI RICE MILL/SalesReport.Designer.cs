
namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL
{
    partial class frmSalesReport
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
            this.SalesReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // SalesReportViewer
            // 
            this.SalesReportViewer.ActiveViewIndex = -1;
            this.SalesReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SalesReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.SalesReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalesReportViewer.Location = new System.Drawing.Point(0, 0);
            this.SalesReportViewer.Name = "SalesReportViewer";
            this.SalesReportViewer.Size = new System.Drawing.Size(800, 450);
            this.SalesReportViewer.TabIndex = 0;
            this.SalesReportViewer.Load += new System.EventHandler(this.SalesReportViewer_Load);
            // 
            // frmSalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SalesReportViewer);
            this.Name = "frmSalesReport";
            this.Text = "SalesReport";
            this.Load += new System.EventHandler(this.frmSalesReport_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private SalesReport SalesReport1;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer SalesReportViewer;
    }
}