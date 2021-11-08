
namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL
{
    partial class frmViewInventoryReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewInventoryReport));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.btnExReport = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnClear = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnRefresh = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnSearch = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvInventoryReport = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.drpYear = new Bunifu.UI.WinForms.BunifuDropdown();
            this.drpMonth = new Bunifu.UI.WinForms.BunifuDropdown();
            this.drpDay = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryReport)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExReport
            // 
            this.btnExReport.AllowAnimations = true;
            this.btnExReport.AllowMouseEffects = true;
            this.btnExReport.AllowToggling = false;
            this.btnExReport.AnimationSpeed = 200;
            this.btnExReport.AutoGenerateColors = false;
            this.btnExReport.AutoRoundBorders = false;
            this.btnExReport.AutoSizeLeftIcon = true;
            this.btnExReport.AutoSizeRightIcon = true;
            this.btnExReport.BackColor = System.Drawing.Color.Transparent;
            this.btnExReport.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnExReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExReport.BackgroundImage")));
            this.btnExReport.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExReport.ButtonText = "Generate Report";
            this.btnExReport.ButtonTextMarginLeft = 0;
            this.btnExReport.ColorContrastOnClick = 45;
            this.btnExReport.ColorContrastOnHover = 45;
            this.btnExReport.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnExReport.CustomizableEdges = borderEdges1;
            this.btnExReport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExReport.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnExReport.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnExReport.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnExReport.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnExReport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExReport.ForeColor = System.Drawing.Color.Black;
            this.btnExReport.IconLeft = null;
            this.btnExReport.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExReport.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnExReport.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnExReport.IconMarginLeft = 11;
            this.btnExReport.IconPadding = 10;
            this.btnExReport.IconRight = null;
            this.btnExReport.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExReport.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnExReport.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnExReport.IconSize = 25;
            this.btnExReport.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnExReport.IdleBorderRadius = 0;
            this.btnExReport.IdleBorderThickness = 0;
            this.btnExReport.IdleFillColor = System.Drawing.Color.Empty;
            this.btnExReport.IdleIconLeftImage = null;
            this.btnExReport.IdleIconRightImage = null;
            this.btnExReport.IndicateFocus = false;
            this.btnExReport.Location = new System.Drawing.Point(807, 156);
            this.btnExReport.Name = "btnExReport";
            this.btnExReport.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnExReport.OnDisabledState.BorderRadius = 1;
            this.btnExReport.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExReport.OnDisabledState.BorderThickness = 1;
            this.btnExReport.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnExReport.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnExReport.OnDisabledState.IconLeftImage = null;
            this.btnExReport.OnDisabledState.IconRightImage = null;
            this.btnExReport.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnExReport.onHoverState.BorderRadius = 1;
            this.btnExReport.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExReport.onHoverState.BorderThickness = 1;
            this.btnExReport.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnExReport.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnExReport.onHoverState.IconLeftImage = null;
            this.btnExReport.onHoverState.IconRightImage = null;
            this.btnExReport.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnExReport.OnIdleState.BorderRadius = 1;
            this.btnExReport.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExReport.OnIdleState.BorderThickness = 1;
            this.btnExReport.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnExReport.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnExReport.OnIdleState.IconLeftImage = null;
            this.btnExReport.OnIdleState.IconRightImage = null;
            this.btnExReport.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnExReport.OnPressedState.BorderRadius = 1;
            this.btnExReport.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExReport.OnPressedState.BorderThickness = 1;
            this.btnExReport.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnExReport.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnExReport.OnPressedState.IconLeftImage = null;
            this.btnExReport.OnPressedState.IconRightImage = null;
            this.btnExReport.Size = new System.Drawing.Size(158, 39);
            this.btnExReport.TabIndex = 12;
            this.btnExReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExReport.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExReport.TextMarginLeft = 0;
            this.btnExReport.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnExReport.UseDefaultRadiusAndThickness = true;
            this.btnExReport.Click += new System.EventHandler(this.btnExReport_Click);
            // 
            // btnClear
            // 
            this.btnClear.ActiveImage = null;
            this.btnClear.AllowAnimations = true;
            this.btnClear.AllowBuffering = false;
            this.btnClear.AllowToggling = false;
            this.btnClear.AllowZooming = false;
            this.btnClear.AllowZoomingOnFocus = false;
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClear.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnClear.ErrorImage")));
            this.btnClear.FadeWhenInactive = false;
            this.btnClear.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnClear.Image = global::SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.Properties.Resources.close_cross;
            this.btnClear.ImageActive = null;
            this.btnClear.ImageLocation = null;
            this.btnClear.ImageMargin = 20;
            this.btnClear.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClear.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.btnClear.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnClear.InitialImage")));
            this.btnClear.Location = new System.Drawing.Point(919, 201);
            this.btnClear.Name = "btnClear";
            this.btnClear.Rotation = 0;
            this.btnClear.ShowActiveImage = true;
            this.btnClear.ShowCursorChanges = true;
            this.btnClear.ShowImageBorders = true;
            this.btnClear.ShowSizeMarkers = false;
            this.btnClear.Size = new System.Drawing.Size(50, 50);
            this.btnClear.TabIndex = 11;
            this.btnClear.ToolTipText = "";
            this.btnClear.WaitOnLoad = false;
            this.btnClear.Zoom = 20;
            this.btnClear.ZoomSpeed = 10;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.ActiveImage = null;
            this.btnRefresh.AllowAnimations = true;
            this.btnRefresh.AllowBuffering = false;
            this.btnRefresh.AllowToggling = false;
            this.btnRefresh.AllowZooming = false;
            this.btnRefresh.AllowZoomingOnFocus = false;
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRefresh.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ErrorImage")));
            this.btnRefresh.FadeWhenInactive = false;
            this.btnRefresh.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnRefresh.Image = global::SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.Properties.Resources.reload;
            this.btnRefresh.ImageActive = null;
            this.btnRefresh.ImageLocation = null;
            this.btnRefresh.ImageMargin = 20;
            this.btnRefresh.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRefresh.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.btnRefresh.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.InitialImage")));
            this.btnRefresh.Location = new System.Drawing.Point(863, 201);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Rotation = 0;
            this.btnRefresh.ShowActiveImage = true;
            this.btnRefresh.ShowCursorChanges = true;
            this.btnRefresh.ShowImageBorders = true;
            this.btnRefresh.ShowSizeMarkers = false;
            this.btnRefresh.Size = new System.Drawing.Size(50, 50);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.ToolTipText = "";
            this.btnRefresh.WaitOnLoad = false;
            this.btnRefresh.Zoom = 20;
            this.btnRefresh.ZoomSpeed = 10;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
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
            this.btnSearch.Location = new System.Drawing.Point(807, 201);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Rotation = 0;
            this.btnSearch.ShowActiveImage = true;
            this.btnSearch.ShowCursorChanges = true;
            this.btnSearch.ShowImageBorders = true;
            this.btnSearch.ShowSizeMarkers = false;
            this.btnSearch.Size = new System.Drawing.Size(50, 50);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.ToolTipText = "";
            this.btnSearch.WaitOnLoad = false;
            this.btnSearch.Zoom = 20;
            this.btnSearch.ZoomSpeed = 10;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Impact", 30F);
            this.bunifuLabel3.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel3.Location = new System.Drawing.Point(404, 53);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(323, 48);
            this.bunifuLabel3.TabIndex = 45;
            this.bunifuLabel3.Text = "INVENTORY REPORTS\r\n";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.Properties.Resources.clipboard;
            this.pictureBox1.Location = new System.Drawing.Point(319, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnExit.Location = new System.Drawing.Point(982, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(58, 38);
            this.btnExit.TabIndex = 100;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvInventoryReport
            // 
            this.dgvInventoryReport.AllowCustomTheming = false;
            this.dgvInventoryReport.AllowUserToAddRows = false;
            this.dgvInventoryReport.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvInventoryReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventoryReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventoryReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInventoryReport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvInventoryReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventoryReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInventoryReport.ColumnHeadersHeight = 40;
            this.dgvInventoryReport.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvInventoryReport.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvInventoryReport.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvInventoryReport.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvInventoryReport.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvInventoryReport.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvInventoryReport.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvInventoryReport.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvInventoryReport.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvInventoryReport.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvInventoryReport.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvInventoryReport.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvInventoryReport.CurrentTheme.Name = null;
            this.dgvInventoryReport.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvInventoryReport.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvInventoryReport.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvInventoryReport.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvInventoryReport.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventoryReport.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInventoryReport.EnableHeadersVisualStyles = false;
            this.dgvInventoryReport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvInventoryReport.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvInventoryReport.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvInventoryReport.HeaderForeColor = System.Drawing.Color.White;
            this.dgvInventoryReport.Location = new System.Drawing.Point(42, 291);
            this.dgvInventoryReport.Name = "dgvInventoryReport";
            this.dgvInventoryReport.ReadOnly = true;
            this.dgvInventoryReport.RowHeadersVisible = false;
            this.dgvInventoryReport.RowTemplate.Height = 40;
            this.dgvInventoryReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventoryReport.Size = new System.Drawing.Size(930, 390);
            this.dgvInventoryReport.TabIndex = 101;
            this.dgvInventoryReport.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bunifuButton1);
            this.groupBox1.Controls.Add(this.drpYear);
            this.groupBox1.Controls.Add(this.drpMonth);
            this.groupBox1.Controls.Add(this.drpDay);
            this.groupBox1.Controls.Add(this.bunifuLabel4);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(42, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 108);
            this.groupBox1.TabIndex = 102;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date Range:";
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.AllowAnimations = true;
            this.bunifuButton1.AllowMouseEffects = true;
            this.bunifuButton1.AllowToggling = false;
            this.bunifuButton1.AnimationSpeed = 200;
            this.bunifuButton1.AutoGenerateColors = false;
            this.bunifuButton1.AutoRoundBorders = false;
            this.bunifuButton1.AutoSizeLeftIcon = true;
            this.bunifuButton1.AutoSizeRightIcon = true;
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.ButtonText = "All Time";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.ColorContrastOnClick = 45;
            this.bunifuButton1.ColorContrastOnHover = 45;
            this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.bunifuButton1.CustomizableEdges = borderEdges2;
            this.bunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.Empty;
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.Empty;
            this.bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.IconLeft = null;
            this.bunifuButton1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton1.IconMarginLeft = 11;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRight = null;
            this.bunifuButton1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton1.IconSize = 25;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.Empty;
            this.bunifuButton1.IdleBorderRadius = 0;
            this.bunifuButton1.IdleBorderThickness = 0;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.Empty;
            this.bunifuButton1.IdleIconLeftImage = null;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.IndicateFocus = false;
            this.bunifuButton1.Location = new System.Drawing.Point(562, 41);
            this.bunifuButton1.Name = "bunifuButton1";
            this.bunifuButton1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.OnDisabledState.BorderRadius = 1;
            this.bunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnDisabledState.BorderThickness = 1;
            this.bunifuButton1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.OnDisabledState.IconLeftImage = null;
            this.bunifuButton1.OnDisabledState.IconRightImage = null;
            this.bunifuButton1.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.bunifuButton1.onHoverState.BorderRadius = 1;
            this.bunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.onHoverState.BorderThickness = 1;
            this.bunifuButton1.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.bunifuButton1.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.onHoverState.IconLeftImage = null;
            this.bunifuButton1.onHoverState.IconRightImage = null;
            this.bunifuButton1.OnIdleState.BorderColor = System.Drawing.Color.RoyalBlue;
            this.bunifuButton1.OnIdleState.BorderRadius = 1;
            this.bunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnIdleState.BorderThickness = 1;
            this.bunifuButton1.OnIdleState.FillColor = System.Drawing.Color.RoyalBlue;
            this.bunifuButton1.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnIdleState.IconLeftImage = null;
            this.bunifuButton1.OnIdleState.IconRightImage = null;
            this.bunifuButton1.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton1.OnPressedState.BorderRadius = 1;
            this.bunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnPressedState.BorderThickness = 1;
            this.bunifuButton1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton1.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnPressedState.IconLeftImage = null;
            this.bunifuButton1.OnPressedState.IconRightImage = null;
            this.bunifuButton1.Size = new System.Drawing.Size(133, 32);
            this.bunifuButton1.TabIndex = 102;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            // 
            // drpYear
            // 
            this.drpYear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drpYear.BackColor = System.Drawing.Color.Transparent;
            this.drpYear.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.drpYear.BorderColor = System.Drawing.Color.Silver;
            this.drpYear.BorderRadius = 1;
            this.drpYear.Color = System.Drawing.Color.Silver;
            this.drpYear.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.drpYear.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.drpYear.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.drpYear.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.drpYear.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.drpYear.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.drpYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.drpYear.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.drpYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpYear.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Center;
            this.drpYear.FillDropDown = true;
            this.drpYear.FillIndicator = false;
            this.drpYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drpYear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpYear.ForeColor = System.Drawing.Color.White;
            this.drpYear.FormattingEnabled = true;
            this.drpYear.Icon = null;
            this.drpYear.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.drpYear.IndicatorColor = System.Drawing.Color.DarkGray;
            this.drpYear.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.drpYear.IndicatorThickness = 2;
            this.drpYear.IsDropdownOpened = false;
            this.drpYear.ItemBackColor = System.Drawing.Color.White;
            this.drpYear.ItemBorderColor = System.Drawing.Color.White;
            this.drpYear.ItemForeColor = System.Drawing.Color.Black;
            this.drpYear.ItemHeight = 26;
            this.drpYear.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.drpYear.ItemHighLightForeColor = System.Drawing.Color.White;
            this.drpYear.ItemTopMargin = 3;
            this.drpYear.Location = new System.Drawing.Point(394, 41);
            this.drpYear.Name = "drpYear";
            this.drpYear.Size = new System.Drawing.Size(139, 32);
            this.drpYear.TabIndex = 10;
            this.drpYear.Text = "Yearly";
            this.drpYear.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Center;
            this.drpYear.TextLeftMargin = 5;
            // 
            // drpMonth
            // 
            this.drpMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drpMonth.BackColor = System.Drawing.Color.Transparent;
            this.drpMonth.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.drpMonth.BorderColor = System.Drawing.Color.Silver;
            this.drpMonth.BorderRadius = 1;
            this.drpMonth.Color = System.Drawing.Color.Silver;
            this.drpMonth.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.drpMonth.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.drpMonth.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.drpMonth.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.drpMonth.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.drpMonth.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.drpMonth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.drpMonth.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.drpMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpMonth.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Center;
            this.drpMonth.FillDropDown = true;
            this.drpMonth.FillIndicator = false;
            this.drpMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drpMonth.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpMonth.ForeColor = System.Drawing.Color.White;
            this.drpMonth.FormattingEnabled = true;
            this.drpMonth.Icon = null;
            this.drpMonth.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.drpMonth.IndicatorColor = System.Drawing.Color.DarkGray;
            this.drpMonth.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.drpMonth.IndicatorThickness = 2;
            this.drpMonth.IsDropdownOpened = false;
            this.drpMonth.ItemBackColor = System.Drawing.Color.White;
            this.drpMonth.ItemBorderColor = System.Drawing.Color.White;
            this.drpMonth.ItemForeColor = System.Drawing.Color.Black;
            this.drpMonth.ItemHeight = 26;
            this.drpMonth.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.drpMonth.ItemHighLightForeColor = System.Drawing.Color.White;
            this.drpMonth.ItemTopMargin = 3;
            this.drpMonth.Location = new System.Drawing.Point(206, 41);
            this.drpMonth.Name = "drpMonth";
            this.drpMonth.Size = new System.Drawing.Size(153, 32);
            this.drpMonth.TabIndex = 9;
            this.drpMonth.Text = "Monthly";
            this.drpMonth.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Center;
            this.drpMonth.TextLeftMargin = 5;
            // 
            // drpDay
            // 
            this.drpDay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drpDay.BackColor = System.Drawing.Color.Transparent;
            this.drpDay.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.drpDay.BorderColor = System.Drawing.Color.Silver;
            this.drpDay.BorderRadius = 1;
            this.drpDay.Color = System.Drawing.Color.Silver;
            this.drpDay.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.drpDay.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.drpDay.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.drpDay.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.drpDay.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.drpDay.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.drpDay.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.drpDay.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.drpDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpDay.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Center;
            this.drpDay.FillDropDown = true;
            this.drpDay.FillIndicator = false;
            this.drpDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drpDay.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpDay.ForeColor = System.Drawing.Color.White;
            this.drpDay.FormattingEnabled = true;
            this.drpDay.Icon = null;
            this.drpDay.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.drpDay.IndicatorColor = System.Drawing.Color.DarkGray;
            this.drpDay.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.drpDay.IndicatorThickness = 2;
            this.drpDay.IsDropdownOpened = false;
            this.drpDay.ItemBackColor = System.Drawing.Color.White;
            this.drpDay.ItemBorderColor = System.Drawing.Color.White;
            this.drpDay.ItemForeColor = System.Drawing.Color.Black;
            this.drpDay.ItemHeight = 26;
            this.drpDay.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.drpDay.ItemHighLightForeColor = System.Drawing.Color.White;
            this.drpDay.ItemTopMargin = 3;
            this.drpDay.Location = new System.Drawing.Point(45, 41);
            this.drpDay.Name = "drpDay";
            this.drpDay.Size = new System.Drawing.Size(119, 32);
            this.drpDay.TabIndex = 8;
            this.drpDay.Text = "Daily";
            this.drpDay.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Center;
            this.drpDay.TextLeftMargin = 5;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel4.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel4.Location = new System.Drawing.Point(18, 47);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(31, 18);
            this.bunifuLabel4.TabIndex = 5;
            this.bunifuLabel4.Text = "Day";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // frmViewInventoryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1040, 710);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExReport);
            this.Controls.Add(this.dgvInventoryReport);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmViewInventoryReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Inventory Report";
            this.Load += new System.EventHandler(this.FrmViewSalesReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryReport)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuImageButton btnRefresh;
        private Bunifu.UI.WinForms.BunifuImageButton btnSearch;
        private Bunifu.UI.WinForms.BunifuImageButton btnClear;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnExReport;
        private System.Windows.Forms.Button btnExit;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvInventoryReport;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private Bunifu.UI.WinForms.BunifuDropdown drpYear;
        private Bunifu.UI.WinForms.BunifuDropdown drpMonth;
        private Bunifu.UI.WinForms.BunifuDropdown drpDay;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
    }
}