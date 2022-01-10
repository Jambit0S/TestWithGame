using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TeacherForm.classJSON.QuestionsJSON
{
    class QuestionBoolean
    {
        public QuestionBoolean()
        {
        }

        public QuestionBoolean(bool isRightAns)
        {
            IsRightAns = isRightAns;
        }

        public bool IsRightAns { get; set; }

        public List<QuestionBoolean> JsonParse(string JsonString)
        {
            QuestionBoolean a = new QuestionBoolean();

            string jsonData = JsonConvert.SerializeObject(a);
            var obj = JsonConvert.DeserializeObject<List<QuestionBoolean>>(JsonString);
            Object bigObject = (Object)obj;
            List<QuestionBoolean> myBooleanQuestion = (List<QuestionBoolean>)bigObject;
            return myBooleanQuestion;
        }

    }
}
