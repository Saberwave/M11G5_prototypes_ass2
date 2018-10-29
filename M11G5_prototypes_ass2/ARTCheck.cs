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
    public partial class ARTCheck : Form
    {
        public ARTCheck()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            AdminRemoveTrainer ART = new AdminRemoveTrainer();
            ART.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            TRemoved TR = new TRemoved();
            TR.Show();
        }
    }
}
