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
    public partial class Form25 : Form
    {
        public int pisteet { get; set; }
        public Form25()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (pisteet < 200)
            {
                Form3 form3 = new Form3();
                form3.ShowDialog();
                
            }
            else
            {
                Form7 form7 = new Form7();
                form7.ShowDialog();
            }
        }
    }
}
