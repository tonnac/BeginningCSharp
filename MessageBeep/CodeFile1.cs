using System;
using System.Runtime.InteropServices;

class Program
{
    [DllImport("user32.dll")]
    static extern int MessageBeep(uint uType);

    static void Main(string[] args)
    {
        MessageBeep(0);
    }
}