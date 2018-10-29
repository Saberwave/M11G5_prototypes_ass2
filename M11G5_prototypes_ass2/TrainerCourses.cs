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
    public partial class TrainerCourses : Form
    {
        public TrainerCourses()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            TrainerMainMenu TMM = new TrainerMainMenu();
            TMM.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            TCheck TC = new TCheck();
            TC.Show();
        }
    }
}
