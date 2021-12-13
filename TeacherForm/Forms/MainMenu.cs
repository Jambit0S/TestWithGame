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
using TeacherForm.classJSON;

namespace TeacherForm
{
    public partial class MainMenu : Form
    {
        Myuser user;
        public MainMenu(Myuser myuser1)
        {
            user = myuser1;
            InitializeComponent();
        }
        
        
        
        

        private void MainMenu_Load(object sender, EventArgs e)
        {
            labelGreetText.Text = user.secondname;
        }

       
        private List<Theme> GetThemes() 
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/general/theme");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";

            WebResponse response = httpWebRequest.GetResponse();
            using (Stream dataStream = response.GetResponseStream())
            {
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                string responseFromServer = reader.ReadToEnd();
                // Display the content.
                
                List<Theme> themes = new List<Theme>();
                {
                    Theme objCreate = new Theme();
                    themes = objCreate.JsonParse(responseFromServer);
                }
                MessageBox.Show(themes[0].name);
                return themes;
            }
            
        }
        private List<MicroTheme> GetMicrothemes()
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/general/microtheme");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";

            WebResponse response = httpWebRequest.GetResponse();
            using (Stream dataStream = response.GetResponseStream())
            {
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                string responseFromServer = reader.ReadToEnd();
                // Display the content.
                

                List<MicroTheme> mirothemes = new List<MicroTheme>();
                {
                    MicroTheme objCreate = new MicroTheme();
                    mirothemes = objCreate.JsonParse(responseFromServer);
                }
                return mirothemes;
            }

        }
        


    }
}
