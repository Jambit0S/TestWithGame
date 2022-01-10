using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeacherForm.Forms
{
    class CustomPanel
    {
        public Size Size { get; set; }
        public Point Location { get; set; }
        public List<Control> Controls { get; }
        public CustomPanel() { }
        public CustomPanel(Panel father) {
            Controls = new List<Control>();
            Size = father.Size;
            Location = father.Location;
            foreach (Control item in father.Controls)
            {
                Controls.Add(item);

            }
        }
        public CustomPanel Clone()
        {
            var cp = (CustomPanel)this.MemberwiseClone();
            //cp.Parent = null; // It has not yet been added to the form.
            return cp;
        }
        public Panel ConvertToPanel()
        {
            Panel newpanel = new Panel();
            newpanel.Size = Size;
            newpanel.Location = Location;
            foreach (Control item in Controls)
            {
                newpanel.Controls.Add(item);

            }
            return newpanel;
        }
    }
}
