using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework__
{
    public partial class Form1 : Form
    {

        int X_velocity = 0;
        int Y_velocity = 0;
        
        void check_location()
        {
            if (Box.Left >= this.ClientSize.Width-Box.Size.Width || Box.Left <= 0 || Box.Top >= this.ClientSize.Height - Box.Size.Height || Box.Top <= 0)
            {
                if( Box.Left >= this.ClientSize.Width - Box.Size.Width || Box.Left <= 0)
                {
                    X_velocity *= -1;
                }
                if (Box.Top >= this.ClientSize.Height - Box.Size.Height || Box.Top <= 0)
                {
                    Y_velocity *= -1;
                }
            }
            if(Box.Left>=(this.ClientSize.Width - Box.Size.Width )/ 2||Box.Top>=(this.ClientSize.Height - Box.Size.Height )/ 2)
            {
                Box.BackColor = Color.Blue;
            }
            else
            {
                Box.BackColor = Color.Red;
            }

        }
        void Move_button(bool check)
        {
            if (check == true)
            {
                Box.Left += 1 * X_velocity;
                Box.Top += 1 * Y_velocity;
                check_location();

            }
            
        }

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            Box.BackColor = Color.Red;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Move_button(S_low.Checked);
            Move_button(F_ast.Checked);
        }

        private void S_low_CheckedChanged(object sender, EventArgs e)
        {
            if (X_velocity > 0)
            {
                X_velocity = 15;
            }
            else X_velocity = -15;
            if (Y_velocity > 0) Y_velocity = 15;
            else Y_velocity =-15;
        }

        private void F_ast_CheckedChanged(object sender, EventArgs e)
        {
            if (X_velocity > 0)
            {
                X_velocity = 20;
            }
            else X_velocity = -20;
            if (Y_velocity > 0) Y_velocity = 20;
            else Y_velocity = -20;
        }
    }
}
