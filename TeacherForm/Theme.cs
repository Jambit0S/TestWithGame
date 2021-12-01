using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
