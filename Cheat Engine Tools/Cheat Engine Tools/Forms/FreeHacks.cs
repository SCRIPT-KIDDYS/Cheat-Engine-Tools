﻿using System;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;

namespace Cheat_Engine_Tools.Forms
{
    public partial class FreeHacks : UserControl
    {
        public FreeHacks()
        {
            InitializeComponent();
            string TempText = null;
            String DownloadString = "http://cyberterminators.co/details.xml";
            XmlDocument XDocument = new XmlDocument();
            XDocument.Load(DownloadString);
            XmlElement Root = XDocument.DocumentElement;
            XmlNodeList Nodes = Root.SelectNodes("/megaT/HackList");

            foreach (XmlNode Node in Nodes)
                TempText = Node.InnerText.ToLower();

            foreach (string NameOfGame in TempText.Split(','))
            {
                if (Regex.Matches(NameOfGame, @"[a-zA-Z]").Count == 0)
                    break;

                else
                    FreeHacks_Games_ComboBox.Items.Add(NameOfGame.TrimStart('\n'));
            }
        }

        private void HackSelectedGame(object sender, EventArgs e)
        {
            string GameName = FreeHacks_Games_ComboBox.SelectedItem.ToString();
            string HTMLFormat = GameName.Replace(" ", "%20");
            WebClient Client = new WebClient();
            String DownloadedString = Client.DownloadString("http://www.cyberterminators.co/ctmt-v2/getDetails.php?gameName=" + HTMLFormat);
            FreeHacks_Codes_TextBox.Text = FreeHacksDecrypt.DecryptStuff(DownloadedString, GameName);
            FreeHacks_Codes_TextBox.Focus();
        }
    }
}
