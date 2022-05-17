
namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.Owner_Modules
{
    partial class frmOwnerSalesReport
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOwnerSalesReport));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.dtpToDate = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.dtpFromDate = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnPrintReport = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvSalesOwnerReport = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.txtItemDesc = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesOwnerReport)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bunifuLabel4);
            this.groupBox1.Controls.Add(this.txtItemDesc);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.bunifuLabel2);
            this.groupBox1.Controls.Add(this.dtpToDate);
            this.groupBox1.Controls.Add(this.bunifuLabel1);
            this.groupBox1.Controls.Add(this.dtpFromDate);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(45, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 108);
            this.groupBox1.TabIndex = 112;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date Range:";
            // 
            // btnSearch
            // 
            this.btnSearch.ActiveImage = null;
            this.btnSearch.AllowAnimations = true;
            this.btnSearch.AllowBuffering = false;
            this.btnSearch.AllowToggling = false;
            this.btnSearch.AllowZooming = false;
            this.btnSearch.AllowZoomingOnFocus = false;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSearch.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.ErrorImage")));
            this.btnSearch.FadeWhenInactive = false;
            this.btnSearch.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnSearch.Image = global::SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.Properties.Resources.search;
            this.btnSearch.ImageActive = null;
            this.btnSearch.ImageLocation = null;
            this.btnSearch.ImageMargin = 20;
            this.btnSearch.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSearch.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.btnSearch.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.InitialImage")));
            this.btnSearch.Location = new System.Drawing.Point(633, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Rotation = 0;
            this.btnSearch.ShowActiveImage = true;
            this.btnSearch.ShowCursorChanges = true;
            this.btnSearch.ShowImageBorders = true;
            this.btnSearch.ShowSizeMarkers = false;
            this.btnSearch.Size = new System.Drawing.Size(50, 50);
            this.btnSearch.TabIndex = 119;
            this.btnSearch.ToolTipText = "";
            this.btnSearch.WaitOnLoad = false;
            this.btnSearch.Zoom = 20;
            this.btnSearch.ZoomSpeed = 10;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.bunifuLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel2.Location = new System.Drawing.Point(335, 31);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(67, 18);
            this.bunifuLabel2.TabIndex = 118;
            this.bunifuLabel2.Text = "To Date:";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dtpToDate
            // 
            this.dtpToDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpToDate.BorderColor = System.Drawing.Color.Black;
            this.dtpToDate.BorderRadius = 10;
            this.dtpToDate.Color = System.Drawing.Color.Black;
            this.dtpToDate.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.dtpToDate.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dtpToDate.DisabledColor = System.Drawing.Color.White;
            this.dtpToDate.DisplayWeekNumbers = false;
            this.dtpToDate.DPHeight = 0;
            this.dtpToDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpToDate.FillDatePicker = false;
            this.dtpToDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpToDate.ForeColor = System.Drawing.Color.Black;
            this.dtpToDate.Icon = ((System.Drawing.Image)(resources.GetObject("dtpToDate.Icon")));
            this.dtpToDate.IconColor = System.Drawing.SystemColors.Control;
            this.dtpToDate.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dtpToDate.LeftTextMargin = 5;
            this.dtpToDate.Location = new System.Drawing.Point(408, 25);
            this.dtpToDate.MinimumSize = new System.Drawing.Size(4, 32);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(182, 32);
            this.dtpToDate.TabIndex = 117;
            this.dtpToDate.Value = new System.DateTime(2022, 4, 27, 0, 0, 0, 0);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel1.Location = new System.Drawing.Point(21, 31);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(88, 18);
            this.bunifuLabel1.TabIndex = 116;
            this.bunifuLabel1.Text = "From Date:";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpFromDate.BorderColor = System.Drawing.Color.Black;
            this.dtpFromDate.BorderRadius = 10;
            this.dtpFromDate.Color = System.Drawing.Color.Black;
            this.dtpFromDate.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.dtpFromDate.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dtpFromDate.DisabledColor = System.Drawing.Color.White;
            this.dtpFromDate.DisplayWeekNumbers = false;
            this.dtpFromDate.DPHeight = 0;
            this.dtpFromDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpFromDate.FillDatePicker = false;
            this.dtpFromDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpFromDate.ForeColor = System.Drawing.Color.Black;
            this.dtpFromDate.Icon = ((System.Drawing.Image)(resources.GetObject("dtpFromDate.Icon")));
            this.dtpFromDate.IconColor = System.Drawing.SystemColors.Control;
            this.dtpFromDate.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dtpFromDate.LeftTextMargin = 5;
            this.dtpFromDate.Location = new System.Drawing.Point(115, 25);
            this.dtpFromDate.MinimumSize = new System.Drawing.Size(4, 32);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(182, 32);
            this.dtpFromDate.TabIndex = 35;
            this.dtpFromDate.Value = new System.DateTime(2022, 4, 27, 0, 0, 0, 0);
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpMilledDate_ValueChanged);
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F);
            this.bunifuLabel3.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel3.Location = new System.Drawing.Point(361, 21);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(274, 46);
            this.bunifuLabel3.TabIndex = 110;
            this.bunifuLabel3.Text = "Sales Reports";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.AllowAnimations = true;
            this.btnPrintReport.AllowMouseEffects = true;
            this.btnPrintReport.AllowToggling = false;
            this.btnPrintReport.AnimationSpeed = 200;
            this.btnPrintReport.AutoGenerateColors = false;
            this.btnPrintReport.AutoRoundBorders = false;
            this.btnPrintReport.AutoSizeLeftIcon = true;
            this.btnPrintReport.AutoSizeRightIcon = true;
            this.btnPrintReport.BackColor = System.Drawing.Color.Transparent;
            this.btnPrintReport.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnPrintReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrintReport.BackgroundImage")));
            this.btnPrintReport.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPrintReport.ButtonText = "Export Report";
            this.btnPrintReport.ButtonTextMarginLeft = 0;
            this.btnPrintReport.ColorContrastOnClick = 45;
            this.btnPrintReport.ColorContrastOnHover = 45;
            this.btnPrintReport.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnPrintReport.CustomizableEdges = borderEdges1;
            this.btnPrintReport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPrintReport.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPrintReport.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnPrintReport.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnPrintReport.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnPrintReport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintReport.ForeColor = System.Drawing.Color.Black;
            this.btnPrintReport.IconLeft = null;
            this.btnPrintReport.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintReport.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnPrintReport.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnPrintReport.IconMarginLeft = 11;
            this.btnPrintReport.IconPadding = 10;
            this.btnPrintReport.IconRight = null;
            this.btnPrintReport.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrintReport.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnPrintReport.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnPrintReport.IconSize = 25;
            this.btnPrintReport.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnPrintReport.IdleBorderRadius = 0;
            this.btnPrintReport.IdleBorderThickness = 0;
            this.btnPrintReport.IdleFillColor = System.Drawing.Color.Empty;
            this.btnPrintReport.IdleIconLeftImage = null;
            this.btnPrintReport.IdleIconRightImage = null;
            this.btnPrintReport.IndicateFocus = false;
            this.btnPrintReport.Location = new System.Drawing.Point(808, 137);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPrintReport.OnDisabledState.BorderRadius = 1;
            this.btnPrintReport.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPrintReport.OnDisabledState.BorderThickness = 1;
            this.btnPrintReport.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPrintReport.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPrintReport.OnDisabledState.IconLeftImage = null;
            this.btnPrintReport.OnDisabledState.IconRightImage = null;
            this.btnPrintReport.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnPrintReport.onHoverState.BorderRadius = 1;
            this.btnPrintReport.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPrintReport.onHoverState.BorderThickness = 1;
            this.btnPrintReport.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnPrintReport.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnPrintReport.onHoverState.IconLeftImage = null;
            this.btnPrintReport.onHoverState.IconRightImage = null;
            this.btnPrintReport.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnPrintReport.OnIdleState.BorderRadius = 1;
            this.btnPrintReport.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPrintReport.OnIdleState.BorderThickness = 1;
            this.btnPrintReport.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnPrintReport.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnPrintReport.OnIdleState.IconLeftImage = null;
            this.btnPrintReport.OnIdleState.IconRightImage = null;
            this.btnPrintReport.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnPrintReport.OnPressedState.BorderRadius = 1;
            this.btnPrintReport.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPrintReport.OnPressedState.BorderThickness = 1;
            this.btnPrintReport.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnPrintReport.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnPrintReport.OnPressedState.IconLeftImage = null;
            this.btnPrintReport.OnPressedState.IconRightImage = null;
            this.btnPrintReport.Size = new System.Drawing.Size(158, 39);
            this.btnPrintReport.TabIndex = 116;
            this.btnPrintReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrintReport.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPrintReport.TextMarginLeft = 0;
            this.btnPrintReport.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnPrintReport.UseDefaultRadiusAndThickness = true;
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.Properties.Resources.sales_report;
            this.pictureBox1.Location = new System.Drawing.Point(237, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 111;
            this.pictureBox1.TabStop = false;
            // 
            // dgvSalesOwnerReport
            // 
            this.dgvSalesOwnerReport.AllowCustomTheming = false;
            this.dgvSalesOwnerReport.AllowUserToAddRows = false;
            this.dgvSalesOwnerReport.AllowUserToDeleteRows = false;
            this.dgvSalesOwnerReport.AllowUserToResizeColumns = false;
            this.dgvSalesOwnerReport.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvSalesOwnerReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSalesOwnerReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalesOwnerReport.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvSalesOwnerReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSalesOwnerReport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSalesOwnerReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalesOwnerReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSalesOwnerReport.ColumnHeadersHeight = 40;
            this.dgvSalesOwnerReport.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvSalesOwnerReport.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvSalesOwnerReport.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvSalesOwnerReport.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvSalesOwnerReport.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvSalesOwnerReport.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvSalesOwnerReport.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvSalesOwnerReport.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvSalesOwnerReport.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvSalesOwnerReport.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSalesOwnerReport.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvSalesOwnerReport.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvSalesOwnerReport.CurrentTheme.Name = null;
            this.dgvSalesOwnerReport.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSalesOwnerReport.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvSalesOwnerReport.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvSalesOwnerReport.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvSalesOwnerReport.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalesOwnerReport.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSalesOwnerReport.EnableHeadersVisualStyles = false;
            this.dgvSalesOwnerReport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvSalesOwnerReport.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvSalesOwnerReport.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvSalesOwnerReport.HeaderForeColor = System.Drawing.Color.White;
            this.dgvSalesOwnerReport.Location = new System.Drawing.Point(40, 214);
            this.dgvSalesOwnerReport.Name = "dgvSalesOwnerReport";
            this.dgvSalesOwnerReport.ReadOnly = true;
            this.dgvSalesOwnerReport.RowHeadersVisible = false;
            this.dgvSalesOwnerReport.RowTemplate.Height = 40;
            this.dgvSalesOwnerReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalesOwnerReport.Size = new System.Drawing.Size(950, 352);
            this.dgvSalesOwnerReport.TabIndex = 133;
            this.dgvSalesOwnerReport.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // txtItemDesc
            // 
            this.txtItemDesc.AcceptsReturn = false;
            this.txtItemDesc.AcceptsTab = false;
            this.txtItemDesc.AnimationSpeed = 200;
            this.txtItemDesc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtItemDesc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtItemDesc.AutoSizeHeight = true;
            this.txtItemDesc.BackColor = System.Drawing.Color.Transparent;
            this.txtItemDesc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtItemDesc.BackgroundImage")));
            this.txtItemDesc.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtItemDesc.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtItemDesc.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtItemDesc.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtItemDesc.BorderRadius = 1;
            this.txtItemDesc.BorderThickness = 1;
            this.txtItemDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtItemDesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemDesc.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtItemDesc.DefaultText = "";
            this.txtItemDesc.FillColor = System.Drawing.Color.White;
            this.txtItemDesc.HideSelection = true;
            this.txtItemDesc.IconLeft = null;
            this.txtItemDesc.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemDesc.IconPadding = 10;
            this.txtItemDesc.IconRight = null;
            this.txtItemDesc.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemDesc.Lines = new string[0];
            this.txtItemDesc.Location = new System.Drawing.Point(163, 63);
            this.txtItemDesc.MaxLength = 50;
            this.txtItemDesc.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtItemDesc.Modified = false;
            this.txtItemDesc.Multiline = false;
            this.txtItemDesc.Name = "txtItemDesc";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtItemDesc.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtItemDesc.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtItemDesc.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtItemDesc.OnIdleState = stateProperties4;
            this.txtItemDesc.Padding = new System.Windows.Forms.Padding(3);
            this.txtItemDesc.PasswordChar = '\0';
            this.txtItemDesc.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtItemDesc.PlaceholderText = "";
            this.txtItemDesc.ReadOnly = false;
            this.txtItemDesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtItemDesc.SelectedText = "";
            this.txtItemDesc.SelectionLength = 0;
            this.txtItemDesc.SelectionStart = 0;
            this.txtItemDesc.ShortcutsEnabled = true;
            this.txtItemDesc.Size = new System.Drawing.Size(352, 39);
            this.txtItemDesc.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtItemDesc.TabIndex = 120;
            this.txtItemDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtItemDesc.TextMarginBottom = 0;
            this.txtItemDesc.TextMarginLeft = 3;
            this.txtItemDesc.TextMarginTop = 1;
            this.txtItemDesc.TextPlaceholder = "";
            this.txtItemDesc.UseSystemPasswordChar = false;
            this.txtItemDesc.WordWrap = true;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.bunifuLabel4.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel4.Location = new System.Drawing.Point(21, 73);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(136, 18);
            this.bunifuLabel4.TabIndex = 121;
            this.bunifuLabel4.Text = "Item Description:";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel4.Click += new System.EventHandler(this.bunifuLabel4_Click);
            // 
            // frmOwnerSalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 586);
            this.Controls.Add(this.dgvSalesOwnerReport);
            this.Controls.Add(this.btnPrintReport);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmOwnerSalesReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OwnerSalesReport";
            this.Load += new System.EventHandler(this.frmOwnerSalesReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesOwnerReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuDatePicker dtpToDate;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuDatePicker dtpFromDate;
        private Bunifu.UI.WinForms.BunifuImageButton btnSearch;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnPrintReport;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvSalesOwnerReport;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        public Bunifu.UI.WinForms.BunifuTextBox txtItemDesc;
    }
}