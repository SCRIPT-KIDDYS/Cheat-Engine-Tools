namespace Cheat_Engine_Tools.Forms
{
	partial class AOBPatternFinder_UC
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
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.FormatAOBs_metroButton = new MetroFramework.Controls.MetroButton();
			this.AOB5Length_metroLabel = new MetroFramework.Controls.MetroLabel();
			this.AOB4Length_metroLabel = new MetroFramework.Controls.MetroLabel();
			this.AOB3Length_metroLabel = new MetroFramework.Controls.MetroLabel();
			this.AOB2Length_metroLabel = new MetroFramework.Controls.MetroLabel();
			this.AOB1Length_metroLabel = new MetroFramework.Controls.MetroLabel();
			this.Compare_metroButton = new MetroFramework.Controls.MetroButton();
			this.AOBResults_metroTextBox = new MetroFramework.Controls.MetroTextBox();
			this.AOB5_metroTextBox = new MetroFramework.Controls.MetroTextBox();
			this.AOB4_metroTextBox = new MetroFramework.Controls.MetroTextBox();
			this.AOB3_metroTextBox = new MetroFramework.Controls.MetroTextBox();
			this.AOB2_metroTextBox = new MetroFramework.Controls.MetroTextBox();
			this.AOB1_metroTextBox = new MetroFramework.Controls.MetroTextBox();
			this.SuspendLayout();
			// 
			// metroLabel1
			// 
			this.metroLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.metroLabel1.ForeColor = System.Drawing.Color.Maroon;
			this.metroLabel1.Location = new System.Drawing.Point(3, 252);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(628, 23);
			this.metroLabel1.TabIndex = 4;
			this.metroLabel1.Text = "*NOTE*   The First TextBox Byte Length Must Be >= To All Others";
			this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroLabel1.UseCustomForeColor = true;
			// 
			// FormatAOBs_metroButton
			// 
			this.FormatAOBs_metroButton.Location = new System.Drawing.Point(308, 190);
			this.FormatAOBs_metroButton.Name = "FormatAOBs_metroButton";
			this.FormatAOBs_metroButton.Size = new System.Drawing.Size(101, 23);
			this.FormatAOBs_metroButton.TabIndex = 3;
			this.FormatAOBs_metroButton.TabStop = false;
			this.FormatAOBs_metroButton.Text = "Format AOB\'s";
			this.FormatAOBs_metroButton.UseSelectable = true;
			this.FormatAOBs_metroButton.UseVisualStyleBackColor = true;
			this.FormatAOBs_metroButton.Click += new System.EventHandler(this.FormatAOBs_metroButton_Click);
			// 
			// AOB5Length_metroLabel
			// 
			this.AOB5Length_metroLabel.AutoSize = true;
			this.AOB5Length_metroLabel.Location = new System.Drawing.Point(526, 158);
			this.AOB5Length_metroLabel.Name = "AOB5Length_metroLabel";
			this.AOB5Length_metroLabel.Size = new System.Drawing.Size(50, 19);
			this.AOB5Length_metroLabel.TabIndex = 2;
			this.AOB5Length_metroLabel.Text = "0 Bytes";
			// 
			// AOB4Length_metroLabel
			// 
			this.AOB4Length_metroLabel.AutoSize = true;
			this.AOB4Length_metroLabel.Location = new System.Drawing.Point(526, 122);
			this.AOB4Length_metroLabel.Name = "AOB4Length_metroLabel";
			this.AOB4Length_metroLabel.Size = new System.Drawing.Size(50, 19);
			this.AOB4Length_metroLabel.TabIndex = 2;
			this.AOB4Length_metroLabel.Text = "0 Bytes";
			// 
			// AOB3Length_metroLabel
			// 
			this.AOB3Length_metroLabel.AutoSize = true;
			this.AOB3Length_metroLabel.Location = new System.Drawing.Point(526, 86);
			this.AOB3Length_metroLabel.Name = "AOB3Length_metroLabel";
			this.AOB3Length_metroLabel.Size = new System.Drawing.Size(50, 19);
			this.AOB3Length_metroLabel.TabIndex = 2;
			this.AOB3Length_metroLabel.Text = "0 Bytes";
			// 
			// AOB2Length_metroLabel
			// 
			this.AOB2Length_metroLabel.AutoSize = true;
			this.AOB2Length_metroLabel.Location = new System.Drawing.Point(526, 50);
			this.AOB2Length_metroLabel.Name = "AOB2Length_metroLabel";
			this.AOB2Length_metroLabel.Size = new System.Drawing.Size(50, 19);
			this.AOB2Length_metroLabel.TabIndex = 2;
			this.AOB2Length_metroLabel.Text = "0 Bytes";
			// 
			// AOB1Length_metroLabel
			// 
			this.AOB1Length_metroLabel.AutoSize = true;
			this.AOB1Length_metroLabel.Location = new System.Drawing.Point(526, 14);
			this.AOB1Length_metroLabel.Name = "AOB1Length_metroLabel";
			this.AOB1Length_metroLabel.Size = new System.Drawing.Size(50, 19);
			this.AOB1Length_metroLabel.TabIndex = 2;
			this.AOB1Length_metroLabel.Text = "0 Bytes";
			// 
			// Compare_metroButton
			// 
			this.Compare_metroButton.Enabled = false;
			this.Compare_metroButton.Location = new System.Drawing.Point(417, 190);
			this.Compare_metroButton.Margin = new System.Windows.Forms.Padding(5, 10, 5, 3);
			this.Compare_metroButton.Name = "Compare_metroButton";
			this.Compare_metroButton.Size = new System.Drawing.Size(101, 23);
			this.Compare_metroButton.TabIndex = 1;
			this.Compare_metroButton.TabStop = false;
			this.Compare_metroButton.Text = "Compare";
			this.Compare_metroButton.UseSelectable = true;
			this.Compare_metroButton.UseVisualStyleBackColor = true;
			this.Compare_metroButton.Click += new System.EventHandler(this.GenerateAOB);
			// 
			// AOBResults_metroTextBox
			// 
			// 
			// 
			// 
			this.AOBResults_metroTextBox.CustomButton.Image = null;
			this.AOBResults_metroTextBox.CustomButton.Location = new System.Drawing.Point(604, 1);
			this.AOBResults_metroTextBox.CustomButton.Name = "";
			this.AOBResults_metroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.AOBResults_metroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.AOBResults_metroTextBox.CustomButton.TabIndex = 1;
			this.AOBResults_metroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.AOBResults_metroTextBox.CustomButton.UseSelectable = true;
			this.AOBResults_metroTextBox.CustomButton.Visible = false;
			this.AOBResults_metroTextBox.Lines = new string[0];
			this.AOBResults_metroTextBox.Location = new System.Drawing.Point(5, 226);
			this.AOBResults_metroTextBox.Margin = new System.Windows.Forms.Padding(5, 10, 5, 3);
			this.AOBResults_metroTextBox.MaxLength = 32767;
			this.AOBResults_metroTextBox.Name = "AOBResults_metroTextBox";
			this.AOBResults_metroTextBox.PasswordChar = '\0';
			this.AOBResults_metroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.AOBResults_metroTextBox.SelectedText = "";
			this.AOBResults_metroTextBox.SelectionLength = 0;
			this.AOBResults_metroTextBox.SelectionStart = 0;
			this.AOBResults_metroTextBox.ShortcutsEnabled = true;
			this.AOBResults_metroTextBox.Size = new System.Drawing.Size(626, 23);
			this.AOBResults_metroTextBox.TabIndex = 0;
			this.AOBResults_metroTextBox.TabStop = false;
			this.AOBResults_metroTextBox.UseSelectable = true;
			this.AOBResults_metroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.AOBResults_metroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// AOB5_metroTextBox
			// 
			// 
			// 
			// 
			this.AOB5_metroTextBox.CustomButton.Image = null;
			this.AOB5_metroTextBox.CustomButton.Location = new System.Drawing.Point(491, 1);
			this.AOB5_metroTextBox.CustomButton.Name = "";
			this.AOB5_metroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.AOB5_metroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.AOB5_metroTextBox.CustomButton.TabIndex = 1;
			this.AOB5_metroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.AOB5_metroTextBox.CustomButton.UseSelectable = true;
			this.AOB5_metroTextBox.CustomButton.Visible = false;
			this.AOB5_metroTextBox.Lines = new string[0];
			this.AOB5_metroTextBox.Location = new System.Drawing.Point(5, 154);
			this.AOB5_metroTextBox.Margin = new System.Windows.Forms.Padding(5, 10, 5, 3);
			this.AOB5_metroTextBox.MaxLength = 32767;
			this.AOB5_metroTextBox.Name = "AOB5_metroTextBox";
			this.AOB5_metroTextBox.PasswordChar = '\0';
			this.AOB5_metroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.AOB5_metroTextBox.SelectedText = "";
			this.AOB5_metroTextBox.SelectionLength = 0;
			this.AOB5_metroTextBox.SelectionStart = 0;
			this.AOB5_metroTextBox.ShortcutsEnabled = true;
			this.AOB5_metroTextBox.Size = new System.Drawing.Size(513, 23);
			this.AOB5_metroTextBox.TabIndex = 4;
			this.AOB5_metroTextBox.TabStop = false;
			this.AOB5_metroTextBox.UseSelectable = true;
			this.AOB5_metroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.AOB5_metroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// AOB4_metroTextBox
			// 
			// 
			// 
			// 
			this.AOB4_metroTextBox.CustomButton.Image = null;
			this.AOB4_metroTextBox.CustomButton.Location = new System.Drawing.Point(491, 1);
			this.AOB4_metroTextBox.CustomButton.Name = "";
			this.AOB4_metroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.AOB4_metroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.AOB4_metroTextBox.CustomButton.TabIndex = 1;
			this.AOB4_metroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.AOB4_metroTextBox.CustomButton.UseSelectable = true;
			this.AOB4_metroTextBox.CustomButton.Visible = false;
			this.AOB4_metroTextBox.Lines = new string[0];
			this.AOB4_metroTextBox.Location = new System.Drawing.Point(5, 118);
			this.AOB4_metroTextBox.Margin = new System.Windows.Forms.Padding(5, 10, 5, 3);
			this.AOB4_metroTextBox.MaxLength = 32767;
			this.AOB4_metroTextBox.Name = "AOB4_metroTextBox";
			this.AOB4_metroTextBox.PasswordChar = '\0';
			this.AOB4_metroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.AOB4_metroTextBox.SelectedText = "";
			this.AOB4_metroTextBox.SelectionLength = 0;
			this.AOB4_metroTextBox.SelectionStart = 0;
			this.AOB4_metroTextBox.ShortcutsEnabled = true;
			this.AOB4_metroTextBox.Size = new System.Drawing.Size(513, 23);
			this.AOB4_metroTextBox.TabIndex = 3;
			this.AOB4_metroTextBox.TabStop = false;
			this.AOB4_metroTextBox.UseSelectable = true;
			this.AOB4_metroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.AOB4_metroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// AOB3_metroTextBox
			// 
			// 
			// 
			// 
			this.AOB3_metroTextBox.CustomButton.Image = null;
			this.AOB3_metroTextBox.CustomButton.Location = new System.Drawing.Point(491, 1);
			this.AOB3_metroTextBox.CustomButton.Name = "";
			this.AOB3_metroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.AOB3_metroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.AOB3_metroTextBox.CustomButton.TabIndex = 1;
			this.AOB3_metroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.AOB3_metroTextBox.CustomButton.UseSelectable = true;
			this.AOB3_metroTextBox.CustomButton.Visible = false;
			this.AOB3_metroTextBox.Lines = new string[0];
			this.AOB3_metroTextBox.Location = new System.Drawing.Point(5, 82);
			this.AOB3_metroTextBox.Margin = new System.Windows.Forms.Padding(5, 10, 5, 3);
			this.AOB3_metroTextBox.MaxLength = 32767;
			this.AOB3_metroTextBox.Name = "AOB3_metroTextBox";
			this.AOB3_metroTextBox.PasswordChar = '\0';
			this.AOB3_metroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.AOB3_metroTextBox.SelectedText = "";
			this.AOB3_metroTextBox.SelectionLength = 0;
			this.AOB3_metroTextBox.SelectionStart = 0;
			this.AOB3_metroTextBox.ShortcutsEnabled = true;
			this.AOB3_metroTextBox.Size = new System.Drawing.Size(513, 23);
			this.AOB3_metroTextBox.TabIndex = 2;
			this.AOB3_metroTextBox.TabStop = false;
			this.AOB3_metroTextBox.UseSelectable = true;
			this.AOB3_metroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.AOB3_metroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// AOB2_metroTextBox
			// 
			// 
			// 
			// 
			this.AOB2_metroTextBox.CustomButton.Image = null;
			this.AOB2_metroTextBox.CustomButton.Location = new System.Drawing.Point(491, 1);
			this.AOB2_metroTextBox.CustomButton.Name = "";
			this.AOB2_metroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.AOB2_metroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.AOB2_metroTextBox.CustomButton.TabIndex = 1;
			this.AOB2_metroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.AOB2_metroTextBox.CustomButton.UseSelectable = true;
			this.AOB2_metroTextBox.CustomButton.Visible = false;
			this.AOB2_metroTextBox.Lines = new string[0];
			this.AOB2_metroTextBox.Location = new System.Drawing.Point(5, 46);
			this.AOB2_metroTextBox.Margin = new System.Windows.Forms.Padding(5, 10, 5, 3);
			this.AOB2_metroTextBox.MaxLength = 32767;
			this.AOB2_metroTextBox.Name = "AOB2_metroTextBox";
			this.AOB2_metroTextBox.PasswordChar = '\0';
			this.AOB2_metroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.AOB2_metroTextBox.SelectedText = "";
			this.AOB2_metroTextBox.SelectionLength = 0;
			this.AOB2_metroTextBox.SelectionStart = 0;
			this.AOB2_metroTextBox.ShortcutsEnabled = true;
			this.AOB2_metroTextBox.Size = new System.Drawing.Size(513, 23);
			this.AOB2_metroTextBox.TabIndex = 1;
			this.AOB2_metroTextBox.TabStop = false;
			this.AOB2_metroTextBox.UseSelectable = true;
			this.AOB2_metroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.AOB2_metroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// AOB1_metroTextBox
			// 
			// 
			// 
			// 
			this.AOB1_metroTextBox.CustomButton.Image = null;
			this.AOB1_metroTextBox.CustomButton.Location = new System.Drawing.Point(491, 1);
			this.AOB1_metroTextBox.CustomButton.Name = "";
			this.AOB1_metroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.AOB1_metroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.AOB1_metroTextBox.CustomButton.TabIndex = 1;
			this.AOB1_metroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.AOB1_metroTextBox.CustomButton.UseSelectable = true;
			this.AOB1_metroTextBox.CustomButton.Visible = false;
			this.AOB1_metroTextBox.Lines = new string[0];
			this.AOB1_metroTextBox.Location = new System.Drawing.Point(5, 10);
			this.AOB1_metroTextBox.Margin = new System.Windows.Forms.Padding(5, 10, 5, 3);
			this.AOB1_metroTextBox.MaxLength = 32767;
			this.AOB1_metroTextBox.Name = "AOB1_metroTextBox";
			this.AOB1_metroTextBox.PasswordChar = '\0';
			this.AOB1_metroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.AOB1_metroTextBox.SelectedText = "";
			this.AOB1_metroTextBox.SelectionLength = 0;
			this.AOB1_metroTextBox.SelectionStart = 0;
			this.AOB1_metroTextBox.ShortcutsEnabled = true;
			this.AOB1_metroTextBox.Size = new System.Drawing.Size(513, 23);
			this.AOB1_metroTextBox.TabIndex = 0;
			this.AOB1_metroTextBox.TabStop = false;
			this.AOB1_metroTextBox.UseSelectable = true;
			this.AOB1_metroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.AOB1_metroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// AOBPatternFinder_UC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.FormatAOBs_metroButton);
			this.Controls.Add(this.AOB5Length_metroLabel);
			this.Controls.Add(this.AOB4Length_metroLabel);
			this.Controls.Add(this.AOB3Length_metroLabel);
			this.Controls.Add(this.AOB2Length_metroLabel);
			this.Controls.Add(this.AOB1Length_metroLabel);
			this.Controls.Add(this.Compare_metroButton);
			this.Controls.Add(this.AOBResults_metroTextBox);
			this.Controls.Add(this.AOB5_metroTextBox);
			this.Controls.Add(this.AOB4_metroTextBox);
			this.Controls.Add(this.AOB3_metroTextBox);
			this.Controls.Add(this.AOB2_metroTextBox);
			this.Controls.Add(this.AOB1_metroTextBox);
			this.Name = "AOBPatternFinder_UC";
			this.Size = new System.Drawing.Size(636, 276);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private MetroFramework.Controls.MetroTextBox AOBResults_metroTextBox;
		private MetroFramework.Controls.MetroButton Compare_metroButton;
		private MetroFramework.Controls.MetroTextBox AOB1_metroTextBox;
		private MetroFramework.Controls.MetroTextBox AOB2_metroTextBox;
		private MetroFramework.Controls.MetroTextBox AOB3_metroTextBox;
		private MetroFramework.Controls.MetroTextBox AOB4_metroTextBox;
		private MetroFramework.Controls.MetroTextBox AOB5_metroTextBox;
		private MetroFramework.Controls.MetroLabel AOB1Length_metroLabel;
		private MetroFramework.Controls.MetroLabel AOB2Length_metroLabel;
		private MetroFramework.Controls.MetroLabel AOB3Length_metroLabel;
		private MetroFramework.Controls.MetroLabel AOB4Length_metroLabel;
		private MetroFramework.Controls.MetroLabel AOB5Length_metroLabel;
		private MetroFramework.Controls.MetroButton FormatAOBs_metroButton;
		private MetroFramework.Controls.MetroLabel metroLabel1;
	}
}
