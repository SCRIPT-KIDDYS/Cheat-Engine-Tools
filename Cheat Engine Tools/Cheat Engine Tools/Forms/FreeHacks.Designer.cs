namespace Cheat_Engine_Tools.Forms
{
    partial class FreeHacks
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
            this.FreeHacks_Codes_TextBox = new System.Windows.Forms.RichTextBox();
            this.FreeHacks_Games_ComboBox = new MetroFramework.Controls.MetroComboBox();
            this.FreeHacks_BottomText_Label = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // FreeHacks_Codes_TextBox
            // 
            this.FreeHacks_Codes_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FreeHacks_Codes_TextBox.Location = new System.Drawing.Point(5, 45);
            this.FreeHacks_Codes_TextBox.Name = "FreeHacks_Codes_TextBox";
            this.FreeHacks_Codes_TextBox.ReadOnly = true;
            this.FreeHacks_Codes_TextBox.Size = new System.Drawing.Size(626, 189);
            this.FreeHacks_Codes_TextBox.TabIndex = 1;
            this.FreeHacks_Codes_TextBox.TabStop = false;
            this.FreeHacks_Codes_TextBox.Text = "";
            // 
            // FreeHacks_Games_ComboBox
            // 
            this.FreeHacks_Games_ComboBox.DropDownHeight = 240;
            this.FreeHacks_Games_ComboBox.FormattingEnabled = true;
            this.FreeHacks_Games_ComboBox.IntegralHeight = false;
            this.FreeHacks_Games_ComboBox.ItemHeight = 23;
            this.FreeHacks_Games_ComboBox.Location = new System.Drawing.Point(5, 10);
            this.FreeHacks_Games_ComboBox.Margin = new System.Windows.Forms.Padding(5, 10, 5, 3);
            this.FreeHacks_Games_ComboBox.Name = "FreeHacks_Games_ComboBox";
            this.FreeHacks_Games_ComboBox.Size = new System.Drawing.Size(626, 29);
            this.FreeHacks_Games_ComboBox.TabIndex = 0;
            this.FreeHacks_Games_ComboBox.TabStop = false;
            this.FreeHacks_Games_ComboBox.UseSelectable = true;
            this.FreeHacks_Games_ComboBox.SelectedIndexChanged += new System.EventHandler(this.HackSelectedGame);
            // 
            // FreeHacks_BottomText_Label
            // 
            this.FreeHacks_BottomText_Label.Location = new System.Drawing.Point(5, 247);
            this.FreeHacks_BottomText_Label.Margin = new System.Windows.Forms.Padding(10);
            this.FreeHacks_BottomText_Label.Name = "FreeHacks_BottomText_Label";
            this.FreeHacks_BottomText_Label.Size = new System.Drawing.Size(626, 23);
            this.FreeHacks_BottomText_Label.TabIndex = 2;
            this.FreeHacks_BottomText_Label.Text = "All codes stolen from CyberTerminators because why not?";
            this.FreeHacks_BottomText_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FreeHacks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FreeHacks_BottomText_Label);
            this.Controls.Add(this.FreeHacks_Codes_TextBox);
            this.Controls.Add(this.FreeHacks_Games_ComboBox);
            this.Name = "FreeHacks";
            this.Size = new System.Drawing.Size(636, 276);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox FreeHacks_Games_ComboBox;
        private System.Windows.Forms.RichTextBox FreeHacks_Codes_TextBox;
        private MetroFramework.Controls.MetroLabel FreeHacks_BottomText_Label;
    }
}
