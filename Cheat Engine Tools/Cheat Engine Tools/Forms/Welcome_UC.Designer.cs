namespace Cheat_Engine_Tools.Forms
{
    partial class Welcome_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome_UC));
            this.ColorChanger_Timer = new System.Windows.Forms.Timer(this.components);
            this.Right_Label = new MetroFramework.Controls.MetroLabel();
            this.Left_Label = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // ColorChanger_Timer
            // 
            this.ColorChanger_Timer.Enabled = true;
            this.ColorChanger_Timer.Interval = 400;
            this.ColorChanger_Timer.Tick += new System.EventHandler(this.ColorChanger_Timer_Tick);
            // 
            // Right_Label
            // 
            this.Right_Label.BackColor = System.Drawing.Color.Transparent;
            this.Right_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Right_Label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Right_Label.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.Right_Label.Location = new System.Drawing.Point(380, 221);
            this.Right_Label.Name = "Right_Label";
            this.Right_Label.Size = new System.Drawing.Size(105, 39);
            this.Right_Label.TabIndex = 2;
            this.Right_Label.Text = "You Paste.";
            this.Right_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Right_Label.UseCustomBackColor = true;
            this.Right_Label.UseCustomForeColor = true;
            // 
            // Left_Label
            // 
            this.Left_Label.BackColor = System.Drawing.Color.Transparent;
            this.Left_Label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Left_Label.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.Left_Label.Location = new System.Drawing.Point(151, 221);
            this.Left_Label.Name = "Left_Label";
            this.Left_Label.Size = new System.Drawing.Size(113, 39);
            this.Left_Label.TabIndex = 3;
            this.Left_Label.Text = "We Copy.";
            this.Left_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Left_Label.UseCustomBackColor = true;
            this.Left_Label.UseCustomForeColor = true;
            // 
            // Welcome_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.Right_Label);
            this.Controls.Add(this.Left_Label);
            this.DoubleBuffered = true;
            this.Name = "Welcome_UC";
            this.Size = new System.Drawing.Size(636, 276);
            this.ResumeLayout(false);

        }

		#endregion

		private MetroFramework.Controls.MetroLabel Right_Label;
		private MetroFramework.Controls.MetroLabel Left_Label;
		private System.Windows.Forms.Timer ColorChanger_Timer;
	}
}
