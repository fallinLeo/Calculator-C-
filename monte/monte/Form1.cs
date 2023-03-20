﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace monte
{
    public partial class Form1 : Form
    {
        const int nPoint = 10000;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            int wd = pictureBox1.ClientSize.Width;
            int ht = pictureBox1.ClientSize.Height;
            int area = wd * ht;

            lblRatioReal.Text = Convert.ToString(100 * 100 / (double)area);

            //
            Graphics grp = pictureBox1.CreateGraphics();

            //랜덤점 발생
            int nIN = 0, nOUT = 0;
            for(int i=0;i<nPoint;i++)
            {
                int xp = rnd.Next(wd);
                int yp = rnd.Next(ht);
                //내부, 외부 판단
                Color col;
                if(InRect(100,100,199,199,xp,yp))
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

            btnStart.Enabled = true;

        }
        private bool InRect(int xmin, int ymin, int xmax, int ymax, int xp, int yp)
        {
            if (xp < xmin) return false;
            if (xp > xmax) return false;
            if (yp < ymin) return false;
            if (yp > ymax) return false;
            else return true;
        }
    }
}
