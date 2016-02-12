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
    public partial class FormMain : Form
    {
        private double firstNumber = 0;
        private double secondNumber = 0;


        public FormMain()
        {
            InitializeComponent();
        }

        private double add(double firstNumber, double secondNumber)
        {
           return firstNumber + secondNumber;
            
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            if(textBoxAusgabe.Text.Contains("+"))
            {
                secondNumber = Convert.ToDouble(textBoxAusgabe.Text.TrimStart('+'));               
                textBoxAusgabe.Text = add(firstNumber, secondNumber).ToString();
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBoxAusgabe.Text);
            textBoxAusgabe.Text += "+";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBoxAusgabe.Text += 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxAusgabe.Text += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxAusgabe.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxAusgabe.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxAusgabe.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxAusgabe.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxAusgabe.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxAusgabe.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxAusgabe.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxAusgabe.Text += 9;
        }
    }
}
