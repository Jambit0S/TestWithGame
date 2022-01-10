using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TeacherForm.classJSON
{
    class Test
    {
        public Test()
        {
        }

        public Test(int id, string name, int weightsum, int[] questionlist, int[] criterion, int author_id, int lesson_id)
        {
            this.id = id;
            this.name = name;
            this.weightsum = weightsum;
            this.questionlist = questionlist;
            this.criterion = criterion;
            this.author_id = author_id;
            this.lesson_id = lesson_id;
        }

        public int id { get; set; }
        public string name { get; set; }
        public int weightsum { get; set; }
        public int[] questionlist { get; set; }
        public int[] criterion { get; set; }
        public int author_id { get; set; }
        public int lesson_id { get; set; }
        public List<Test> JsonParseObjects(string JsonString)
        {
            Test a = new Test();

            string jsonData = JsonConvert.SerializeObject(a);

            //List<Theme> obj = new List<Theme>();
            var obj = JsonConvert.DeserializeObject<List<Test>>(JsonString);
            Object bigObject = (Object)obj;
            List<Test> myTests = (List<Test>)bigObject;
            return myTests;
        }
    }
    
}
