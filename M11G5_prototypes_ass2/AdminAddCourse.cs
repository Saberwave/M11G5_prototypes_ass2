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
    public partial class AdminAddCourse : Form
    {
        public AdminAddCourse()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            AdminViewCourses AVC = new AdminViewCourses();
            AVC.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {       
            AACSucc AASC = new AACSucc();
            AASC.Show();            
        }
    }
}
