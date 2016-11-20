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
    public partial class AddTask : Form
    {
        public AddTask()
        {
            InitializeComponent();
            name.Text = GlobalVar.GlobalName;
            projectName.Text = GlobalVar.ProjectName;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string title = taskTitle.Text;
            string description = taskDescription.Text;
            try
            {
                string _url = GlobalVar.GlobalUrl + "addtask.php";

                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(_url);
                req.Method = "POST";
                string Data = "title=" + title + "&description=" + description + "&projectid=" + GlobalVar.ProjectID + "&userid=" + GlobalVar.GlobalID;
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

                MessageBox.Show("Successfully added the task, Please re select the project.");
                this.Close();
                //JObject joResponse = JObject.Parse(responseText);
                //JObject ojObject = (JObject)joResponse["response"];

                //int id = Convert.ToInt32(array[0].ToString());

            }
            catch (WebException)
            {
                MessageBox.Show("Please Check Your Internet Connection");
            }
        }
    }
}
