namespace WareHouse_Accounting
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.GpMain = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.SuspendLayout();
            // 
            // GpMain
            // 
            this.GpMain.CanvasColor = System.Drawing.SystemColors.Control;
            this.GpMain.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.GpMain.DisabledBackColor = System.Drawing.Color.Empty;
            this.GpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GpMain.Location = new System.Drawing.Point(0, 0);
            this.GpMain.Name = "GpMain";
            this.GpMain.Size = new System.Drawing.Size(711, 482);
            // 
            // 
            // 
            this.GpMain.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.GpMain.Style.BackColorGradientAngle = 90;
            this.GpMain.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.GpMain.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GpMain.Style.BorderBottomWidth = 1;
            this.GpMain.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.GpMain.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GpMain.Style.BorderLeftWidth = 1;
            this.GpMain.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GpMain.Style.BorderRightWidth = 1;
            this.GpMain.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GpMain.Style.BorderTopWidth = 1;
            this.GpMain.Style.CornerDiameter = 4;
            this.GpMain.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.GpMain.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.GpMain.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.GpMain.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.GpMain.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.GpMain.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.GpMain.TabIndex = 0;
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Black;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 482);
            this.Controls.Add(this.GpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel GpMain;
        private DevComponents.DotNetBar.StyleManager styleManager1;
    }
}

