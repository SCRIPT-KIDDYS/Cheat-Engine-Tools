using System;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using System.Threading;
using System.IO;

namespace Cheat_Engine_Tools.Forms
{
    public partial class FreeHacks_UC : UserControl
    {

        public FreeHacks_UC()
        {
            InitializeComponent();
            //Thread IsWebsiteActive = new Thread(CheckWebAddress);
            //IsWebsiteActive.Start();

            ////  CTMT is OFFLINE at the moment. This section REMOVED!  ////
        }

        private void CheckWebAddress()
        {
            string TempText = null;
            String DownloadString = "http://cyberterminators.co/details-v2.xml";
            XmlDocument XDocument = new XmlDocument();
            try
            {
                XDocument.Load(DownloadString);
            }
            catch { return; }
            XmlElement Root = XDocument.DocumentElement;
            XmlNodeList Nodes = Root.SelectNodes("/megaT/HackList");

            foreach (XmlNode Node in Nodes)
                TempText = Node.InnerText.ToLower();

            foreach (string NameOfGame in TempText.Split(','))
            {
                if (Regex.Matches(NameOfGame, @"[a-zA-Z]").Count == 0) break;
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
			if (DownloadedString.Length <= 3)
                FreeHacks_Codes_TextBox.Text = "This is a manual hack";
			else
                FreeHacks_Codes_TextBox.Text = FreeHacksDecrypt.DecryptStuff(DownloadedString, GameName);

			FreeHacks_Codes_TextBox.Focus();
        }
    }
}
