namespace Cheat_Engine_Tools.Forms
{
    partial class CEDecompiler_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CEDecompiler_UC));
            this.DragAndDrop_Label = new MetroFramework.Controls.MetroLabel();
            this.NewEncryption_Label = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // DragAndDrop_Label
            // 
            this.DragAndDrop_Label.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DragAndDrop_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.DragAndDrop_Label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.DragAndDrop_Label.Location = new System.Drawing.Point(0, 279);
            this.DragAndDrop_Label.Margin = new System.Windows.Forms.Padding(10);
            this.DragAndDrop_Label.Name = "DragAndDrop_Label";
            this.DragAndDrop_Label.Size = new System.Drawing.Size(650, 36);
            this.DragAndDrop_Label.TabIndex = 0;
            this.DragAndDrop_Label.Text = "Drag and Drop .cetrainer file(s) here.";
            this.DragAndDrop_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewEncryption_Label
            // 
            this.NewEncryption_Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.NewEncryption_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.NewEncryption_Label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.NewEncryption_Label.Location = new System.Drawing.Point(0, 0);
            this.NewEncryption_Label.Margin = new System.Windows.Forms.Padding(10);
            this.NewEncryption_Label.Name = "NewEncryption_Label";
            this.NewEncryption_Label.Size = new System.Drawing.Size(650, 36);
            this.NewEncryption_Label.TabIndex = 1;
            this.NewEncryption_Label.Text = "NOTE: Will not work on new encodeFunction()...... yet";
            this.NewEncryption_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CEDecompiler_UC
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.NewEncryption_Label);
            this.Controls.Add(this.DragAndDrop_Label);
            this.DoubleBuffered = true;
            this.Name = "CEDecompiler_UC";
            this.Size = new System.Drawing.Size(650, 315);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.CEDecompiler_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.CEDecompiler_DragEnter);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel DragAndDrop_Label;
        private MetroFramework.Controls.MetroLabel NewEncryption_Label;
    }
}
