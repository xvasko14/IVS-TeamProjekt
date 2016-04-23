using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "";
            elseBox3.Text = "";
        }

        double number1;
        double number2;
        string operation;
        
        private void button0_Click(object sender, EventArgs e)
        {
            if (elseBox3.Text != "0")
            {
                elseBox3.Text = elseBox3.Text + ((Button)sender).Text;
                textBox1.Text = textBox1.Text + ((Button)sender).Text;
            }
            else
            {
                elseBox3.Text = ((Button)sender).Text;
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
           number1 = double.Parse(elseBox3.Text);
           textBox1.Text += "+";
           elseBox3.Text = "";
           operation = "plus";
         }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(elseBox3.Text);
            textBox1.Text += "-";
            elseBox3.Text = "";
            operation = "minus";
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(elseBox3.Text);
            textBox1.Text += "*";
            elseBox3.Text = "";
            operation = "multiple";
        }


        private void buttonDiv_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(elseBox3.Text);
            textBox1.Text += "/";
            elseBox3.Text = "";
            operation = "divide";
        }

        private void buttonExp_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(elseBox3.Text);
            textBox1.Text += "ˇ";
            elseBox3.Text = "";
            operation = "exp";
        }
        private void buttonFac_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(elseBox3.Text);
            textBox1.Text += "!";
            elseBox3.Text = "0";
            operation = "fac";
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(elseBox3.Text);
            textBox1.Text = "Sqrt: ";
            textBox1.Text += number1;
            elseBox3.Text = "0";
            operation = "sqrt";
            
        }
        

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            elseBox3.Text = "";
            operation = "";
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            elseBox3.Text = "";
            operation = "";
        }


        private void buttonHlp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"At first click on numbers button to set first value, then
push the button with operation that you want to proceed after that push a 
button with second number than push equal button.

for srq and factorial push only one button a than the operation");
        }

        private void buttonEq_Click(object sender, EventArgs e)
        {
            number2 = double.Parse(elseBox3.Text);
            textBox1.Text = "";
            Class1 obj = new Class1();
            double Res = obj.Function(number1, number2, operation);
            textBox1.Text = Res.ToString();
            operation = "";
        }
    }
}
