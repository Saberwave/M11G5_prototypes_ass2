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
    public partial class TrainerCourseEnrollments : Form
    {
        public TrainerCourseEnrollments()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            TrainerMainMenu TMM = new TrainerMainMenu();
            TMM.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TDConfirm TDC = new TDConfirm();
            TDC.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}