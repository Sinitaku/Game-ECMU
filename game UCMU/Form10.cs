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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void btnTeamElTha3_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13();
            form13.ShowDialog();
        }

        private void btnTeamSeDo3_Click(object sender, EventArgs e)
        {
            Form14 form14 = new Form14();
            form14.ShowDialog();
        }
    }
}
