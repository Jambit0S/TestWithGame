using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace TeacherForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Myuser user = new Myuser();

            user= Autorization(user);
            if (user.id!=0)
            {
                //MessageBox.Show("You are GAY");
                MainMenu newform = new MainMenu(user);
                this.Hide();
                newform.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong Login or Password");
            }

        }
        Myuser Autorization(Myuser user) 
        {
            user.login = textBoxLogin.Text;
            user.password= textBoxPassword.Text;
            //return user;

            string login = user.login;
            string password = user.password;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/general/authorization");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{\"login\":\"" + login + "\"," +
                              "\"password\":\"" + password + "\"}";

                streamWriter.Write(json);
            }
            //Доабвить оьбработку пробелов
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                if (result != "")
                {
                    MessageBox.Show("Succses");
                    List<Myuser> users = user.JsonParse(result);
                    user = users[0];
                }
            }
            return user;

        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            //textBoxLogin.AutoSize = false;
            //textBoxPassword.AutoSize = false;
            //Все шрифты 14 siez
        }

        
    }
}
