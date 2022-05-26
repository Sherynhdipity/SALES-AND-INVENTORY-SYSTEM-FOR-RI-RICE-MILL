
namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL
{
    partial class frmCustomerLists
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
            this.CustomerList1 = new SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.CustomerList();
            this.CustomerListViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CustomerListViewer
            // 
            this.CustomerListViewer.ActiveViewIndex = 0;
            this.CustomerListViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CustomerListViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.CustomerListViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerListViewer.Location = new System.Drawing.Point(0, 0);
            this.CustomerListViewer.Name = "CustomerListViewer";
            this.CustomerListViewer.Size = new System.Drawing.Size(800, 450);
            this.CustomerListViewer.TabIndex = 0;
            this.CustomerListViewer.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // frmCustomerLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CustomerListViewer);
            this.Name = "frmCustomerLists";
            this.Text = "CustomerLists";
            this.Load += new System.EventHandler(this.frmCustomerLists_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private CustomerList CustomerList1;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer CustomerListViewer;
    }
}