using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M11G5_prototypes_ass2
{
    public partial class StudentMainMenu : Form
    {
        public StudentMainMenu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StdUpdateInfo stdupdate = new StdUpdateInfo();
            stdupdate.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            StudentLogin stdlogin = new StudentLogin();
            stdlogin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            StdViewCourses stdView = new StdViewCourses();
            stdView.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
