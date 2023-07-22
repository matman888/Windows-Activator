using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsActivator;

namespace Activator_GUI
{
    public partial class Form1 : Form
    {
        //Get the necessary values
        public string Winver = Checks.CheckKernelVersions();
        public string WinEdition = Checks.CheckWindowsEdition();
        public string ActivationStatus = Convert.ToString(Checks.CheckWindowsActivation());
        public string WinBuild= Convert.ToString(System.Environment.OSVersion.Version.Build);
        public bool InternetConnection = Checks.CheckConnection("google.com");

        public Form1()
        {
            //Form initialization
            if (InternetConnection)
            {
                InitializeComponent();
                lbl_Activation.Text = ActivationStatus;
                lbl_Version.Text = Winver;
                lbl_Edition.Text = WinEdition;
                lbl_Build.Text = WinBuild;
                
            }
            else
            {
                //Displays the "Missing Internet Connection" error
                Internet_Connection_Error form = new Internet_Connection_Error();
                form.Show();
                this.Hide();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Starts the Windows Activation and displays the result message
            string message;
            string title;
            btn_Activate.Enabled = false;
            prb.MarqueeAnimationSpeed = 30;
            prb.Style= ProgressBarStyle.Marquee;
            prb.MarqueeAnimationSpeed = 30;
              string key = GetKey.Key(Winver,WinBuild,WinEdition);
              bool activate = Activation.Start(key);

              if (activate)
              {
                  message = "Windows was Activated Successfully";
                  title = "Windows is Activated";
              }
              else
              {
                  message = "Windows did not be Activated!";
                  title = "Activation Error";
              }
            
        
            
            btn_Activate.Enabled=true;
            prb.MarqueeAnimationSpeed = 0;
            prb.Style = ProgressBarStyle.Continuous;
            Activation_Sucess form = new Activation_Sucess(message, title);
            form.ShowDialog();

            lbl_Activation.Text = Convert.ToString(activate);

        }
    }
}
