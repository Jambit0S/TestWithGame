using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace TeacherForm.classJSON
{
    class MicroTheme
    {
        public int id;
        public string name;
        public string info;
        public MicroTheme() 
        {
            id = 0;
            name = "none";
            info = "none";
        }
        public MicroTheme(int Id, string Name, string Info)
        {
            id = Id;
            name = Name;
            info = Info;
        }
        public List<MicroTheme> JsonParse(string JsonString)
        {
            MicroTheme a = new MicroTheme();

            string jsonData = JsonConvert.SerializeObject(a);

            //List<Theme> obj = new List<Theme>();
            var obj = JsonConvert.DeserializeObject<List<MicroTheme>>(JsonString);
            Object bigObject = (Object)obj;
            List<MicroTheme> myMicrothemes = (List<MicroTheme>)bigObject;
            return myMicrothemes;
        }

    }
}
