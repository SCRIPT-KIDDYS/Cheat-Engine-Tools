namespace Cheat_Engine_Tools.Forms
{
    partial class DLLInjector_UC
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
            this.DLLInjector_openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.InjectDLL_Button = new MetroFramework.Controls.MetroButton();
            this.RefreshProcessList_Button = new MetroFramework.Controls.MetroButton();
            this.ProcessList_ComboBox = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // DLLInjector_openFileDialog
            // 
            this.DLLInjector_openFileDialog.FileName = "openFileDialog1";
            // 
            // InjectDLL_Button
            // 
            this.InjectDLL_Button.Location = new System.Drawing.Point(3, 67);
            this.InjectDLL_Button.Name = "InjectDLL_Button";
            this.InjectDLL_Button.Size = new System.Drawing.Size(630, 23);
            this.InjectDLL_Button.TabIndex = 2;
            this.InjectDLL_Button.Text = "Inject DLL";
            this.InjectDLL_Button.UseSelectable = true;
            this.InjectDLL_Button.UseVisualStyleBackColor = true;
            this.InjectDLL_Button.Click += new System.EventHandler(this.InjectDLL_metroButton_Click);
            // 
            // RefreshProcessList_Button
            // 
            this.RefreshProcessList_Button.Location = new System.Drawing.Point(3, 38);
            this.RefreshProcessList_Button.Name = "RefreshProcessList_Button";
            this.RefreshProcessList_Button.Size = new System.Drawing.Size(630, 23);
            this.RefreshProcessList_Button.TabIndex = 1;
            this.RefreshProcessList_Button.Text = "Refresh Process List";
            this.RefreshProcessList_Button.UseSelectable = true;
            this.RefreshProcessList_Button.UseVisualStyleBackColor = true;
            this.RefreshProcessList_Button.Click += new System.EventHandler(this.RefreshProcessList_metroButton_Click);
            // 
            // ProcessList_ComboBox
            // 
            this.ProcessList_ComboBox.DropDownHeight = 250;
            this.ProcessList_ComboBox.FormattingEnabled = true;
            this.ProcessList_ComboBox.IntegralHeight = false;
            this.ProcessList_ComboBox.ItemHeight = 23;
            this.ProcessList_ComboBox.Location = new System.Drawing.Point(3, 3);
            this.ProcessList_ComboBox.Name = "ProcessList_ComboBox";
            this.ProcessList_ComboBox.Size = new System.Drawing.Size(630, 29);
            this.ProcessList_ComboBox.TabIndex = 0;
            this.ProcessList_ComboBox.UseSelectable = true;
            // 
            // DLLInjector_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.InjectDLL_Button);
            this.Controls.Add(this.RefreshProcessList_Button);
            this.Controls.Add(this.ProcessList_ComboBox);
            this.Name = "DLLInjector_UC";
            this.Size = new System.Drawing.Size(636, 276);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox ProcessList_ComboBox;
        private MetroFramework.Controls.MetroButton RefreshProcessList_Button;
        private MetroFramework.Controls.MetroButton InjectDLL_Button;
        private System.Windows.Forms.OpenFileDialog DLLInjector_openFileDialog;
    }
}
