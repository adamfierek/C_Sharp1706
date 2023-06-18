using System;
using System.Runtime.InteropServices;

namespace WpfApp1.ViewModel
{
    public partial class MainWindowViewModel
    {
        [DllImport("user32.dll")]
        public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);
    }
}
