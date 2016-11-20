using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Qtracker
{
    public partial class Tracker : Form
    {
        int _Counter = 0;
        string _StartTime;
        string _EndTime;
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
            this._StartTime = DateTime.Now.ToString();
           
            
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
            this._EndTime = DateTime.Now.ToString();
            var timespend = this._Counter;
            
            GlobalVar.TimeSpend = timespend;

            try
            {
                string _url = GlobalVar.GlobalUrl + "track.php";
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(_url);
                req.Method = "POST";
                string Data = "startTime=" + this._StartTime + "&endTime=" + this._EndTime + "&timeSpend=" + GlobalVar.TimeSpend + "&taskID=" + GlobalVar.TaskID + "&projectID=" + GlobalVar.ProjectID + "&userID=" + GlobalVar.GlobalID;

                byte[] postBytes = Encoding.ASCII.GetBytes(Data);
                req.ContentType = "application/x-www-form-urlencoded";
                req.ContentLength = postBytes.Length;
                Stream requestStream = req.GetRequestStream();
                requestStream.Write(postBytes, 0, postBytes.Length);
                requestStream.Close();

                HttpWebResponse response = (HttpWebResponse)req.GetResponse();
                Stream resStream = response.GetResponseStream();

                var sr = new StreamReader(response.GetResponseStream());
                string responseText = sr.ReadToEnd();
                
                JObject joResponse = JObject.Parse(responseText);
                //JObject ojObject = (JObject)joResponse["response"];
                
                //int id = Convert.ToInt32(array[0].ToString());


                if ((Boolean)joResponse["trackStatus"])
                {
                    MessageBox.Show("Updated your time.");
                    GlobalVar.TimeSpend = 0;
                    this._Counter = 0;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error occured during time save. Please try again.");
                }
                
            }
            catch (WebException)
            {
                MessageBox.Show("Please Check Your Internet Connection");
            }
        }

        private void Tracker_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this._Counter > 0)
            {
                if (MessageBox.Show("You have unsaved time. Are you sure you want to close?", "QTracker",
                MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    // Cancel the Closing event from closing the form.
                    e.Cancel = true;

                }

            }
            
        }
    }
}
