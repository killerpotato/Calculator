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



        public FormMain()
        {
            InitializeComponent();
        }

        private string add(double firstNumber, double secondNumber)
        {
            return (firstNumber + secondNumber).ToString();
        }

        //Eine Methode um die Berechnungen auszuführen!
        //Die Anderen Click Mehthode, sind nur zum hinzufügen von Zeichen!
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            if(textBoxAusgabe.Text.Contains("+"))
            {
                double firstNumber = Convert.ToDouble(textBoxAusgabe.Text.Substring(0, textBoxAusgabe.Text.Length -1  - textBoxAusgabe.Text.IndexOf('+')));
                double secondNumber = Convert.ToDouble(textBoxAusgabe.Text.Substring((textBoxAusgabe.Text.Length) - textBoxAusgabe.Text.IndexOf('+')));             
                textBoxAusgabe.Text = add(firstNumber, secondNumber).ToString();
            }
        }

        private void addChar(string zeichen)
        {
            if (textBoxAusgabe.Text == "0" && zeichen != "+" && zeichen != "0")
            {
                textBoxAusgabe.Text = zeichen;
            }
            else
            {
                textBoxAusgabe.Text += zeichen;
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            addChar("+");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            addChar("0");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addChar("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addChar("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addChar("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addChar("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            addChar("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            addChar("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            addChar("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            addChar("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            addChar("9");
        }
    }
}
