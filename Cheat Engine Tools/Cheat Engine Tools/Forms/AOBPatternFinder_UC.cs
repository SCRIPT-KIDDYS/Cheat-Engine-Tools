using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MetroFramework.Controls;

namespace Cheat_Engine_Tools.Forms
{
	public partial class AOBPatternFinder_UC : UserControl
	{

		private readonly List<char> whitelist = new List<char>() { '?', '*' };

		private List<string> AOBs = new List<string>();


		public AOBPatternFinder_UC()
		{
			InitializeComponent();
		}

		private bool OnWhitelist(char c)
		{
			return whitelist.Contains(c);
		}

		private string ReplaceAt(string input, int index, char newChar)
		{
			StringBuilder builder = new StringBuilder(input);
			builder[index] = newChar;
			return builder.ToString();
		}
		private void WildcardString(ref string original, string other)
		{
			for (int i = 0; i < original.Length; i++)
				try
				{
					char originalChar = Convert.ToChar(original.Substring(i, 1));
					char otherChar = Convert.ToChar(other.Substring(i, 1));

					if (!OnWhitelist(originalChar))
						if (originalChar != otherChar)
							original = ReplaceAt(original, i, '?');
				}
				catch
				{ continue; }
		}

		private void GenerateAOB()
		{
			AOBs.Clear();
			AOBs.Add(metroTextBox1.Text);
			AOBs.Add(metroTextBox2.Text);
			AOBs.Add(metroTextBox3.Text);
			AOBs.Add(metroTextBox4.Text);
			AOBs.Add(metroTextBox5.Text);

			string wildcard = AOBs[0];

			foreach (string AOB in AOBs)
				WildcardString(ref wildcard, AOB);

			metroTextBox6.Text = wildcard;
		}

		private void MetroButton1_Click_1(object sender, EventArgs e)
		{
			GenerateAOB();
		}

		private void MetroButton2_Click(object sender, EventArgs e)
		{
			foreach (Control x in this.Controls)
				if (x is MetroTextBox)
				{
					string lala = Regex.Replace(x.Text, @" ", "");
					string lala2 = Regex.Replace(lala, ".{2}", "$0 ");
					x.Text = lala2.Trim();
				}

			Length_Gen();
		}

		private void Length_Gen()
		{
			metroLabel1.Text = (metroTextBox1.Text.Length - SpaceCount(metroTextBox1.Text)) / 2 + " bytes";
			metroLabel2.Text = (metroTextBox2.Text.Length - SpaceCount(metroTextBox2.Text)) / 2 + " bytes";
			metroLabel3.Text = (metroTextBox3.Text.Length - SpaceCount(metroTextBox3.Text)) / 2 + " bytes";
			metroLabel4.Text = (metroTextBox4.Text.Length - SpaceCount(metroTextBox4.Text)) / 2 + " bytes";
			metroLabel5.Text = (metroTextBox5.Text.Length - SpaceCount(metroTextBox5.Text)) / 2 + " bytes";
		}

		private static int SpaceCount(string str)
		{
			int spcctr = 0;
			string str1;
			for (int i = 0; i < str.Length; i++)
			{
				str1 = str.Substring(i, 1);
				if (str1 == " ")
					spcctr++;
			}
			return spcctr;
		}
	}
}
