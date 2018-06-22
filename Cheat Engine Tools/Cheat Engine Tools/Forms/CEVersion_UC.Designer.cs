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
			this.Open64_metroButton = new MetroFramework.Controls.MetroButton();
			this.Open32_metroButton = new MetroFramework.Controls.MetroButton();
			this.CEVersion_metroLabel = new MetroFramework.Controls.MetroLabel();
			this.CEVersion_metroComboBox = new MetroFramework.Controls.MetroComboBox();
			this.metroButton1 = new MetroFramework.Controls.MetroButton();
			this.SuspendLayout();
			// 
			// Open64_metroButton
			// 
			this.Open64_metroButton.Location = new System.Drawing.Point(99, 82);
			this.Open64_metroButton.Margin = new System.Windows.Forms.Padding(10);
			this.Open64_metroButton.Name = "Open64_metroButton";
			this.Open64_metroButton.Size = new System.Drawing.Size(75, 23);
			this.Open64_metroButton.TabIndex = 11;
			this.Open64_metroButton.Text = "64";
			this.Open64_metroButton.UseSelectable = true;
			this.Open64_metroButton.UseVisualStyleBackColor = true;
			this.Open64_metroButton.Click += new System.EventHandler(this.OpenCE);
			// 
			// Open32_metroButton
			// 
			this.Open32_metroButton.Location = new System.Drawing.Point(13, 82);
			this.Open32_metroButton.Margin = new System.Windows.Forms.Padding(10);
			this.Open32_metroButton.Name = "Open32_metroButton";
			this.Open32_metroButton.Size = new System.Drawing.Size(75, 23);
			this.Open32_metroButton.TabIndex = 11;
			this.Open32_metroButton.Text = "32";
			this.Open32_metroButton.UseSelectable = true;
			this.Open32_metroButton.UseVisualStyleBackColor = true;
			this.Open32_metroButton.Click += new System.EventHandler(this.OpenCE);
			// 
			// CEVersion_metroLabel
			// 
			this.CEVersion_metroLabel.Location = new System.Drawing.Point(10, 49);
			this.CEVersion_metroLabel.Name = "CEVersion_metroLabel";
			this.CEVersion_metroLabel.Size = new System.Drawing.Size(616, 23);
			this.CEVersion_metroLabel.TabIndex = 10;
			this.CEVersion_metroLabel.Text = "Select Installed Version Of CE";
			this.CEVersion_metroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// CEVersion_metroComboBox
			// 
			this.CEVersion_metroComboBox.FormattingEnabled = true;
			this.CEVersion_metroComboBox.ItemHeight = 23;
			this.CEVersion_metroComboBox.Location = new System.Drawing.Point(13, 10);
			this.CEVersion_metroComboBox.Margin = new System.Windows.Forms.Padding(10);
			this.CEVersion_metroComboBox.Name = "CEVersion_metroComboBox";
			this.CEVersion_metroComboBox.Size = new System.Drawing.Size(613, 29);
			this.CEVersion_metroComboBox.TabIndex = 9;
			this.CEVersion_metroComboBox.UseSelectable = true;
			this.CEVersion_metroComboBox.SelectedIndexChanged += new System.EventHandler(this.CEVersion_metroComboBox_SelectedIndexChanged);
			// 
			// metroButton1
			// 
			this.metroButton1.Location = new System.Drawing.Point(446, 82);
			this.metroButton1.Margin = new System.Windows.Forms.Padding(10);
			this.metroButton1.Name = "metroButton1";
			this.metroButton1.Size = new System.Drawing.Size(180, 23);
			this.metroButton1.TabIndex = 11;
			this.metroButton1.Text = "Install Plugins (Coming Soon)";
			this.metroButton1.UseSelectable = true;
			this.metroButton1.UseVisualStyleBackColor = true;
			// 
			// CEVersion_UC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.metroButton1);
			this.Controls.Add(this.Open64_metroButton);
			this.Controls.Add(this.Open32_metroButton);
			this.Controls.Add(this.CEVersion_metroLabel);
			this.Controls.Add(this.CEVersion_metroComboBox);
			this.Name = "CEVersion_UC";
			this.Size = new System.Drawing.Size(636, 276);
			this.Load += new System.EventHandler(this.CEVersion_UC_Load);
			this.ResumeLayout(false);

		}

		#endregion
		private MetroFramework.Controls.MetroComboBox CEVersion_metroComboBox;
		private MetroFramework.Controls.MetroLabel CEVersion_metroLabel;
		private MetroFramework.Controls.MetroButton Open32_metroButton;
		private MetroFramework.Controls.MetroButton Open64_metroButton;
		private MetroFramework.Controls.MetroButton metroButton1;
	}
}
