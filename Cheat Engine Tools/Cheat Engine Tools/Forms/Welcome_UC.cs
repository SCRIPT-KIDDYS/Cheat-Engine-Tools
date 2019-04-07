using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cheat_Engine_Tools.Forms
{
    public partial class Welcome_UC : UserControl
    {
        public Welcome_UC() => InitializeComponent();

        private void ColorChanger_Timer_Tick(object sender, EventArgs e)
		{
			Random random = new Random();
			int A = random.Next(0, 255);
			int R = random.Next(0, 255);
			int G = random.Next(0, 255);
			int B = random.Next(0, 255);
			Left_Label.ForeColor = Color.FromArgb(B, G, R, A);
			Right_Label.ForeColor = Color.FromArgb(A, R, G, B);
		}
	}
}
