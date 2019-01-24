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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.MainMenu_metroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.Welcome_Tab = new System.Windows.Forms.TabPage();
            this.welcome1 = new Cheat_Engine_Tools.Forms.Welcome_UC();
            this.Converters_Tab = new System.Windows.Forms.TabPage();
            this.byteConverter_UC1 = new Cheat_Engine_Tools.ByteConverter_UC();
            this.SWFDumper_Tab = new System.Windows.Forms.TabPage();
            this.swfDumper1 = new Cheat_Engine_Tools.Forms.SWFDumper_UC();
            this.FreeHacks_Tab = new System.Windows.Forms.TabPage();
            this.freeHacks1 = new Cheat_Engine_Tools.Forms.FreeHacks_UC();
            this.CEDecompiler_Tab = new System.Windows.Forms.TabPage();
            this.ceDecompiler1 = new Cheat_Engine_Tools.Forms.CEDecompiler_UC();
            this.DLLInjector_Tab = new System.Windows.Forms.TabPage();
            this.dllInjector_UC1 = new Cheat_Engine_Tools.Forms.DLLInjector_UC();
            this.CEVersion_Tab = new System.Windows.Forms.TabPage();
            this.ceVersion_UC1 = new Cheat_Engine_Tools.Forms.CEVersion_UC();
            this.Links_Tab = new System.Windows.Forms.TabPage();
            this.links_UC1 = new Cheat_Engine_Tools.Forms.Links_UC();
            this.AOBPatternFinder_Tab = new System.Windows.Forms.TabPage();
            this.aobPatternFinder_UC1 = new Cheat_Engine_Tools.Forms.AOBPatternFinder_UC();
            this.StyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.MainMenu_metroTabControl.SuspendLayout();
            this.Welcome_Tab.SuspendLayout();
            this.Converters_Tab.SuspendLayout();
            this.SWFDumper_Tab.SuspendLayout();
            this.FreeHacks_Tab.SuspendLayout();
            this.CEDecompiler_Tab.SuspendLayout();
            this.DLLInjector_Tab.SuspendLayout();
            this.CEVersion_Tab.SuspendLayout();
            this.Links_Tab.SuspendLayout();
            this.AOBPatternFinder_Tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu_metroTabControl
            // 
            this.MainMenu_metroTabControl.Controls.Add(this.Welcome_Tab);
            this.MainMenu_metroTabControl.Controls.Add(this.Converters_Tab);
            this.MainMenu_metroTabControl.Controls.Add(this.SWFDumper_Tab);
            this.MainMenu_metroTabControl.Controls.Add(this.FreeHacks_Tab);
            this.MainMenu_metroTabControl.Controls.Add(this.CEDecompiler_Tab);
            this.MainMenu_metroTabControl.Controls.Add(this.DLLInjector_Tab);
            this.MainMenu_metroTabControl.Controls.Add(this.CEVersion_Tab);
            this.MainMenu_metroTabControl.Controls.Add(this.Links_Tab);
            this.MainMenu_metroTabControl.Controls.Add(this.AOBPatternFinder_Tab);
            this.MainMenu_metroTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainMenu_metroTabControl.Location = new System.Drawing.Point(5, 60);
            this.MainMenu_metroTabControl.Multiline = true;
            this.MainMenu_metroTabControl.Name = "MainMenu_metroTabControl";
            this.MainMenu_metroTabControl.Padding = new System.Drawing.Point(0, 0);
            this.MainMenu_metroTabControl.SelectedIndex = 0;
            this.MainMenu_metroTabControl.Size = new System.Drawing.Size(650, 338);
            this.MainMenu_metroTabControl.TabIndex = 0;
            this.MainMenu_metroTabControl.TabStop = false;
            this.MainMenu_metroTabControl.UseSelectable = true;
            // 
            // Welcome_Tab
            // 
            this.Welcome_Tab.Controls.Add(this.welcome1);
            this.Welcome_Tab.Location = new System.Drawing.Point(4, 52);
            this.Welcome_Tab.Name = "Welcome_Tab";
            this.Welcome_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.Welcome_Tab.Size = new System.Drawing.Size(642, 282);
            this.Welcome_Tab.TabIndex = 1;
            this.Welcome_Tab.Text = "Welcome";
            this.Welcome_Tab.UseVisualStyleBackColor = true;
            // 
            // welcome1
            // 
            this.welcome1.BackColor = System.Drawing.Color.Transparent;
            this.welcome1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("welcome1.BackgroundImage")));
            this.welcome1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.welcome1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcome1.Location = new System.Drawing.Point(3, 3);
            this.welcome1.Name = "welcome1";
            this.welcome1.Size = new System.Drawing.Size(636, 276);
            this.welcome1.TabIndex = 0;
            // 
            // Converters_Tab
            // 
            this.Converters_Tab.Controls.Add(this.byteConverter_UC1);
            this.Converters_Tab.Location = new System.Drawing.Point(4, 52);
            this.Converters_Tab.Name = "Converters_Tab";
            this.Converters_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.Converters_Tab.Size = new System.Drawing.Size(642, 282);
            this.Converters_Tab.TabIndex = 0;
            this.Converters_Tab.Text = "Converters";
            this.Converters_Tab.UseVisualStyleBackColor = true;
            // 
            // byteConverter_UC1
            // 
            this.byteConverter_UC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.byteConverter_UC1.Location = new System.Drawing.Point(3, 3);
            this.byteConverter_UC1.Name = "byteConverter_UC1";
            this.byteConverter_UC1.Padding = new System.Windows.Forms.Padding(5);
            this.byteConverter_UC1.Size = new System.Drawing.Size(636, 276);
            this.byteConverter_UC1.TabIndex = 0;
            // 
            // SWFDumper_Tab
            // 
            this.SWFDumper_Tab.Controls.Add(this.swfDumper1);
            this.SWFDumper_Tab.Location = new System.Drawing.Point(4, 52);
            this.SWFDumper_Tab.Name = "SWFDumper_Tab";
            this.SWFDumper_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.SWFDumper_Tab.Size = new System.Drawing.Size(642, 282);
            this.SWFDumper_Tab.TabIndex = 2;
            this.SWFDumper_Tab.Text = "SWF Dumper";
            this.SWFDumper_Tab.UseVisualStyleBackColor = true;
            // 
            // swfDumper1
            // 
            this.swfDumper1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.swfDumper1.Location = new System.Drawing.Point(3, 3);
            this.swfDumper1.Name = "swfDumper1";
            this.swfDumper1.Size = new System.Drawing.Size(636, 276);
            this.swfDumper1.TabIndex = 0;
            // 
            // FreeHacks_Tab
            // 
            this.FreeHacks_Tab.Controls.Add(this.freeHacks1);
            this.FreeHacks_Tab.Location = new System.Drawing.Point(4, 52);
            this.FreeHacks_Tab.Name = "FreeHacks_Tab";
            this.FreeHacks_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.FreeHacks_Tab.Size = new System.Drawing.Size(642, 282);
            this.FreeHacks_Tab.TabIndex = 3;
            this.FreeHacks_Tab.Text = "Free Hacks";
            this.FreeHacks_Tab.UseVisualStyleBackColor = true;
            // 
            // freeHacks1
            // 
            this.freeHacks1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.freeHacks1.Location = new System.Drawing.Point(3, 3);
            this.freeHacks1.Name = "freeHacks1";
            this.freeHacks1.Size = new System.Drawing.Size(636, 276);
            this.freeHacks1.TabIndex = 0;
            // 
            // CEDecompiler_Tab
            // 
            this.CEDecompiler_Tab.Controls.Add(this.ceDecompiler1);
            this.CEDecompiler_Tab.Location = new System.Drawing.Point(4, 52);
            this.CEDecompiler_Tab.Name = "CEDecompiler_Tab";
            this.CEDecompiler_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.CEDecompiler_Tab.Size = new System.Drawing.Size(642, 282);
            this.CEDecompiler_Tab.TabIndex = 4;
            this.CEDecompiler_Tab.Text = "CE Decompiler";
            this.CEDecompiler_Tab.UseVisualStyleBackColor = true;
            // 
            // ceDecompiler1
            // 
            this.ceDecompiler1.AllowDrop = true;
            this.ceDecompiler1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ceDecompiler1.BackgroundImage")));
            this.ceDecompiler1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ceDecompiler1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ceDecompiler1.Location = new System.Drawing.Point(3, 3);
            this.ceDecompiler1.Name = "ceDecompiler1";
            this.ceDecompiler1.Size = new System.Drawing.Size(636, 276);
            this.ceDecompiler1.TabIndex = 0;
            // 
            // DLLInjector_Tab
            // 
            this.DLLInjector_Tab.Controls.Add(this.dllInjector_UC1);
            this.DLLInjector_Tab.Location = new System.Drawing.Point(4, 52);
            this.DLLInjector_Tab.Name = "DLLInjector_Tab";
            this.DLLInjector_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.DLLInjector_Tab.Size = new System.Drawing.Size(642, 282);
            this.DLLInjector_Tab.TabIndex = 6;
            this.DLLInjector_Tab.Text = "DLL Injector";
            this.DLLInjector_Tab.UseVisualStyleBackColor = true;
            // 
            // dllInjector_UC1
            // 
            this.dllInjector_UC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dllInjector_UC1.Location = new System.Drawing.Point(3, 3);
            this.dllInjector_UC1.Name = "dllInjector_UC1";
            this.dllInjector_UC1.Size = new System.Drawing.Size(636, 276);
            this.dllInjector_UC1.TabIndex = 0;
            // 
            // CEVersion_Tab
            // 
            this.CEVersion_Tab.Controls.Add(this.ceVersion_UC1);
            this.CEVersion_Tab.Location = new System.Drawing.Point(4, 52);
            this.CEVersion_Tab.Name = "CEVersion_Tab";
            this.CEVersion_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.CEVersion_Tab.Size = new System.Drawing.Size(642, 282);
            this.CEVersion_Tab.TabIndex = 7;
            this.CEVersion_Tab.Text = "CE Version";
            this.CEVersion_Tab.UseVisualStyleBackColor = true;
            // 
            // ceVersion_UC1
            // 
            this.ceVersion_UC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ceVersion_UC1.Location = new System.Drawing.Point(3, 3);
            this.ceVersion_UC1.Name = "ceVersion_UC1";
            this.ceVersion_UC1.Size = new System.Drawing.Size(636, 276);
            this.ceVersion_UC1.TabIndex = 0;
            // 
            // Links_Tab
            // 
            this.Links_Tab.Controls.Add(this.links_UC1);
            this.Links_Tab.Location = new System.Drawing.Point(4, 52);
            this.Links_Tab.Name = "Links_Tab";
            this.Links_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.Links_Tab.Size = new System.Drawing.Size(642, 282);
            this.Links_Tab.TabIndex = 5;
            this.Links_Tab.Text = "Links";
            this.Links_Tab.UseVisualStyleBackColor = true;
            // 
            // links_UC1
            // 
            this.links_UC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.links_UC1.Location = new System.Drawing.Point(3, 3);
            this.links_UC1.Name = "links_UC1";
            this.links_UC1.Size = new System.Drawing.Size(636, 276);
            this.links_UC1.TabIndex = 0;
            // 
            // AOBPatternFinder_Tab
            // 
            this.AOBPatternFinder_Tab.BackColor = System.Drawing.Color.Transparent;
            this.AOBPatternFinder_Tab.Controls.Add(this.aobPatternFinder_UC1);
            this.AOBPatternFinder_Tab.Location = new System.Drawing.Point(4, 52);
            this.AOBPatternFinder_Tab.Name = "AOBPatternFinder_Tab";
            this.AOBPatternFinder_Tab.Size = new System.Drawing.Size(642, 282);
            this.AOBPatternFinder_Tab.TabIndex = 8;
            this.AOBPatternFinder_Tab.Text = "AOB Pattern Finder";
            // 
            // aobPatternFinder_UC1
            // 
            this.aobPatternFinder_UC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aobPatternFinder_UC1.Location = new System.Drawing.Point(0, 0);
            this.aobPatternFinder_UC1.Name = "aobPatternFinder_UC1";
            this.aobPatternFinder_UC1.Size = new System.Drawing.Size(642, 282);
            this.aobPatternFinder_UC1.TabIndex = 0;
            // 
            // StyleManager
            // 
            this.StyleManager.Owner = this;
            this.StyleManager.Style = MetroFramework.MetroColorStyle.Teal;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 403);
            this.Controls.Add(this.MainMenu_metroTabControl);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Padding = new System.Windows.Forms.Padding(5, 60, 5, 5);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Cheat Engine Tools";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.MainMenu_metroTabControl.ResumeLayout(false);
            this.Welcome_Tab.ResumeLayout(false);
            this.Converters_Tab.ResumeLayout(false);
            this.SWFDumper_Tab.ResumeLayout(false);
            this.FreeHacks_Tab.ResumeLayout(false);
            this.CEDecompiler_Tab.ResumeLayout(false);
            this.DLLInjector_Tab.ResumeLayout(false);
            this.CEVersion_Tab.ResumeLayout(false);
            this.Links_Tab.ResumeLayout(false);
            this.AOBPatternFinder_Tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StyleManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl MainMenu_metroTabControl;
        private System.Windows.Forms.TabPage Converters_Tab;
        private System.Windows.Forms.TabPage Welcome_Tab;
        private new MetroFramework.Components.MetroStyleManager StyleManager;
        private ByteConverter_UC byteConverter_UC1;
        private System.Windows.Forms.TabPage SWFDumper_Tab;
        private System.Windows.Forms.TabPage FreeHacks_Tab;
        private System.Windows.Forms.TabPage CEDecompiler_Tab;
        private System.Windows.Forms.TabPage Links_Tab;
        private System.Windows.Forms.TabPage DLLInjector_Tab;
        private Forms.SWFDumper_UC swfDumper1;
        private Forms.Welcome_UC welcome1;
        private Forms.FreeHacks_UC freeHacks1;
        private Forms.CEDecompiler_UC ceDecompiler1;
        private Forms.Links_UC links_UC1;
        private Forms.DLLInjector_UC dllInjector_UC1;
		private System.Windows.Forms.TabPage CEVersion_Tab;
		private Forms.CEVersion_UC ceVersion_UC1;
		private System.Windows.Forms.TabPage AOBPatternFinder_Tab;
		private Forms.AOBPatternFinder_UC aobPatternFinder_UC1;
	}
}
