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
    public partial class Form24 : Form
    {
        public Form24()
        {
            InitializeComponent();
        }

        private void btnTeamElTha4_Click(object sender, EventArgs e)
        {
            Form22 form22 = new Form22();
            form22.ShowDialog();
        }

        private void btnTeamSeDo4_Click(object sender, EventArgs e)
        {
            Form19 form19 = new Form19();
            form19.ShowDialog();
        }
    }
}
