using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Diagnostics;

namespace Cheat_Engine_Tools.Forms
{
	public partial class CEVersion_UC : UserControl
	{

		string[] CEStrings = new string[10];

		int CEStringsNum = 0;

		public CEVersion_UC()
		{
			InitializeComponent();
		}

		private void OpenCE(object sender, EventArgs e)
		{
			Button OS = sender as Button;
			if (CEVersion_metroComboBox.SelectedIndex == -1)
				MessageBox.Show("Select CE from drop down first.");
			else
				if (OS.Text.Contains("32"))
				Process.Start(CEVersion_metroLabel.Text + "cheatengine-i386.exe");
			else
				Process.Start(CEVersion_metroLabel.Text + "Cheat Engine.exe");
		}

		private void CEVersion_UC_Load(object sender, EventArgs e)
		{
			string RegistryKey = @"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall";
			using (RegistryKey Key = Registry.LocalMachine.OpenSubKey(RegistryKey))
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
