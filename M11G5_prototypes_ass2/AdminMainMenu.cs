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


        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void TheMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Hide();
            Form1 F1 = new Form1();
            F1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            AdminUserDetails AUD = new AdminUserDetails();
            AUD.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Hide();
            AdminViewCourses AVC = new AdminViewCourses();
            AVC.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            AdminVewEnrollments AVE = new AdminVewEnrollments();
            AVE.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Hide();
            AdminViewResults AVR = new AdminViewResults();
            AVR.Show();
        }
    }
}
