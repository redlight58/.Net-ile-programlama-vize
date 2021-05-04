using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;


namespace ConsoleApp1
{
    class two
    {
        public static void Main()
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();
            process.StandardInput.WriteLine("netstat -a -n");
            process.StandardInput.Flush();
            process.StandardInput.Close();
            // process.WaitForExit();
            Console.WriteLine(process.StandardOutput.ReadToEnd());
            Console.ReadKey();
        }
    }
}
