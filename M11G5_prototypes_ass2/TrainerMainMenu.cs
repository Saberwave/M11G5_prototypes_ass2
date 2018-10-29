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
    public partial class TrainerMainMenu : Form
    {
        public TrainerMainMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            TrainerLogin TL = new TrainerLogin();
            TL.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            TrainerCourses TC = new TrainerCourses();
            TC.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TrainerModDeets TMD = new TrainerModDeets();
            TMD.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            TrainerCourseEnrollments TCE = new TrainerCourseEnrollments();
            TCE.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            TrainerCourseResults TCR = new TrainerCourseResults();
            TCR.Show();
        }
    }
}
