﻿
namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL
{
    partial class frmInventoryReport
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
            this.InventoryReport1 = new SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.InventoryReport();
            this.InventoryReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ReturnReport1 = new SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.ReturnReport();
            this.SuspendLayout();
            // 
            // InventoryReportViewer1
            // 
            this.InventoryReportViewer1.ActiveViewIndex = -1;
            this.InventoryReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InventoryReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.InventoryReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InventoryReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.InventoryReportViewer1.Name = "InventoryReportViewer1";
            this.InventoryReportViewer1.Size = new System.Drawing.Size(800, 450);
            this.InventoryReportViewer1.TabIndex = 0;
            this.InventoryReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.InventoryReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // frmInventoryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InventoryReportViewer1);
            this.Name = "frmInventoryReport";
            this.Text = "InventoryRepot";
            this.ResumeLayout(false);

        }

        #endregion
        private InventoryReport InventoryReport1;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer InventoryReportViewer1;
        private ReturnReport ReturnReport1;
    }
}