using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;


namespace TeacherForm
{
    public class Myuser
    {
        public int id { get;set; }
        public string login { get; set; }
        public  string password { get; set; }
        public string name { get; set; }
        public string secondname { get; set; }
        public string patronomic { get; set; }
        public string customization { get; set; }
        public Myuser() {
            id = 0;
            login = "log";
            password = "pas";
            name = "nam";
            secondname = "sec";
            
        }
        public List<Myuser> JsonParse(string JsonString)
        {
            Myuser a = new Myuser();

            string jsonData = JsonConvert.SerializeObject(a);

            //List<Theme> obj = new List<Theme>();
            var obj = JsonConvert.DeserializeObject<List<Myuser>>(JsonString);
            Object bigObject = (Object)obj;
            List<Myuser> myThemes = (List<Myuser>)bigObject;
            return myThemes;
        }
    }
}
