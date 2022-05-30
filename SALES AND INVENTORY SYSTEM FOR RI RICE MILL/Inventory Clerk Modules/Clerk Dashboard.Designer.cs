
namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL
{
    partial class ucInventoryDashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucInventoryDashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPanel3 = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblQtyStockedOut = new Bunifu.UI.WinForms.BunifuLabel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.bunifuPanel10 = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblTotalAvailableStock = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel7 = new Bunifu.UI.WinForms.BunifuLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.StocksChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.stockChartViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ownerDashboardDataset = new SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.OwnerDashboardDataset();
            this.stockChartViewTableAdapter = new SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.OwnerDashboardDatasetTableAdapters.StockChartViewTableAdapter();
            this.bunifuPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.bunifuPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StocksChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockChartViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerDashboardDataset)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Impact", 15.75F);
            this.bunifuLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel3.Location = new System.Drawing.Point(109, 36);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(112, 27);
            this.bunifuLabel3.TabIndex = 5;
            this.bunifuLabel3.Text = "STOCKED OUT";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPanel3
            // 
            this.bunifuPanel3.BackgroundColor = System.Drawing.Color.Brown;
            this.bunifuPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel3.BackgroundImage")));
            this.bunifuPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel3.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel3.BorderRadius = 3;
            this.bunifuPanel3.BorderThickness = 1;
            this.bunifuPanel3.Controls.Add(this.lblQtyStockedOut);
            this.bunifuPanel3.Controls.Add(this.bunifuLabel3);
            this.bunifuPanel3.Controls.Add(this.pictureBox4);
            this.bunifuPanel3.Location = new System.Drawing.Point(558, 130);
            this.bunifuPanel3.Name = "bunifuPanel3";
            this.bunifuPanel3.ShowBorders = true;
            this.bunifuPanel3.Size = new System.Drawing.Size(234, 133);
            this.bunifuPanel3.TabIndex = 72;
            // 
            // lblQtyStockedOut
            // 
            this.lblQtyStockedOut.AllowParentOverrides = false;
            this.lblQtyStockedOut.AutoEllipsis = false;
            this.lblQtyStockedOut.CursorType = null;
            this.lblQtyStockedOut.Font = new System.Drawing.Font("Impact", 15.75F);
            this.lblQtyStockedOut.ForeColor = System.Drawing.Color.White;
            this.lblQtyStockedOut.Location = new System.Drawing.Point(154, 81);
            this.lblQtyStockedOut.Name = "lblQtyStockedOut";
            this.lblQtyStockedOut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblQtyStockedOut.Size = new System.Drawing.Size(11, 26);
            this.lblQtyStockedOut.TabIndex = 6;
            this.lblQtyStockedOut.Text = "0";
            this.lblQtyStockedOut.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblQtyStockedOut.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.Properties.Resources.packages;
            this.pictureBox4.Location = new System.Drawing.Point(19, 25);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(77, 82);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // bunifuPanel10
            // 
            this.bunifuPanel10.BackgroundColor = System.Drawing.Color.Orange;
            this.bunifuPanel10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel10.BackgroundImage")));
            this.bunifuPanel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel10.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel10.BorderRadius = 3;
            this.bunifuPanel10.BorderThickness = 1;
            this.bunifuPanel10.Controls.Add(this.lblTotalAvailableStock);
            this.bunifuPanel10.Controls.Add(this.bunifuLabel7);
            this.bunifuPanel10.Controls.Add(this.pictureBox3);
            this.bunifuPanel10.Location = new System.Drawing.Point(213, 130);
            this.bunifuPanel10.Name = "bunifuPanel10";
            this.bunifuPanel10.ShowBorders = true;
            this.bunifuPanel10.Size = new System.Drawing.Size(282, 133);
            this.bunifuPanel10.TabIndex = 71;
            // 
            // lblTotalAvailableStock
            // 
            this.lblTotalAvailableStock.AllowParentOverrides = false;
            this.lblTotalAvailableStock.AutoEllipsis = false;
            this.lblTotalAvailableStock.CursorType = null;
            this.lblTotalAvailableStock.Font = new System.Drawing.Font("Impact", 15.75F);
            this.lblTotalAvailableStock.ForeColor = System.Drawing.Color.White;
            this.lblTotalAvailableStock.Location = new System.Drawing.Point(185, 81);
            this.lblTotalAvailableStock.Name = "lblTotalAvailableStock";
            this.lblTotalAvailableStock.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalAvailableStock.Size = new System.Drawing.Size(11, 26);
            this.lblTotalAvailableStock.TabIndex = 6;
            this.lblTotalAvailableStock.Text = "0";
            this.lblTotalAvailableStock.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTotalAvailableStock.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel7
            // 
            this.bunifuLabel7.AllowParentOverrides = false;
            this.bunifuLabel7.AutoEllipsis = false;
            this.bunifuLabel7.AutoSize = false;
            this.bunifuLabel7.CursorType = null;
            this.bunifuLabel7.Font = new System.Drawing.Font("Impact", 15.75F);
            this.bunifuLabel7.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel7.Location = new System.Drawing.Point(102, 3);
            this.bunifuLabel7.Name = "bunifuLabel7";
            this.bunifuLabel7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel7.Size = new System.Drawing.Size(177, 92);
            this.bunifuLabel7.TabIndex = 5;
            this.bunifuLabel7.Text = "AVAILABLE STOCK";
            this.bunifuLabel7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel7.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.Properties.Resources.ecommerce;
            this.pictureBox3.Location = new System.Drawing.Point(19, 25);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(77, 82);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // StocksChart
            // 
            this.StocksChart.BorderlineColor = System.Drawing.Color.Black;
            this.StocksChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.StocksChart.ChartAreas.Add(chartArea1);
            this.StocksChart.DataSource = this.stockChartViewBindingSource;
            legend1.Name = "Legend1";
            this.StocksChart.Legends.Add(legend1);
            this.StocksChart.Location = new System.Drawing.Point(213, 269);
            this.StocksChart.Name = "StocksChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Stockin";
            series1.XValueMember = "Description";
            series1.YValueMembers = "Quantity";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Stockout";
            series2.XValueMember = "Description";
            series2.YValueMembers = "QtySold";
            this.StocksChart.Series.Add(series1);
            this.StocksChart.Series.Add(series2);
            this.StocksChart.Size = new System.Drawing.Size(579, 345);
            this.StocksChart.TabIndex = 76;
            this.StocksChart.Text = "chart1";
            title1.Name = "Inventory Data";
            title1.Text = "Inventory Data Chart";
            this.StocksChart.Titles.Add(title1);
            // 
            // stockChartViewBindingSource
            // 
            this.stockChartViewBindingSource.DataMember = "StockChartView";
            this.stockChartViewBindingSource.DataSource = this.ownerDashboardDataset;
            // 
            // ownerDashboardDataset
            // 
            this.ownerDashboardDataset.DataSetName = "OwnerDashboardDataset";
            this.ownerDashboardDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockChartViewTableAdapter
            // 
            this.stockChartViewTableAdapter.ClearBeforeFill = true;
            // 
            // ucInventoryDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StocksChart);
            this.Controls.Add(this.bunifuPanel3);
            this.Controls.Add(this.bunifuPanel10);
            this.Name = "ucInventoryDashboard";
            this.Size = new System.Drawing.Size(1087, 675);
            this.Load += new System.EventHandler(this.ucInventoryDashboard_Load);
            this.bunifuPanel3.ResumeLayout(false);
            this.bunifuPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.bunifuPanel10.ResumeLayout(false);
            this.bunifuPanel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StocksChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockChartViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerDashboardDataset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel3;
        private Bunifu.UI.WinForms.BunifuLabel lblQtyStockedOut;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel10;
        private Bunifu.UI.WinForms.BunifuLabel lblTotalAvailableStock;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataVisualization.Charting.Chart StocksChart;
        private System.Windows.Forms.BindingSource stockChartViewBindingSource;
        private OwnerDashboardDataset ownerDashboardDataset;
        private OwnerDashboardDatasetTableAdapters.StockChartViewTableAdapter stockChartViewTableAdapter;
    }
}
