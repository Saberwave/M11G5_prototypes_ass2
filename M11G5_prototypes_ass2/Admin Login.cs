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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            TheMainMenu mainMenu = new TheMainMenu();
            mainMenu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Splash splash = new Splash();
            splash.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            button2.Image = Properties.Resources.pressedbutton;
        }
        private void button2_MouseUp(object sender, MouseEventArgs e)

        {
            button2.Image = Properties.Resources.button;
        }

        private void button1_MouseDown_1(object sender, MouseEventArgs e)
        {
            button1.Image = Properties.Resources.pressedbutton;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.Image = Properties.Resources.button;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
