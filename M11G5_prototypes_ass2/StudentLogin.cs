﻿using System;
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
    public partial class StudentLogin : Form
    {
        public StudentLogin()
        {
            InitializeComponent();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            StudentRegistration StdReg = new StudentRegistration();
            StdReg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Splash splash = new Splash();
            splash.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            StudentMainMenu StdMM = new StudentMainMenu();
            StdMM.Show();
        }
    }
}
