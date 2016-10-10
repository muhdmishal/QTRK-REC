using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Qtracker
{
    public partial class Tracker : Form
    {
        int _Counter = 0;
        [DllImport("User32.dll")]
        private static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);

        [DllImport("Kernel32.dll")]
        private static extern uint GetLastError();

        public static uint GetIdleTime()
        {
            LASTINPUTINFO lastInPut = new LASTINPUTINFO();
            lastInPut.cbSize = (uint)System.Runtime.InteropServices.Marshal.SizeOf(lastInPut);
            GetLastInputInfo(ref lastInPut);

            return ((uint)Environment.TickCount - lastInPut.dwTime);
        }

        internal struct LASTINPUTINFO
        {
            public uint cbSize;

            public uint dwTime;
        }
        public Tracker()
        {
            InitializeComponent();
            name.Text = GlobalVar.GlobalName;
            projectName.Text = GlobalVar.ProjectName;
            taskName.Text = GlobalVar.TaskName;
            startTime.Text = DateTime.Now.ToString("h:mm:ss tt");
           
           
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var RunningProcessPaths = ProcessFileNameFinderClass.GetAllRunningProcessFilePaths();
            if (!RunningProcessPaths.Contains("chrome.exe") && !RunningProcessPaths.Contains("firefox.exe") && GetIdleTime() < 60000)
            {
                this._Counter += 1;
                timeSpend.Text = TimeSpan.FromSeconds(_Counter).ToString();
            }
        }

        private void stopTrack_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            var timespend = timeSpend.Text;
        }
    }
}
