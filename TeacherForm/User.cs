using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TeacherForm
{
    class Myuser
    {
        int id { get;set; }
        string login { get; set; }
        string password { get; set; }
        string name { get; set; }
        string secondname { get; set; }
        string patronomic { get; set; }
        string customization { get; set; }
        public Myuser() {
            id = 0;
            login = "log";
            password = "pas";
            name = "nam";
            secondname = "sec";
            
        }
    }
}
