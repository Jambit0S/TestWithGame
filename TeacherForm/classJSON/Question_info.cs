using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TeacherForm.classJSON
{
    class Question_info
    {
        public Question_info()
        {
        }

        public Question_info(int id, int microheme, int weight, string quetion, string tex, int type)
        {
            this.id = id;
            this.microheme = microheme;
            this.weight = weight;
            this.quetion = quetion;
            this.tex = tex;
            this.type = type;
        }

        public int id { get; set; }
        public int microheme { get; set; }
        public int weight { get; set; }
        public string quetion { get; set; }
        public string tex { get; set; }
        public int type { get; set; }

        public List<Question_info> JsonParse(string JsonString)
        {
            Question_info a = new Question_info();

            string jsonData = JsonConvert.SerializeObject(a);
            var obj = JsonConvert.DeserializeObject<List<Question_info>>(JsonString);
            Object bigObject = (Object)obj;
            List<Question_info> myQuestion_info = (List<Question_info>)bigObject;
            return myQuestion_info;
        }
    }
}
