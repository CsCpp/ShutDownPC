using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ShutDownPC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Process p = new Process();
            p.StartInfo.FileName = "shutdovn.exe";
            p.StartInfo.Arguments = "/s /t 0";
            p.Start();
        }
    }
}
