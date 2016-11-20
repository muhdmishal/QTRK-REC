using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Qtracker
{
    public partial class Project : Form
    {
        public Project()
        {
            InitializeComponent();
            name.Text = GlobalVar.GlobalName;
            btn_addTask.Hide();
            try
            {
                string _url = GlobalVar.GlobalUrl + "projects.php";

                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(_url);
                req.Method = "POST";
                string Data = "userid=" + GlobalVar.GlobalID;
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

                if ((int)joResponse["num_projects"] <= 0)
                    MessageBox.Show("You are not assigned to any project. Please contact Project Manager.");
                else
                {
                    List<select> sl = new List<select>();
                    sl.Add(new select() { Text = "Select Project From below", Value = 0 });
                    JArray projects = (JArray)joResponse["projects"];
                    foreach (var project in projects)
                    {
                        sl.Add(new select() { Text = (string)project["projectTitle"], Value = (int)project["projectID"] });
                    }
                    projectList.DataSource = sl;
                    projectList.DisplayMember = "Text";

                }


            }
            catch (WebException)
            {
                MessageBox.Show("Please Check Your Internet Connection");
            }
        }

        private void projectList_SelectedIndexChanged(object sender, EventArgs e)
        {
            select sl1 = projectList.SelectedItem as select;
            var _project_ID = Convert.ToInt16(sl1.Value);
            GlobalVar.ProjectID = _project_ID;
            GlobalVar.ProjectName = Convert.ToString(sl1.Text);
            List<select> sl = new List<select>();


            if (GlobalVar.ProjectID > 0)
            {
                btn_addTask.Show();
                try
                {
                    string _url = GlobalVar.GlobalUrl + "tasks.php";

                    HttpWebRequest req = (HttpWebRequest)WebRequest.Create(_url);
                    req.Method = "POST";
                    string Data = "projectid=" + GlobalVar.ProjectID + "&userid=" + GlobalVar.GlobalID;
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

                    if ((int)joResponse["num_tasks"] <= 0)
                    {
                        sl.Add(new select() { Text = "", Value = 0 });
                        taskList.DataSource = sl;
                        taskList.DisplayMember = "Text";
                        MessageBox.Show("You are not assigned any tasks. Please contact Project Manager.");
                    }
                    else
                    {

                        sl.Add(new select() { Text = "Select Task From below", Value = 0 });
                        JArray tasks = (JArray)joResponse["tasks"];
                        foreach (var task in tasks)
                        {
                            sl.Add(new select() { Text = (string)task["taskTitle"], Value = (int)task["taskID"] });
                        }
                        taskList.DataSource = sl;
                        taskList.DisplayMember = "Text";

                    }


                }
                catch (WebException)
                {
                    MessageBox.Show("Please Check Your Internet Connection");
                }

            }
            else
            {
                btn_addTask.Hide();
                sl.Add(new select() { Text = "", Value = 0 });
                taskList.DataSource = sl;
                taskList.DisplayMember = "Text";
            }
        }

        private void startTrack_Click(object sender, EventArgs e)
        {
            select sl1 = taskList.SelectedItem as select;
            var _task_ID = Convert.ToInt16(sl1.Value);
            GlobalVar.TaskID = _task_ID;
            GlobalVar.TaskName = Convert.ToString(sl1.Text);

            if (GlobalVar.ProjectID <= 0)
            {
                message.Text = "Please select a project.";
            }
            else if (GlobalVar.TaskID <= 0)
            {
                message.Text = "Please select a task.";
            }
            else
            {
                Tracker tracker = new Tracker();
                tracker.Show();
                this.Hide();
                tracker.FormClosed += tracker_Closed;
            }
        }
        private void tracker_Closed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btn_addTask_Click(object sender, EventArgs e)
        {
            AddTask addtask = new AddTask();
            addtask.Show();
        }
    }
}
