using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClipBoardAccessMonitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Process currentProcess = null;
            while (true)
            {
                int processId;
                User32.GetWindowThreadProcessId((int)User32.GetClipboardOwner(), out processId);


                if (Process.GetProcessById(processId).Id != (currentProcess != null ? currentProcess.Id : -1))
                {
                    currentProcess = Process.GetProcessById(processId);
                    Console.WriteLine(currentProcess.ProcessName);
                }
            }
        }
    }
}
