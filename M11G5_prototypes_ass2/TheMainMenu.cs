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
    public partial class TheMainMenu : Form
    {
        public TheMainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Enrolments enrolments = new Enrolments();
            enrolments.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void TheMainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
