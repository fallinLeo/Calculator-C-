using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Run_button
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        Random rnd2 = new Random();

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            button1.Location = new System.Drawing.Point(100, 120);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int sec = Convert.ToInt32(label1.Text);
            sec--;
            label1.Text = Convert.ToString(sec);
            if(sec==0)
            {
                timer1.Enabled = false;
                MessageBox.Show("ㅋㅋ속았지??");
                Application.Exit();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.Left = rnd.Next(this.Width - button1.Width);
            button1.Top = rnd.Next(this.Height - button1.Height);
        }
    }
}
