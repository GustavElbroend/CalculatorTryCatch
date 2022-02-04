using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTryCatch
{
    public class Calculator
    {
        //This is going to be a simple calculator, that does not handles large numbers

        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Subtract(double a, double b)
        {
            return a - b;
        }
        public double Multiply(double a, double b)
        {
            return a * b;
        }
        public double Power(double a, double b)
        {
            return Math.Pow(a,b);
        }
    }
}
