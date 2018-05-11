using MetroFramework.Controls;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Cheat_Engine_Tools
{
    public partial class ByteConverter_UC : UserControl
    {
        public ByteConverter_UC()
        {
            InitializeComponent();
            ByteConverter Converter = new ByteConverter();
            Converter_FourByte_TextBox.DataBindings.Add("Text", Converter, "FourByte", false, DataSourceUpdateMode.OnPropertyChanged);
            Converter_FourBytex8_TextBox.DataBindings.Add("Text", Converter, "FourByte_x8", false, DataSourceUpdateMode.OnPropertyChanged);
            Converter_FourBytex8p6_TextBox.DataBindings.Add("Text", Converter, "FourByte_x8_p6", false, DataSourceUpdateMode.OnPropertyChanged);
            Converter_Hex_TextBox.DataBindings.Add("Text", Converter, "Hex", true, DataSourceUpdateMode.OnPropertyChanged, 0, "X");
            Converter_U30_TextBox.DataBindings.Add("Text", Converter, "U30", true, DataSourceUpdateMode.OnPropertyChanged, 0, "X");
            Converter_Ieeex32_TextBox.DataBindings.Add("Text", Converter, "Ieeex32", true, DataSourceUpdateMode.OnPropertyChanged, 0, "X");
            Converter_Ieeex64_TextBox.DataBindings.Add("Text", Converter, "Ieeex64", true, DataSourceUpdateMode.OnPropertyChanged, 0, "X");
            Converter_UnityFloatx32_TextBox.DataBindings.Add("Text", Converter, "UnityFloatx32", true, DataSourceUpdateMode.OnPropertyChanged, 1, "X");
            ProcessList_GridView.DefaultCellStyle.SelectionBackColor = ProcessList_GridView.DefaultCellStyle.BackColor;
            ProcessList_GridView.DefaultCellStyle.SelectionForeColor = ProcessList_GridView.DefaultCellStyle.ForeColor;
            GetListOProcesses();
        }

        private void GetListOProcesses()
        {
            Process[] MyProcess = Process.GetProcesses();
            Array.Sort(MyProcess, (x, y) => String.Compare(x.ToString(), y.ToString()));
            for (int i = 0; i < MyProcess.Length; i++)
            {
                int n = ProcessList_GridView.Rows.Add();
                ProcessList_GridView.Rows[n].Cells[0].Value = MyProcess[i].ProcessName;
                ProcessList_GridView.Rows[n].Cells[1].Value = MyProcess[i].Id;
                ProcessList_GridView.Rows[n].Cells[2].Value = MyProcess[i].Id.ToString("X");
            }
        }

        private void DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Clipboard.SetText(ProcessList_GridView[e.ColumnIndex, e.RowIndex].Value.ToString());
            MessageBox.Show(Clipboard.GetText() + " Copied to Clipboard.");
        }

        private void RefreshProcesses_Button_Click(object sender, EventArgs e)
        {
            ProcessList_GridView.Rows.Clear();
            GetListOProcesses();
            ProcessList_GridView.Focus();
        }

        private void CopyText(object sender, EventArgs e)
        {
            string Text = null;
            MetroLabel SelectedLabel = sender as MetroLabel;
            switch (SelectedLabel.TabIndex)
            {
                case 1:
                    Clipboard.SetText(Converter_FourByte_TextBox.Text);
                    Text = Converter_FourByte_TextBox.Text;
                    break;
                case 2:
                    Clipboard.SetText(Converter_FourBytex8_TextBox.Text);
                    Text = Converter_FourBytex8_TextBox.Text;
                    break;
                case 3:
                    Clipboard.SetText(Converter_FourBytex8p6_TextBox.Text);
                    Text = Converter_FourBytex8p6_TextBox.Text;
                    break;
                case 4:
                    Clipboard.SetText(Converter_Hex_TextBox.Text);
                    Text = Converter_Hex_TextBox.Text;
                    break;
                case 5:
                    Clipboard.SetText(Converter_U30_TextBox.Text);
                    Text = Converter_U30_TextBox.Text;
                    break;
                case 6:
                    Clipboard.SetText(Converter_Ieeex32_TextBox.Text);
                    Text = Converter_Ieeex32_TextBox.Text;
                    break;
                case 7:
                    Clipboard.SetText(Converter_Ieeex64_TextBox.Text);
                    Text = Converter_Ieeex64_TextBox.Text;
                    break;
                case 8:
                    Clipboard.SetText(Converter_UnityFloatx32_TextBox.Text);
                    Text = Converter_UnityFloatx32_TextBox.Text;
                    break;
            }
            MessageBox.Show(Text + " Copied to Clipboard.");
        }
    }
}
