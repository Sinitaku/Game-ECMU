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
    public partial class Form18 : Form
    {
        public int pisteet { get; set; }
        public Form18()
        {
            InitializeComponent();
        }

        private void btnSePow1_Click(object sender, EventArgs e)
        {
            if (progBarWtr.Value + 10 < progBarWtr.Maximum)
            {
                progBarWtr.Value = progBarWtr.Value + 10;
            }
            else
            {
                Form25 form25 = new Form25();
                form25.pisteet = pisteet + 30;
                form25.ShowDialog();
            }
        }

        private void btnElPow2_Click(object sender, EventArgs e)
        {
            if (progBarWtr.Value + 15 < progBarWtr.Maximum)
            {
                progBarWtr.Value = progBarWtr.Value + 15;
            }
            else
            {
                Form25 form25 = new Form25();
                form25.pisteet = pisteet + 30;
                form25.ShowDialog();
            }
        }

        private void btnDoPow1_Click(object sender, EventArgs e)
        {
            if (progBarWtr.Value + 10 < progBarWtr.Maximum)
            {
                progBarWtr.Value = progBarWtr.Value + 10;
            }
            else
            {
                Form25 form25 = new Form25();
                form25.pisteet = pisteet + 30;
                form25.ShowDialog();
            }
        }

        private void btnDoPo2_Click(object sender, EventArgs e)
        {
            if (progBarWtr.Value + 15 < progBarWtr.Maximum)
            {
                progBarWtr.Value = progBarWtr.Value + 15;
            }
            else
            {
                Form25 form25 = new Form25();
                form25.pisteet = pisteet + 30;
                form25.ShowDialog();
            }
        }
    }
}
