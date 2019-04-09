using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using static Helpers;
using static WarCommanderDecodeStrings;

namespace Cheat_Engine_Tools.Forms
{
    public partial class WCStringDecode_UC : UserControl
    {
        private static List<byte[]> binaryDatas = new List<byte[]>();

        private static List<string[]> binHolder = new List<string[]>();

        private static List<string[]> filePath = new List<string[]>();

        private static string ScriptFolderPath;

        private static string BinFolderPath;

        private int ProgressBarCount = 0;

        public WCStringDecode_UC() => InitializeComponent();

        private void WCDecodeProgressBar_timer_Tick(object sender, EventArgs e) => Decode_ProgressBar.Value = ProgressBarCount;

        private void ClearLog_Button_Click(object sender, EventArgs e) => Log_TextBox.Text = "";

        private void Log(string message, MessageType messageType = MessageType.INFO)
        {
            if (Log_TextBox.InvokeRequired)
            { Log_TextBox.Invoke(new MethodInvoker(delegate { Log_TextBox.Text += $"[{messageType}] {message} {Environment.NewLine}"; })); }
            else
            { Log_TextBox.Text += $"[{messageType}] {message} {Environment.NewLine}"; }
        }

        private void BinFolder_Button_Click(object sender, EventArgs e)
        {
            if (WCDecode_folderBrowserDialog.ShowDialog() == DialogResult.OK)
            { BinFolderPath = WCDecode_folderBrowserDialog.SelectedPath; }
            BinFolder_Label.Text = BinFolderPath;
        }

        private void ScriptsFolder_Button_Click(object sender, EventArgs e)
        {
            if (WCDecode_folderBrowserDialog.ShowDialog() == DialogResult.OK)
            { ScriptFolderPath = WCDecode_folderBrowserDialog.SelectedPath; }
            ScriptsFolder_Label.Text = ScriptFolderPath;
        }

        private void Start_Button_Click(object sender, EventArgs e)
        {
            if (!BinErrorCheck() && !ScriptsErrorCheck())
            {
                Decode_ProgressBar.Value = 0;
                Decode_ProgressBar.Maximum = filePath[0].Length;
                WCDecodeProgressBar_timer.Enabled = true;
                WCDecodeProgressBar_timer.Start();
                Log_TextBox.Text = "";
                Thread Decode_Thread = new Thread(new ThreadStart(DecodeStrings));
                Decode_Thread.Start();
            }
        }

        private bool BinErrorCheck()
        {
            bool error = true;
            binHolder.Clear();
            binaryDatas.Clear();
            if (Directory.Exists(BinFolderPath))
            {
                binHolder.Add(Directory.GetFiles(BinFolderPath, "*.bin"));
                foreach (string[] bins in binHolder)
                {
                    if (bins.Length == 3)
                    {
                        foreach (string[] binfiles in binHolder)
                            for (int i = 0; i < binfiles.Length; i++)
                            {
                                binaryDatas.Add(File.ReadAllBytes(binfiles[i]));
                                Log($"{binfiles[i]} - FOUND");
                            }
                        error = false;
                    }
                    else if (bins.Length > 3)
                    { Log($"Was looking for 3 bin files, but found '{bins.Length}'", MessageType.ERROR); }
                    else if (bins.Length < 3)
                    { Log($"Could only find '{bins.Length}' of the 3 bin files.", MessageType.ERROR); }
                }
            }
            else
            { Log($"No BIN path detected", MessageType.ERROR); }
            return error;
        }

        private bool ScriptsErrorCheck()
        {
            bool error = true;
            filePath.Clear();
            if (Directory.Exists(ScriptFolderPath))
            {
                filePath.Add(Directory.GetFiles(ScriptFolderPath, "*.as*", SearchOption.AllDirectories));
                Log($"Found {filePath[0].Length} Script Files.");
                error = false;
            }
            else
            { Log($"No Scripts path detected", MessageType.ERROR); }
            return error;

        }

        private void DecodeStrings()
        {
            ProgressBarCount = 0;
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            int fileCount = 0;
            foreach (string[] path in filePath)
            {
                for (int i = 0; i < path.Length; i++)
                {
                    ProgressBarCount = i;
                    string originalText = File.ReadAllText(path[i]);
                    string regexPattern = @"\(-([0-9]\d{9})\)";
                    Match match = Regex.Match(originalText, regexPattern);
                    if (match.Success)
                    {
                        try
                        {
                            string result = Regex.Replace(originalText, regexPattern, m =>
                            {
                                int value = -(Convert.ToInt32(m.Groups[1].Value));
                                return WrapperLeft_TextBox.Text + Class_2.GetDefinitionName(value, binaryDatas) + WrapperRight_TextBox.Text;
                            });
                            File.WriteAllText(path[i].Remove(path[i].Length - 3) + "___DECODED.as", result);
                            fileCount++;
                        }
                        catch { Log("Something went wrong... Hmmmmm.... Im to lazy to set up a trace so figure it out yourself ;)", MessageType.ERROR); }
                    }
                }
            }
            WCDecodeProgressBar_timer.Stop();
            stopwatch.Stop();
            Log($"{fileCount} - Files Decoded in '{stopwatch.Elapsed.Seconds}'seconds");
            ShakeMe("Finsihed", MessageType.INFO, MessageBoxButtons.OK, MessageBoxIcon.Information);
            Decode_ProgressBar.Invoke(new MethodInvoker(delegate { Decode_ProgressBar.Value = 0; }));
        }
    }
}
