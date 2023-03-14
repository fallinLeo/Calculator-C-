using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_4TH_WEEK
{
    public partial class Form1 : Form
    {
        double xmin = -5, xmax = 20;
        double ymin = -5, ymax = 100;
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

        private void draw_Click(object sender, EventArgs e)
        {
            const int ndat = 6;
            double[] xw = new double[ndat] { 1, 2, 3, 4, 5, 6 };
            double[] yw = new double[ndat] { 2.1, 7.7, 13.6, 27.2, 40.9, 61.1 };

            Graphics grp = pictureBox1.CreateGraphics();
            grp.DrawLine(new Pen(Color.Black), xpixel(xmin), ypixel(0), xpixel(xmax), ypixel(0));
            grp.DrawLine(new Pen(Color.Black), xpixel(0), ypixel(ymin), xpixel(0), ypixel(ymax));

            for (int i = 0; i < ndat; i++)
            {
                grp.DrawEllipse(new Pen(Color.Red), xpixel(xw[i]), ypixel(yw[i]), 2, 2);
            }

            //행렬곱 성분 생성
            double sumX = 0, sumXX = 0, sumXXX = 0, sumXXXX = 0;
            double sumY = 0, sumXY = 0, sumXXY = 0;
            for (int i = 0; i < ndat; i++)
            {
                sumX += xw[i];
                sumXX += xw[i] * xw[i];
                sumXXX += xw[i] * xw[i] * xw[i];
                sumXXXX += xw[i] * xw[i] * xw[i] * xw[i];
                sumY += yw[i];
                sumXY += xw[i] * yw[i];
                sumXXY += xw[i] * xw[i] * yw[i];
            }
            //배열 생성
            double[,] array = new double[3, 3];
            double Det, DetX, DetY, DetZ;
            //A행렬 초기화 시작
            array[0, 0] = ndat;
            array[0, 1] = sumX; array[0, 2] = sumXX;
            array[1, 0] = sumX; array[1, 1] = sumXX; array[1, 2] = sumXXX;
            array[2, 0] = sumXX; array[2, 1] = sumXXX; array[2, 2] = sumXXXX;
            //A행렬 초기화 완료
            //크래머법칙 적용

            //det
            Det = array[0, 0] * (array[1, 1] * array[2, 2] - array[1, 2] * array[2, 1]) - array[0, 1] * (array[1, 0] * array[2, 2] - array[2, 0] * array[1, 2]) + array[0, 2] * (array[1, 0] * array[2, 1] - array[2, 0] * array[1, 1]);
            //detx
            array[0, 0] = sumY;
            array[1, 0] = sumXY;
            array[2, 0] = sumXXY;
            DetX = array[0, 0] * (array[1, 1] * array[2, 2] - array[1, 2] * array[2, 1]) - array[0, 1] * (array[1, 0] * array[2, 2] - array[2, 0] * array[1, 2]) + array[0, 2] * (array[1, 0] * array[2, 1] - array[2, 0] * array[1, 1]);

            //dety
            //A행렬 초기화 시작
            array[0, 0] = ndat;
            array[0, 1] = sumX; array[0, 2] = sumXX;
            array[1, 0] = sumX; array[1, 1] = sumXX; array[1, 2] = sumXXX;
            array[2, 0] = sumXX; array[2, 1] = sumXXX; array[2, 2] = sumXXXX;
            //A행렬 초기화 완료
            array[0, 1] = sumY;
            array[1, 1] = sumXY;
            array[2, 1] = sumXXY;
            DetY = array[0, 0] * (array[1, 1] * array[2, 2] - array[1, 2] * array[2, 1]) - array[0, 1] * (array[1, 0] * array[2, 2] - array[2, 0] * array[1, 2]) + array[0, 2] * (array[1, 0] * array[2, 1] - array[2, 0] * array[1, 1]);

            //detz
            //A행렬 초기화 시작
            array[0, 0] = ndat;
            array[0, 1] = sumX; array[0, 2] = sumXX;
            array[1, 0] = sumX; array[1, 1] = sumXX; array[1, 2] = sumXXX;
            array[2, 0] = sumXX; array[2, 1] = sumXXX; array[2, 2] = sumXXXX;
            //A행렬 초기화 완료
            array[0, 2] = sumY;
            array[1, 2] = sumXY;
            array[2, 2] = sumXXY;
            DetZ = array[0, 0] * (array[1, 1] * array[2, 2] - array[1, 2] * array[2, 1]) - array[0, 1] * (array[1, 0] * array[2, 2] - array[2, 0] * array[1, 2]) + array[0, 2] * (array[1, 0] * array[2, 1] - array[2, 0] * array[1, 1]);

            //answer
            double a0 = DetX / Det;
            double a1 = DetY / Det;
            double a2 = DetZ / Det;

            //직선 그리기
            int n = 100;
            double k = (xmax - xmin) / n;
            double deltax;
            double deltaxx;
            Console.WriteLine(a0);
            Console.WriteLine(a1);
            Console.WriteLine(a2);
            for (int i=0;i<n;i++)
            {
                deltax = xmin + i * k;
                deltaxx = deltax + k;
                grp.DrawLine(new Pen(Color.Blue), xpixel(deltax), ypixel(a0 + a1 * deltax + a2 * deltax * deltax), xpixel(deltaxx), ypixel(a0 + a1 * deltaxx + a2 * deltaxx * deltaxx));
            }

        }
    }
}
