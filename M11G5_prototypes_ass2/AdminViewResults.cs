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
    public partial class AdminViewResults : Form
    {
        public AdminViewResults()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            TheMainMenu TMM = new TheMainMenu();
            TMM.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TrainerUpdateResults TUR = new TrainerUpdateResults();
            TUR.Show();
        }
    }
}
