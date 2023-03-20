﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace hanguk
{
    public partial class Form1 : Form
    {
        double xmin = 0;
        double ymin = 350;
        double xmax = 350;
        double ymax = 0;

        private float xpixel(double xw)
        {
            return (float)(pictureBox1.ClientSize.Width * (xw - xmin) / (xmax - xmin));

        }
        private float ypixel(double yw)
        {
            return (float)(pictureBox1.ClientSize.Height * (1 - (yw - ymin) / (ymax - ymin)));
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Draw_Click(object sender, EventArgs e)
        {
            //파일 이름 얻기
            DialogResult rtn = openFileDialog1.ShowDialog();
            if(rtn != DialogResult.OK)
            {
                return;
            }
            string fname = openFileDialog1.FileName;
            lblFileName.Text = fname;

            //파일 읽기
            string[] stAll = File.ReadAllLines(fname);
            int cnt = Convert.ToInt32(stAll[0]);

            int[] xp = new int[cnt];
            int[] yp = new int[cnt];

            for (int i = 0; i < cnt; i++)
            {
                char[] sep = new char[] { ',' };
                string[] word = stAll[i + 1].Split(sep);
                xp[i] = Convert.ToInt32(word[0].Trim());
                yp[i] = Convert.ToInt32(word[1].Trim());
            }

            //그리기
            Graphics grp = pictureBox1.CreateGraphics();
            for (int i = 1; i < cnt; i++)
            {
                grp.DrawLine(new Pen(Color.Black), xpixel(xp[i - 1]), ypixel(yp[i - 1]), xpixel(xp[i]), ypixel(yp[i]));
            }


        }
    }
}
