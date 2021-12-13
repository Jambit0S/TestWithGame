using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace TeacherForm
{
    class Theme
    {
        public int id { get; set; }
        public string name { get; set; }
        public int[] microthemelistid { get; set; }

        public Theme() 
        {
            id = 0;
            name = "none";
            microthemelistid =new int[]{1,2,3};
        }
        public List<Theme> JsonParse(string JsonString) 
        {
            Theme a = new Theme();

            string jsonData = JsonConvert.SerializeObject(a);

            //List<Theme> obj = new List<Theme>();
            var obj = JsonConvert.DeserializeObject<List<Theme>>(JsonString);
            Object bigObject = (Object)obj;
            List<Theme> myThemes = (List<Theme>)bigObject;
            return myThemes;
        }

    }
}
