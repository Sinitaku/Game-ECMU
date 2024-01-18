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
    public partial class Form23 : Form
    {
        public int pisteet { get; set; }
        public Form23()
        {
            InitializeComponent();
        }

        private void btnTeamElTha4_Click(object sender, EventArgs e)
        {
            Form20 form20 = new Form20();
            form20.pisteet = pisteet;
            form20.ShowDialog();
        }

        private void btnTeamSeDo4_Click(object sender, EventArgs e)
        {
            Form21 form21 = new Form21();
            form21.pisteet = pisteet;
            form21.ShowDialog();
        }
    }
}
