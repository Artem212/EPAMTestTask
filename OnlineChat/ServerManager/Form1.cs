using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace ServerManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void StartWeb(string name)
        {
            FileInfo fileInfo = new FileInfo("applicationhost.config");
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.WorkingDirectory = @"C:\Program Files (x86)\IIS Express";
            startInfo.FileName = @"C:\Windows\System32\cmd.exe";
            startInfo.Arguments = "/C iisexpress /config:" + fileInfo.FullName + "  /site:"+name;
            process.StartInfo = startInfo;
            process.Start();
        }
        private void btnStartServer_Click(object sender, EventArgs e)
        {
            StartWeb("WCFAuthService");
        }

        private void btnStartSite_Click(object sender, EventArgs e)
        {
            StartWeb("OnlineChatWeb");
        }

        private void btnStartSignalR_Click(object sender, EventArgs e)
        {
            StartWeb("SignalRChatHost");
        }
    }
}
