using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToggleChromaVisualiser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string appEngine = @"C:\Program Files\Razer\RzAppEngine\rzappengine.exe";
            string streamerCompanionArguments = " --url-params=apps=streamer-companion-app --disable-background-timer-throttling";

            Process[] allprocesses = Process.GetProcesses();
            for (int i = 0; i < allprocesses.Length; i++)
            {
                if (allprocesses[i].ProcessName.Contains("rzappengine"))
                {
                    allprocesses[i].Kill();
                    this.Close();
                    return;
                }
            }
            {
                Process startit = new Process();
                startit.StartInfo.FileName = appEngine;
                startit.StartInfo.Arguments = streamerCompanionArguments;
                startit.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
                startit.Start();
            }
            this.Close();
        }
    }
}
