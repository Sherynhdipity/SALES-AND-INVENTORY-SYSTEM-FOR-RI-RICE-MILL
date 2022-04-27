
namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL
{
    partial class frmPrintReceipt
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
            this.components = new System.ComponentModel.Container();
            this.BarcodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AppData = new SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.AppData();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.OReceipt1 = new SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.OReceipt();
            ((System.ComponentModel.ISupportInitialize)(this.BarcodeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppData)).BeginInit();
            this.SuspendLayout();
            // 
            // BarcodeBindingSource
            // 
            this.BarcodeBindingSource.DataMember = "Barcode";
            this.BarcodeBindingSource.DataSource = this.AppData;
            // 
            // AppData
            // 
            this.AppData.DataSetName = "AppData";
            this.AppData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(680, 484);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // frmPrintReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 484);
            this.Controls.Add(this.crystalReportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrintReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrintReceipt";
            this.Load += new System.EventHandler(this.PrintReciept_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BarcodeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.BindingSource BarcodeBindingSource;
        private AppData AppData;
        private SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.OReceipt OReceipt1;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        //private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}