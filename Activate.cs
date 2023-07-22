using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WindowsActivator
{
    public static class Activation
    
    {
        //It activates Windows and checks if it is possible to activate it.
        public static bool Start(string key)
        {
           
            List<string> Servers = new List<string>() { "kms8.msguides.com", "kms7.msguides.com", "kms9.msguides.com", "kms.digiboy.ir", "nkms.cnlic.com", "kms.chinancce.com", "kms.ddns.net", "franklv.ddns.net", "k.zpale.com", "m.zpale.com", "mvg.zpale.com", "kms.shuax.com", "kensol263.imwork.net:1688", "xykz.f3322.org", "kms789.com", "dimanyakms.sytes.net:1688", "kms.03k.org:1688" };
            
            //It checks if the program is compatible with the Windows edition
            bool run=true;
            int i = 0;
            bool status = false;
            if(key =="")
            {
                run = false;
            }
            //It tries to activate Windows.
            while(run)
            {
                Process activate = new Process();
                activate.StartInfo.FileName = "cscript";
                activate.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                activate.StartInfo.WorkingDirectory = @"C:\Windows\System32";
                activate.StartInfo.Arguments = $"slmgr.vbs /ipk {key}";
                activate.Start();
                activate.WaitForExit();
                activate.StartInfo.Arguments = $"slmgr.vbs /skms {Servers[i]}";
                activate.Start();
                activate.WaitForExit();
                activate.StartInfo.Arguments = "slmgr.vbs /ato";
                activate.Start();
                activate.WaitForExit();
                //It checks if the program should run or not.
                if(Checks.CheckWindowsActivation())
                {
                    run = false;
                    status = true;

                }
                else
                {
                    i++;
                    
                }
                if(i>Servers.Count-1)
                {
                    
                    run = false;
                    
                }

            }
            return status;
        }
    }
}
