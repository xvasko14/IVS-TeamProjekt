using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        private double Function(double num1, double num2, string op)
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
