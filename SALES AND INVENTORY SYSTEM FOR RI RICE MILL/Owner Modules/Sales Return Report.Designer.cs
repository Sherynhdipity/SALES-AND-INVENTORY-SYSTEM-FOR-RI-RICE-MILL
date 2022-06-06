
namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.Owner_Modules
{
    partial class frmSales_Return
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSales_Return));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSearch = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.dtpToDate = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.dtpFromDate = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.dgvReturnOwnerReport = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbnCustom = new System.Windows.Forms.RadioButton();
            this.rbnYearly = new System.Windows.Forms.RadioButton();
            this.rbnMonthly = new System.Windows.Forms.RadioButton();
            this.rbnWeekly = new System.Windows.Forms.RadioButton();
            this.rbnDaily = new System.Windows.Forms.RadioButton();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.TotalReturnedSales = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel6 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblTotalReturnItem = new Bunifu.UI.WinForms.BunifuLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnOwnerReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.bunifuLabel2);
            this.groupBox1.Controls.Add(this.dtpToDate);
            this.groupBox1.Controls.Add(this.bunifuLabel1);
            this.groupBox1.Controls.Add(this.dtpFromDate);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(24, 198);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(930, 73);
            this.groupBox1.TabIndex = 123;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date Range:";
            // 
            // btnPrint
            // 
            this.btnPrint.AllowAnimations = true;
            this.btnPrint.AllowMouseEffects = true;
            this.btnPrint.AllowToggling = false;
            this.btnPrint.AnimationSpeed = 200;
            this.btnPrint.AutoGenerateColors = false;
            this.btnPrint.AutoRoundBorders = false;
            this.btnPrint.AutoSizeLeftIcon = true;
            this.btnPrint.AutoSizeRightIcon = true;
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.BackgroundImage")));
            this.btnPrint.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPrint.ButtonText = "Print Report";
            this.btnPrint.ButtonTextMarginLeft = 0;
            this.btnPrint.ColorContrastOnClick = 45;
            this.btnPrint.ColorContrastOnHover = 45;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnPrint.CustomizableEdges = borderEdges1;
            this.btnPrint.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPrint.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPrint.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnPrint.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnPrint.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.IconLeft = null;
            this.btnPrint.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnPrint.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnPrint.IconMarginLeft = 11;
            this.btnPrint.IconPadding = 10;
            this.btnPrint.IconRight = null;
            this.btnPrint.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnPrint.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnPrint.IconSize = 25;
            this.btnPrint.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnPrint.IdleBorderRadius = 0;
            this.btnPrint.IdleBorderThickness = 0;
            this.btnPrint.IdleFillColor = System.Drawing.Color.Empty;
            this.btnPrint.IdleIconLeftImage = null;
            this.btnPrint.IdleIconRightImage = null;
            this.btnPrint.IndicateFocus = false;
            this.btnPrint.Location = new System.Drawing.Point(758, 20);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPrint.OnDisabledState.BorderRadius = 1;
            this.btnPrint.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPrint.OnDisabledState.BorderThickness = 1;
            this.btnPrint.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPrint.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPrint.OnDisabledState.IconLeftImage = null;
            this.btnPrint.OnDisabledState.IconRightImage = null;
            this.btnPrint.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnPrint.onHoverState.BorderRadius = 1;
            this.btnPrint.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPrint.onHoverState.BorderThickness = 1;
            this.btnPrint.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnPrint.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnPrint.onHoverState.IconLeftImage = null;
            this.btnPrint.onHoverState.IconRightImage = null;
            this.btnPrint.OnIdleState.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnPrint.OnIdleState.BorderRadius = 1;
            this.btnPrint.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPrint.OnIdleState.BorderThickness = 1;
            this.btnPrint.OnIdleState.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnPrint.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnPrint.OnIdleState.IconLeftImage = null;
            this.btnPrint.OnIdleState.IconRightImage = null;
            this.btnPrint.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnPrint.OnPressedState.BorderRadius = 1;
            this.btnPrint.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPrint.OnPressedState.BorderThickness = 1;
            this.btnPrint.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnPrint.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnPrint.OnPressedState.IconLeftImage = null;
            this.btnPrint.OnPressedState.IconRightImage = null;
            this.btnPrint.Size = new System.Drawing.Size(158, 39);
            this.btnPrint.TabIndex = 158;
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrint.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPrint.TextMarginLeft = 0;
            this.btnPrint.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnPrint.UseDefaultRadiusAndThickness = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
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
            this.btnSearch.Location = new System.Drawing.Point(610, 17);
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
            this.bunifuLabel2.Location = new System.Drawing.Point(362, 31);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(25, 18);
            this.bunifuLabel2.TabIndex = 118;
            this.bunifuLabel2.Text = "To:";
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
            this.dtpToDate.DisabledColor = System.Drawing.Color.Black;
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
            this.dtpToDate.Location = new System.Drawing.Point(390, 25);
            this.dtpToDate.MinimumSize = new System.Drawing.Size(4, 32);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(214, 32);
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
            this.bunifuLabel1.Location = new System.Drawing.Point(65, 31);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(46, 18);
            this.bunifuLabel1.TabIndex = 116;
            this.bunifuLabel1.Text = "From:";
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
            this.dtpFromDate.DisabledColor = System.Drawing.Color.Black;
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
            this.dtpFromDate.Size = new System.Drawing.Size(214, 32);
            this.dtpFromDate.TabIndex = 35;
            this.dtpFromDate.Value = new System.DateTime(2022, 4, 27, 0, 0, 0, 0);
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Impact", 26.25F);
            this.bunifuLabel3.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel3.Location = new System.Drawing.Point(388, 68);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(306, 43);
            this.bunifuLabel3.TabIndex = 122;
            this.bunifuLabel3.Text = "SALES RETURN REPORT\r\n";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dgvReturnOwnerReport
            // 
            this.dgvReturnOwnerReport.AllowCustomTheming = false;
            this.dgvReturnOwnerReport.AllowUserToAddRows = false;
            this.dgvReturnOwnerReport.AllowUserToDeleteRows = false;
            this.dgvReturnOwnerReport.AllowUserToResizeColumns = false;
            this.dgvReturnOwnerReport.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvReturnOwnerReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReturnOwnerReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReturnOwnerReport.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvReturnOwnerReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReturnOwnerReport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReturnOwnerReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReturnOwnerReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReturnOwnerReport.ColumnHeadersHeight = 40;
            this.dgvReturnOwnerReport.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvReturnOwnerReport.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvReturnOwnerReport.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvReturnOwnerReport.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvReturnOwnerReport.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvReturnOwnerReport.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvReturnOwnerReport.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvReturnOwnerReport.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvReturnOwnerReport.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvReturnOwnerReport.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvReturnOwnerReport.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvReturnOwnerReport.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvReturnOwnerReport.CurrentTheme.Name = null;
            this.dgvReturnOwnerReport.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvReturnOwnerReport.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvReturnOwnerReport.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvReturnOwnerReport.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvReturnOwnerReport.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReturnOwnerReport.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReturnOwnerReport.EnableHeadersVisualStyles = false;
            this.dgvReturnOwnerReport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvReturnOwnerReport.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvReturnOwnerReport.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvReturnOwnerReport.HeaderForeColor = System.Drawing.Color.White;
            this.dgvReturnOwnerReport.Location = new System.Drawing.Point(24, 276);
            this.dgvReturnOwnerReport.Name = "dgvReturnOwnerReport";
            this.dgvReturnOwnerReport.ReadOnly = true;
            this.dgvReturnOwnerReport.RowHeadersVisible = false;
            this.dgvReturnOwnerReport.RowTemplate.Height = 40;
            this.dgvReturnOwnerReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReturnOwnerReport.Size = new System.Drawing.Size(930, 245);
            this.dgvReturnOwnerReport.TabIndex = 136;
            this.dgvReturnOwnerReport.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgvReturnOwnerReport.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvReturnOwnerReport_CellFormatting);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.White;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(309, 52);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(73, 73);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 127;
            this.pictureBox8.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.rbnCustom);
            this.panel1.Controls.Add(this.rbnYearly);
            this.panel1.Controls.Add(this.rbnMonthly);
            this.panel1.Controls.Add(this.rbnWeekly);
            this.panel1.Controls.Add(this.rbnDaily);
            this.panel1.Location = new System.Drawing.Point(205, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 33);
            this.panel1.TabIndex = 153;
            // 
            // rbnCustom
            // 
            this.rbnCustom.AutoSize = true;
            this.rbnCustom.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnCustom.ForeColor = System.Drawing.Color.White;
            this.rbnCustom.Location = new System.Drawing.Point(444, 7);
            this.rbnCustom.Name = "rbnCustom";
            this.rbnCustom.Size = new System.Drawing.Size(87, 22);
            this.rbnCustom.TabIndex = 4;
            this.rbnCustom.TabStop = true;
            this.rbnCustom.Text = "Custom";
            this.rbnCustom.UseVisualStyleBackColor = true;
            this.rbnCustom.CheckedChanged += new System.EventHandler(this.rbnCustom_CheckedChanged);
            // 
            // rbnYearly
            // 
            this.rbnYearly.AutoSize = true;
            this.rbnYearly.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnYearly.ForeColor = System.Drawing.Color.White;
            this.rbnYearly.Location = new System.Drawing.Point(338, 7);
            this.rbnYearly.Name = "rbnYearly";
            this.rbnYearly.Size = new System.Drawing.Size(76, 22);
            this.rbnYearly.TabIndex = 3;
            this.rbnYearly.TabStop = true;
            this.rbnYearly.Text = "Yearly";
            this.rbnYearly.UseVisualStyleBackColor = true;
            this.rbnYearly.CheckedChanged += new System.EventHandler(this.rbnYearly_CheckedChanged);
            // 
            // rbnMonthly
            // 
            this.rbnMonthly.AutoSize = true;
            this.rbnMonthly.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnMonthly.ForeColor = System.Drawing.Color.White;
            this.rbnMonthly.Location = new System.Drawing.Point(229, 7);
            this.rbnMonthly.Name = "rbnMonthly";
            this.rbnMonthly.Size = new System.Drawing.Size(88, 22);
            this.rbnMonthly.TabIndex = 2;
            this.rbnMonthly.TabStop = true;
            this.rbnMonthly.Text = "Monthly";
            this.rbnMonthly.UseVisualStyleBackColor = true;
            this.rbnMonthly.CheckedChanged += new System.EventHandler(this.rbnMonthly_CheckedChanged);
            // 
            // rbnWeekly
            // 
            this.rbnWeekly.AutoSize = true;
            this.rbnWeekly.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnWeekly.ForeColor = System.Drawing.Color.White;
            this.rbnWeekly.Location = new System.Drawing.Point(104, 7);
            this.rbnWeekly.Name = "rbnWeekly";
            this.rbnWeekly.Size = new System.Drawing.Size(83, 22);
            this.rbnWeekly.TabIndex = 1;
            this.rbnWeekly.TabStop = true;
            this.rbnWeekly.Text = "Weekly";
            this.rbnWeekly.UseVisualStyleBackColor = true;
            this.rbnWeekly.CheckedChanged += new System.EventHandler(this.rbnWeekly_CheckedChanged);
            // 
            // rbnDaily
            // 
            this.rbnDaily.AutoSize = true;
            this.rbnDaily.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnDaily.ForeColor = System.Drawing.Color.White;
            this.rbnDaily.Location = new System.Drawing.Point(14, 7);
            this.rbnDaily.Name = "rbnDaily";
            this.rbnDaily.Size = new System.Drawing.Size(65, 22);
            this.rbnDaily.TabIndex = 0;
            this.rbnDaily.TabStop = true;
            this.rbnDaily.Text = "Daily";
            this.rbnDaily.UseVisualStyleBackColor = true;
            this.rbnDaily.CheckedChanged += new System.EventHandler(this.rbnDaily_CheckedChanged);
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.bunifuLabel4.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel4.Location = new System.Drawing.Point(621, 568);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(167, 18);
            this.bunifuLabel4.TabIndex = 154;
            this.bunifuLabel4.Text = "Total Returned Sales";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // TotalReturnedSales
            // 
            this.TotalReturnedSales.AllowParentOverrides = false;
            this.TotalReturnedSales.AutoEllipsis = false;
            this.TotalReturnedSales.CursorType = null;
            this.TotalReturnedSales.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.TotalReturnedSales.ForeColor = System.Drawing.Color.Black;
            this.TotalReturnedSales.Location = new System.Drawing.Point(870, 568);
            this.TotalReturnedSales.Name = "TotalReturnedSales";
            this.TotalReturnedSales.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TotalReturnedSales.Size = new System.Drawing.Size(10, 18);
            this.TotalReturnedSales.TabIndex = 155;
            this.TotalReturnedSales.Text = "0";
            this.TotalReturnedSales.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.TotalReturnedSales.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel6
            // 
            this.bunifuLabel6.AllowParentOverrides = false;
            this.bunifuLabel6.AutoEllipsis = false;
            this.bunifuLabel6.CursorType = null;
            this.bunifuLabel6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.bunifuLabel6.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel6.Location = new System.Drawing.Point(621, 535);
            this.bunifuLabel6.Name = "bunifuLabel6";
            this.bunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel6.Size = new System.Drawing.Size(158, 18);
            this.bunifuLabel6.TabIndex = 156;
            this.bunifuLabel6.Text = "Total Returned Item";
            this.bunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblTotalReturnItem
            // 
            this.lblTotalReturnItem.AllowParentOverrides = false;
            this.lblTotalReturnItem.AutoEllipsis = false;
            this.lblTotalReturnItem.CursorType = null;
            this.lblTotalReturnItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.lblTotalReturnItem.ForeColor = System.Drawing.Color.Black;
            this.lblTotalReturnItem.Location = new System.Drawing.Point(870, 535);
            this.lblTotalReturnItem.Name = "lblTotalReturnItem";
            this.lblTotalReturnItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalReturnItem.Size = new System.Drawing.Size(10, 18);
            this.lblTotalReturnItem.TabIndex = 157;
            this.lblTotalReturnItem.Text = "0";
            this.lblTotalReturnItem.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTotalReturnItem.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // frmSales_Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 598);
            this.Controls.Add(this.lblTotalReturnItem);
            this.Controls.Add(this.bunifuLabel6);
            this.Controls.Add(this.TotalReturnedSales);
            this.Controls.Add(this.bunifuLabel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvReturnOwnerReport);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bunifuLabel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSales_Return";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Return";
            this.Load += new System.EventHandler(this.frmSales_Return_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnOwnerReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.UI.WinForms.BunifuImageButton btnSearch;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuDatePicker dtpToDate;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuDatePicker dtpFromDate;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private System.Windows.Forms.PictureBox pictureBox8;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvReturnOwnerReport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbnCustom;
        private System.Windows.Forms.RadioButton rbnYearly;
        private System.Windows.Forms.RadioButton rbnMonthly;
        private System.Windows.Forms.RadioButton rbnWeekly;
        private System.Windows.Forms.RadioButton rbnDaily;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuLabel TotalReturnedSales;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel6;
        private Bunifu.UI.WinForms.BunifuLabel lblTotalReturnItem;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnPrint;
    }
}