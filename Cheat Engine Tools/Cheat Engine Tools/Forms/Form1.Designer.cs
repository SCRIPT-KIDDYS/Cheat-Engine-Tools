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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.Welcome_Tab = new System.Windows.Forms.TabPage();
            this.Converters_Tab = new System.Windows.Forms.TabPage();
            this.byteConverter_UC1 = new Cheat_Engine_Tools.ByteConverter_UC();
            this.StyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.metroTabControl1.SuspendLayout();
            this.Converters_Tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.Welcome_Tab);
            this.metroTabControl1.Controls.Add(this.Converters_Tab);
            this.metroTabControl1.Controls.Add(this.tabPage1);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(5, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.Padding = new System.Drawing.Point(0, 0);
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(600, 285);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.TabStop = false;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.SelectedIndexChanged += new System.EventHandler(this.MetroTabControl1_SelectedIndexChanged);
            // 
            // Welcome_Tab
            // 
            this.Welcome_Tab.Location = new System.Drawing.Point(4, 28);
            this.Welcome_Tab.Name = "Welcome_Tab";
            this.Welcome_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.Welcome_Tab.Size = new System.Drawing.Size(592, 253);
            this.Welcome_Tab.TabIndex = 1;
            this.Welcome_Tab.Text = "Welcome";
            this.Welcome_Tab.UseVisualStyleBackColor = true;
            // 
            // Converters_Tab
            // 
            this.Converters_Tab.Controls.Add(this.byteConverter_UC1);
            this.Converters_Tab.Location = new System.Drawing.Point(4, 28);
            this.Converters_Tab.Name = "Converters_Tab";
            this.Converters_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.Converters_Tab.Size = new System.Drawing.Size(592, 253);
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
            this.byteConverter_UC1.Size = new System.Drawing.Size(586, 247);
            this.byteConverter_UC1.TabIndex = 0;
            // 
            // StyleManager
            // 
            this.StyleManager.Owner = this;
            this.StyleManager.Style = MetroFramework.MetroColorStyle.Teal;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(592, 253);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 350);
            this.Controls.Add(this.metroTabControl1);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Padding = new System.Windows.Forms.Padding(5, 60, 5, 5);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Cheat Engine Tools";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.metroTabControl1.ResumeLayout(false);
            this.Converters_Tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StyleManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage Converters_Tab;
        private System.Windows.Forms.TabPage Welcome_Tab;
        private new MetroFramework.Components.MetroStyleManager StyleManager;
        private ByteConverter_UC byteConverter_UC1;
        private System.Windows.Forms.TabPage tabPage1;
    }
}
