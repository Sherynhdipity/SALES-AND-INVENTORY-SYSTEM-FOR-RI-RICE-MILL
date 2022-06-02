
namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL
{
    partial class frmPrintReturnSlip
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
            this.btnClose = new System.Windows.Forms.Button();
            this.SalesReturnSlip1 = new SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.ReturnSlip();
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
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(23, 43);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.SalesReturnSlip1;
            this.crystalReportViewer1.ShowCloseButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(723, 604);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(698, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(48, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmPrintReturnSlip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 604);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.crystalReportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrintReturnSlip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrintReceipt";
            ((System.ComponentModel.ISupportInitialize)(this.BarcodeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.BindingSource BarcodeBindingSource;
        private AppData AppData;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button btnClose;
        private ReturnSlip SalesReturnSlip1;
    }
}