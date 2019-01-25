using System;
using System.Diagnostics;
using System.Windows.Forms;
using MetroFramework;

namespace Cheat_Engine_Tools.Forms
{
    public partial class DLLInjector_UC : UserControl
    {

        public DLLInjector_UC()
        {
            InitializeComponent();
            GetListOProcesses();
        }

        private void GetListOProcesses()
        {
            Process[] MyProcess = Process.GetProcesses();
            Array.Sort(MyProcess, (x, y) => String.Compare(x.ToString(), y.ToString()));
            for (int i = 0; i < MyProcess.Length; i++)
                ProcessList_metroComboBox.Items.Add(MyProcess[i].ProcessName);
        }

        private void RefreshProcessList_metroButton_Click(object sender, EventArgs e)
        {
            ProcessList_metroComboBox.Items.Clear();
            GetListOProcesses();
        }

        private void InjectDLL_metroButton_Click(object sender, EventArgs e)
        {
            if (ProcessList_metroComboBox.SelectedIndex > -1)
            {
                string processname = ProcessList_metroComboBox.SelectedItem.ToString();

                OpenFileDialog OpenFile = new OpenFileDialog();
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string dllfile = openFileDialog1.FileName;
                    DllInjector DLLInjector = new DllInjector();
                    DLLInjector.GetInstance.Inject(processname, dllfile);
                }
                else { MetroMessageBox.Show(this, "No DLL Injected", "Canceled",MessageBoxButtons.OK, MessageBoxIcon.Warning, Height / 2); }
            }
            else
                MetroMessageBox.Show(this, "Select a process", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, Height / 2);
        }
    }
}
