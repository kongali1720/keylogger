using System;
using System.Windows.Forms;

namespace KeyloggerApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.Run(new Keylogger());
        }
    }
}
