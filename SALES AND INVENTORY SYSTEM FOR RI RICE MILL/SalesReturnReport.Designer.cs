
namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL
{
    partial class frmSalesReturnReport
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
            this.SalesReturnViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SalesReturn1 = new SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.SalesReturn();
            this.SuspendLayout();
            // 
            // SalesReturnViewer
            // 
            this.SalesReturnViewer.ActiveViewIndex = 0;
            this.SalesReturnViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SalesReturnViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.SalesReturnViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalesReturnViewer.Location = new System.Drawing.Point(0, 0);
            this.SalesReturnViewer.Name = "SalesReturnViewer";
            this.SalesReturnViewer.ReportSource = this.SalesReturn1;
            this.SalesReturnViewer.Size = new System.Drawing.Size(800, 450);
            this.SalesReturnViewer.TabIndex = 0;
            // 
            // frmSalesReturnReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SalesReturnViewer);
            this.Name = "frmSalesReturnReport";
            this.Text = "SalesReturnReport";
            this.Load += new System.EventHandler(this.frmSalesReturnReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer SalesReturnViewer;
        private SalesReturn SalesReturn1;
    }
}