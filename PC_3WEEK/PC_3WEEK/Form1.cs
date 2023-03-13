using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace PC_3WEEK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*void tresh_fuc()
        {
            int a = Convert.ToInt32(txtNumber.Text);
            double Check = Convert.ToInt64(Convert.ToString(a, 2));
            Console.WriteLine(Convert.ToString(a, 2));
            Console.WriteLine(Check / 10);
            if (Check % 10 == 1)
            {
                check_0.Checked = true;
            }
            if (Check % 100 - Check % 10 == 1)
            {
                check_1.Checked = true;
            }
            if ((Check % 1000 - Check % 100) / 100 == 1) check_2.Checked = true;
            if ((Check % 10000 - Check % 1000) / 1000 == 1) check_3.Checked = true;
            if (((Check % 100000 - Check % 10000) / 10000) == 1) check_4.Checked = true;
            if (((Check % 1000000 - Check % 100000) / 100000) == 1) check_5.Checked = true;
            if (((Check % 10000000 - Check % 1000000) / 1000000) == 1) check_6.Checked = true;
            if (((Check % 100000000 - Check % 10000000) / 10000000) == 1) check_7.Checked = true;
        }*/
        private void SetCheckBox(int gB)
        {
            check_0.Checked = (gB & 0x01) != 0;
            check_1.Checked = (gB & 0x02) != 0;
            check_2.Checked = (gB & 0x04) != 0;
            check_3.Checked = (gB & 0x08) != 0;
            check_4.Checked = (gB & 0x10) != 0;
            check_5.Checked = (gB & 0x20) != 0;
            check_6.Checked = (gB & 0x40) != 0;
            check_7.Checked = (gB & 0x80) != 0;
        }
        private void returnCheckBox()
        {
            double sum = 0;
            if (check_0.Checked == true) sum += Math.Pow(2, 0);
            if (check_1.Checked == true) sum += Math.Pow(2, 1);
            if (check_2.Checked == true) sum += Math.Pow(2, 2);
            if (check_3.Checked == true) sum += Math.Pow(2, 3);
            if (check_4.Checked == true) sum += Math.Pow(2, 4);
            if (check_5.Checked == true) sum += Math.Pow(2, 5);
            if (check_6.Checked == true) sum += Math.Pow(2, 6);
            if (check_7.Checked == true) sum += Math.Pow(2, 7);
            txtNumber.Text = Convert.ToString(sum);
            
        }
        private void Check_return()
        {
            if (Convert.ToInt32(textIndex.Text) == 0)
            {
                if (check_0.Checked == true) check_0.Checked = false;
                else if (check_0.Checked == false) check_0.Checked = true;
            }
            if (Convert.ToInt32(textIndex.Text) == 1)
            {
                if (check_1.Checked == true) check_1.Checked = false;
                else if (check_1.Checked == false) check_1.Checked = true;
            }
            if (Convert.ToInt32(textIndex.Text) == 2)
            {
                if (check_2.Checked == true) check_2.Checked = false;
                else if (check_2.Checked == false) check_2.Checked = true;
            }
            if (Convert.ToInt32(textIndex.Text) == 3)
            {
                if (check_3.Checked == true) check_3.Checked = false;
                else if (check_3.Checked == false) check_3.Checked = true;
            }
           
            if (Convert.ToInt32(textIndex.Text) == 4)
            {
                if (check_4.Checked == true) check_4.Checked = false;
                 else if(check_4.Checked ==false) check_4.Checked = true;
            }
            if (Convert.ToInt32(textIndex.Text) == 5)
            {
                if (check_5.Checked == true) check_5.Checked = false;
                else if (check_5.Checked == false) check_5.Checked = true;
            }
            if (Convert.ToInt32(textIndex.Text) == 6)
            {
                if (check_6.Checked == true) check_6.Checked = false;
                else if (check_6.Checked == false) check_6.Checked = true;
            }
            if (Convert.ToInt32(textIndex.Text) == 7)
            {
                if (check_7.Checked == true) check_7.Checked = false;
                else if (check_7.Checked == false) check_7.Checked = true;
            }
        }


        private void htnToRit_Click(object sender, EventArgs e)
        {
            SetCheckBox(Convert.ToInt32(txtNumber.Text));
        }
        
        

        private void btnFromBit_Click(object sender, EventArgs e)
        {
            returnCheckBox();
        }

        private void ON_Click(object sender, EventArgs e)
        {
            
            if (Convert.ToInt32(textIndex.Text) == 0) check_0.Checked = true;
            if (Convert.ToInt32(textIndex.Text) == 1) check_1.Checked = true;
            if (Convert.ToInt32(textIndex.Text) == 2) check_2.Checked = true;
            if (Convert.ToInt32(textIndex.Text) == 3) check_3.Checked = true;
            if (Convert.ToInt32(textIndex.Text) == 4) check_4.Checked = true;
            if (Convert.ToInt32(textIndex.Text) == 5) check_5.Checked = true;
            if (Convert.ToInt32(textIndex.Text) == 6) check_6.Checked = true;
            if (Convert.ToInt32(textIndex.Text) == 7) check_7.Checked = true;
            returnCheckBox();
        }

        private void OFF_Click(object sender, EventArgs e)
        {
            SetCheckBox(Convert.ToInt32(txtNumber.Text));
            if (Convert.ToInt32(textIndex.Text) == 0) check_0.Checked = false;
            if (Convert.ToInt32(textIndex.Text) == 1) check_1.Checked = false;
            if (Convert.ToInt32(textIndex.Text) == 2) check_2.Checked = false;
            if (Convert.ToInt32(textIndex.Text) == 3) check_3.Checked = false;
            if (Convert.ToInt32(textIndex.Text) == 4) check_4.Checked = false;
            if (Convert.ToInt32(textIndex.Text) == 5) check_5.Checked = false;
            if (Convert.ToInt32(textIndex.Text) == 6) check_6.Checked = false;
            if (Convert.ToInt32(textIndex.Text) == 7) check_7.Checked = false;
            returnCheckBox();
        }

        private void Toggle_Click(object sender, EventArgs e)
        {
            Check_return();
            returnCheckBox();
        }

        private void htnShiftUp_Click(object sender, EventArgs e)
        {
            int k = Convert.ToInt32(txtNumber.Text) << 1;
            txtNumber.Text = Convert.ToString(k);
            SetCheckBox(Convert.ToInt32(txtNumber.Text));
        }

        private void btnShiftDown_Click(object sender, EventArgs e)
        {
            int k = Convert.ToInt32(txtNumber.Text) >> 1;
            txtNumber.Text = Convert.ToString(k);
            SetCheckBox(Convert.ToInt32(txtNumber.Text));
        }
    }
}
