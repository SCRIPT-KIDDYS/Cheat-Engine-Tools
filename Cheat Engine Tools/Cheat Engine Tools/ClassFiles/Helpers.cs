using Cheat_Engine_Tools;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

public class Helpers
{
    public static ByteConverter_ Converter = new ByteConverter_();

    public enum MessageType { INFO, WARNING, ERROR, CANCELED }

    public static string[] ErrorList = { };

    public static void ShakeMe(string errorlist, MessageType messagetype, MessageBoxButtons button, MessageBoxIcon icon, bool shouldshake = false)
    {
        Form form = MainWindow.ActiveForm;
        var original = form.Location;
        var rnd = new Random(1337);
        const int shake_amplitude = 20;
        if (shouldshake)
        {
            for (int i = 0; i < 15; i++)
            {
                form.Location = new Point(original.X + rnd.Next(-shake_amplitude, shake_amplitude), original.Y + rnd.Next(-shake_amplitude, shake_amplitude));
                Thread.Sleep(20);
            }
        }
        form.Location = original;
        MetroFramework.MetroMessageBox.Show(form, errorlist, messagetype.ToString(), button, icon, form.Height / 2);
    }

    public static void ShakeMe()
    {
        Form form = MainWindow.ActiveForm;
        var original = form.Location;
        var rnd = new Random(1337);
        const int shake_amplitude = 20;
        for (int i = 0; i < 15; i++)
        {
            form.Location = new Point(original.X + rnd.Next(-shake_amplitude, shake_amplitude), original.Y + rnd.Next(-shake_amplitude, shake_amplitude));
            System.Threading.Thread.Sleep(20);
        }
        form.Location = original;
    }
}


