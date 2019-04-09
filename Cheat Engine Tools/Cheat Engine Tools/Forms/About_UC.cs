using System;
using System.Windows.Forms;

namespace Cheat_Engine_Tools.Forms
{
    public partial class About_UC : UserControl
    {
        public About_UC()
        {
            InitializeComponent();
            metroTextBox1.Text = string.Join(Environment.NewLine,
                "This is a project made from boredom.",
                "If you find any issues or have any suggestions please let me know.",
                "",
                "## CHANGELOG ##",
                "> v1.0 <",
                "- Redesigned the main menu.",
                "- Removed 'Free Hacks' since CTMT shut down.",
                "- Added WarCommander String Decoder.",
                "- Added About UserControl.",
                "- Cleaned up TabStop items.",
                "",
                "",
                "> v0.1 <",
                "- Original Release.");
        }
    }
}
