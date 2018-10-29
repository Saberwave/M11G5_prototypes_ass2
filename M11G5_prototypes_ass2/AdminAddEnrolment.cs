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
    public partial class AdminAddEnrolment : Form
    {
        public AdminAddEnrolment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            AdminVewEnrollments AVE = new AdminVewEnrollments();
            AVE.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ASESucc ASES = new ASESucc();
            ASES.Show();
        }
    }
}
