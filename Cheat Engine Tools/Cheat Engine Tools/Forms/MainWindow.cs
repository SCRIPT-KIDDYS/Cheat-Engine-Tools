using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;


// ByteConverter Size =         310, 540
// Welcome Size =               610, 540

namespace Cheat_Engine_Tools
{
    public partial class MainWindow : MetroForm
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MetroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            if (metroTabControl1.SelectedIndex == 0)
                this.Size = new Size(610, 540);
            if (metroTabControl1.SelectedIndex == 1)
                this.Size = new Size(310, 540);
            */
        }
    }
}
