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

/**
* @name Timovy projekt z IVS
* @author Marek Zelenak
* @date April 2016
* @file Form1.cs
*/

namespace WindowsFormsApplication2
{
/// <summary>
/// Trieda urcuje, co sa stane ked sa klikne na nejaky button.
/// </summary>

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

	/// <summary> Funkcia urcuje, ze ked sa klikne na button , moze sa zadat druhe cislo
	/// </summary>
	/// <param name="sender"> Objekt, v ktorom sa zadavaju cisla </param>
	/// <param name="e"> Je objekt, v ktorom sa uchovavaju data, ked sa klikne na button. </param>
        public void button0_Click(object sender, EventArgs e)
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
	
	/// <summary> Funkcia urcuje, co sa stane ked sa klikne na tlacitko + </summary>
	/// <param name="sender"> Objekt, v ktorom sa zadavaju cisla </param>
	/// <param name="e"> Je objekt, v ktorom sa uchovavaju data, ked sa klikne na button. </param>
        public void buttonPlus_Click(object sender, EventArgs e)
        {
           number1 = double.Parse(elseBox3.Text);
           textBox1.Text += "+";
           elseBox3.Text = "";
           operation = "plus";
         }
	/// <summary> Funkcia urcuje, co sa stane ked sa klikne na tlacitko - </summary>
	/// <param name="sender"> Objekt, v ktorom sa zadavaju cisla </param>
	/// <param name="e"> Je objekt, v ktorom sa uchovavaju data, ked sa klikne na button. </param>
        public void buttonMinus_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(elseBox3.Text);
            textBox1.Text += "-";
            elseBox3.Text = "";
            operation = "minus";
        }
	/// <summary> Funkcia urcuje, co sa stane ked sa klikne na tlacitko * </summary>
	/// <param name="sender"> Objekt, v ktorom sa zadavaju cisla </param>
	/// <param name="e"> Je objekt, v ktorom sa uchovavaju data, ked sa klikne na button. </param>
        public void buttonMul_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(elseBox3.Text);
            textBox1.Text += "*";
            elseBox3.Text = "";
            operation = "multiple";
        }

	/// <summary> Funkcia urcuje, co sa stane ked sa klikne na tlacitko / </summary>
	/// <param name="sender"> Objekt, v ktorom sa zadavaju cisla </param>
	/// <param name="e"> Je objekt, v ktorom sa uchovavaju data, ked sa klikne na button. </param>
        public void buttonDiv_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(elseBox3.Text);
            textBox1.Text += "/";
            elseBox3.Text = "";
            operation = "divide";
        }
	/// <summary> Funkcia urcuje, co sa stane ked sa klikne na tlacitko odmocniny </summary>
	/// <param name="sender"> Objekt, v ktorom sa zadavaju cisla </param>
	/// <param name="e"> Je objekt, v ktorom sa uchovavaju data, ked sa klikne na button. </param>
        public void buttonExp_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(elseBox3.Text);
            textBox1.Text += "ˇ";
            elseBox3.Text = "";
            operation = "exp";
        }
	/// <summary> Funkcia urcuje, co sa stane ked sa klikne na tlacitko ! </summary>
	/// <param name="sender"> Objekt, v ktorom sa zadavaju cisla </param>
	/// <param name="e"> Je objekt, v ktorom sa uchovavaju data, ked sa klikne na button. </param>
        public void buttonFac_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(elseBox3.Text);
            textBox1.Text += "!";
            elseBox3.Text = "0";
            operation = "fac";
        }
	/// <summary> Funkcia urcuje, co sa stane ked sa klikne na tlacitko mocnenia dvoch cisiel </summary>
	/// <param name="sender"> Objekt, v ktorom sa zadavaju cisla </param>
	/// <param name="e"> Je objekt, v ktorom sa uchovavaju data, ked sa klikne na button. </param>
       public void buttonSqrt_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(elseBox3.Text);
            textBox1.Text = "Sqrt: ";
            textBox1.Text += number1;
            elseBox3.Text = "0";
            operation = "sqrt";
            
        }
        
	/// <summary> Funkcia urcuje, co sa stane ked sa klikne na tlacitko C </summary>
	/// <param name="sender"> Objekt, v ktorom sa zadavaju cisla </param>
	/// <param name="e"> Je objekt, v ktorom sa uchovavaju data, ked sa klikne na button. </param>
        public void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            elseBox3.Text = "";
            operation = "";
        }
	/// <summary> Funkcia urcuje, co sa stane ked sa klikne na tlacitko CE </summary>
	/// <param name="sender"> Objekt, v ktorom sa zadavaju cisla </param>
	/// <param name="e"> Je objekt, v ktorom sa uchovavaju data, ked sa klikne na button. </param>
       public void buttonCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            elseBox3.Text = "";
            operation = "";
        }

	/// <summary> Funkcia urcuje, co sa stane ked sa klikne na tlacitko Help, teda vypise sa pomocna hlaska </summary>
	/// <param name="sender"> Objekt, v ktorom sa zadavaju cisla </param>
	/// <param name="e"> Je objekt, v ktorom sa uchovavaju data, ked sa klikne na button. </param>
        public void buttonHlp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"At first click on numbers button to set first value, then
push the button with operation that you want to proceed after that push a 
button with second number than push equal button.

for srq and factorial push only one button a than the operation");
        }
	/// <summary> Funkcia urcuje, co sa stane ked sa klikne na tlacitko =, teda rovna sa </summary>
	/// <param name="sender"> Objekt, v ktorom sa zadavaju cisla </param>
	/// <param name="e"> Je objekt, v ktorom sa uchovavaju data, ked sa klikne na button. </param>
        public void buttonEq_Click(object sender, EventArgs e)
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
