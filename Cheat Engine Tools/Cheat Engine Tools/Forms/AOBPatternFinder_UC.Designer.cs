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
            this.Bottom_Label = new MetroFramework.Controls.MetroLabel();
            this.FormatAOBs_Button = new MetroFramework.Controls.MetroButton();
            this.AOB5Length_Label = new MetroFramework.Controls.MetroLabel();
            this.AOB4Length_Label = new MetroFramework.Controls.MetroLabel();
            this.AOB3Length_Label = new MetroFramework.Controls.MetroLabel();
            this.AOB2Length_Label = new MetroFramework.Controls.MetroLabel();
            this.AOB1Length_Label = new MetroFramework.Controls.MetroLabel();
            this.Compare_Button = new MetroFramework.Controls.MetroButton();
            this.AOBResults_TextBox = new MetroFramework.Controls.MetroTextBox();
            this.AOB5_TextBox = new MetroFramework.Controls.MetroTextBox();
            this.AOB4_TextBox = new MetroFramework.Controls.MetroTextBox();
            this.AOB3_TextBox = new MetroFramework.Controls.MetroTextBox();
            this.AOB2_TextBox = new MetroFramework.Controls.MetroTextBox();
            this.AOB1_TextBox = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // Bottom_Label
            // 
            this.Bottom_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bottom_Label.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Bottom_Label.ForeColor = System.Drawing.Color.Maroon;
            this.Bottom_Label.Location = new System.Drawing.Point(3, 252);
            this.Bottom_Label.Name = "Bottom_Label";
            this.Bottom_Label.Size = new System.Drawing.Size(628, 23);
            this.Bottom_Label.TabIndex = 4;
            this.Bottom_Label.Text = "*NOTE*   The First TextBox Byte Length Must Be >= To All Others";
            this.Bottom_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Bottom_Label.UseCustomForeColor = true;
            // 
            // FormatAOBs_Button
            // 
            this.FormatAOBs_Button.Location = new System.Drawing.Point(308, 190);
            this.FormatAOBs_Button.Name = "FormatAOBs_Button";
            this.FormatAOBs_Button.Size = new System.Drawing.Size(101, 23);
            this.FormatAOBs_Button.TabIndex = 3;
            this.FormatAOBs_Button.TabStop = false;
            this.FormatAOBs_Button.Text = "Format AOB\'s";
            this.FormatAOBs_Button.UseSelectable = true;
            this.FormatAOBs_Button.UseVisualStyleBackColor = true;
            this.FormatAOBs_Button.Click += new System.EventHandler(this.FormatAOBs_Button_Click);
            // 
            // AOB5Length_Label
            // 
            this.AOB5Length_Label.AutoSize = true;
            this.AOB5Length_Label.Location = new System.Drawing.Point(526, 158);
            this.AOB5Length_Label.Name = "AOB5Length_Label";
            this.AOB5Length_Label.Size = new System.Drawing.Size(50, 19);
            this.AOB5Length_Label.TabIndex = 2;
            this.AOB5Length_Label.Text = "0 Bytes";
            // 
            // AOB4Length_Label
            // 
            this.AOB4Length_Label.AutoSize = true;
            this.AOB4Length_Label.Location = new System.Drawing.Point(526, 122);
            this.AOB4Length_Label.Name = "AOB4Length_Label";
            this.AOB4Length_Label.Size = new System.Drawing.Size(50, 19);
            this.AOB4Length_Label.TabIndex = 2;
            this.AOB4Length_Label.Text = "0 Bytes";
            // 
            // AOB3Length_Label
            // 
            this.AOB3Length_Label.AutoSize = true;
            this.AOB3Length_Label.Location = new System.Drawing.Point(526, 86);
            this.AOB3Length_Label.Name = "AOB3Length_Label";
            this.AOB3Length_Label.Size = new System.Drawing.Size(50, 19);
            this.AOB3Length_Label.TabIndex = 2;
            this.AOB3Length_Label.Text = "0 Bytes";
            // 
            // AOB2Length_Label
            // 
            this.AOB2Length_Label.AutoSize = true;
            this.AOB2Length_Label.Location = new System.Drawing.Point(526, 50);
            this.AOB2Length_Label.Name = "AOB2Length_Label";
            this.AOB2Length_Label.Size = new System.Drawing.Size(50, 19);
            this.AOB2Length_Label.TabIndex = 2;
            this.AOB2Length_Label.Text = "0 Bytes";
            // 
            // AOB1Length_Label
            // 
            this.AOB1Length_Label.AutoSize = true;
            this.AOB1Length_Label.Location = new System.Drawing.Point(526, 14);
            this.AOB1Length_Label.Name = "AOB1Length_Label";
            this.AOB1Length_Label.Size = new System.Drawing.Size(50, 19);
            this.AOB1Length_Label.TabIndex = 2;
            this.AOB1Length_Label.Text = "0 Bytes";
            // 
            // Compare_Button
            // 
            this.Compare_Button.Enabled = false;
            this.Compare_Button.Location = new System.Drawing.Point(417, 190);
            this.Compare_Button.Margin = new System.Windows.Forms.Padding(5, 10, 5, 3);
            this.Compare_Button.Name = "Compare_Button";
            this.Compare_Button.Size = new System.Drawing.Size(101, 23);
            this.Compare_Button.TabIndex = 1;
            this.Compare_Button.TabStop = false;
            this.Compare_Button.Text = "Compare";
            this.Compare_Button.UseSelectable = true;
            this.Compare_Button.UseVisualStyleBackColor = true;
            this.Compare_Button.Click += new System.EventHandler(this.GenerateAOB);
            // 
            // AOBResults_TextBox
            // 
            // 
            // 
            // 
            this.AOBResults_TextBox.CustomButton.Image = null;
            this.AOBResults_TextBox.CustomButton.Location = new System.Drawing.Point(604, 1);
            this.AOBResults_TextBox.CustomButton.Name = "";
            this.AOBResults_TextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.AOBResults_TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.AOBResults_TextBox.CustomButton.TabIndex = 1;
            this.AOBResults_TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AOBResults_TextBox.CustomButton.UseSelectable = true;
            this.AOBResults_TextBox.CustomButton.Visible = false;
            this.AOBResults_TextBox.Lines = new string[0];
            this.AOBResults_TextBox.Location = new System.Drawing.Point(5, 226);
            this.AOBResults_TextBox.Margin = new System.Windows.Forms.Padding(5, 10, 5, 3);
            this.AOBResults_TextBox.MaxLength = 32767;
            this.AOBResults_TextBox.Name = "AOBResults_TextBox";
            this.AOBResults_TextBox.PasswordChar = '\0';
            this.AOBResults_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AOBResults_TextBox.SelectedText = "";
            this.AOBResults_TextBox.SelectionLength = 0;
            this.AOBResults_TextBox.SelectionStart = 0;
            this.AOBResults_TextBox.ShortcutsEnabled = true;
            this.AOBResults_TextBox.Size = new System.Drawing.Size(626, 23);
            this.AOBResults_TextBox.TabIndex = 0;
            this.AOBResults_TextBox.TabStop = false;
            this.AOBResults_TextBox.UseSelectable = true;
            this.AOBResults_TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AOBResults_TextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AOB5_TextBox
            // 
            // 
            // 
            // 
            this.AOB5_TextBox.CustomButton.Image = null;
            this.AOB5_TextBox.CustomButton.Location = new System.Drawing.Point(491, 1);
            this.AOB5_TextBox.CustomButton.Name = "";
            this.AOB5_TextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.AOB5_TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.AOB5_TextBox.CustomButton.TabIndex = 1;
            this.AOB5_TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AOB5_TextBox.CustomButton.UseSelectable = true;
            this.AOB5_TextBox.CustomButton.Visible = false;
            this.AOB5_TextBox.Lines = new string[0];
            this.AOB5_TextBox.Location = new System.Drawing.Point(5, 154);
            this.AOB5_TextBox.Margin = new System.Windows.Forms.Padding(5, 10, 5, 3);
            this.AOB5_TextBox.MaxLength = 32767;
            this.AOB5_TextBox.Name = "AOB5_TextBox";
            this.AOB5_TextBox.PasswordChar = '\0';
            this.AOB5_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AOB5_TextBox.SelectedText = "";
            this.AOB5_TextBox.SelectionLength = 0;
            this.AOB5_TextBox.SelectionStart = 0;
            this.AOB5_TextBox.ShortcutsEnabled = true;
            this.AOB5_TextBox.Size = new System.Drawing.Size(513, 23);
            this.AOB5_TextBox.TabIndex = 4;
            this.AOB5_TextBox.TabStop = false;
            this.AOB5_TextBox.UseSelectable = true;
            this.AOB5_TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AOB5_TextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AOB4_TextBox
            // 
            // 
            // 
            // 
            this.AOB4_TextBox.CustomButton.Image = null;
            this.AOB4_TextBox.CustomButton.Location = new System.Drawing.Point(491, 1);
            this.AOB4_TextBox.CustomButton.Name = "";
            this.AOB4_TextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.AOB4_TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.AOB4_TextBox.CustomButton.TabIndex = 1;
            this.AOB4_TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AOB4_TextBox.CustomButton.UseSelectable = true;
            this.AOB4_TextBox.CustomButton.Visible = false;
            this.AOB4_TextBox.Lines = new string[0];
            this.AOB4_TextBox.Location = new System.Drawing.Point(5, 118);
            this.AOB4_TextBox.Margin = new System.Windows.Forms.Padding(5, 10, 5, 3);
            this.AOB4_TextBox.MaxLength = 32767;
            this.AOB4_TextBox.Name = "AOB4_TextBox";
            this.AOB4_TextBox.PasswordChar = '\0';
            this.AOB4_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AOB4_TextBox.SelectedText = "";
            this.AOB4_TextBox.SelectionLength = 0;
            this.AOB4_TextBox.SelectionStart = 0;
            this.AOB4_TextBox.ShortcutsEnabled = true;
            this.AOB4_TextBox.Size = new System.Drawing.Size(513, 23);
            this.AOB4_TextBox.TabIndex = 3;
            this.AOB4_TextBox.TabStop = false;
            this.AOB4_TextBox.UseSelectable = true;
            this.AOB4_TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AOB4_TextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AOB3_TextBox
            // 
            // 
            // 
            // 
            this.AOB3_TextBox.CustomButton.Image = null;
            this.AOB3_TextBox.CustomButton.Location = new System.Drawing.Point(491, 1);
            this.AOB3_TextBox.CustomButton.Name = "";
            this.AOB3_TextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.AOB3_TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.AOB3_TextBox.CustomButton.TabIndex = 1;
            this.AOB3_TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AOB3_TextBox.CustomButton.UseSelectable = true;
            this.AOB3_TextBox.CustomButton.Visible = false;
            this.AOB3_TextBox.Lines = new string[0];
            this.AOB3_TextBox.Location = new System.Drawing.Point(5, 82);
            this.AOB3_TextBox.Margin = new System.Windows.Forms.Padding(5, 10, 5, 3);
            this.AOB3_TextBox.MaxLength = 32767;
            this.AOB3_TextBox.Name = "AOB3_TextBox";
            this.AOB3_TextBox.PasswordChar = '\0';
            this.AOB3_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AOB3_TextBox.SelectedText = "";
            this.AOB3_TextBox.SelectionLength = 0;
            this.AOB3_TextBox.SelectionStart = 0;
            this.AOB3_TextBox.ShortcutsEnabled = true;
            this.AOB3_TextBox.Size = new System.Drawing.Size(513, 23);
            this.AOB3_TextBox.TabIndex = 2;
            this.AOB3_TextBox.TabStop = false;
            this.AOB3_TextBox.UseSelectable = true;
            this.AOB3_TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AOB3_TextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AOB2_TextBox
            // 
            // 
            // 
            // 
            this.AOB2_TextBox.CustomButton.Image = null;
            this.AOB2_TextBox.CustomButton.Location = new System.Drawing.Point(491, 1);
            this.AOB2_TextBox.CustomButton.Name = "";
            this.AOB2_TextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.AOB2_TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.AOB2_TextBox.CustomButton.TabIndex = 1;
            this.AOB2_TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AOB2_TextBox.CustomButton.UseSelectable = true;
            this.AOB2_TextBox.CustomButton.Visible = false;
            this.AOB2_TextBox.Lines = new string[0];
            this.AOB2_TextBox.Location = new System.Drawing.Point(5, 46);
            this.AOB2_TextBox.Margin = new System.Windows.Forms.Padding(5, 10, 5, 3);
            this.AOB2_TextBox.MaxLength = 32767;
            this.AOB2_TextBox.Name = "AOB2_TextBox";
            this.AOB2_TextBox.PasswordChar = '\0';
            this.AOB2_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AOB2_TextBox.SelectedText = "";
            this.AOB2_TextBox.SelectionLength = 0;
            this.AOB2_TextBox.SelectionStart = 0;
            this.AOB2_TextBox.ShortcutsEnabled = true;
            this.AOB2_TextBox.Size = new System.Drawing.Size(513, 23);
            this.AOB2_TextBox.TabIndex = 1;
            this.AOB2_TextBox.TabStop = false;
            this.AOB2_TextBox.UseSelectable = true;
            this.AOB2_TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AOB2_TextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AOB1_TextBox
            // 
            // 
            // 
            // 
            this.AOB1_TextBox.CustomButton.Image = null;
            this.AOB1_TextBox.CustomButton.Location = new System.Drawing.Point(491, 1);
            this.AOB1_TextBox.CustomButton.Name = "";
            this.AOB1_TextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.AOB1_TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.AOB1_TextBox.CustomButton.TabIndex = 1;
            this.AOB1_TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AOB1_TextBox.CustomButton.UseSelectable = true;
            this.AOB1_TextBox.CustomButton.Visible = false;
            this.AOB1_TextBox.Lines = new string[0];
            this.AOB1_TextBox.Location = new System.Drawing.Point(5, 10);
            this.AOB1_TextBox.Margin = new System.Windows.Forms.Padding(5, 10, 5, 3);
            this.AOB1_TextBox.MaxLength = 32767;
            this.AOB1_TextBox.Name = "AOB1_TextBox";
            this.AOB1_TextBox.PasswordChar = '\0';
            this.AOB1_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AOB1_TextBox.SelectedText = "";
            this.AOB1_TextBox.SelectionLength = 0;
            this.AOB1_TextBox.SelectionStart = 0;
            this.AOB1_TextBox.ShortcutsEnabled = true;
            this.AOB1_TextBox.Size = new System.Drawing.Size(513, 23);
            this.AOB1_TextBox.TabIndex = 0;
            this.AOB1_TextBox.TabStop = false;
            this.AOB1_TextBox.UseSelectable = true;
            this.AOB1_TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AOB1_TextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AOBPatternFinder_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Bottom_Label);
            this.Controls.Add(this.FormatAOBs_Button);
            this.Controls.Add(this.AOB5Length_Label);
            this.Controls.Add(this.AOB4Length_Label);
            this.Controls.Add(this.AOB3Length_Label);
            this.Controls.Add(this.AOB2Length_Label);
            this.Controls.Add(this.AOB1Length_Label);
            this.Controls.Add(this.Compare_Button);
            this.Controls.Add(this.AOBResults_TextBox);
            this.Controls.Add(this.AOB5_TextBox);
            this.Controls.Add(this.AOB4_TextBox);
            this.Controls.Add(this.AOB3_TextBox);
            this.Controls.Add(this.AOB2_TextBox);
            this.Controls.Add(this.AOB1_TextBox);
            this.Name = "AOBPatternFinder_UC";
            this.Size = new System.Drawing.Size(636, 276);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private MetroFramework.Controls.MetroTextBox AOBResults_TextBox;
		private MetroFramework.Controls.MetroButton Compare_Button;
		private MetroFramework.Controls.MetroTextBox AOB1_TextBox;
		private MetroFramework.Controls.MetroTextBox AOB2_TextBox;
		private MetroFramework.Controls.MetroTextBox AOB3_TextBox;
		private MetroFramework.Controls.MetroTextBox AOB4_TextBox;
		private MetroFramework.Controls.MetroTextBox AOB5_TextBox;
		private MetroFramework.Controls.MetroLabel AOB1Length_Label;
		private MetroFramework.Controls.MetroLabel AOB2Length_Label;
		private MetroFramework.Controls.MetroLabel AOB3Length_Label;
		private MetroFramework.Controls.MetroLabel AOB4Length_Label;
		private MetroFramework.Controls.MetroLabel AOB5Length_Label;
		private MetroFramework.Controls.MetroButton FormatAOBs_Button;
		private MetroFramework.Controls.MetroLabel Bottom_Label;
	}
}
