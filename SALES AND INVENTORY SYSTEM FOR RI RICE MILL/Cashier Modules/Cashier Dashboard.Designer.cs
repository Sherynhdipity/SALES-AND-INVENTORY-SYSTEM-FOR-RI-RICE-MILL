
namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL
{
    partial class ucSalesDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSalesDashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panelTotalTrans = new Bunifu.UI.WinForms.BunifuPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTotalTransactions = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.panelTotalSales = new Bunifu.UI.WinForms.BunifuPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTotalSales = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.salesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.StocksChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelTotalTrans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelTotalSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StocksChart)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTotalTrans
            // 
            this.panelTotalTrans.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.panelTotalTrans.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTotalTrans.BackgroundImage")));
            this.panelTotalTrans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTotalTrans.BorderColor = System.Drawing.Color.Transparent;
            this.panelTotalTrans.BorderRadius = 3;
            this.panelTotalTrans.BorderThickness = 1;
            this.panelTotalTrans.Controls.Add(this.pictureBox2);
            this.panelTotalTrans.Controls.Add(this.lblTotalTransactions);
            this.panelTotalTrans.Controls.Add(this.bunifuLabel4);
            this.panelTotalTrans.Location = new System.Drawing.Point(540, 86);
            this.panelTotalTrans.Name = "panelTotalTrans";
            this.panelTotalTrans.ShowBorders = true;
            this.panelTotalTrans.Size = new System.Drawing.Size(234, 133);
            this.panelTotalTrans.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.Properties.Resources.lending;
            this.pictureBox2.Location = new System.Drawing.Point(18, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(77, 82);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // lblTotalTransactions
            // 
            this.lblTotalTransactions.AllowParentOverrides = false;
            this.lblTotalTransactions.AutoEllipsis = false;
            this.lblTotalTransactions.CursorType = null;
            this.lblTotalTransactions.Font = new System.Drawing.Font("Impact", 15.75F);
            this.lblTotalTransactions.ForeColor = System.Drawing.Color.White;
            this.lblTotalTransactions.Location = new System.Drawing.Point(104, 81);
            this.lblTotalTransactions.Name = "lblTotalTransactions";
            this.lblTotalTransactions.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalTransactions.Size = new System.Drawing.Size(11, 26);
            this.lblTotalTransactions.TabIndex = 1;
            this.lblTotalTransactions.Text = "0";
            this.lblTotalTransactions.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTotalTransactions.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Impact", 15.75F);
            this.bunifuLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel4.Location = new System.Drawing.Point(101, 27);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(124, 53);
            this.bunifuLabel4.TabIndex = 0;
            this.bunifuLabel4.Text = "TOTAL \r\nTRANSACTIONS";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // panelTotalSales
            // 
            this.panelTotalSales.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.panelTotalSales.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTotalSales.BackgroundImage")));
            this.panelTotalSales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTotalSales.BorderColor = System.Drawing.Color.Transparent;
            this.panelTotalSales.BorderRadius = 3;
            this.panelTotalSales.BorderThickness = 1;
            this.panelTotalSales.Controls.Add(this.pictureBox1);
            this.panelTotalSales.Controls.Add(this.lblTotalSales);
            this.panelTotalSales.Controls.Add(this.bunifuLabel1);
            this.panelTotalSales.Location = new System.Drawing.Point(300, 86);
            this.panelTotalSales.Name = "panelTotalSales";
            this.panelTotalSales.ShowBorders = true;
            this.panelTotalSales.Size = new System.Drawing.Size(234, 133);
            this.panelTotalSales.TabIndex = 0;
            this.panelTotalSales.Click += new System.EventHandler(this.panelTotalSales_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.Properties.Resources.growth;
            this.pictureBox1.Location = new System.Drawing.Point(19, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.AllowParentOverrides = false;
            this.lblTotalSales.AutoEllipsis = false;
            this.lblTotalSales.CursorType = null;
            this.lblTotalSales.Font = new System.Drawing.Font("Impact", 15.75F);
            this.lblTotalSales.ForeColor = System.Drawing.Color.White;
            this.lblTotalSales.Location = new System.Drawing.Point(102, 67);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalSales.Size = new System.Drawing.Size(11, 26);
            this.lblTotalSales.TabIndex = 1;
            this.lblTotalSales.Text = "0";
            this.lblTotalSales.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTotalSales.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Impact", 15.75F);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel1.Location = new System.Drawing.Point(102, 35);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(102, 26);
            this.bunifuLabel1.TabIndex = 0;
            this.bunifuLabel1.Text = "TOTAL SALES";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // salesChart
            // 
            this.salesChart.BorderlineColor = System.Drawing.Color.Black;
            this.salesChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.salesChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.salesChart.Legends.Add(legend1);
            this.salesChart.Location = new System.Drawing.Point(60, 251);
            this.salesChart.Name = "salesChart";
            this.salesChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Total Sales";
            series1.XValueMember = "Date";
            series1.YValueMembers = "Total";
            this.salesChart.Series.Add(series1);
            this.salesChart.Size = new System.Drawing.Size(474, 313);
            this.salesChart.TabIndex = 75;
            this.salesChart.Text = "Sales Chart";
            title1.Name = "Title1";
            title1.Text = "Sales Data Chart";
            this.salesChart.Titles.Add(title1);
            // 
            // StocksChart
            // 
            this.StocksChart.BorderlineColor = System.Drawing.Color.Black;
            this.StocksChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.Name = "ChartArea1";
            this.StocksChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.StocksChart.Legends.Add(legend2);
            this.StocksChart.Location = new System.Drawing.Point(540, 251);
            this.StocksChart.Name = "StocksChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Quantity";
            series2.XValueMember = "Description";
            series2.YValueMembers = "QtySold";
            this.StocksChart.Series.Add(series2);
            this.StocksChart.Size = new System.Drawing.Size(471, 313);
            this.StocksChart.TabIndex = 76;
            this.StocksChart.Text = "chart1";
            title2.Name = "Title1";
            title2.Text = "Rice Item Sold by Variety";
            this.StocksChart.Titles.Add(title2);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ucSalesDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StocksChart);
            this.Controls.Add(this.salesChart);
            this.Controls.Add(this.panelTotalTrans);
            this.Controls.Add(this.panelTotalSales);
            this.Name = "ucSalesDashboard";
            this.Size = new System.Drawing.Size(1087, 675);
            this.Load += new System.EventHandler(this.ucSalesDashboard_Load);
            this.panelTotalTrans.ResumeLayout(false);
            this.panelTotalTrans.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelTotalSales.ResumeLayout(false);
            this.panelTotalSales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StocksChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel panelTotalSales;
        private Bunifu.UI.WinForms.BunifuLabel lblTotalSales;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuPanel panelTotalTrans;
        private Bunifu.UI.WinForms.BunifuLabel lblTotalTransactions;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart salesChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart StocksChart;
        private System.Windows.Forms.Timer timer1;
    }
}
