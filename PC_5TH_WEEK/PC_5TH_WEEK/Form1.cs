using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_5TH_WEEK
{
    public partial class Form1 : Form
    {
        const int nPoint = 20000;
        Random rnd = new Random();


        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Start.Enabled = false;

            int wd = pictureBox1.ClientSize.Width;
            int ht = pictureBox1.ClientSize.Height;
            
            Graphics grp = pictureBox1.CreateGraphics();
            double[] P1 = new double[2] { rnd.Next(wd), rnd.Next(ht) };
            double[] P2 = new double[2] { rnd.Next(wd), rnd.Next(ht) };
            double[] P3 = new double[2] { rnd.Next(wd), rnd.Next(ht) };
            double S = ((P1[0] * P2[1] + P2[0] * P3[1] + P3[0] * P1[1]) - (P2[0] * P1[1] + P3[0] * P2[1] + P1[0] * P3[1])) / 2;
            if (S < 0) S *= -1;

            lblRatioReal.Text = Convert.ToString(100 * 100 / S);


            int nIN = 0, nOUT = 0;
            for (int i=0;i<nPoint;i++)
            {
                int xp = rnd.Next(wd);
                int yp = rnd.Next(ht);
                Color col;
                col = Color.Black;


                //내부 외부 판단
                if (InTriangle(P1[0], P2[0], P3[0], P1[1], P2[1], P3[1],xp,yp))
                {
                    nIN++;
                    col = Color.Black;
                }
                else
                {
                    nOUT++;
                    col = Color.FromArgb(0xC0, 0xC0, 0xC0);
                }
                grp.DrawEllipse(new Pen(col), xp, yp, 1, 1);
                lblIN.Text = Convert.ToString(nIN);
                lblOUT.Text = Convert.ToString(nOUT);
                lblRatioMonte.Text = Convert.ToString(nIN / (double)(nIN + nOUT));

                
            }


            Start.Enabled = true;
        }
        private bool InTriangle(double P1x, double P2x, double P3x, double P1y, double P2y, double P3y, double xp, double yp)
        {
            double S1 = ((xp * P1y + P1x * P2y + P2x * yp) - (P1x * yp + P2x * P1y + xp * P2y)) / 2;
            double S2 = ((xp * P2y + P2x * P3y + P3x * yp) - (P2x * yp + P3x * P2y + xp * P3y)) / 2;
            double S3 = ((xp * P3y + P3x * P1y + P1x * yp) - (P3x * yp + P1x * P3y + xp * P1y)) / 2;
            if (S1 > 0 && S2 > 0 && S3 > 0) return true;
            else if (S1 < 0 && S2 < 0 && S3 < 0) return true;
            else return false;

        }
        
    }
}
