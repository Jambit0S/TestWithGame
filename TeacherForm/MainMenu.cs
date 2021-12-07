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

        private void MainMenu_Load(object sender, EventArgs e)
        {
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            //tabControl1.Location = new Point(tabControl1.Location.X,-36);
            //tabControl1.Size = new Size(tabControl1.Size.Width, 688);
            //tabPageMenu.Hide();
            tabPageMenu.BackColor = Color.Bisque;
            tabPageTheme.BackColor = Color.Bisque;
            tabPageTest.BackColor = Color.Bisque;
            tabPageStats.BackColor = Color.Bisque;
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPageMenu;
        }

        private void themesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPageTheme;
            UpdateThemesDataGrid(dataGridView1);
        }

        private void testsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPageTest;
        }

        private void statisticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPageStats;
        }
        void UpdateThemesDataGrid(DataGridView datagrid) 
        {
           
        }
    }
}
