using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel.Design.Serialization;

namespace WindowsActivator
{
    public static class Checks
    {
        public static bool CheckConnection(string server)
        {
            //Checks connection with the serverh 
            bool connection;
            try
            {
                Ping Connect = new Ping();
                Connect.Send(server);
                connection = true;
            }
            catch(PingException)
            {
                connection = false;
            }
            return connection;
        }
        public static bool CheckWindowsActivation()
        {
            //It checks the Windows activation status using powershell and slmgr
            bool activation;
            Process Check = new Process();
            string status;
            Check.StartInfo.FileName = "powershell";
            Check.StartInfo.WorkingDirectory = @"C:\Windows\System32";
            Check.StartInfo.Arguments = " cscript.exe slmgr.vbs /dli > output.txt";
            Check.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            Check.Start();
            Check.WaitForExit();
            status = File.ReadLines(@"C:\Windows\System32\output.txt").Skip(7).Take(1).First();
            File.Delete(@"C:\Windows\System32\output.txt");
            if(status == "License Status: Licensed")
            {
                activation = true;
            }
            else
            {
                activation = false;
            }
            return activation;
        }
        //It checks the Windows Edition using slmgr.
        public static string CheckWindowsEdition()
        {
            string edition;
            Process dism = new Process();
            dism.StartInfo.FileName = "powershell";
            dism.StartInfo.Arguments = "dism /Online /Get-CurrentEdition > output.txt";
            dism.StartInfo.WorkingDirectory = @"C:\Windows\System32";
            dism.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            dism.Start();
            dism.WaitForExit();
            edition = File.ReadLines(@"C:\Windows\System32\output.txt").Skip(8).Take(1).First().Substring(18);
            File.Delete(@"C:\Windows\System32\output.txt");
            return edition;
        }
        //It checks the Windows NT Kernel version
        public static string CheckKernelVersions()
        {
            string version;
            string majorver;
            string minorver;
            majorver = Convert.ToString(System.Environment.OSVersion.Version.Major);
            minorver = Convert.ToString(System.Environment.OSVersion.Version.Minor);
            version = $"{majorver}.{minorver}";
            return version;

        }

    }
}
