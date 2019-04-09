namespace Cheat_Engine_Tools
{
    partial class MainWindow
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
            this.StyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.MainWindowMenuStrip = new System.Windows.Forms.MenuStrip();
            this.welcomeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheatEngineToolsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decompilerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aOBPatternFinderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.othersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dLLInjectorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warCommanderStringDecoderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linksMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainWindowPanel = new MetroFramework.Controls.MetroPanel();
            ((System.ComponentModel.ISupportInitialize)(this.StyleManager)).BeginInit();
            this.MainWindowMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // StyleManager
            // 
            this.StyleManager.Owner = this;
            this.StyleManager.Style = MetroFramework.MetroColorStyle.Teal;
            // 
            // MainWindowMenuStrip
            // 
            this.MainWindowMenuStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.MainWindowMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.welcomeMenuItem,
            this.cheatEngineToolsMenuItem,
            this.othersMenuItem,
            this.helpMenuItem});
            this.MainWindowMenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.MainWindowMenuStrip.Location = new System.Drawing.Point(5, 60);
            this.MainWindowMenuStrip.Name = "MainWindowMenuStrip";
            this.MainWindowMenuStrip.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.MainWindowMenuStrip.Size = new System.Drawing.Size(650, 23);
            this.MainWindowMenuStrip.TabIndex = 1;
            // 
            // welcomeMenuItem
            // 
            this.welcomeMenuItem.Name = "welcomeMenuItem";
            this.welcomeMenuItem.Size = new System.Drawing.Size(69, 19);
            this.welcomeMenuItem.Text = "Welcome";
            this.welcomeMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // cheatEngineToolsMenuItem
            // 
            this.cheatEngineToolsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convertersMenuItem,
            this.decompilerMenuItem,
            this.versionMenuItem,
            this.aOBPatternFinderToolStripMenuItem});
            this.cheatEngineToolsMenuItem.Name = "cheatEngineToolsMenuItem";
            this.cheatEngineToolsMenuItem.Size = new System.Drawing.Size(121, 19);
            this.cheatEngineToolsMenuItem.Text = "Cheat Engine Tools";
            // 
            // convertersMenuItem
            // 
            this.convertersMenuItem.Name = "convertersMenuItem";
            this.convertersMenuItem.Size = new System.Drawing.Size(175, 22);
            this.convertersMenuItem.Text = "Converters";
            this.convertersMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // decompilerMenuItem
            // 
            this.decompilerMenuItem.Name = "decompilerMenuItem";
            this.decompilerMenuItem.Size = new System.Drawing.Size(175, 22);
            this.decompilerMenuItem.Text = "Decompiler";
            this.decompilerMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // versionMenuItem
            // 
            this.versionMenuItem.Name = "versionMenuItem";
            this.versionMenuItem.Size = new System.Drawing.Size(175, 22);
            this.versionMenuItem.Text = "CE Version";
            this.versionMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // aOBPatternFinderToolStripMenuItem
            // 
            this.aOBPatternFinderToolStripMenuItem.Name = "aOBPatternFinderToolStripMenuItem";
            this.aOBPatternFinderToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.aOBPatternFinderToolStripMenuItem.Text = "AOB Pattern Finder";
            this.aOBPatternFinderToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // othersMenuItem
            // 
            this.othersMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dLLInjectorMenuItem,
            this.warCommanderStringDecoderMenuItem});
            this.othersMenuItem.Name = "othersMenuItem";
            this.othersMenuItem.Size = new System.Drawing.Size(54, 19);
            this.othersMenuItem.Text = "Others";
            // 
            // dLLInjectorMenuItem
            // 
            this.dLLInjectorMenuItem.Name = "dLLInjectorMenuItem";
            this.dLLInjectorMenuItem.Size = new System.Drawing.Size(243, 22);
            this.dLLInjectorMenuItem.Text = "DLL Injector";
            this.dLLInjectorMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // warCommanderStringDecoderMenuItem
            // 
            this.warCommanderStringDecoderMenuItem.Name = "warCommanderStringDecoderMenuItem";
            this.warCommanderStringDecoderMenuItem.Size = new System.Drawing.Size(243, 22);
            this.warCommanderStringDecoderMenuItem.Text = "WarCommander String Decoder";
            this.warCommanderStringDecoderMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linksMenuItem,
            this.aboutMenuItem});
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(44, 19);
            this.helpMenuItem.Text = "Help";
            // 
            // linksMenuItem
            // 
            this.linksMenuItem.Name = "linksMenuItem";
            this.linksMenuItem.Size = new System.Drawing.Size(107, 22);
            this.linksMenuItem.Text = "Links";
            this.linksMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutMenuItem.Text = "About";
            this.aboutMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // MainWindowPanel
            // 
            this.MainWindowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainWindowPanel.HorizontalScrollbarBarColor = true;
            this.MainWindowPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.MainWindowPanel.HorizontalScrollbarSize = 10;
            this.MainWindowPanel.Location = new System.Drawing.Point(5, 83);
            this.MainWindowPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainWindowPanel.Name = "MainWindowPanel";
            this.MainWindowPanel.Size = new System.Drawing.Size(650, 315);
            this.MainWindowPanel.TabIndex = 2;
            this.MainWindowPanel.VerticalScrollbarBarColor = true;
            this.MainWindowPanel.VerticalScrollbarHighlightOnWheel = false;
            this.MainWindowPanel.VerticalScrollbarSize = 10;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 403);
            this.Controls.Add(this.MainWindowPanel);
            this.Controls.Add(this.MainWindowMenuStrip);
            this.MainMenuStrip = this.MainWindowMenuStrip;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Padding = new System.Windows.Forms.Padding(5, 60, 5, 5);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Cheat Engine Tools";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            ((System.ComponentModel.ISupportInitialize)(this.StyleManager)).EndInit();
            this.MainWindowMenuStrip.ResumeLayout(false);
            this.MainWindowMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private new MetroFramework.Components.MetroStyleManager StyleManager;
        private System.Windows.Forms.MenuStrip MainWindowMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem welcomeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheatEngineToolsMenuItem;
        private MetroFramework.Controls.MetroPanel MainWindowPanel;
        private System.Windows.Forms.ToolStripMenuItem convertersMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decompilerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionMenuItem;
        private System.Windows.Forms.ToolStripMenuItem othersMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dLLInjectorMenuItem;
        private System.Windows.Forms.ToolStripMenuItem warCommanderStringDecoderMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aOBPatternFinderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linksMenuItem;
    }
}
