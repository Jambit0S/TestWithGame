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
            {
                /*
                //label1.Text = textBoxPassword.Text;
                WebRequest request = WebRequest.Create("http://localhost:8080/teacher/theme");
                WebResponse response = request.GetResponse();
                using (Stream stream = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        string line = "";
                        while ((line = reader.ReadLine()) != null)
                        {
                            label1.Text += line;
                            Console.WriteLine(line);
                            Theme a = new Theme();

                            string jsonData = JsonConvert.SerializeObject(a);

                            //List<Theme> obj = new List<Theme>();
                            var obj = JsonConvert.DeserializeObject<List<Theme>>(line);
                            Object bigObject = (Object)obj;
                            List<Theme> myTheme = (List<Theme>)bigObject;
                        }
                    }
                }

                response.Close();
                Console.WriteLine("Запрос выполнен");
                //Console.Read();
                */
            }
            if (LogIn(textBoxLogin.Text, textBoxPassword.Text))
            {
                //MessageBox.Show("You are GAY");
                MainMenu newform = new MainMenu();
                this.Hide();
                newform.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong Login or Password");
            }

        }

        bool LogIn(string login, string password) 
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/general/user");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{\"login\":\""+login+"\"," +
                              "\"password\":\""+password+"\"}";

                streamWriter.Write(json);
            }
            //Доабвить оьбработку пробелов
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                if (result =="")
                    return false;
                else
                    return true;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //textBoxLogin.AutoSize = false;
            //textBoxPassword.AutoSize = false;
            //Все шрифты 14 siez
        }

        
    }
}
