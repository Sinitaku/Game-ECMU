using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game_UCMU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Thread thread = new Thread(CloseAfterTime);
            thread.Start();
        }
        private void CloseAfterTime()
        {
            int elapsedTime = 0;

            while (true)
            {
                Thread.Sleep(1000); //odota yksi sekunti

                elapsedTime++;

                if (elapsedTime >= maxTime)
                {
                    CloseForm();
                    break;
                }
            }
        }
        private void CloseForm()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(CloseForm));
            }
            else
            {
                MessageBox.Show("Programm is turning off.");
                Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblGameName_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private const int maxTime = 200;


        
    }
}
