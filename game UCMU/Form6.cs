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
    public partial class Form6 : Form
    {
        public int pisteet { get; set; }
        public Form6()
        {
            InitializeComponent();
        }


        private void btnElPow1_Click(object sender, EventArgs e)
        {
            if (progBarWtr.Value + 5 < progBarWtr.Maximum)
            {
                progBarWtr.Value = progBarWtr.Value + 5;
            }
            else
            {
                Form25 form25 = new Form25();
                form25.pisteet = pisteet;
                form25.ShowDialog();
            }
        }

        private void btnElPow2_Click(object sender, EventArgs e)
        {
            if (progBarWtr.Value + 10 < progBarWtr.Maximum)
            {
                progBarWtr.Value = progBarWtr.Value + 10;
            }
            else
            {
                Form25 form25 = new Form25();
                form25.pisteet = pisteet;
                form25.ShowDialog();
            }
        }

        private void btnThaPow1_Click(object sender, EventArgs e)
        {
            if (progBarWtr.Value + 5 < progBarWtr.Maximum)
            {
                progBarWtr.Value = progBarWtr.Value + 5;
            }
            else
            {
                Form25 form25 = new Form25();
                form25.pisteet = pisteet;
                form25.ShowDialog();
            }
        }

        private void btnThaPow2_Click(object sender, EventArgs e)
        {
            if (progBarWtr.Value + 10 < progBarWtr.Maximum)
            {
                progBarWtr.Value = progBarWtr.Value + 10;
            }
            else
            {
                Form25 form25 = new Form25();
                form25.pisteet = pisteet;
                form25.ShowDialog();
            }
        }
    }
}
