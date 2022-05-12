namespace SALES_AND_INVENTORY_SYSTEM_FOR_RI_RICE_MILL.Cashier_Modules
{
    partial class ucReturns
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucReturns));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPanel4 = new Bunifu.UI.WinForms.BunifuPanel();
            this.dgvOrderDeetsList = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.btnViewReturn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDeetsList)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Underline);
            this.bunifuLabel3.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel3.Location = new System.Drawing.Point(76, 79);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(245, 48);
            this.bunifuLabel3.TabIndex = 41;
            this.bunifuLabel3.Text = "SALES RETURNS";
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
            this.bunifuPanel4.Controls.Add(this.dgvOrderDeetsList);
            this.bunifuPanel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuPanel4.Location = new System.Drawing.Point(76, 158);
            this.bunifuPanel4.Name = "bunifuPanel4";
            this.bunifuPanel4.ShowBorders = false;
            this.bunifuPanel4.Size = new System.Drawing.Size(907, 458);
            this.bunifuPanel4.TabIndex = 42;
            // 
            // dgvOrderDeetsList
            // 
            this.dgvOrderDeetsList.AllowCustomTheming = false;
            this.dgvOrderDeetsList.AllowUserToAddRows = false;
            this.dgvOrderDeetsList.AllowUserToDeleteRows = false;
            this.dgvOrderDeetsList.AllowUserToResizeColumns = false;
            this.dgvOrderDeetsList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvOrderDeetsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrderDeetsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderDeetsList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvOrderDeetsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrderDeetsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOrderDeetsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderDeetsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrderDeetsList.ColumnHeadersHeight = 40;
            this.dgvOrderDeetsList.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvOrderDeetsList.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvOrderDeetsList.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvOrderDeetsList.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvOrderDeetsList.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvOrderDeetsList.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvOrderDeetsList.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvOrderDeetsList.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvOrderDeetsList.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvOrderDeetsList.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvOrderDeetsList.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvOrderDeetsList.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvOrderDeetsList.CurrentTheme.Name = null;
            this.dgvOrderDeetsList.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvOrderDeetsList.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvOrderDeetsList.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvOrderDeetsList.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvOrderDeetsList.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrderDeetsList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOrderDeetsList.EnableHeadersVisualStyles = false;
            this.dgvOrderDeetsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvOrderDeetsList.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvOrderDeetsList.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvOrderDeetsList.HeaderForeColor = System.Drawing.Color.White;
            this.dgvOrderDeetsList.Location = new System.Drawing.Point(30, 33);
            this.dgvOrderDeetsList.Name = "dgvOrderDeetsList";
            this.dgvOrderDeetsList.ReadOnly = true;
            this.dgvOrderDeetsList.RowHeadersVisible = false;
            this.dgvOrderDeetsList.RowTemplate.Height = 40;
            this.dgvOrderDeetsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderDeetsList.Size = new System.Drawing.Size(851, 395);
            this.dgvOrderDeetsList.TabIndex = 4;
            this.dgvOrderDeetsList.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // btnViewReturn
            // 
            this.btnViewReturn.AllowAnimations = true;
            this.btnViewReturn.AllowMouseEffects = true;
            this.btnViewReturn.AllowToggling = false;
            this.btnViewReturn.AnimationSpeed = 200;
            this.btnViewReturn.AutoGenerateColors = false;
            this.btnViewReturn.AutoRoundBorders = false;
            this.btnViewReturn.AutoSizeLeftIcon = true;
            this.btnViewReturn.AutoSizeRightIcon = true;
            this.btnViewReturn.BackColor = System.Drawing.Color.Transparent;
            this.btnViewReturn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnViewReturn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewReturn.BackgroundImage")));
            this.btnViewReturn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnViewReturn.ButtonText = "View Returns";
            this.btnViewReturn.ButtonTextMarginLeft = 0;
            this.btnViewReturn.ColorContrastOnClick = 45;
            this.btnViewReturn.ColorContrastOnHover = 45;
            this.btnViewReturn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnViewReturn.CustomizableEdges = borderEdges1;
            this.btnViewReturn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnViewReturn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnViewReturn.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnViewReturn.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnViewReturn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnViewReturn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnViewReturn.ForeColor = System.Drawing.Color.White;
            this.btnViewReturn.IconLeft = null;
            this.btnViewReturn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewReturn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnViewReturn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnViewReturn.IconMarginLeft = 11;
            this.btnViewReturn.IconPadding = 10;
            this.btnViewReturn.IconRight = null;
            this.btnViewReturn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewReturn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnViewReturn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnViewReturn.IconSize = 25;
            this.btnViewReturn.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnViewReturn.IdleBorderRadius = 0;
            this.btnViewReturn.IdleBorderThickness = 0;
            this.btnViewReturn.IdleFillColor = System.Drawing.Color.Empty;
            this.btnViewReturn.IdleIconLeftImage = null;
            this.btnViewReturn.IdleIconRightImage = null;
            this.btnViewReturn.IndicateFocus = false;
            this.btnViewReturn.Location = new System.Drawing.Point(861, 102);
            this.btnViewReturn.Name = "btnViewReturn";
            this.btnViewReturn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnViewReturn.OnDisabledState.BorderRadius = 1;
            this.btnViewReturn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnViewReturn.OnDisabledState.BorderThickness = 1;
            this.btnViewReturn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnViewReturn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnViewReturn.OnDisabledState.IconLeftImage = null;
            this.btnViewReturn.OnDisabledState.IconRightImage = null;
            this.btnViewReturn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnViewReturn.onHoverState.BorderRadius = 1;
            this.btnViewReturn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnViewReturn.onHoverState.BorderThickness = 1;
            this.btnViewReturn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnViewReturn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnViewReturn.onHoverState.IconLeftImage = null;
            this.btnViewReturn.onHoverState.IconRightImage = null;
            this.btnViewReturn.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btnViewReturn.OnIdleState.BorderRadius = 1;
            this.btnViewReturn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnViewReturn.OnIdleState.BorderThickness = 1;
            this.btnViewReturn.OnIdleState.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnViewReturn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnViewReturn.OnIdleState.IconLeftImage = null;
            this.btnViewReturn.OnIdleState.IconRightImage = null;
            this.btnViewReturn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnViewReturn.OnPressedState.BorderRadius = 1;
            this.btnViewReturn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnViewReturn.OnPressedState.BorderThickness = 1;
            this.btnViewReturn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnViewReturn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnViewReturn.OnPressedState.IconLeftImage = null;
            this.btnViewReturn.OnPressedState.IconRightImage = null;
            this.btnViewReturn.Size = new System.Drawing.Size(122, 39);
            this.btnViewReturn.TabIndex = 43;
            this.btnViewReturn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnViewReturn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnViewReturn.TextMarginLeft = 0;
            this.btnViewReturn.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnViewReturn.UseDefaultRadiusAndThickness = true;
            this.btnViewReturn.Click += new System.EventHandler(this.btnViewReturn_Click);
            // 
            // ucReturns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnViewReturn);
            this.Controls.Add(this.bunifuPanel4);
            this.Controls.Add(this.bunifuLabel3);
            this.Name = "ucReturns";
            this.Size = new System.Drawing.Size(1087, 675);
            this.bunifuPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDeetsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel4;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvOrderDeetsList;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnViewReturn;
    }
}
