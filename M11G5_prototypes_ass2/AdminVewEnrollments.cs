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
    public partial class AdminVewEnrollments : Form
    {
        public AdminVewEnrollments()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            TheMainMenu TMM = new TheMainMenu();
            TMM.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TDConfirm TDC = new TDConfirm();
            TDC.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            AdminAddEnrolment AAE = new AdminAddEnrolment();
            AAE.Show();
        }
    }
}
