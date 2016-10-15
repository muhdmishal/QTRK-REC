using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Qtracker
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            
            try
            {
                string _url = GlobalVar.GlobalUrl + "login.php";
                string _username = username.Text;
                string _password = password.Text;

                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(_url);
                req.Method = "POST";
                string Data = "username=" + _username + "&password=" + _password;
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

                if ((Boolean)joResponse["loginStatus"])
                {
                    String name = (String)joResponse["name"];
                    int id = (int)joResponse["userID"];
                    GlobalVar.GlobalName = name;
                    GlobalVar.GlobalID = id;
                    Project project = new Project();
                    project.Show();
                    this.Hide();
                    project.FormClosing += project_Closing; 
                    
                }
                else
                {
                    message.Text = "Username and Passwrod doesn't match";
                }
            }
            catch (WebException)
            {
                MessageBox.Show("Please Check Your Internet Connection");
            }
        }

        private void project_Closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }
    }
}
