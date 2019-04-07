using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Cheat_Engine_Tools.Forms
{
    public partial class AOBPatternFinder_UC : UserControl
	{
		private readonly List<char> Whitelist = new List<char>() { '?', '*', 'x', 'X' };

		private List<string> AOBs = new List<string>();

		private int JakeFromStateFarm = 0;

        public AOBPatternFinder_UC() => InitializeComponent();

        private bool OnWhitelist(char c) => Whitelist.Contains(c);

		private string ReplaceAt(string Input, int Index, char NewChar)
		{
			StringBuilder SB = new StringBuilder(Input);
			SB[Index] = NewChar;
			return SB.ToString();
		}

		private void WildcardString(ref string original, string other)
		{
			for (int i = 1; i < original.Length; i++)
				try
				{
					char originalChar = Convert.ToChar(original.Substring(i, 1));
					char otherChar = Convert.ToChar(other.Substring(i, 1));

                    if (!OnWhitelist(originalChar))
                        if (originalChar != otherChar)
                        { original = ReplaceAt(original, i, '?'); }
				}
                // TODO: startIndex error. Can not be larger. Look into later. 
                catch
                { Console.WriteLine("Hmmmmmm"); }
		}

		private void GenerateAOB(object sender, EventArgs e)
		{
			AOBs.Clear();
			AOBs.Add(AOB1_TextBox.Text);
			AOBs.Add(AOB2_TextBox.Text);
			AOBs.Add(AOB3_TextBox.Text);
			AOBs.Add(AOB4_TextBox.Text);
			AOBs.Add(AOB5_TextBox.Text);

			string wildcard = AOBs[0];

            foreach (string AOB in AOBs)
            { WildcardString(ref wildcard, AOB); }

			AOBResults_TextBox.Text = wildcard;
			IdiotProof();
		}

		private void FormatAOBs_Button_Click(object sender, EventArgs e)
		{
			foreach (Control TextBoxs in this.Controls)
				if (TextBoxs is MetroTextBox)
				{
					string RemoveSpaces = Regex.Replace(TextBoxs.Text, @" ", "");
					string AddSpaces = Regex.Replace(RemoveSpaces, ".{2}", "$0 ");
					TextBoxs.Text = AddSpaces.Trim();
				}

			AOB1Length_Label.Text = (AOB1_TextBox.Text.Length - SpaceCount(AOB1_TextBox.Text)) / 2 + " bytes";
			AOB2Length_Label.Text = (AOB2_TextBox.Text.Length - SpaceCount(AOB2_TextBox.Text)) / 2 + " bytes";
			AOB3Length_Label.Text = (AOB3_TextBox.Text.Length - SpaceCount(AOB3_TextBox.Text)) / 2 + " bytes";
			AOB4Length_Label.Text = (AOB4_TextBox.Text.Length - SpaceCount(AOB4_TextBox.Text)) / 2 + " bytes";
			AOB5Length_Label.Text = (AOB5_TextBox.Text.Length - SpaceCount(AOB5_TextBox.Text)) / 2 + " bytes";
			IdiotProof();
		}

		private static int SpaceCount(string str)
		{
			int spcctr = 0;
			string str1;
			for (int i = 0; i < str.Length; i++)
			{
				str1 = str.Substring(i, 1);
                if (str1 == " ")
                { spcctr++; }
			}
			return spcctr;
		}

		private void IdiotProof()
		{
			if (JakeFromStateFarm == 0)
			{
				Compare_Button.Enabled = true;
				FormatAOBs_Button.Enabled = false;
				JakeFromStateFarm = 1;
			}
			else
			{
				Compare_Button.Enabled = false;
				FormatAOBs_Button.Enabled = true;
				JakeFromStateFarm = 0;
			}
		}
	}
}
