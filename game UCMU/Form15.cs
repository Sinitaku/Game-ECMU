using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game_UCMU
{
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void btn50pt2_Click(object sender, EventArgs e)
        {
            Form17 form17 = new Form17();
            form17.pisteet = 30;
            form17.ShowDialog();
        }

        private void btn100pt2_Click(object sender, EventArgs e)
        {
            Form23 form23 = new Form23();
            form23.pisteet = 60;
            form23.ShowDialog();
        }

        private void btn150pt2_Click(object sender, EventArgs e)
        {
            Form24 form24 = new Form24();
            form24.pisteet = 100;
            form24.ShowDialog();
        }
    }
}
