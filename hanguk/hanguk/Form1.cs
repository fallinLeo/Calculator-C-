using System;
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
        }
    }
}
