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
    public partial class AdminViewCourses : Form
    {
        public AdminViewCourses()
        {
            InitializeComponent();
        }

        private void AdminViewCourses_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CRSucc CRS = new CRSucc();
            CRS.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            TheMainMenu TMM = new TheMainMenu();
            TMM.Show();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            AdminAddCourse AAC = new AdminAddCourse();
            AAC.Show();
        }
    }
}
