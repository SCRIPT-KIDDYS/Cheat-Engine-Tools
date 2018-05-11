using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cheat_Engine_Tools.Forms
{
    public partial class CEDecompiler_UC : UserControl
    {
        public CEDecompiler_UC()
        {
            InitializeComponent();
        }

        void CEDecompiler_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void CEDecompiler_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
                if (Path.GetFileName(file).ToLower().Contains(".cetrainer") == true)
                    if (CEDecompile.DecryptTrainer(file) == true)
                        MessageBox.Show("Done");
        }
    }
}
