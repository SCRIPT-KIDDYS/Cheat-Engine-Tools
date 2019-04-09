namespace Cheat_Engine_Tools.Forms
{
    partial class WCStringDecode_UC
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
            this.components = new System.ComponentModel.Container();
            this.WCDecode_openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.WCDecode_folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.WCDecodeProgressBar_timer = new System.Windows.Forms.Timer(this.components);
            this.Decode_ProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.Log_TextBox = new MetroFramework.Controls.MetroTextBox();
            this.WrapperRight_TextBox = new MetroFramework.Controls.MetroTextBox();
            this.WrapperLeft_TextBox = new MetroFramework.Controls.MetroTextBox();
            this.Wrapper_Label = new MetroFramework.Controls.MetroLabel();
            this.ScriptsFolder_Label = new MetroFramework.Controls.MetroLabel();
            this.BinFolder_Label = new MetroFramework.Controls.MetroLabel();
            this.ClearLog_Button = new MetroFramework.Controls.MetroButton();
            this.Start_Button = new MetroFramework.Controls.MetroButton();
            this.ScriptsFolder_Button = new MetroFramework.Controls.MetroButton();
            this.BinFolder_Button = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // WCDecode_openFileDialog
            // 
            this.WCDecode_openFileDialog.FileName = "openFileDialog1";
            // 
            // WCDecodeProgressBar_timer
            // 
            this.WCDecodeProgressBar_timer.Enabled = true;
            this.WCDecodeProgressBar_timer.Tick += new System.EventHandler(this.WCDecodeProgressBar_timer_Tick);
            // 
            // Decode_ProgressBar
            // 
            this.Decode_ProgressBar.FontSize = MetroFramework.MetroProgressBarSize.Small;
            this.Decode_ProgressBar.HideProgressText = false;
            this.Decode_ProgressBar.Location = new System.Drawing.Point(8, 269);
            this.Decode_ProgressBar.Margin = new System.Windows.Forms.Padding(5);
            this.Decode_ProgressBar.Name = "Decode_ProgressBar";
            this.Decode_ProgressBar.Size = new System.Drawing.Size(620, 41);
            this.Decode_ProgressBar.Step = 1;
            this.Decode_ProgressBar.TabIndex = 5;
            // 
            // Log_TextBox
            // 
            // 
            // 
            // 
            this.Log_TextBox.CustomButton.Image = null;
            this.Log_TextBox.CustomButton.Location = new System.Drawing.Point(362, 1);
            this.Log_TextBox.CustomButton.Name = "";
            this.Log_TextBox.CustomButton.Size = new System.Drawing.Size(147, 147);
            this.Log_TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Log_TextBox.CustomButton.TabIndex = 1;
            this.Log_TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Log_TextBox.CustomButton.UseSelectable = true;
            this.Log_TextBox.CustomButton.Visible = false;
            this.Log_TextBox.Lines = new string[0];
            this.Log_TextBox.Location = new System.Drawing.Point(8, 110);
            this.Log_TextBox.Margin = new System.Windows.Forms.Padding(5);
            this.Log_TextBox.MaxLength = 32767;
            this.Log_TextBox.Multiline = true;
            this.Log_TextBox.Name = "Log_TextBox";
            this.Log_TextBox.PasswordChar = '\0';
            this.Log_TextBox.PromptText = "OUTPUT:";
            this.Log_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Log_TextBox.SelectedText = "";
            this.Log_TextBox.SelectionLength = 0;
            this.Log_TextBox.SelectionStart = 0;
            this.Log_TextBox.ShortcutsEnabled = true;
            this.Log_TextBox.Size = new System.Drawing.Size(510, 149);
            this.Log_TextBox.TabIndex = 4;
            this.Log_TextBox.TabStop = false;
            this.Log_TextBox.UseSelectable = true;
            this.Log_TextBox.WaterMark = "OUTPUT:";
            this.Log_TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Log_TextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // WrapperRight_TextBox
            // 
            // 
            // 
            // 
            this.WrapperRight_TextBox.CustomButton.Image = null;
            this.WrapperRight_TextBox.CustomButton.Location = new System.Drawing.Point(73, 1);
            this.WrapperRight_TextBox.CustomButton.Name = "";
            this.WrapperRight_TextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.WrapperRight_TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.WrapperRight_TextBox.CustomButton.TabIndex = 1;
            this.WrapperRight_TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.WrapperRight_TextBox.CustomButton.UseSelectable = true;
            this.WrapperRight_TextBox.CustomButton.Visible = false;
            this.WrapperRight_TextBox.Lines = new string[] {
        "  ]]=="};
            this.WrapperRight_TextBox.Location = new System.Drawing.Point(531, 75);
            this.WrapperRight_TextBox.Margin = new System.Windows.Forms.Padding(5);
            this.WrapperRight_TextBox.MaxLength = 32767;
            this.WrapperRight_TextBox.Name = "WrapperRight_TextBox";
            this.WrapperRight_TextBox.PasswordChar = '\0';
            this.WrapperRight_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.WrapperRight_TextBox.SelectedText = "";
            this.WrapperRight_TextBox.SelectionLength = 0;
            this.WrapperRight_TextBox.SelectionStart = 0;
            this.WrapperRight_TextBox.ShortcutsEnabled = true;
            this.WrapperRight_TextBox.Size = new System.Drawing.Size(97, 25);
            this.WrapperRight_TextBox.TabIndex = 3;
            this.WrapperRight_TextBox.TabStop = false;
            this.WrapperRight_TextBox.Text = "  ]]==";
            this.WrapperRight_TextBox.UseSelectable = true;
            this.WrapperRight_TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.WrapperRight_TextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // WrapperLeft_TextBox
            // 
            // 
            // 
            // 
            this.WrapperLeft_TextBox.CustomButton.Image = null;
            this.WrapperLeft_TextBox.CustomButton.Location = new System.Drawing.Point(73, 1);
            this.WrapperLeft_TextBox.CustomButton.Name = "";
            this.WrapperLeft_TextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.WrapperLeft_TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.WrapperLeft_TextBox.CustomButton.TabIndex = 1;
            this.WrapperLeft_TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.WrapperLeft_TextBox.CustomButton.UseSelectable = true;
            this.WrapperLeft_TextBox.CustomButton.Visible = false;
            this.WrapperLeft_TextBox.Lines = new string[] {
        "==[[  "};
            this.WrapperLeft_TextBox.Location = new System.Drawing.Point(8, 75);
            this.WrapperLeft_TextBox.Margin = new System.Windows.Forms.Padding(5);
            this.WrapperLeft_TextBox.MaxLength = 32767;
            this.WrapperLeft_TextBox.Name = "WrapperLeft_TextBox";
            this.WrapperLeft_TextBox.PasswordChar = '\0';
            this.WrapperLeft_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.WrapperLeft_TextBox.SelectedText = "";
            this.WrapperLeft_TextBox.SelectionLength = 0;
            this.WrapperLeft_TextBox.SelectionStart = 0;
            this.WrapperLeft_TextBox.ShortcutsEnabled = true;
            this.WrapperLeft_TextBox.Size = new System.Drawing.Size(97, 25);
            this.WrapperLeft_TextBox.TabIndex = 3;
            this.WrapperLeft_TextBox.TabStop = false;
            this.WrapperLeft_TextBox.Text = "==[[  ";
            this.WrapperLeft_TextBox.UseSelectable = true;
            this.WrapperLeft_TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.WrapperLeft_TextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Wrapper_Label
            // 
            this.Wrapper_Label.Location = new System.Drawing.Point(115, 75);
            this.Wrapper_Label.Margin = new System.Windows.Forms.Padding(5);
            this.Wrapper_Label.Name = "Wrapper_Label";
            this.Wrapper_Label.Size = new System.Drawing.Size(403, 25);
            this.Wrapper_Label.TabIndex = 2;
            this.Wrapper_Label.Text = "<- Wrapper to show difference in decoded script ->";
            this.Wrapper_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScriptsFolder_Label
            // 
            this.ScriptsFolder_Label.Location = new System.Drawing.Point(5, 40);
            this.ScriptsFolder_Label.Margin = new System.Windows.Forms.Padding(5);
            this.ScriptsFolder_Label.Name = "ScriptsFolder_Label";
            this.ScriptsFolder_Label.Size = new System.Drawing.Size(513, 25);
            this.ScriptsFolder_Label.TabIndex = 2;
            this.ScriptsFolder_Label.Text = "Select Scripts Folder";
            this.ScriptsFolder_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BinFolder_Label
            // 
            this.BinFolder_Label.Location = new System.Drawing.Point(5, 5);
            this.BinFolder_Label.Margin = new System.Windows.Forms.Padding(5);
            this.BinFolder_Label.Name = "BinFolder_Label";
            this.BinFolder_Label.Size = new System.Drawing.Size(513, 25);
            this.BinFolder_Label.TabIndex = 2;
            this.BinFolder_Label.Text = "Select Bin Folder";
            this.BinFolder_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ClearLog_Button
            // 
            this.ClearLog_Button.Location = new System.Drawing.Point(531, 110);
            this.ClearLog_Button.Margin = new System.Windows.Forms.Padding(5);
            this.ClearLog_Button.Name = "ClearLog_Button";
            this.ClearLog_Button.Size = new System.Drawing.Size(97, 25);
            this.ClearLog_Button.TabIndex = 1;
            this.ClearLog_Button.TabStop = false;
            this.ClearLog_Button.Text = "Clear Log";
            this.ClearLog_Button.UseSelectable = true;
            this.ClearLog_Button.UseVisualStyleBackColor = true;
            this.ClearLog_Button.Click += new System.EventHandler(this.ClearLog_Button_Click);
            // 
            // Start_Button
            // 
            this.Start_Button.Location = new System.Drawing.Point(531, 208);
            this.Start_Button.Margin = new System.Windows.Forms.Padding(5);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(97, 51);
            this.Start_Button.TabIndex = 1;
            this.Start_Button.TabStop = false;
            this.Start_Button.Text = "START";
            this.Start_Button.UseSelectable = true;
            this.Start_Button.UseVisualStyleBackColor = true;
            this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // ScriptsFolder_Button
            // 
            this.ScriptsFolder_Button.Location = new System.Drawing.Point(531, 40);
            this.ScriptsFolder_Button.Margin = new System.Windows.Forms.Padding(5);
            this.ScriptsFolder_Button.Name = "ScriptsFolder_Button";
            this.ScriptsFolder_Button.Size = new System.Drawing.Size(97, 25);
            this.ScriptsFolder_Button.TabIndex = 1;
            this.ScriptsFolder_Button.TabStop = false;
            this.ScriptsFolder_Button.Text = "Scripts Folder";
            this.ScriptsFolder_Button.UseSelectable = true;
            this.ScriptsFolder_Button.UseVisualStyleBackColor = true;
            this.ScriptsFolder_Button.Click += new System.EventHandler(this.ScriptsFolder_Button_Click);
            // 
            // BinFolder_Button
            // 
            this.BinFolder_Button.Location = new System.Drawing.Point(531, 5);
            this.BinFolder_Button.Margin = new System.Windows.Forms.Padding(5);
            this.BinFolder_Button.Name = "BinFolder_Button";
            this.BinFolder_Button.Size = new System.Drawing.Size(97, 25);
            this.BinFolder_Button.TabIndex = 0;
            this.BinFolder_Button.TabStop = false;
            this.BinFolder_Button.Text = "Bin Folder";
            this.BinFolder_Button.UseSelectable = true;
            this.BinFolder_Button.UseVisualStyleBackColor = true;
            this.BinFolder_Button.Click += new System.EventHandler(this.BinFolder_Button_Click);
            // 
            // WCStringDecode_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.Decode_ProgressBar);
            this.Controls.Add(this.Log_TextBox);
            this.Controls.Add(this.WrapperRight_TextBox);
            this.Controls.Add(this.WrapperLeft_TextBox);
            this.Controls.Add(this.Wrapper_Label);
            this.Controls.Add(this.ScriptsFolder_Label);
            this.Controls.Add(this.BinFolder_Label);
            this.Controls.Add(this.ClearLog_Button);
            this.Controls.Add(this.Start_Button);
            this.Controls.Add(this.ScriptsFolder_Button);
            this.Controls.Add(this.BinFolder_Button);
            this.DoubleBuffered = true;
            this.Name = "WCStringDecode_UC";
            this.Size = new System.Drawing.Size(650, 315);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton BinFolder_Button;
        private MetroFramework.Controls.MetroButton ScriptsFolder_Button;
        private MetroFramework.Controls.MetroLabel BinFolder_Label;
        private MetroFramework.Controls.MetroLabel ScriptsFolder_Label;
        private MetroFramework.Controls.MetroTextBox WrapperLeft_TextBox;
        private MetroFramework.Controls.MetroTextBox WrapperRight_TextBox;
        private MetroFramework.Controls.MetroLabel Wrapper_Label;
        private MetroFramework.Controls.MetroTextBox Log_TextBox;
        private MetroFramework.Controls.MetroButton Start_Button;
        private System.Windows.Forms.OpenFileDialog WCDecode_openFileDialog;
        private System.Windows.Forms.FolderBrowserDialog WCDecode_folderBrowserDialog;
        private MetroFramework.Controls.MetroButton ClearLog_Button;
        private MetroFramework.Controls.MetroProgressBar Decode_ProgressBar;
        private System.Windows.Forms.Timer WCDecodeProgressBar_timer;
    }
}
