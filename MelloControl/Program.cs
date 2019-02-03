using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Threading;

namespace MelloControl
{
    class Program
    {

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        private static List<Process> processes { get; set; }

        static void Main(string[] args)
        {
            processes = new List<Process>();

            for (int i = 0; i < 3; i++)
            {
                var process = new Process();
                process.StartInfo.FileName = @"C:\Users\louis\source\repos\Mello\Key\bin\Debug\key.exe";
                process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                process.Start();
                processes.Add(process);
                Thread.Sleep(100);

                IntPtr id = process.MainWindowHandle;
                MoveWindow(id, 100 + (i * 150), 50, 20, 200, true);

            }

            Thread.Sleep(1000);

            CloseProcesses();
        }

        private static void CloseProcesses()
        {
            processes.ForEach(c =>
            {

                c.CloseMainWindow();
            });
        }
    }
}
