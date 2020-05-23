using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratorio_7
{
    public partial class Form1 : Form
    {
        double n1;
        double n2;
        string operation;
        string lastans;
        public Form1()
        {
            InitializeComponent();
        }

        Plus obj = new Plus();
        Rest obj2 = new Rest();
        Mult obj3 = new Mult();
        Div obj4 = new Div();

        private void button12_Click(object sender, EventArgs e)
        {
            if (result.Text.Length == 1)
                result.Text = "";
            else
                result.Text = result.Text.Substring(0, result.Text.Length - 1);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void Operatorclick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            n1 = double.Parse(result.Text);
            result.Clear();


        }

        private void ButtonClick(object sender, EventArgs e)
        {
            if (result.Text == "0")
            {
                result.Clear();
            }
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
            
    
        }

        private void same_Click(object sender, EventArgs e)
        {
            n2 = double.Parse(result.Text);
            double sum;
            double res;
            double mul;
            double div;

            switch(operation)
            {
                case "+":
                    sum = obj.plus(n1, n2);
                    result.Text = sum.ToString();
                    lastans = sum.ToString();
                    break;
                case "-":
                    res = obj2.Res(n1, n2);
                    result.Text = res.ToString();
                    lastans = res.ToString();
                    break;
                case "x":
                    mul = obj3.multi(n1, n2);  
                    result.Text = mul.ToString();
                    lastans = mul.ToString();
                    break;
                case "/":
                    div = obj4.Divi(n1, n2);
                    result.Text = div.ToString();
                    lastans = div.ToString();
                    break;
                default:
                    break;
            }
        }

        private void ans_Click(object sender, EventArgs e)
        {
            result.Text = lastans;
        }
    }
}
