﻿using System;
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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void lblGameName10_Click(object sender, EventArgs e)
        {

        }

        private void btnSePow1_Click(object sender, EventArgs e)
        {
            if (progBarFire.Value + 5 < progBarFire.Maximum)
            {
                progBarFire.Value = progBarFire.Value + 5;
            }
            else
            {
                Form25 form25 = new Form25();
                form25.ShowDialog();
            }
        }

        private void btnSePow2_Click(object sender, EventArgs e)
        {
            if (progBarFire.Value + 10 < progBarFire.Maximum)
            {
                progBarFire.Value = progBarFire.Value + 10;
            }
            else
            {
                Form25 form25 = new Form25();
                form25.ShowDialog();
            }
        }

        private void btnDoPow1_Click(object sender, EventArgs e)
        {
            if (progBarFire.Value + 5 < progBarFire.Maximum)
            {
                progBarFire.Value = progBarFire.Value + 5;
            }
            else
            {
                Form25 form25 = new Form25();
                form25.ShowDialog();
            }
        }

        private void btnDoPow2_Click(object sender, EventArgs e)
        {
            if (progBarFire.Value + 10 < progBarFire.Maximum)
            {
                progBarFire.Value = progBarFire.Value + 10;
            }
            else 
            {
                Form25 form25 = new Form25();
                form25.ShowDialog();
            }
        }

    }
}
