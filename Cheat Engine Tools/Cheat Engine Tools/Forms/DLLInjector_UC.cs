using System;
using System.Diagnostics;
using System.Windows.Forms;
using static Helpers;

namespace Cheat_Engine_Tools.Forms
{
    public partial class DLLInjector_UC : UserControl
    {

        public DLLInjector_UC() => InitializeComponent();

        private void GetListOProcesses()
        {
            Process[] MyProcess = Process.GetProcesses();
            Array.Sort(MyProcess, (x, y) => String.Compare(x.ToString(), y.ToString()));
            for (int i = 0; i < MyProcess.Length; i++)
            { ProcessList_ComboBox.Items.Add(MyProcess[i].ProcessName); }
        }

        private void RefreshProcessList_metroButton_Click(object sender, EventArgs e)
        {
            ProcessList_ComboBox.Items.Clear();
            GetListOProcesses();
        }

        private void InjectDLL_metroButton_Click(object sender, EventArgs e)
        {
            if (ProcessList_ComboBox.SelectedIndex > -1)
            {
                string processname = ProcessList_ComboBox.SelectedItem.ToString();

                OpenFileDialog OpenFile = new OpenFileDialog();
                if (DLLInjector_openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string dllfile = DLLInjector_openFileDialog.FileName;
                    DllInjector DLLInjector = new DllInjector();
                    DLLInjector.GetInstance.Inject(processname, dllfile);
                }
                else
                { ShakeMe("No DLL Injected", MessageType.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Warning, true); }
            }
            else
            { ShakeMe("Select a process", MessageType.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Warning, true); }
        }
    }
}
