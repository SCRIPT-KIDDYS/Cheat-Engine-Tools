namespace Cheat_Engine_Tools.Forms
{
	partial class CEVersion_UC
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
            this.Open64_Button = new MetroFramework.Controls.MetroButton();
            this.Open32_Button = new MetroFramework.Controls.MetroButton();
            this.CEVersion_Label = new MetroFramework.Controls.MetroLabel();
            this.CEVersion_ComboBox = new MetroFramework.Controls.MetroComboBox();
            this.InstallPlugins_Button = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // Open64_Button
            // 
            this.Open64_Button.Location = new System.Drawing.Point(99, 82);
            this.Open64_Button.Margin = new System.Windows.Forms.Padding(10);
            this.Open64_Button.Name = "Open64_Button";
            this.Open64_Button.Size = new System.Drawing.Size(75, 23);
            this.Open64_Button.TabIndex = 11;
            this.Open64_Button.TabStop = false;
            this.Open64_Button.Text = "64";
            this.Open64_Button.UseSelectable = true;
            this.Open64_Button.UseVisualStyleBackColor = true;
            this.Open64_Button.Click += new System.EventHandler(this.OpenCE);
            // 
            // Open32_Button
            // 
            this.Open32_Button.Location = new System.Drawing.Point(13, 82);
            this.Open32_Button.Margin = new System.Windows.Forms.Padding(10);
            this.Open32_Button.Name = "Open32_Button";
            this.Open32_Button.Size = new System.Drawing.Size(75, 23);
            this.Open32_Button.TabIndex = 11;
            this.Open32_Button.TabStop = false;
            this.Open32_Button.Text = "32";
            this.Open32_Button.UseSelectable = true;
            this.Open32_Button.UseVisualStyleBackColor = true;
            this.Open32_Button.Click += new System.EventHandler(this.OpenCE);
            // 
            // CEVersion_Label
            // 
            this.CEVersion_Label.Location = new System.Drawing.Point(13, 49);
            this.CEVersion_Label.Name = "CEVersion_Label";
            this.CEVersion_Label.Size = new System.Drawing.Size(627, 23);
            this.CEVersion_Label.TabIndex = 10;
            this.CEVersion_Label.Text = "Select Installed Version Of CE";
            this.CEVersion_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CEVersion_ComboBox
            // 
            this.CEVersion_ComboBox.FormattingEnabled = true;
            this.CEVersion_ComboBox.ItemHeight = 23;
            this.CEVersion_ComboBox.Location = new System.Drawing.Point(13, 10);
            this.CEVersion_ComboBox.Margin = new System.Windows.Forms.Padding(10);
            this.CEVersion_ComboBox.Name = "CEVersion_ComboBox";
            this.CEVersion_ComboBox.Size = new System.Drawing.Size(627, 29);
            this.CEVersion_ComboBox.TabIndex = 9;
            this.CEVersion_ComboBox.TabStop = false;
            this.CEVersion_ComboBox.UseSelectable = true;
            this.CEVersion_ComboBox.SelectedIndexChanged += new System.EventHandler(this.CEVersion_ComboBox_SelectedIndexChanged);
            // 
            // InstallPlugins_Button
            // 
            this.InstallPlugins_Button.Location = new System.Drawing.Point(460, 82);
            this.InstallPlugins_Button.Margin = new System.Windows.Forms.Padding(10);
            this.InstallPlugins_Button.Name = "InstallPlugins_Button";
            this.InstallPlugins_Button.Size = new System.Drawing.Size(180, 23);
            this.InstallPlugins_Button.TabIndex = 11;
            this.InstallPlugins_Button.TabStop = false;
            this.InstallPlugins_Button.Text = "Install Plugins (Coming Soon)";
            this.InstallPlugins_Button.UseSelectable = true;
            this.InstallPlugins_Button.UseVisualStyleBackColor = true;
            // 
            // CEVersion_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.InstallPlugins_Button);
            this.Controls.Add(this.Open64_Button);
            this.Controls.Add(this.Open32_Button);
            this.Controls.Add(this.CEVersion_Label);
            this.Controls.Add(this.CEVersion_ComboBox);
            this.Name = "CEVersion_UC";
            this.Size = new System.Drawing.Size(650, 315);
            this.Load += new System.EventHandler(this.CEVersion_UC_Load);
            this.ResumeLayout(false);

		}

		#endregion
		private MetroFramework.Controls.MetroComboBox CEVersion_ComboBox;
		private MetroFramework.Controls.MetroLabel CEVersion_Label;
		private MetroFramework.Controls.MetroButton Open32_Button;
		private MetroFramework.Controls.MetroButton Open64_Button;
		private MetroFramework.Controls.MetroButton InstallPlugins_Button;
	}
}
