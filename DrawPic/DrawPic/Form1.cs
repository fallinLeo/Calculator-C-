using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawPic
{
    public partial class Form1 : Form
    {        //참조ㄱ
        List<Geom> geoms = new List<Geom>();  // 컨테이너 클래스 List !!
                                              //ㄴ 클래스 자료형 이름 행세  변수이름   생성자
        Random rnd = new Random();
        public Form1()
        {

            InitializeComponent();
        }
        //=======================================
        // 모두 지우고 다시 그리기
        //=======================================
        private void RedrawAll()
        {
            Graphics grp = pictureBox1.CreateGraphics();
            grp.Clear(Color.White);
            for (int i = 0; i < geoms.Count; i++)
            {
                geoms[i].Draw(pictureBox1);  // 다형적 호출
            }

            this.lblNcir.Text = Circle.num.ToString();  // static 멤버의 access
            this.lblNdir.Text = Diamond.num.ToString();
            this.lblNtri.Text = Triangle.num.ToString();  // static 멤버의 access
            this.lblNsta.Text = Star.num.ToString();
            this.lblNtotal.Text = geoms.Count.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDraw3_Click(object sender, EventArgs e)
        {
            Geom geom;
            Color col;

            for (int i = 0; i < 3; i++)
            {
                if (rnd.Next(4) == 0)
                {
                    col = Color.FromArgb(rnd.Next(200), rnd.Next(200), rnd.Next(200));
                    Circle cir = new Circle(rnd.Next(500), rnd.Next(500),
                                            rnd.Next(30), col);
                    geoms.Add(cir);
                }
                else if (rnd.Next(4) == 1)
                {
                    col = Color.FromArgb(rnd.Next(200), rnd.Next(200), rnd.Next(200));
                    Triangle tri = new Triangle(rnd.Next(500), rnd.Next(500),
                                              rnd.Next(30), rnd.Next(30), col);
                    geoms.Add(tri);
                }
                else if (rnd.Next(4) == 2)
                {
                    col = Color.FromArgb(rnd.Next(200), rnd.Next(200), rnd.Next(200));
                    Star sta = new Star(rnd.Next(500), rnd.Next(500),
                                              rnd.Next(500), rnd.Next(500),
                                              rnd.Next(500), rnd.Next(500),
                                              rnd.Next(500), rnd.Next(500),
                                              rnd.Next(500), rnd.Next(500), col);
                    geoms.Add(sta);
                }
                else
                {
                    col = Color.FromArgb(rnd.Next(200), rnd.Next(200), rnd.Next(200));
                    Diamond dia = new Diamond(rnd.Next(500), rnd.Next(500),
                                              rnd.Next(30), rnd.Next(30), col);
                    geoms.Add(dia);
                }
            }

            RedrawAll();
        }

        private void btndraw100_Click(object sender, EventArgs e)
        {
            Color col;
            int ngeom = 100;
            for (int i = 0; i < ngeom; i++)
            {
                int flag = rnd.Next(4);
                if (flag == 0)
                {
                    col = Color.FromArgb(rnd.Next(200), rnd.Next(200), rnd.Next(200));
                    Circle cir = new Circle(rnd.Next(500), rnd.Next(500),
                                            rnd.Next(30), col);
                    geoms.Add(cir);
                }
                else if (flag == 1)
                {
                    col = Color.FromArgb(rnd.Next(200), rnd.Next(200), rnd.Next(200));
                    Triangle tri = new Triangle(rnd.Next(500), rnd.Next(500),
                                              rnd.Next(30), rnd.Next(30), col);
                    geoms.Add(tri);
                }
                else if (flag == 2)
                {
                    col = Color.FromArgb(rnd.Next(200), rnd.Next(200), rnd.Next(200));
                    Star sta = new Star(rnd.Next(200), rnd.Next(200),
                                              rnd.Next(200), rnd.Next(200),
                                              rnd.Next(350), rnd.Next(350),
                                              rnd.Next(500), rnd.Next(500),
                                              rnd.Next(500), rnd.Next(500), col);
                    geoms.Add(sta);
                }
                else
                {
                    col = Color.FromArgb(rnd.Next(200), rnd.Next(200), rnd.Next(200));
                    Diamond dia = new Diamond(rnd.Next(500), rnd.Next(500),
                                              rnd.Next(30), rnd.Next(30), col);
                    geoms.Add(dia);
                }
            }

            RedrawAll();
        }

        private void btnerase_Click(object sender, EventArgs e)
        {
            geoms.Clear();
            Circle.num = 0;
            Diamond.num = 0;
            Triangle.num = 0;
            Star.num = 0;
            RedrawAll();
        }
    }
}
