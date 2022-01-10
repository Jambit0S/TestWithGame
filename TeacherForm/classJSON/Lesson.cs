using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TeacherForm.classJSON
{
    class Lesson
    {
        public Lesson()
        {
        }

        public Lesson(int id, string name, int[] themeList)
        {
            this.id = id;
            this.name = name;
            this.themeList = themeList;
        }

        public int id { get; set; }
        public string name { get; set; }
        public int[] themeList {get;set;}

        public List<Lesson> JsonParse(string JsonString)
        {
            Theme a = new Theme();

            string jsonData = JsonConvert.SerializeObject(a);
            var obj = JsonConvert.DeserializeObject<List<Lesson>>(JsonString);
            Object bigObject = (Object)obj;
            List<Lesson> myThemes = (List<Lesson>)bigObject;
            return myThemes;
        }

    }
}
