using MetroFramework.Forms;
using Cheat_Engine_Tools.Forms;
using System;

namespace Cheat_Engine_Tools
{
    public partial class MainWindow : MetroForm
    {
        public static Welcome_UC Welcome = new Welcome_UC();
        public static AOBPatternFinder_UC AOBPatternFinder = new AOBPatternFinder_UC();
        public static ByteConverter_UC ByteConverter = new ByteConverter_UC();
        public static CEDecompiler_UC CEDecompiler = new CEDecompiler_UC();
        public static CEVersion_UC CEVersion = new CEVersion_UC();
        public static DLLInjector_UC DLLInjector = new DLLInjector_UC();
        public static Links_UC Links = new Links_UC();
        public static ComingSoon_UC ComingSoon = new ComingSoon_UC();
        public static WCStringDecode_UC WCStringDecode = new WCStringDecode_UC();

        public MainWindow() => InitializeComponent();

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
                case "About":
                    MainWindowPanel.Controls.Add(ComingSoon);
                    break;
                default:
                    MainWindowPanel.Controls.Add(ComingSoon);
                    break;

            }
        }
    }
}
