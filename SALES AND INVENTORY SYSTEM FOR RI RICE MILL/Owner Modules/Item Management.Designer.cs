namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.Owner_Modules
{
    partial class frmItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItems));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPanel4 = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnAddItem = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtViewItems = new Bunifu.UI.WinForms.BunifuTextBox();
            this.dgvItemList = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.bunifuPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Underline);
            this.bunifuLabel3.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel3.Location = new System.Drawing.Point(76, 75);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(299, 48);
            this.bunifuLabel3.TabIndex = 41;
            this.bunifuLabel3.Text = "ITEM MANAGEMENT";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPanel4
            // 
            this.bunifuPanel4.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bunifuPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel4.BackgroundImage")));
            this.bunifuPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel4.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuPanel4.BorderRadius = 5;
            this.bunifuPanel4.BorderThickness = 3;
            this.bunifuPanel4.Controls.Add(this.btnAddItem);
            this.bunifuPanel4.Controls.Add(this.txtViewItems);
            this.bunifuPanel4.Controls.Add(this.dgvItemList);
            this.bunifuPanel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuPanel4.Location = new System.Drawing.Point(76, 129);
            this.bunifuPanel4.Name = "bunifuPanel4";
            this.bunifuPanel4.ShowBorders = false;
            this.bunifuPanel4.Size = new System.Drawing.Size(907, 497);
            this.bunifuPanel4.TabIndex = 42;
            // 
            // btnAddItem
            // 
            this.btnAddItem.AllowAnimations = true;
            this.btnAddItem.AllowMouseEffects = true;
            this.btnAddItem.AllowToggling = false;
            this.btnAddItem.AnimationSpeed = 200;
            this.btnAddItem.AutoGenerateColors = false;
            this.btnAddItem.AutoRoundBorders = false;
            this.btnAddItem.AutoSizeLeftIcon = true;
            this.btnAddItem.AutoSizeRightIcon = true;
            this.btnAddItem.BackColor = System.Drawing.Color.Transparent;
            this.btnAddItem.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnAddItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddItem.BackgroundImage")));
            this.btnAddItem.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddItem.ButtonText = "ADD ITEM";
            this.btnAddItem.ButtonTextMarginLeft = 0;
            this.btnAddItem.ColorContrastOnClick = 45;
            this.btnAddItem.ColorContrastOnHover = 45;
            this.btnAddItem.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnAddItem.CustomizableEdges = borderEdges1;
            this.btnAddItem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddItem.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddItem.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnAddItem.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnAddItem.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAddItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.IconLeft = null;
            this.btnAddItem.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddItem.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddItem.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAddItem.IconMarginLeft = 11;
            this.btnAddItem.IconPadding = 10;
            this.btnAddItem.IconRight = null;
            this.btnAddItem.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddItem.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddItem.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAddItem.IconSize = 25;
            this.btnAddItem.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnAddItem.IdleBorderRadius = 0;
            this.btnAddItem.IdleBorderThickness = 0;
            this.btnAddItem.IdleFillColor = System.Drawing.Color.Empty;
            this.btnAddItem.IdleIconLeftImage = null;
            this.btnAddItem.IdleIconRightImage = null;
            this.btnAddItem.IndicateFocus = false;
            this.btnAddItem.Location = new System.Drawing.Point(769, 29);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddItem.OnDisabledState.BorderRadius = 1;
            this.btnAddItem.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddItem.OnDisabledState.BorderThickness = 1;
            this.btnAddItem.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddItem.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddItem.OnDisabledState.IconLeftImage = null;
            this.btnAddItem.OnDisabledState.IconRightImage = null;
            this.btnAddItem.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnAddItem.onHoverState.BorderRadius = 1;
            this.btnAddItem.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddItem.onHoverState.BorderThickness = 1;
            this.btnAddItem.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnAddItem.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.onHoverState.IconLeftImage = null;
            this.btnAddItem.onHoverState.IconRightImage = null;
            this.btnAddItem.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btnAddItem.OnIdleState.BorderRadius = 1;
            this.btnAddItem.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddItem.OnIdleState.BorderThickness = 1;
            this.btnAddItem.OnIdleState.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnAddItem.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.OnIdleState.IconLeftImage = null;
            this.btnAddItem.OnIdleState.IconRightImage = null;
            this.btnAddItem.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAddItem.OnPressedState.BorderRadius = 1;
            this.btnAddItem.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddItem.OnPressedState.BorderThickness = 1;
            this.btnAddItem.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAddItem.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.OnPressedState.IconLeftImage = null;
            this.btnAddItem.OnPressedState.IconRightImage = null;
            this.btnAddItem.Size = new System.Drawing.Size(122, 39);
            this.btnAddItem.TabIndex = 6;
            this.btnAddItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddItem.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddItem.TextMarginLeft = 0;
            this.btnAddItem.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAddItem.UseDefaultRadiusAndThickness = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // txtViewItems
            // 
            this.txtViewItems.AcceptsReturn = false;
            this.txtViewItems.AcceptsTab = false;
            this.txtViewItems.AnimationSpeed = 200;
            this.txtViewItems.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtViewItems.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtViewItems.AutoSizeHeight = true;
            this.txtViewItems.BackColor = System.Drawing.Color.Transparent;
            this.txtViewItems.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtViewItems.BackgroundImage")));
            this.txtViewItems.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtViewItems.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtViewItems.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtViewItems.BorderColorIdle = System.Drawing.Color.Black;
            this.txtViewItems.BorderRadius = 20;
            this.txtViewItems.BorderThickness = 1;
            this.txtViewItems.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtViewItems.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtViewItems.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtViewItems.DefaultText = "";
            this.txtViewItems.FillColor = System.Drawing.Color.White;
            this.txtViewItems.HideSelection = true;
            this.txtViewItems.IconLeft = null;
            this.txtViewItems.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtViewItems.IconPadding = 10;
            this.txtViewItems.IconRight = null;
            this.txtViewItems.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtViewItems.Lines = new string[0];
            this.txtViewItems.Location = new System.Drawing.Point(16, 29);
            this.txtViewItems.MaxLength = 32767;
            this.txtViewItems.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtViewItems.Modified = false;
            this.txtViewItems.Multiline = false;
            this.txtViewItems.Name = "txtViewItems";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtViewItems.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtViewItems.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtViewItems.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Black;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtViewItems.OnIdleState = stateProperties4;
            this.txtViewItems.Padding = new System.Windows.Forms.Padding(3);
            this.txtViewItems.PasswordChar = '\0';
            this.txtViewItems.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtViewItems.PlaceholderText = "Search..";
            this.txtViewItems.ReadOnly = false;
            this.txtViewItems.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtViewItems.SelectedText = "";
            this.txtViewItems.SelectionLength = 0;
            this.txtViewItems.SelectionStart = 0;
            this.txtViewItems.ShortcutsEnabled = true;
            this.txtViewItems.Size = new System.Drawing.Size(260, 39);
            this.txtViewItems.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtViewItems.TabIndex = 5;
            this.txtViewItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtViewItems.TextMarginBottom = 0;
            this.txtViewItems.TextMarginLeft = 3;
            this.txtViewItems.TextMarginTop = 1;
            this.txtViewItems.TextPlaceholder = "Search..";
            this.txtViewItems.UseSystemPasswordChar = false;
            this.txtViewItems.WordWrap = true;
            this.txtViewItems.TextChange += new System.EventHandler(this.txtViewItems_TextChange);
            // 
            // dgvItemList
            // 
            this.dgvItemList.AllowCustomTheming = false;
            this.dgvItemList.AllowUserToAddRows = false;
            this.dgvItemList.AllowUserToDeleteRows = false;
            this.dgvItemList.AllowUserToResizeColumns = false;
            this.dgvItemList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvItemList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItemList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItemList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvItemList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItemList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvItemList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItemList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItemList.ColumnHeadersHeight = 40;
            this.dgvItemList.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvItemList.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvItemList.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvItemList.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvItemList.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvItemList.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvItemList.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvItemList.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvItemList.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvItemList.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvItemList.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvItemList.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvItemList.CurrentTheme.Name = null;
            this.dgvItemList.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvItemList.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvItemList.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvItemList.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvItemList.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItemList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvItemList.EnableHeadersVisualStyles = false;
            this.dgvItemList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvItemList.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvItemList.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvItemList.HeaderForeColor = System.Drawing.Color.White;
            this.dgvItemList.Location = new System.Drawing.Point(16, 74);
            this.dgvItemList.Name = "dgvItemList";
            this.dgvItemList.ReadOnly = true;
            this.dgvItemList.RowHeadersVisible = false;
            this.dgvItemList.RowTemplate.Height = 40;
            this.dgvItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemList.Size = new System.Drawing.Size(875, 409);
            this.dgvItemList.TabIndex = 4;
            this.dgvItemList.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgvItemList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemList_CellContentClick);
            // 
            // frmItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuPanel4);
            this.Controls.Add(this.bunifuLabel3);
            this.Name = "frmItems";
            this.Size = new System.Drawing.Size(1002, 646);
            this.bunifuPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel4;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddItem;
        private Bunifu.UI.WinForms.BunifuTextBox txtViewItems;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvItemList;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
    }
}
