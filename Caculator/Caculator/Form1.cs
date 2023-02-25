using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Caculator
{
    public partial class Form1 : Form
    {
        List<int> Number = new List<int>() { 0 };
        int cnt = 0;
        enum Operators
        { 
            None,
            Add,
            Subtract,
            Multiply,
            Divide,
            Result
        }
        Operators currentOperator = Operators.None;
        

        public Form1()
        {
            InitializeComponent();
        }

        void reset()
        {
            cnt = 0;
            Number = new List<int>() { 0 };
            currentOperator = Operators.None;
            label1.Text = "0";
            label2.Text = "0";
            answer.Text = "ans";
        }

        void Operator_check()
        {
            if(currentOperator == Operators.Result)
            {
                //reset();
            }

        }

        void expression_check()
        {
            

            if (Number.Count == 1)
            {
                string strNumber = label2.Text += Number[cnt];
                int intNumber = Convert.ToInt32(strNumber);
                label2.Text = intNumber.ToString();
            }
            else if(currentOperator == Operators.Add)
            {
                label2.Text += Convert.ToString(Number[cnt]);
            }
            else if(currentOperator == Operators.Subtract)
            {
                label2.Text += Convert.ToString(Number[cnt] * (-1));
            }
            

        }

        
        
        private void button_0_Click(object sender, EventArgs e)
        {
            Operator_check();
            string strNumber = label1.Text += "0";
            int intNumber = Convert.ToInt32(strNumber);
            label1.Text = intNumber.ToString();
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            Operator_check();
            string strNumber = label1.Text += "1";
            int intNumber = Convert.ToInt32(strNumber);
            label1.Text = intNumber.ToString();
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            Operator_check();
            string strNumber = label1.Text += "2";
            int intNumber = Convert.ToInt32(strNumber);
            label1.Text = intNumber.ToString();
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            Operator_check();
            string strNumber = label1.Text += "3";
            int intNumber = Convert.ToInt32(strNumber);
            label1.Text = intNumber.ToString();
        }
        private void button_4_Click(object sender, EventArgs e)
        {
            Operator_check();
            string strNumber = label1.Text += "4";
            int intNumber = Convert.ToInt32(strNumber);
            label1.Text = intNumber.ToString();
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            Operator_check();
            string strNumber = label1.Text += "5";
            int intNumber = Convert.ToInt32(strNumber);
            label1.Text = intNumber.ToString();
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            Operator_check();
            string strNumber = label1.Text += "6";
            int intNumber = Convert.ToInt32(strNumber);
            label1.Text = intNumber.ToString();
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            Operator_check();
            string strNumber = label1.Text += "7";
            int intNumber = Convert.ToInt32(strNumber);
            label1.Text = intNumber.ToString();
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            Operator_check();
            string strNumber = label1.Text += "8";
            int intNumber = Convert.ToInt32(strNumber);
            label1.Text = intNumber.ToString();
        }

        
        private void button_equal_Click(object sender, EventArgs e)
        {
            int sum = 0;
            if (currentOperator == Operators.Subtract)
            {
                Number[cnt] = Convert.ToInt32(label1.Text) * (-1);
            }
            else
            {
                Number[cnt] = Convert.ToInt32(label1.Text);
            }
            
            for(int i=0;i<Number.Count;i++)
            {
                sum += Number.ElementAt(i);
                
            }
            expression_check();
            answer.Text = Convert.ToString(sum);
            currentOperator = Operators.Result;
        }

        private void button_C_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            Operator_check();
            string strNumber = label1.Text += "9";
            int intNumber = Convert.ToInt32(strNumber);
            label1.Text = intNumber.ToString();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            Operator_check();
            if (currentOperator == Operators.Subtract)
            {
                Number[cnt] = Convert.ToInt32(label1.Text) * (-1);
            }
            else
            {
                Number[cnt] = Convert.ToInt32(label1.Text);
            }
            expression_check();
            label2.Text += "+";

            cnt++;
            Number.Add(0);
            currentOperator = Operators.Add;

            label1.Text = "0";

        }


        private void button_Subtract_Click(object sender, EventArgs e)
        {
            Operator_check();
            
            if (currentOperator==Operators.Subtract)
            {
                Number[cnt] = Convert.ToInt32(label1.Text)*(-1);
            }
            else
            {
                Number[cnt] = Convert.ToInt32(label1.Text);
            }
            expression_check();
            label2.Text += "-";
            cnt++;
            Number.Add(0);
            currentOperator = Operators.Subtract;

            label1.Text = "0";
        }

        private void button_Multiply_Click(object sender, EventArgs e)
        {


            currentOperator = Operators.Multiply;
            label1.Text = "0";
        }
    }
}
