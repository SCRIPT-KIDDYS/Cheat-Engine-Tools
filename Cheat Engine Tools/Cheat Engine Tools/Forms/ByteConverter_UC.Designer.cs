namespace Cheat_Engine_Tools.Forms
{
    partial class ByteConverter_UC
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
            this.ProcessList_GridView = new System.Windows.Forms.DataGridView();
            this.Processes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SystemPID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEPID_dataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Copy_Label = new MetroFramework.Controls.MetroLabel();
            this.RefreshProcesses_Button = new MetroFramework.Controls.MetroButton();
            this.UnityFloatx32_Label = new MetroFramework.Controls.MetroLabel();
            this.IEEEx64_Label = new MetroFramework.Controls.MetroLabel();
            this.IEEEx32_Label = new MetroFramework.Controls.MetroLabel();
            this.U30_Label = new MetroFramework.Controls.MetroLabel();
            this.Hex_Label = new MetroFramework.Controls.MetroLabel();
            this._4byte_x8_p6_Label = new MetroFramework.Controls.MetroLabel();
            this._4bytex8_Label = new MetroFramework.Controls.MetroLabel();
            this._4byte_Label = new MetroFramework.Controls.MetroLabel();
            this.Converter_UnityFloatx32_TextBox = new MetroFramework.Controls.MetroTextBox();
            this.Converter_Ieeex64_TextBox = new MetroFramework.Controls.MetroTextBox();
            this.Converter_Ieeex32_TextBox = new MetroFramework.Controls.MetroTextBox();
            this.Converter_U30_TextBox = new MetroFramework.Controls.MetroTextBox();
            this.Converter_Hex_TextBox = new MetroFramework.Controls.MetroTextBox();
            this.Converter_FourBytex8p6_TextBox = new MetroFramework.Controls.MetroTextBox();
            this.Converter_FourBytex8_TextBox = new MetroFramework.Controls.MetroTextBox();
            this.Converter_FourByte_TextBox = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessList_GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ProcessList_GridView
            // 
            this.ProcessList_GridView.AllowUserToAddRows = false;
            this.ProcessList_GridView.AllowUserToDeleteRows = false;
            this.ProcessList_GridView.AllowUserToResizeColumns = false;
            this.ProcessList_GridView.AllowUserToResizeRows = false;
            this.ProcessList_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProcessList_GridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProcessList_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProcessList_GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Processes,
            this.SystemPID,
            this.CEPID_dataGridView});
            this.ProcessList_GridView.EnableHeadersVisualStyles = false;
            this.ProcessList_GridView.Location = new System.Drawing.Point(252, 8);
            this.ProcessList_GridView.MultiSelect = false;
            this.ProcessList_GridView.Name = "ProcessList_GridView";
            this.ProcessList_GridView.ReadOnly = true;
            this.ProcessList_GridView.RowHeadersVisible = false;
            this.ProcessList_GridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ProcessList_GridView.Size = new System.Drawing.Size(390, 249);
            this.ProcessList_GridView.TabIndex = 19;
            this.ProcessList_GridView.TabStop = false;
            this.ProcessList_GridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentDoubleClick);
            // 
            // Processes
            // 
            this.Processes.FillWeight = 152.2843F;
            this.Processes.HeaderText = "Processes";
            this.Processes.MinimumWidth = 10;
            this.Processes.Name = "Processes";
            this.Processes.ReadOnly = true;
            // 
            // SystemPID
            // 
            this.SystemPID.FillWeight = 73.85786F;
            this.SystemPID.HeaderText = "System PID";
            this.SystemPID.Name = "SystemPID";
            this.SystemPID.ReadOnly = true;
            // 
            // CEPID_dataGridView
            // 
            this.CEPID_dataGridView.FillWeight = 73.85786F;
            this.CEPID_dataGridView.HeaderText = "CE PID";
            this.CEPID_dataGridView.Name = "CEPID_dataGridView";
            this.CEPID_dataGridView.ReadOnly = true;
            // 
            // Copy_Label
            // 
            this.Copy_Label.AutoSize = true;
            this.Copy_Label.Location = new System.Drawing.Point(509, 291);
            this.Copy_Label.Name = "Copy_Label";
            this.Copy_Label.Size = new System.Drawing.Size(133, 19);
            this.Copy_Label.TabIndex = 21;
            this.Copy_Label.Text = "Double Click to copy.";
            this.Copy_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RefreshProcesses_Button
            // 
            this.RefreshProcesses_Button.Location = new System.Drawing.Point(252, 263);
            this.RefreshProcesses_Button.Name = "RefreshProcesses_Button";
            this.RefreshProcesses_Button.Size = new System.Drawing.Size(390, 25);
            this.RefreshProcesses_Button.TabIndex = 20;
            this.RefreshProcesses_Button.TabStop = false;
            this.RefreshProcesses_Button.Text = "Refresh Process List";
            this.RefreshProcesses_Button.UseSelectable = true;
            this.RefreshProcesses_Button.UseVisualStyleBackColor = true;
            this.RefreshProcesses_Button.Click += new System.EventHandler(this.RefreshProcesses_Button_Click);
            // 
            // UnityFloatx32_Label
            // 
            this.UnityFloatx32_Label.Location = new System.Drawing.Point(8, 225);
            this.UnityFloatx32_Label.Name = "UnityFloatx32_Label";
            this.UnityFloatx32_Label.Size = new System.Drawing.Size(96, 25);
            this.UnityFloatx32_Label.TabIndex = 8;
            this.UnityFloatx32_Label.Text = "Unity Float 32";
            this.UnityFloatx32_Label.DoubleClick += new System.EventHandler(this.CopyText);
            // 
            // IEEEx64_Label
            // 
            this.IEEEx64_Label.Location = new System.Drawing.Point(8, 194);
            this.IEEEx64_Label.Name = "IEEEx64_Label";
            this.IEEEx64_Label.Size = new System.Drawing.Size(96, 25);
            this.IEEEx64_Label.TabIndex = 7;
            this.IEEEx64_Label.Text = "IEEE 64bit";
            this.IEEEx64_Label.DoubleClick += new System.EventHandler(this.CopyText);
            // 
            // IEEEx32_Label
            // 
            this.IEEEx32_Label.Location = new System.Drawing.Point(8, 163);
            this.IEEEx32_Label.Name = "IEEEx32_Label";
            this.IEEEx32_Label.Size = new System.Drawing.Size(96, 25);
            this.IEEEx32_Label.TabIndex = 6;
            this.IEEEx32_Label.Text = "IEEE 32bit";
            this.IEEEx32_Label.DoubleClick += new System.EventHandler(this.CopyText);
            // 
            // U30_Label
            // 
            this.U30_Label.Location = new System.Drawing.Point(8, 132);
            this.U30_Label.Name = "U30_Label";
            this.U30_Label.Size = new System.Drawing.Size(96, 25);
            this.U30_Label.TabIndex = 5;
            this.U30_Label.Text = "u30";
            this.U30_Label.DoubleClick += new System.EventHandler(this.CopyText);
            // 
            // Hex_Label
            // 
            this.Hex_Label.Location = new System.Drawing.Point(8, 101);
            this.Hex_Label.Name = "Hex_Label";
            this.Hex_Label.Size = new System.Drawing.Size(96, 25);
            this.Hex_Label.TabIndex = 4;
            this.Hex_Label.Text = "0x16";
            this.Hex_Label.DoubleClick += new System.EventHandler(this.CopyText);
            // 
            // _4byte_x8_p6_Label
            // 
            this._4byte_x8_p6_Label.Location = new System.Drawing.Point(8, 70);
            this._4byte_x8_p6_Label.Name = "_4byte_x8_p6_Label";
            this._4byte_x8_p6_Label.Size = new System.Drawing.Size(96, 25);
            this._4byte_x8_p6_Label.TabIndex = 3;
            this._4byte_x8_p6_Label.Text = "4 Byte *8 + 6";
            this._4byte_x8_p6_Label.DoubleClick += new System.EventHandler(this.CopyText);
            // 
            // _4bytex8_Label
            // 
            this._4bytex8_Label.Location = new System.Drawing.Point(8, 39);
            this._4bytex8_Label.Name = "_4bytex8_Label";
            this._4bytex8_Label.Size = new System.Drawing.Size(96, 25);
            this._4bytex8_Label.TabIndex = 2;
            this._4bytex8_Label.Text = "4 Byte *8";
            this._4bytex8_Label.DoubleClick += new System.EventHandler(this.CopyText);
            // 
            // _4byte_Label
            // 
            this._4byte_Label.Location = new System.Drawing.Point(8, 8);
            this._4byte_Label.Name = "_4byte_Label";
            this._4byte_Label.Size = new System.Drawing.Size(96, 25);
            this._4byte_Label.TabIndex = 1;
            this._4byte_Label.Text = "4 Byte";
            this._4byte_Label.DoubleClick += new System.EventHandler(this.CopyText);
            // 
            // Converter_UnityFloatx32_TextBox
            // 
            // 
            // 
            // 
            this.Converter_UnityFloatx32_TextBox.CustomButton.Image = null;
            this.Converter_UnityFloatx32_TextBox.CustomButton.Location = new System.Drawing.Point(112, 1);
            this.Converter_UnityFloatx32_TextBox.CustomButton.Name = "";
            this.Converter_UnityFloatx32_TextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.Converter_UnityFloatx32_TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Converter_UnityFloatx32_TextBox.CustomButton.TabIndex = 1;
            this.Converter_UnityFloatx32_TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Converter_UnityFloatx32_TextBox.CustomButton.UseSelectable = true;
            this.Converter_UnityFloatx32_TextBox.CustomButton.Visible = false;
            this.Converter_UnityFloatx32_TextBox.Lines = new string[0];
            this.Converter_UnityFloatx32_TextBox.Location = new System.Drawing.Point(110, 225);
            this.Converter_UnityFloatx32_TextBox.MaxLength = 32767;
            this.Converter_UnityFloatx32_TextBox.Name = "Converter_UnityFloatx32_TextBox";
            this.Converter_UnityFloatx32_TextBox.PasswordChar = '\0';
            this.Converter_UnityFloatx32_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Converter_UnityFloatx32_TextBox.SelectedText = "";
            this.Converter_UnityFloatx32_TextBox.SelectionLength = 0;
            this.Converter_UnityFloatx32_TextBox.SelectionStart = 0;
            this.Converter_UnityFloatx32_TextBox.ShortcutsEnabled = true;
            this.Converter_UnityFloatx32_TextBox.Size = new System.Drawing.Size(136, 25);
            this.Converter_UnityFloatx32_TextBox.TabIndex = 8;
            this.Converter_UnityFloatx32_TextBox.TabStop = false;
            this.Converter_UnityFloatx32_TextBox.UseSelectable = true;
            this.Converter_UnityFloatx32_TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Converter_UnityFloatx32_TextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Converter_Ieeex64_TextBox
            // 
            // 
            // 
            // 
            this.Converter_Ieeex64_TextBox.CustomButton.Image = null;
            this.Converter_Ieeex64_TextBox.CustomButton.Location = new System.Drawing.Point(112, 1);
            this.Converter_Ieeex64_TextBox.CustomButton.Name = "";
            this.Converter_Ieeex64_TextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.Converter_Ieeex64_TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Converter_Ieeex64_TextBox.CustomButton.TabIndex = 1;
            this.Converter_Ieeex64_TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Converter_Ieeex64_TextBox.CustomButton.UseSelectable = true;
            this.Converter_Ieeex64_TextBox.CustomButton.Visible = false;
            this.Converter_Ieeex64_TextBox.Lines = new string[0];
            this.Converter_Ieeex64_TextBox.Location = new System.Drawing.Point(110, 194);
            this.Converter_Ieeex64_TextBox.MaxLength = 32767;
            this.Converter_Ieeex64_TextBox.Name = "Converter_Ieeex64_TextBox";
            this.Converter_Ieeex64_TextBox.PasswordChar = '\0';
            this.Converter_Ieeex64_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Converter_Ieeex64_TextBox.SelectedText = "";
            this.Converter_Ieeex64_TextBox.SelectionLength = 0;
            this.Converter_Ieeex64_TextBox.SelectionStart = 0;
            this.Converter_Ieeex64_TextBox.ShortcutsEnabled = true;
            this.Converter_Ieeex64_TextBox.Size = new System.Drawing.Size(136, 25);
            this.Converter_Ieeex64_TextBox.TabIndex = 7;
            this.Converter_Ieeex64_TextBox.TabStop = false;
            this.Converter_Ieeex64_TextBox.UseSelectable = true;
            this.Converter_Ieeex64_TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Converter_Ieeex64_TextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Converter_Ieeex32_TextBox
            // 
            // 
            // 
            // 
            this.Converter_Ieeex32_TextBox.CustomButton.Image = null;
            this.Converter_Ieeex32_TextBox.CustomButton.Location = new System.Drawing.Point(112, 1);
            this.Converter_Ieeex32_TextBox.CustomButton.Name = "";
            this.Converter_Ieeex32_TextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.Converter_Ieeex32_TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Converter_Ieeex32_TextBox.CustomButton.TabIndex = 1;
            this.Converter_Ieeex32_TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Converter_Ieeex32_TextBox.CustomButton.UseSelectable = true;
            this.Converter_Ieeex32_TextBox.CustomButton.Visible = false;
            this.Converter_Ieeex32_TextBox.Lines = new string[0];
            this.Converter_Ieeex32_TextBox.Location = new System.Drawing.Point(110, 163);
            this.Converter_Ieeex32_TextBox.MaxLength = 32767;
            this.Converter_Ieeex32_TextBox.Name = "Converter_Ieeex32_TextBox";
            this.Converter_Ieeex32_TextBox.PasswordChar = '\0';
            this.Converter_Ieeex32_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Converter_Ieeex32_TextBox.SelectedText = "";
            this.Converter_Ieeex32_TextBox.SelectionLength = 0;
            this.Converter_Ieeex32_TextBox.SelectionStart = 0;
            this.Converter_Ieeex32_TextBox.ShortcutsEnabled = true;
            this.Converter_Ieeex32_TextBox.Size = new System.Drawing.Size(136, 25);
            this.Converter_Ieeex32_TextBox.TabIndex = 6;
            this.Converter_Ieeex32_TextBox.TabStop = false;
            this.Converter_Ieeex32_TextBox.UseSelectable = true;
            this.Converter_Ieeex32_TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Converter_Ieeex32_TextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Converter_U30_TextBox
            // 
            // 
            // 
            // 
            this.Converter_U30_TextBox.CustomButton.Image = null;
            this.Converter_U30_TextBox.CustomButton.Location = new System.Drawing.Point(112, 1);
            this.Converter_U30_TextBox.CustomButton.Name = "";
            this.Converter_U30_TextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.Converter_U30_TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Converter_U30_TextBox.CustomButton.TabIndex = 1;
            this.Converter_U30_TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Converter_U30_TextBox.CustomButton.UseSelectable = true;
            this.Converter_U30_TextBox.CustomButton.Visible = false;
            this.Converter_U30_TextBox.Lines = new string[0];
            this.Converter_U30_TextBox.Location = new System.Drawing.Point(110, 132);
            this.Converter_U30_TextBox.MaxLength = 32767;
            this.Converter_U30_TextBox.Name = "Converter_U30_TextBox";
            this.Converter_U30_TextBox.PasswordChar = '\0';
            this.Converter_U30_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Converter_U30_TextBox.SelectedText = "";
            this.Converter_U30_TextBox.SelectionLength = 0;
            this.Converter_U30_TextBox.SelectionStart = 0;
            this.Converter_U30_TextBox.ShortcutsEnabled = true;
            this.Converter_U30_TextBox.Size = new System.Drawing.Size(136, 25);
            this.Converter_U30_TextBox.TabIndex = 5;
            this.Converter_U30_TextBox.TabStop = false;
            this.Converter_U30_TextBox.UseSelectable = true;
            this.Converter_U30_TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Converter_U30_TextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Converter_Hex_TextBox
            // 
            // 
            // 
            // 
            this.Converter_Hex_TextBox.CustomButton.Image = null;
            this.Converter_Hex_TextBox.CustomButton.Location = new System.Drawing.Point(112, 1);
            this.Converter_Hex_TextBox.CustomButton.Name = "";
            this.Converter_Hex_TextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.Converter_Hex_TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Converter_Hex_TextBox.CustomButton.TabIndex = 1;
            this.Converter_Hex_TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Converter_Hex_TextBox.CustomButton.UseSelectable = true;
            this.Converter_Hex_TextBox.CustomButton.Visible = false;
            this.Converter_Hex_TextBox.Lines = new string[0];
            this.Converter_Hex_TextBox.Location = new System.Drawing.Point(110, 101);
            this.Converter_Hex_TextBox.MaxLength = 32767;
            this.Converter_Hex_TextBox.Name = "Converter_Hex_TextBox";
            this.Converter_Hex_TextBox.PasswordChar = '\0';
            this.Converter_Hex_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Converter_Hex_TextBox.SelectedText = "";
            this.Converter_Hex_TextBox.SelectionLength = 0;
            this.Converter_Hex_TextBox.SelectionStart = 0;
            this.Converter_Hex_TextBox.ShortcutsEnabled = true;
            this.Converter_Hex_TextBox.Size = new System.Drawing.Size(136, 25);
            this.Converter_Hex_TextBox.TabIndex = 4;
            this.Converter_Hex_TextBox.TabStop = false;
            this.Converter_Hex_TextBox.UseSelectable = true;
            this.Converter_Hex_TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Converter_Hex_TextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Converter_FourBytex8p6_TextBox
            // 
            // 
            // 
            // 
            this.Converter_FourBytex8p6_TextBox.CustomButton.Image = null;
            this.Converter_FourBytex8p6_TextBox.CustomButton.Location = new System.Drawing.Point(112, 1);
            this.Converter_FourBytex8p6_TextBox.CustomButton.Name = "";
            this.Converter_FourBytex8p6_TextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.Converter_FourBytex8p6_TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Converter_FourBytex8p6_TextBox.CustomButton.TabIndex = 1;
            this.Converter_FourBytex8p6_TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Converter_FourBytex8p6_TextBox.CustomButton.UseSelectable = true;
            this.Converter_FourBytex8p6_TextBox.CustomButton.Visible = false;
            this.Converter_FourBytex8p6_TextBox.Lines = new string[0];
            this.Converter_FourBytex8p6_TextBox.Location = new System.Drawing.Point(110, 70);
            this.Converter_FourBytex8p6_TextBox.MaxLength = 32767;
            this.Converter_FourBytex8p6_TextBox.Name = "Converter_FourBytex8p6_TextBox";
            this.Converter_FourBytex8p6_TextBox.PasswordChar = '\0';
            this.Converter_FourBytex8p6_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Converter_FourBytex8p6_TextBox.SelectedText = "";
            this.Converter_FourBytex8p6_TextBox.SelectionLength = 0;
            this.Converter_FourBytex8p6_TextBox.SelectionStart = 0;
            this.Converter_FourBytex8p6_TextBox.ShortcutsEnabled = true;
            this.Converter_FourBytex8p6_TextBox.Size = new System.Drawing.Size(136, 25);
            this.Converter_FourBytex8p6_TextBox.TabIndex = 3;
            this.Converter_FourBytex8p6_TextBox.TabStop = false;
            this.Converter_FourBytex8p6_TextBox.UseSelectable = true;
            this.Converter_FourBytex8p6_TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Converter_FourBytex8p6_TextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Converter_FourBytex8_TextBox
            // 
            // 
            // 
            // 
            this.Converter_FourBytex8_TextBox.CustomButton.Image = null;
            this.Converter_FourBytex8_TextBox.CustomButton.Location = new System.Drawing.Point(112, 1);
            this.Converter_FourBytex8_TextBox.CustomButton.Name = "";
            this.Converter_FourBytex8_TextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.Converter_FourBytex8_TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Converter_FourBytex8_TextBox.CustomButton.TabIndex = 1;
            this.Converter_FourBytex8_TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Converter_FourBytex8_TextBox.CustomButton.UseSelectable = true;
            this.Converter_FourBytex8_TextBox.CustomButton.Visible = false;
            this.Converter_FourBytex8_TextBox.Lines = new string[0];
            this.Converter_FourBytex8_TextBox.Location = new System.Drawing.Point(110, 39);
            this.Converter_FourBytex8_TextBox.MaxLength = 32767;
            this.Converter_FourBytex8_TextBox.Name = "Converter_FourBytex8_TextBox";
            this.Converter_FourBytex8_TextBox.PasswordChar = '\0';
            this.Converter_FourBytex8_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Converter_FourBytex8_TextBox.SelectedText = "";
            this.Converter_FourBytex8_TextBox.SelectionLength = 0;
            this.Converter_FourBytex8_TextBox.SelectionStart = 0;
            this.Converter_FourBytex8_TextBox.ShortcutsEnabled = true;
            this.Converter_FourBytex8_TextBox.Size = new System.Drawing.Size(136, 25);
            this.Converter_FourBytex8_TextBox.TabIndex = 2;
            this.Converter_FourBytex8_TextBox.TabStop = false;
            this.Converter_FourBytex8_TextBox.UseSelectable = true;
            this.Converter_FourBytex8_TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Converter_FourBytex8_TextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Converter_FourByte_TextBox
            // 
            // 
            // 
            // 
            this.Converter_FourByte_TextBox.CustomButton.Image = null;
            this.Converter_FourByte_TextBox.CustomButton.Location = new System.Drawing.Point(112, 1);
            this.Converter_FourByte_TextBox.CustomButton.Name = "";
            this.Converter_FourByte_TextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.Converter_FourByte_TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Converter_FourByte_TextBox.CustomButton.TabIndex = 1;
            this.Converter_FourByte_TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Converter_FourByte_TextBox.CustomButton.UseSelectable = true;
            this.Converter_FourByte_TextBox.CustomButton.Visible = false;
            this.Converter_FourByte_TextBox.Lines = new string[0];
            this.Converter_FourByte_TextBox.Location = new System.Drawing.Point(110, 8);
            this.Converter_FourByte_TextBox.MaxLength = 32767;
            this.Converter_FourByte_TextBox.Name = "Converter_FourByte_TextBox";
            this.Converter_FourByte_TextBox.PasswordChar = '\0';
            this.Converter_FourByte_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Converter_FourByte_TextBox.SelectedText = "";
            this.Converter_FourByte_TextBox.SelectionLength = 0;
            this.Converter_FourByte_TextBox.SelectionStart = 0;
            this.Converter_FourByte_TextBox.ShortcutsEnabled = true;
            this.Converter_FourByte_TextBox.Size = new System.Drawing.Size(136, 25);
            this.Converter_FourByte_TextBox.TabIndex = 1;
            this.Converter_FourByte_TextBox.TabStop = false;
            this.Converter_FourByte_TextBox.UseSelectable = true;
            this.Converter_FourByte_TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Converter_FourByte_TextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ByteConverter_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Copy_Label);
            this.Controls.Add(this.RefreshProcesses_Button);
            this.Controls.Add(this.ProcessList_GridView);
            this.Controls.Add(this.UnityFloatx32_Label);
            this.Controls.Add(this.IEEEx64_Label);
            this.Controls.Add(this.IEEEx32_Label);
            this.Controls.Add(this.U30_Label);
            this.Controls.Add(this.Hex_Label);
            this.Controls.Add(this._4byte_x8_p6_Label);
            this.Controls.Add(this._4bytex8_Label);
            this.Controls.Add(this._4byte_Label);
            this.Controls.Add(this.Converter_UnityFloatx32_TextBox);
            this.Controls.Add(this.Converter_Ieeex64_TextBox);
            this.Controls.Add(this.Converter_Ieeex32_TextBox);
            this.Controls.Add(this.Converter_U30_TextBox);
            this.Controls.Add(this.Converter_Hex_TextBox);
            this.Controls.Add(this.Converter_FourBytex8p6_TextBox);
            this.Controls.Add(this.Converter_FourBytex8_TextBox);
            this.Controls.Add(this.Converter_FourByte_TextBox);
            this.Name = "ByteConverter_UC";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(650, 315);
            ((System.ComponentModel.ISupportInitialize)(this.ProcessList_GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox Converter_UnityFloatx32_TextBox;
        private MetroFramework.Controls.MetroTextBox Converter_Ieeex64_TextBox;
        private MetroFramework.Controls.MetroTextBox Converter_Ieeex32_TextBox;
        private MetroFramework.Controls.MetroTextBox Converter_U30_TextBox;
        private MetroFramework.Controls.MetroTextBox Converter_Hex_TextBox;
        private MetroFramework.Controls.MetroTextBox Converter_FourBytex8p6_TextBox;
        private MetroFramework.Controls.MetroTextBox Converter_FourBytex8_TextBox;
        private MetroFramework.Controls.MetroTextBox Converter_FourByte_TextBox;
        private MetroFramework.Controls.MetroLabel _4byte_Label;
        private MetroFramework.Controls.MetroLabel _4bytex8_Label;
        private MetroFramework.Controls.MetroLabel _4byte_x8_p6_Label;
        private MetroFramework.Controls.MetroLabel Hex_Label;
        private MetroFramework.Controls.MetroLabel U30_Label;
        private MetroFramework.Controls.MetroLabel IEEEx32_Label;
        private MetroFramework.Controls.MetroLabel IEEEx64_Label;
        private MetroFramework.Controls.MetroLabel UnityFloatx32_Label;
        private System.Windows.Forms.DataGridView ProcessList_GridView;
        private MetroFramework.Controls.MetroButton RefreshProcesses_Button;
        private System.Windows.Forms.DataGridViewTextBoxColumn Processes;
        private System.Windows.Forms.DataGridViewTextBoxColumn SystemPID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEPID_dataGridView;
        private MetroFramework.Controls.MetroLabel Copy_Label;
    }
}
