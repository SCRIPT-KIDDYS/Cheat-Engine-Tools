using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using static Helpers;

namespace Cheat_Engine_Tools.Forms
{
    public partial class CEVersion_UC : UserControl
	{
		string[] CEStrings = new string[10];

		int CEStringsNum = 0;

        public CEVersion_UC() => InitializeComponent();

        private void OpenCE(object sender, EventArgs e)
		{
            if (CEVersion_ComboBox.SelectedIndex == -1)
            { ShakeMe("Select CE from drop down first.", MessageType.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error, true); }
            else
            {
                if ((sender as Button).Text.Contains("32"))
                { Process.Start(CEVersion_Label.Text + "cheatengine-i386.exe"); }
                else
                { Process.Start(CEVersion_Label.Text + "Cheat Engine.exe"); }
            }
		}

		private void CEVersion_UC_Load(object sender, EventArgs e)
		{
            using (RegistryKey Key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall"))
				foreach (string SubKeyName in Key.GetSubKeyNames())
					using (RegistryKey SubKey = Key.OpenSubKey(SubKeyName))
						if (SubKeyName.Contains("Cheat"))
						{
							CEStrings[CEStringsNum] = SubKey.GetValue("DisplayName").ToString();
							CEVersion_ComboBox.Items.Add(CEStrings[CEStringsNum]);
							CEStringsNum++;
							CEStrings[CEStringsNum] = SubKey.GetValue("InstallLocation").ToString();
							CEStringsNum++;
						}
		}

		private void CEVersion_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
            if (CEVersion_ComboBox.SelectedIndex == 0)
            { CEVersion_Label.Text = CEStrings[CEVersion_ComboBox.SelectedIndex + 1]; }
            else
            { CEVersion_Label.Text = CEStrings[CEVersion_ComboBox.SelectedIndex + 2]; }
		}
	}
}
