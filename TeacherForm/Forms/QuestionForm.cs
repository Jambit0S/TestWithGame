using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeacherForm.classJSON;
using TeacherForm.Forms;

namespace TeacherForm
{
    public partial class QuestionForm : Form
    {
        public QuestionForm()
        {
            InitializeComponent();
        }
        private static List<Lesson> lessonsList=new List<Lesson>();
        private static Lesson pickLesson = new Lesson();
        private static List<Test> pickTestList = new List<Test>();
        private static List<Questions> pickedQuestions = new List<Questions>();
        private static Test newTest;

        private void QuestionForm_Load(object sender, EventArgs e)
        {
            {
                //comboBox5.Items.Add("Добавить элемент");
                comboBox5.Enabled = false;
                
                tabControl1.Enabled = false;
            }
            {
                Lesson lesson = new Lesson();
                int leng = tabControl1.TabPages.Count;
                var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/general/lesson");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "GET";

                HttpWebResponse response = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(response.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    if (result != "")
                    {
                        //MessageBox.Show("Succses");
                        List<Lesson> LessonList = lesson.JsonParse(result);
                        for (int i = 0; i < LessonList.Count; i++)
                        {
                            lesson = LessonList[i];
                            comboBox1.Items.Add(lesson.name);
                            lessonsList.Add(LessonList[i]);
                        }

                        //MessageBox.Show(theme.name);
                    }
                }
            }
            //Lessons load  
        }

        private void QueAndLoad()
        {
            

            {
                Questions a = new Questions();
                foreach (Questions que in a.QuestionsTypes)
                {
                    comboBox3.Items.Add(que.type);
                    comboBox4.Items.Add(que.type);
                }
            }
            //Questions load
            Lesson pickedLesson = lessonsList.Find(item => item.name == comboBox1.SelectedItem.ToString());
            pickLesson = pickedLesson;
            //MessageBox.Show(pickedLesson.name);
            foreach (int id in pickedLesson.themeList)
            {
                Theme theme = new Theme();
                int leng = tabControl1.TabPages.Count;
                var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/general/theme/"+id);
                //var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/general/theme");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "GET";

                HttpWebResponse response = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(response.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    if (result != "")
                    {

                        //MessageBox.Show("Succses");
                        Theme themeList = theme.JsonParseObject(result);
                        comboBox2.Items.Add(themeList.name);
                        //MessageBox.Show(themka.name);
                    }
                }
            }
            
            {
                /*
                for (int j = 0; j < lessonsList.Count; j++)
                {
                    Theme theme = new Theme();
                    int leng = tabControl1.TabPages.Count;
                    //var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/general/theme/"+"\u003A"+themesList[j]);
                    var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/general/theme");
                    httpWebRequest.ContentType = "application/json";
                    httpWebRequest.Method = "GET";

                    HttpWebResponse response = (HttpWebResponse)httpWebRequest.GetResponse();
                    using (var streamReader = new StreamReader(response.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                        if (result != "")
                        {
                            
                            //MessageBox.Show("Succses");
                            List<Theme> themeList = theme.JsonParse(result);
                            for (int i = 0; i < themeList.Count; i++)
                            {
                                theme = themeList[i];
                                comboBox2.Items.Add(theme.name);
                            }
                            
                            
                            //MessageBox.Show(themka.name);
                        }
                    }
                }*/
            }
            //Theme's load
            

        }
        private void TestLoad(Lesson pickedLesson)
        {
            Test test = new Test();
            int leng = tabControl1.TabPages.Count;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/general/test/lesson/"+pickedLesson.id);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";

            HttpWebResponse response = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                if (result != "")
                {
                    //MessageBox.Show("Succses");
                    List<Test> TestList = test.JsonParseObjects(result);
                    for (int i = 0; i < TestList.Count; i++)
                    {
                        test = TestList[i];
                        comboBox5.Items.Add(test.name);
                        pickTestList.Add(test);
                        //lessonsList.Add(LessonList[i]);
                    }

                    //MessageBox.Show(theme.name);
                }
            }
            
        }
        private void TreeNodeLoadOnTest(Test pickTest)
        {
            if (pickTestList != null)
            {
                foreach (int id in pickTest.questionlist)
                {
                    Questions questionMain = new Questions();
                    int leng = tabControl1.TabPages.Count;
                    var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/general/question/" + id);
                    httpWebRequest.ContentType = "application/json";
                    httpWebRequest.Method = "GET";

                    HttpWebResponse response = (HttpWebResponse)httpWebRequest.GetResponse();
                    using (var streamReader = new StreamReader(response.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                        if (result != "")
                        {
                            //MessageBox.Show("Succses");
                            Questions question = questionMain.JsonParseObject(result);
                            //questionMain = question;
                            treeViewMain.Nodes.Add(question.type.ToString());
                            pickedQuestions.Add(question);

                            //MessageBox.Show(theme.name);
                        }
                    }
                }
            }
            else 
            {
                newTest = new Test();
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox5.Enabled = true;
            tabControl1.Enabled = true;
            QueAndLoad();
            TestLoad(pickLesson);
            treeViewMain.Nodes.Clear();
            treeViewMain.Nodes.Add(comboBox1.SelectedItem.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(richTextBox2.Text=="")
            {
                MessageBox.Show("Введите текст ответа");
            }
            else
                treeView1.Nodes.Add(richTextBox2.Text);
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeView a = (TreeView)sender;
            MessageBox.Show("Answer = "+a.SelectedNode.Text,"Que Type = "+comboBox4.SelectedItem.ToString());
            
        }

        static bool ans=false;
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!ans)
            {
                comboBox4.SelectedItem = comboBox3.SelectedItem;
                ans = true;
            }
            else
            {
                comboBox3.SelectedItem = comboBox4.SelectedItem;
                ans = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            treeViewMain.Nodes.Add(richTextBox1.Text.ToString());
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            Test test = pickTestList.Find(item => item.name == comboBox5.SelectedItem.ToString());
            TreeNodeLoadOnTest(test);
        }

        private void treeViewMain_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //MessageBox.Show(treeViewMain.SelectedNode.Text);
            /*
            Questions que = pickedQuestions.Find(item => item.type == treeViewMain.SelectedNode.Text.ToString());
            if (que != null)
            {
                MessageBox.Show(que.type.ToString());
            }*/
        }
    }
    
}
