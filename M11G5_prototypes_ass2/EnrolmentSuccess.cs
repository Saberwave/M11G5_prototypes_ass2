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
    public partial class EnrolmentSuccess : Form
    {
        public EnrolmentSuccess()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            StudentMainMenu stdMM = new StudentMainMenu();
            stdMM.Show();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
