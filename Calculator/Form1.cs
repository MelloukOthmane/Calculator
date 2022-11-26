using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double value;
        string soperator;
        bool check;

        public Form1()
        {
            InitializeComponent();
        }
         
        private void PNumber(Object sender, EventArgs e)
        {
            if ((soperator == "+") || (soperator == "-") || (soperator == "*") || (soperator == "/"))
            {
                if (check)
                {
                    check = false;
                    textBox1.Text = "0";
                }
            }
            Button b = sender as Button;
            if (textBox1.Text == "0")
                textBox1.Text = b.Text;
            else
                textBox1.Text += b.Text;
        }

        private void POperator(Object sender,EventArgs e)
        {
            Button b = sender as Button;
            value = double.Parse(textBox1.Text);
            soperator = b.Text;
            textBox1.Text += b.Text;
            check = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            value = 0;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                switch (soperator)
                {
                    case "+":
                        textBox1.Text = (value + double.Parse(textBox1.Text)).ToString();
                        break;
                    case "-":
                        textBox1.Text = (value - double.Parse(textBox1.Text)).ToString();
                        break;
                    case "*":
                        textBox1.Text = (value * double.Parse(textBox1.Text)).ToString();
                        break;
                    case "/":
                        textBox1.Text = (value / double.Parse(textBox1.Text)).ToString();
                        break;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Message",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
