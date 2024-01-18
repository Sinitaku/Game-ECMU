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
    public partial class Form8 : Form
    {
        public int pisteet { get; set; }
        public Form8()
        {
            InitializeComponent();
        }

        private void btnElPow1_Click(object sender, EventArgs e)
        {
            if (progBarFire.Value + 10 < progBarFire.Maximum)
            {
                progBarFire.Value = progBarFire.Value + 10;
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
            if (progBarFire.Value + 15 < progBarFire.Maximum)
            {
                progBarFire.Value = progBarFire.Value + 15;
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
            if (progBarFire.Value + 10 < progBarFire.Maximum)
            {
                progBarFire.Value = progBarFire.Value + 10;
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
            if (progBarFire.Value + 15 < progBarFire.Maximum)
            {
                progBarFire.Value = progBarFire.Value + 15;
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
