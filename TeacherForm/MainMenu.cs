using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeacherForm
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        private bool peekMenu;
        private bool themes;
        private bool tests;
        private bool stats;

        private void themeListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitcherPanels(menuStrip1.Items.IndexOf(themeListToolStripMenuItem)+1);         
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            SwitcherPanels(0); //Инициализация bool
        }
        

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitcherPanels(menuStrip1.Items.IndexOf(mainToolStripMenuItem) + 1);            
        }

        private void testsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitcherPanels(menuStrip1.Items.IndexOf(testsToolStripMenuItem) + 1);            
        }

        private void statsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitcherPanels(menuStrip1.Items.IndexOf(statsToolStripMenuItem) + 1);            
        }
        private void SwitcherPanels(int indexPanel)
        {
            switch (indexPanel)
            {
                case 0:
                    peekMenu = false;
                    themes = false;
                    tests = false;
                    stats = false;
                    break;
                case 1:
                    peekMenu = true;
                    themes = false;
                    tests = false;
                    stats = false;
                    break;
                case 2:
                    peekMenu = false;
                    themes = true;
                    tests = false;
                    stats = false;
                    break;
                case 3:
                    peekMenu = false;
                    themes = false;
                    tests = true;
                    stats = false;
                    break;
                case 4:
                    peekMenu = false;
                    themes = false;
                    tests = false;
                    stats = true;
                    break;
                default:
                    throw new Exception("Picked panel dont exist in switch");
                    break;
            }
            PanelVisible();
        }
        void PanelVisible() 
        {
            panelMain.Visible = peekMenu;
            panelTheme.Visible = themes;
            panelTest.Visible = tests;
            panelStast.Visible = stats;
        }
    }
}
