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
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.SuspendLayout();
			// 
			// ColorChanger_Timer
			// 
			this.ColorChanger_Timer.Enabled = true;
			this.ColorChanger_Timer.Interval = 400;
			this.ColorChanger_Timer.Tick += new System.EventHandler(this.ColorChanger_Timer_Tick);
			// 
			// metroLabel2
			// 
			this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
			this.metroLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.metroLabel2.Location = new System.Drawing.Point(380, 221);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(105, 39);
			this.metroLabel2.TabIndex = 2;
			this.metroLabel2.Text = "You Paste.";
			this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.metroLabel2.UseCustomBackColor = true;
			this.metroLabel2.UseCustomForeColor = true;
			// 
			// metroLabel1
			// 
			this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
			this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.metroLabel1.Location = new System.Drawing.Point(151, 221);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(113, 39);
			this.metroLabel1.TabIndex = 3;
			this.metroLabel1.Text = "We Copy.";
			this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.metroLabel1.UseCustomBackColor = true;
			this.metroLabel1.UseCustomForeColor = true;
			// 
			// Welcome_UC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.metroLabel1);
			this.DoubleBuffered = true;
			this.Name = "Welcome_UC";
			this.Size = new System.Drawing.Size(636, 276);
			this.ResumeLayout(false);

        }

		#endregion

		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private System.Windows.Forms.Timer ColorChanger_Timer;
	}
}
