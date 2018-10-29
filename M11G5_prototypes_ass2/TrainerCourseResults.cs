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
    public partial class TrainerCourseResults : Form
    {
        public TrainerCourseResults()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TrainerUpdateResults TUR = new TrainerUpdateResults();
            TUR.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            TrainerMainMenu TMM = new TrainerMainMenu();
            TMM.Show();
        }
    }
}
