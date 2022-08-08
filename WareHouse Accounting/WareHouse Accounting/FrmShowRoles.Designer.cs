namespace WareHouse_Accounting
{
    partial class FrmShowRoles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmShowRoles));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.BtnNew = new DevComponents.DotNetBar.ButtonX();
            this.BtnEdit = new DevComponents.DotNetBar.ButtonX();
            this.BtnExit = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.DgvRolesShow = new System.Windows.Forms.DataGridView();
            this.EpShowRoles = new System.Windows.Forms.ErrorProvider(this.components);
            this.BsShowRoles = new System.Windows.Forms.BindingSource(this.components);
            this.roleIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depotPermissionDataGridViewTextBoxColumn = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.bankPermissionDataGridViewTextBoxColumn = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.personPermissionDataGridViewTextBoxColumn = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.factorPermissionDataGridViewTextBoxColumn = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.settingPermissionDataGridViewTextBoxColumn = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.userPermissionDataGridViewTextBoxColumn = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.lastEditDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnDelete = new DevComponents.DotNetBar.ButtonX();
            this.panelEx1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRolesShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpShowRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsShowRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.groupPanel2);
            this.panelEx1.Controls.Add(this.groupPanel1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(713, 316);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // groupPanel2
            // 
            this.groupPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.BtnDelete);
            this.groupPanel2.Controls.Add(this.BtnNew);
            this.groupPanel2.Controls.Add(this.BtnEdit);
            this.groupPanel2.Controls.Add(this.BtnExit);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(12, 253);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(689, 54);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 2;
            // 
            // BtnNew
            // 
            this.BtnNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnNew.FocusCuesEnabled = false;
            this.BtnNew.Image = global::WareHouse_Accounting.Properties.Resources.New;
            this.BtnNew.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.BtnNew.Location = new System.Drawing.Point(576, 6);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnNew.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5);
            this.BtnNew.Size = new System.Drawing.Size(100, 36);
            this.BtnNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnNew.TabIndex = 0;
            this.BtnNew.Text = "New";
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnEdit.FocusCuesEnabled = false;
            this.BtnEdit.Image = global::WareHouse_Accounting.Properties.Resources.Edit;
            this.BtnEdit.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.BtnEdit.Location = new System.Drawing.Point(461, 6);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnEdit.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5);
            this.BtnEdit.Size = new System.Drawing.Size(100, 36);
            this.BtnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnEdit.TabIndex = 1;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnExit.FocusCuesEnabled = false;
            this.BtnExit.Image = global::WareHouse_Accounting.Properties.Resources.Cancel;
            this.BtnExit.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.BtnExit.Location = new System.Drawing.Point(3, 6);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnExit.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5);
            this.BtnExit.Size = new System.Drawing.Size(100, 36);
            this.BtnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "Exit";
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.DgvRolesShow);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(12, 3);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(689, 244);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 0;
            this.groupPanel1.Text = "ShowRoles";
            // 
            // DgvRolesShow
            // 
            this.DgvRolesShow.AllowUserToAddRows = false;
            this.DgvRolesShow.AllowUserToDeleteRows = false;
            this.DgvRolesShow.AutoGenerateColumns = false;
            this.DgvRolesShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRolesShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roleIdDataGridViewTextBoxColumn,
            this.roleNameDataGridViewTextBoxColumn,
            this.depotPermissionDataGridViewTextBoxColumn,
            this.bankPermissionDataGridViewTextBoxColumn,
            this.personPermissionDataGridViewTextBoxColumn,
            this.factorPermissionDataGridViewTextBoxColumn,
            this.settingPermissionDataGridViewTextBoxColumn,
            this.userPermissionDataGridViewTextBoxColumn,
            this.lastEditDateTimeDataGridViewTextBoxColumn});
            this.DgvRolesShow.DataSource = this.BsShowRoles;
            this.DgvRolesShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvRolesShow.Location = new System.Drawing.Point(0, 0);
            this.DgvRolesShow.Name = "DgvRolesShow";
            this.DgvRolesShow.ReadOnly = true;
            this.DgvRolesShow.Size = new System.Drawing.Size(683, 220);
            this.DgvRolesShow.TabIndex = 0;
            // 
            // EpShowRoles
            // 
            this.EpShowRoles.ContainerControl = this;
            // 
            // BsShowRoles
            // 
            this.BsShowRoles.DataSource = typeof(WareHouse_Accounting.Role);
            // 
            // roleIdDataGridViewTextBoxColumn
            // 
            this.roleIdDataGridViewTextBoxColumn.DataPropertyName = "Role_Id";
            this.roleIdDataGridViewTextBoxColumn.HeaderText = "Role_Id";
            this.roleIdDataGridViewTextBoxColumn.Name = "roleIdDataGridViewTextBoxColumn";
            this.roleIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.roleIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // roleNameDataGridViewTextBoxColumn
            // 
            this.roleNameDataGridViewTextBoxColumn.DataPropertyName = "RoleName";
            this.roleNameDataGridViewTextBoxColumn.HeaderText = "Role Name";
            this.roleNameDataGridViewTextBoxColumn.Name = "roleNameDataGridViewTextBoxColumn";
            this.roleNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // depotPermissionDataGridViewTextBoxColumn
            // 
            this.depotPermissionDataGridViewTextBoxColumn.Checked = true;
            this.depotPermissionDataGridViewTextBoxColumn.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.depotPermissionDataGridViewTextBoxColumn.CheckValue = "N";
            this.depotPermissionDataGridViewTextBoxColumn.DataPropertyName = "DepotPermission";
            this.depotPermissionDataGridViewTextBoxColumn.HeaderText = "Depot Permission";
            this.depotPermissionDataGridViewTextBoxColumn.Name = "depotPermissionDataGridViewTextBoxColumn";
            this.depotPermissionDataGridViewTextBoxColumn.ReadOnly = true;
            this.depotPermissionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.depotPermissionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // bankPermissionDataGridViewTextBoxColumn
            // 
            this.bankPermissionDataGridViewTextBoxColumn.Checked = true;
            this.bankPermissionDataGridViewTextBoxColumn.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.bankPermissionDataGridViewTextBoxColumn.CheckValue = "N";
            this.bankPermissionDataGridViewTextBoxColumn.DataPropertyName = "BankPermission";
            this.bankPermissionDataGridViewTextBoxColumn.HeaderText = "Bank Permission";
            this.bankPermissionDataGridViewTextBoxColumn.Name = "bankPermissionDataGridViewTextBoxColumn";
            this.bankPermissionDataGridViewTextBoxColumn.ReadOnly = true;
            this.bankPermissionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.bankPermissionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // personPermissionDataGridViewTextBoxColumn
            // 
            this.personPermissionDataGridViewTextBoxColumn.Checked = true;
            this.personPermissionDataGridViewTextBoxColumn.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.personPermissionDataGridViewTextBoxColumn.CheckValue = "N";
            this.personPermissionDataGridViewTextBoxColumn.DataPropertyName = "PersonPermission";
            this.personPermissionDataGridViewTextBoxColumn.HeaderText = "Person Permission";
            this.personPermissionDataGridViewTextBoxColumn.Name = "personPermissionDataGridViewTextBoxColumn";
            this.personPermissionDataGridViewTextBoxColumn.ReadOnly = true;
            this.personPermissionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.personPermissionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // factorPermissionDataGridViewTextBoxColumn
            // 
            this.factorPermissionDataGridViewTextBoxColumn.Checked = true;
            this.factorPermissionDataGridViewTextBoxColumn.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.factorPermissionDataGridViewTextBoxColumn.CheckValue = "N";
            this.factorPermissionDataGridViewTextBoxColumn.DataPropertyName = "FactorPermission";
            this.factorPermissionDataGridViewTextBoxColumn.HeaderText = "Factor Permission";
            this.factorPermissionDataGridViewTextBoxColumn.Name = "factorPermissionDataGridViewTextBoxColumn";
            this.factorPermissionDataGridViewTextBoxColumn.ReadOnly = true;
            this.factorPermissionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.factorPermissionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // settingPermissionDataGridViewTextBoxColumn
            // 
            this.settingPermissionDataGridViewTextBoxColumn.Checked = true;
            this.settingPermissionDataGridViewTextBoxColumn.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.settingPermissionDataGridViewTextBoxColumn.CheckValue = "N";
            this.settingPermissionDataGridViewTextBoxColumn.DataPropertyName = "SettingPermission";
            this.settingPermissionDataGridViewTextBoxColumn.HeaderText = "Setting Permission";
            this.settingPermissionDataGridViewTextBoxColumn.Name = "settingPermissionDataGridViewTextBoxColumn";
            this.settingPermissionDataGridViewTextBoxColumn.ReadOnly = true;
            this.settingPermissionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.settingPermissionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // userPermissionDataGridViewTextBoxColumn
            // 
            this.userPermissionDataGridViewTextBoxColumn.Checked = true;
            this.userPermissionDataGridViewTextBoxColumn.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.userPermissionDataGridViewTextBoxColumn.CheckValue = "N";
            this.userPermissionDataGridViewTextBoxColumn.DataPropertyName = "UserPermission";
            this.userPermissionDataGridViewTextBoxColumn.HeaderText = "User Permission";
            this.userPermissionDataGridViewTextBoxColumn.Name = "userPermissionDataGridViewTextBoxColumn";
            this.userPermissionDataGridViewTextBoxColumn.ReadOnly = true;
            this.userPermissionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.userPermissionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // lastEditDateTimeDataGridViewTextBoxColumn
            // 
            this.lastEditDateTimeDataGridViewTextBoxColumn.DataPropertyName = "LastEditDateTime";
            this.lastEditDateTimeDataGridViewTextBoxColumn.HeaderText = "LastEditDateTime";
            this.lastEditDateTimeDataGridViewTextBoxColumn.Name = "lastEditDateTimeDataGridViewTextBoxColumn";
            this.lastEditDateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastEditDateTimeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.lastEditDateTimeDataGridViewTextBoxColumn.Visible = false;
            // 
            // BtnDelete
            // 
            this.BtnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnDelete.FocusCuesEnabled = false;
            this.BtnDelete.Image = global::WareHouse_Accounting.Properties.Resources.Delete;
            this.BtnDelete.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.BtnDelete.Location = new System.Drawing.Point(119, 6);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnDelete.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5);
            this.BtnDelete.Size = new System.Drawing.Size(91, 36);
            this.BtnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnDelete.TabIndex = 4;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // FrmShowRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnExit;
            this.ClientSize = new System.Drawing.Size(713, 316);
            this.ControlBox = false;
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmShowRoles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmShowRoles_Load);
            this.panelEx1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvRolesShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpShowRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsShowRoles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.ButtonX BtnExit;
        private DevComponents.DotNetBar.ButtonX BtnEdit;
        private DevComponents.DotNetBar.ButtonX BtnNew;
        private System.Windows.Forms.DataGridView DgvRolesShow;
        private System.Windows.Forms.ErrorProvider EpShowRoles;
        private System.Windows.Forms.BindingSource BsShowRoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleNameDataGridViewTextBoxColumn;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn depotPermissionDataGridViewTextBoxColumn;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn bankPermissionDataGridViewTextBoxColumn;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn personPermissionDataGridViewTextBoxColumn;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn factorPermissionDataGridViewTextBoxColumn;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn settingPermissionDataGridViewTextBoxColumn;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn userPermissionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastEditDateTimeDataGridViewTextBoxColumn;
        private DevComponents.DotNetBar.ButtonX BtnDelete;
    }
}