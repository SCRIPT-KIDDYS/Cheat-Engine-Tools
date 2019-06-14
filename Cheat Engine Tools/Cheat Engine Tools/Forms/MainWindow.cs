using MetroFramework.Forms;
using Cheat_Engine_Tools.Forms;
using System;

namespace Cheat_Engine_Tools
{
    public partial class MainWindow : MetroForm
    {
        private static Welcome_UC Welcome = new Welcome_UC();
        private static AOBPatternFinder_UC AOBPatternFinder = new AOBPatternFinder_UC();
        private static ByteConverter_UC ByteConverter = new ByteConverter_UC();
        private static CEDecompiler_UC CEDecompiler = new CEDecompiler_UC();
        private static CEVersion_UC CEVersion = new CEVersion_UC();
        private static DLLInjector_UC DLLInjector = new DLLInjector_UC();
        private static Links_UC Links = new Links_UC();
        private static ComingSoon_UC ComingSoon = new ComingSoon_UC();
        private static WCStringDecode_UC WCStringDecode = new WCStringDecode_UC();
        private static About_UC About = new About_UC();
        private static WCSWFDumper_UC WCSWFDumper = new WCSWFDumper_UC();

        public MainWindow()
        {
            InitializeComponent();
            MainWindowPanel.Controls.Add(Welcome);
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            MainWindowPanel.Controls.Clear();
            switch (sender.ToString())
            {
                case "Welcome":
                    MainWindowPanel.Controls.Add(Welcome);
                    break;
                case "Converters":
                    MainWindowPanel.Controls.Add(ByteConverter);
                    break;
                case "Decompiler":
                    MainWindowPanel.Controls.Add(CEDecompiler);
                    break;
                case "CE Version":
                    MainWindowPanel.Controls.Add(CEVersion);
                    break;
                case "Links":
                    MainWindowPanel.Controls.Add(Links);
                    break;
                case "DLL Injector":
                    MainWindowPanel.Controls.Add(DLLInjector);
                    break;
                case "AOB Pattern Finder":
                    MainWindowPanel.Controls.Add(AOBPatternFinder);
                    break;
                case "WarCommander String Decoder":
                    MainWindowPanel.Controls.Add(WCStringDecode);
                    break;
                case "WarCommander SWF Dumper":
                    MainWindowPanel.Controls.Add(WCSWFDumper);
                    break;
                case "About":
                    MainWindowPanel.Controls.Add(About);
                    break;
                default:
                    MainWindowPanel.Controls.Add(ComingSoon);
                    break;

            }
        }
    }
}
