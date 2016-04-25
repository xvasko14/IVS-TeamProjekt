using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
* @name Timovy projekt z IVS
* @author Marek Zelenak
* @date April 2016
* @file Class1.cs
*/




namespace ClassLibrary1
{
/// <summary>
/// Trieda, v ktorej je kod na matematicke operacie.
/// </summary>
    public class Class1
    {

	/// <summary>
  	/// Funkcia prevadza matematicke operacie so zadanymi cislami
	/// </summary>
	/// <param name="num1"> Prve zadane cislo</param>
	/// <param name="num2">Druhe zadane cislo</param>
	/// <param name="op">Operacia, ktora sa vykona so zadanymi cislami</param>
	/// <returns>Funkcia vrati hodnotu finRes, co je vysledok matematickej operacie</returns>
        public double Function(double num1, double num2, string op)
        {
	
            double finRes = 0; 
            if (op == "plus")
            {
                finRes = num1 + num2; 
            }
            else if (op == "minus")
            {
                finRes = num1 - num2; 
            }
            else if (op == "multiple")
            {
                finRes = num1 * num2; 
            }
            else if (op == "divide")
            {
                finRes = num1 / num2; 
            }
            else if (op == "exp")
            {
                finRes = Math.Pow(num1, num2); 
            }
            else if (op == "fac") 
            {
                double result = num1; 
                for (double i = (num1) - 1; i > 0; i--)
                {
                    result = result * i;
                    finRes = result;
                }
            }
            else if (op == "sqrt")
            {
                finRes = Math.Sqrt(num1);
            }
            return finRes;
        }
    }
}
