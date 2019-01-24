using MetroFramework.Controls;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Cheat_Engine_Tools.Forms
{
    public partial class Links_UC : UserControl
    {

        // ForceProjectX
        private string ForceProjectXYoutube = "https://www.youtube.com/user/ForceProjectX";
        private string ForceProjectXTwitch = "https://www.twitch.tv/forceprojectx";
        private string ForceProjectXGitHub = "https://github.com/forceprojectx";

        // Cheat The Game
        private string CTGFacebook = "https://www.facebook.com/groups/CheatTheGame";
        private string CTGWebsite = "http://cheatthegame.net";
        private string CTGDiscord = "https://discordapp.com/invite/ndn4pqs";
        private string CTGYoutube = "https://www.youtube.com/chrisfayte";

        // FearER
        private string FearEXGitHub = "https://github.com/FreeER";

        public Links_UC() => InitializeComponent();

        private void LinkGrabber(object sender, EventArgs e)
        {
            int NameToNumber = 0;
            MetroLink Info = sender as MetroLink;
            if (Info.Name.Contains("Force"))
                NameToNumber = 1;
            if (Info.Name.Contains("CTG"))
                NameToNumber = 2;
            if (Info.Name.Contains("Fear"))
                NameToNumber = 3;

            switch (NameToNumber)
            {
                case 1:
                    if (Info.Text.Contains("Youtube"))
                        Process.Start(ForceProjectXYoutube);
                    if (Info.Text.Contains("Twitch"))
                        Process.Start(ForceProjectXTwitch);
                    if (Info.Text.Contains("GitHub"))
                        Process.Start(ForceProjectXGitHub);
                    break;
                case 2:
                    if (Info.Text.Contains("Facebook"))
                        Process.Start(CTGFacebook);
                    if (Info.Text.Contains("Website"))
                        Process.Start(CTGWebsite);
                    if (Info.Text.Contains("Discord"))
                        Process.Start(CTGDiscord);
                    if (Info.Text.Contains("Youtube"))
                        Process.Start(CTGYoutube);
                    break;
                case 3:
                    if (Info.Text.Contains("GitHub"))
                        Process.Start(FearEXGitHub);
                    break;
            }
        }
    }
}
