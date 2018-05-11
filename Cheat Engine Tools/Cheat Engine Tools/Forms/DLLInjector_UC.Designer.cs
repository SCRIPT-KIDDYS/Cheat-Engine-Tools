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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.InjectDLL_metroButton = new MetroFramework.Controls.MetroButton();
            this.RefreshProcessList_metroButton = new MetroFramework.Controls.MetroButton();
            this.ProcessList_metroComboBox = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // InjectDLL_metroButton
            // 
            this.InjectDLL_metroButton.Location = new System.Drawing.Point(3, 67);
            this.InjectDLL_metroButton.Name = "InjectDLL_metroButton";
            this.InjectDLL_metroButton.Size = new System.Drawing.Size(630, 23);
            this.InjectDLL_metroButton.TabIndex = 2;
            this.InjectDLL_metroButton.Text = "Inject DLL";
            this.InjectDLL_metroButton.UseSelectable = true;
            this.InjectDLL_metroButton.UseVisualStyleBackColor = true;
            this.InjectDLL_metroButton.Click += new System.EventHandler(this.InjectDLL_metroButton_Click);
            // 
            // RefreshProcessList_metroButton
            // 
            this.RefreshProcessList_metroButton.Location = new System.Drawing.Point(3, 38);
            this.RefreshProcessList_metroButton.Name = "RefreshProcessList_metroButton";
            this.RefreshProcessList_metroButton.Size = new System.Drawing.Size(630, 23);
            this.RefreshProcessList_metroButton.TabIndex = 1;
            this.RefreshProcessList_metroButton.Text = "Refresh Process List";
            this.RefreshProcessList_metroButton.UseSelectable = true;
            this.RefreshProcessList_metroButton.UseVisualStyleBackColor = true;
            this.RefreshProcessList_metroButton.Click += new System.EventHandler(this.RefreshProcessList_metroButton_Click);
            // 
            // ProcessList_metroComboBox
            // 
            this.ProcessList_metroComboBox.DropDownHeight = 250;
            this.ProcessList_metroComboBox.FormattingEnabled = true;
            this.ProcessList_metroComboBox.IntegralHeight = false;
            this.ProcessList_metroComboBox.ItemHeight = 23;
            this.ProcessList_metroComboBox.Location = new System.Drawing.Point(3, 3);
            this.ProcessList_metroComboBox.Name = "ProcessList_metroComboBox";
            this.ProcessList_metroComboBox.Size = new System.Drawing.Size(630, 29);
            this.ProcessList_metroComboBox.TabIndex = 0;
            this.ProcessList_metroComboBox.UseSelectable = true;
            // 
            // DLLInjector_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.InjectDLL_metroButton);
            this.Controls.Add(this.RefreshProcessList_metroButton);
            this.Controls.Add(this.ProcessList_metroComboBox);
            this.Name = "DLLInjector_UC";
            this.Size = new System.Drawing.Size(636, 276);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox ProcessList_metroComboBox;
        private MetroFramework.Controls.MetroButton RefreshProcessList_metroButton;
        private MetroFramework.Controls.MetroButton InjectDLL_metroButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
