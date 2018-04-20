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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.Welcome_Tab = new System.Windows.Forms.TabPage();
            this.welcome1 = new Cheat_Engine_Tools.Forms.Welcome();
            this.Converters_Tab = new System.Windows.Forms.TabPage();
            this.byteConverter_UC1 = new Cheat_Engine_Tools.ByteConverter_UC();
            this.SWFDumper_Tab = new System.Windows.Forms.TabPage();
            this.swfDumper1 = new Cheat_Engine_Tools.Forms.SWFDumper();
            this.FreeHacks_Tab = new System.Windows.Forms.TabPage();
            this.freeHacks1 = new Cheat_Engine_Tools.Forms.FreeHacks();
            this.CEDecompiler_Tab = new System.Windows.Forms.TabPage();
            this.ceDecompiler1 = new Cheat_Engine_Tools.Forms.CEDecompiler();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.StyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroTabControl1.SuspendLayout();
            this.Welcome_Tab.SuspendLayout();
            this.Converters_Tab.SuspendLayout();
            this.SWFDumper_Tab.SuspendLayout();
            this.FreeHacks_Tab.SuspendLayout();
            this.CEDecompiler_Tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.Welcome_Tab);
            this.metroTabControl1.Controls.Add(this.Converters_Tab);
            this.metroTabControl1.Controls.Add(this.SWFDumper_Tab);
            this.metroTabControl1.Controls.Add(this.FreeHacks_Tab);
            this.metroTabControl1.Controls.Add(this.CEDecompiler_Tab);
            this.metroTabControl1.Controls.Add(this.tabPage4);
            this.metroTabControl1.Controls.Add(this.tabPage5);
            this.metroTabControl1.Controls.Add(this.tabPage6);
            this.metroTabControl1.Controls.Add(this.tabPage7);
            this.metroTabControl1.Controls.Add(this.tabPage8);
            this.metroTabControl1.Controls.Add(this.tabPage9);
            this.metroTabControl1.Controls.Add(this.tabPage10);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroTabControl1.Location = new System.Drawing.Point(5, 60);
            this.metroTabControl1.Multiline = true;
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.Padding = new System.Drawing.Point(0, 0);
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(650, 338);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.TabStop = false;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.SelectedIndexChanged += new System.EventHandler(this.MetroTabControl1_SelectedIndexChanged);
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
            this.Converters_Tab.Location = new System.Drawing.Point(4, 28);
            this.Converters_Tab.Name = "Converters_Tab";
            this.Converters_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.Converters_Tab.Size = new System.Drawing.Size(642, 306);
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
            this.byteConverter_UC1.Size = new System.Drawing.Size(636, 300);
            this.byteConverter_UC1.TabIndex = 0;
            // 
            // SWFDumper_Tab
            // 
            this.SWFDumper_Tab.Controls.Add(this.swfDumper1);
            this.SWFDumper_Tab.Location = new System.Drawing.Point(4, 28);
            this.SWFDumper_Tab.Name = "SWFDumper_Tab";
            this.SWFDumper_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.SWFDumper_Tab.Size = new System.Drawing.Size(642, 306);
            this.SWFDumper_Tab.TabIndex = 2;
            this.SWFDumper_Tab.Text = "SWF Dumper";
            this.SWFDumper_Tab.UseVisualStyleBackColor = true;
            // 
            // swfDumper1
            // 
            this.swfDumper1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.swfDumper1.Location = new System.Drawing.Point(3, 3);
            this.swfDumper1.Name = "swfDumper1";
            this.swfDumper1.Size = new System.Drawing.Size(636, 300);
            this.swfDumper1.TabIndex = 0;
            // 
            // FreeHacks_Tab
            // 
            this.FreeHacks_Tab.Controls.Add(this.freeHacks1);
            this.FreeHacks_Tab.Location = new System.Drawing.Point(4, 28);
            this.FreeHacks_Tab.Name = "FreeHacks_Tab";
            this.FreeHacks_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.FreeHacks_Tab.Size = new System.Drawing.Size(642, 306);
            this.FreeHacks_Tab.TabIndex = 3;
            this.FreeHacks_Tab.Text = "Free Hacks";
            this.FreeHacks_Tab.UseVisualStyleBackColor = true;
            // 
            // freeHacks1
            // 
            this.freeHacks1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.freeHacks1.Location = new System.Drawing.Point(3, 3);
            this.freeHacks1.Name = "freeHacks1";
            this.freeHacks1.Size = new System.Drawing.Size(636, 300);
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
            this.ceDecompiler1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ceDecompiler1.Location = new System.Drawing.Point(3, 3);
            this.ceDecompiler1.Name = "ceDecompiler1";
            this.ceDecompiler1.Size = new System.Drawing.Size(636, 276);
            this.ceDecompiler1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(642, 306);
            this.tabPage4.TabIndex = 5;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 28);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(642, 306);
            this.tabPage5.TabIndex = 6;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 28);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(642, 306);
            this.tabPage6.TabIndex = 7;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 52);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(642, 282);
            this.tabPage7.TabIndex = 8;
            this.tabPage7.Text = "tabPage7";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(4, 52);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(642, 282);
            this.tabPage8.TabIndex = 9;
            this.tabPage8.Text = "tabPage8";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabPage9
            // 
            this.tabPage9.Location = new System.Drawing.Point(4, 52);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(642, 282);
            this.tabPage9.TabIndex = 10;
            this.tabPage9.Text = "tabPage9";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // tabPage10
            // 
            this.tabPage10.Location = new System.Drawing.Point(4, 52);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(642, 282);
            this.tabPage10.TabIndex = 11;
            this.tabPage10.Text = "tabPage10";
            this.tabPage10.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.metroTabControl1);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Padding = new System.Windows.Forms.Padding(5, 60, 5, 5);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Cheat Engine Tools";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.metroTabControl1.ResumeLayout(false);
            this.Welcome_Tab.ResumeLayout(false);
            this.Converters_Tab.ResumeLayout(false);
            this.SWFDumper_Tab.ResumeLayout(false);
            this.FreeHacks_Tab.ResumeLayout(false);
            this.CEDecompiler_Tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StyleManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage Converters_Tab;
        private System.Windows.Forms.TabPage Welcome_Tab;
        private new MetroFramework.Components.MetroStyleManager StyleManager;
        private ByteConverter_UC byteConverter_UC1;
        private System.Windows.Forms.TabPage SWFDumper_Tab;
        private System.Windows.Forms.TabPage FreeHacks_Tab;
        private System.Windows.Forms.TabPage CEDecompiler_Tab;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TabPage tabPage10;
        private Forms.SWFDumper swfDumper1;
        private Forms.Welcome welcome1;
        private Forms.FreeHacks freeHacks1;
        private Forms.CEDecompiler ceDecompiler1;
    }
}
