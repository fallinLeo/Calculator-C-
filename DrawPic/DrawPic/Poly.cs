using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawPic
{
    class Geom
    {

        public virtual void Draw(PictureBox pic)
        {

        }
        public Color col;
    }
    class Circle : Geom
    {
        private int xcen, ycen, radius;
        public static int num;

        public Circle(int xcen, int ycen, int radius, Color col)
        {
            this.col = col;     // 상속된 속성
            this.xcen = xcen;   // 확장된 속성
            this.ycen = ycen;
            this.radius = radius;
            num++;              // static 멤버
        }

        public override void Draw(PictureBox pic)
        {
            Graphics grp = pic.CreateGraphics();
            grp.DrawEllipse(new Pen(col), xcen, ycen, radius * 2, radius * 2);
        }
    }

    class Diamond : Geom
    {
        private int xcen, ycen, xsize, ysize;
        public static int num;

        public Diamond(int x, int y, int xs, int ys, Color col)
        {
            this.col = col;
            this.xcen = x;
            this.ycen = y;
            this.xsize = xs;
            this.ysize = ys;
            num++;
        }

        public override void Draw(PictureBox pic)
        {
            Graphics grp = pic.CreateGraphics();
            grp.DrawLine(new Pen(col), xcen + xsize / 2, ycen, xcen, ycen + ysize / 2);
            grp.DrawLine(new Pen(col), xcen, ycen + ysize / 2, xcen - xsize / 2, ycen);
            grp.DrawLine(new Pen(col), xcen - xsize / 2, ycen, xcen, ycen - ysize / 2);
            grp.DrawLine(new Pen(col), xcen, ycen - ysize / 2, xcen + xsize / 2, ycen);
        }
    }
    class Triangle : Geom
    {
        private int xcen, ycen, width, height;
        public static int num;

        public Triangle(int x, int y, int xw, int yh, Color col)
        {
            this.col = col;
            this.xcen = x;
            this.ycen = y;
            this.width = xw;
            this.height = yh;
            num++;
        }

        public override void Draw(PictureBox pic)
        {
            Graphics grp = pic.CreateGraphics();
            grp.DrawLine(new Pen(col), xcen - width, ycen, xcen, ycen);
            grp.DrawLine(new Pen(col), xcen, ycen, xcen, ycen + height);
            grp.DrawLine(new Pen(col), xcen - width, ycen, xcen, ycen + height);


        }
    }
    class Star : Geom
    {
        private int x1, y1, x2, y2, x3, y3, x4, y4, x5, y5;
        public static int num;

        public Star(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4, int x5, int y5, Color col)
        {
            this.col = col;
            this.x1 = x1;
            this.x2 = x2;
            this.x3 = x3;
            this.x4 = x4;
            this.x5 = x5;
            this.y1 = y1;
            this.y2 = y2;
            this.y3 = y3;
            this.y4 = y4;
            this.y5 = y5;
            num++;
        }

        public override void Draw(PictureBox pic)
        {
            Graphics grp = pic.CreateGraphics();
            grp.DrawLine(new Pen(col), x1, y1, x2, y2);
            grp.DrawLine(new Pen(col), x2, y2, x3, y3);
            grp.DrawLine(new Pen(col), x3, y3, x4, y4);
            grp.DrawLine(new Pen(col), x4, y4, x5, y5);
            grp.DrawLine(new Pen(col), x5, y5, x1, y1);

        }
    }



}
