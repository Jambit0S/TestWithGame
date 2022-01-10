using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TeacherForm.classJSON
{
    class Questions
    {
        public int type { get; }
        public List<Questions> QuestionsTypes { get; }
        private Questions(int type ) 
        {
            this.type = type;
        }

        public Questions() 
        
        {
            QuestionsTypes = new List<Questions>();
            List<string> typesName = new List<string>();
            typesName = GetListTypes(typesName);
            foreach (string a in typesName)
            {
                QuestionsTypes.Add(new Questions(1));
            }
            
        }
        private List<string> GetListTypes(List<string> names) 
        {
            names.Add("Bool");
            names.Add("One Answer");
            names.Add("Many Answer");
            names.Add("Essay");
            return names;
        }
        public List<Questions> JsonParseObjects(string JsonString)
        {
            Questions a = new Questions();

            string jsonData = JsonConvert.SerializeObject(a);

            //List<Theme> obj = new List<Theme>();
            var obj = JsonConvert.DeserializeObject<List<Questions>>(JsonString);
            Object bigObject = (Object)obj;
            List<Questions> myTests = (List<Questions>)bigObject;
            return myTests;
        }
        public Questions JsonParseObject(string JsonString)
        {
            Questions a = new Questions();

            string jsonData = JsonConvert.SerializeObject(a);

            //List<Theme> obj = new List<Theme>();
            var obj = JsonConvert.DeserializeObject<Questions>(JsonString);
            Object bigObject = (Object)obj;
            Questions myTests = (Questions)bigObject;
            return myTests;
        }
    }
}
