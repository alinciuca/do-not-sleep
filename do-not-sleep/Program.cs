using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace do_not_sleep
{
    class Program
    {
        static void Main(string[] args)
        {
            var process = new Process();
            process.StartInfo.FileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "exec.exe");
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.Start();
        }
    }
}
