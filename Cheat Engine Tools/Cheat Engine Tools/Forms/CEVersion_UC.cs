using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Cheat_Engine_Tools.Forms
{
    public partial class CEVersion_UC : UserControl
	{
		string[] CEStrings = new string[10];

		int CEStringsNum = 0;

        public CEVersion_UC() => InitializeComponent();

        private void OpenCE(object sender, EventArgs e)
		{
            if (CEVersion_metroComboBox.SelectedIndex == -1)
                MessageBox.Show("Select CE from drop down first.");
            else
            {
                if ((sender as Button).Text.Contains("32"))
                    Process.Start(CEVersion_metroLabel.Text + "cheatengine-i386.exe");
                else
                    Process.Start(CEVersion_metroLabel.Text + "Cheat Engine.exe");
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
							CEVersion_metroComboBox.Items.Add(CEStrings[CEStringsNum]);
							CEStringsNum++;
							CEStrings[CEStringsNum] = SubKey.GetValue("InstallLocation").ToString();
							CEStringsNum++;
						}
		}

		private void CEVersion_metroComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (CEVersion_metroComboBox.SelectedIndex == 0)
				CEVersion_metroLabel.Text = CEStrings[CEVersion_metroComboBox.SelectedIndex + 1];
			else
				CEVersion_metroLabel.Text = CEStrings[CEVersion_metroComboBox.SelectedIndex + 2];
		}
	}
}
