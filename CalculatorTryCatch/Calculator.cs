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
            if(a<100&&b<100)
                return a + b;
            else
            {
                throw new Exception("Number to large");
            }
        }
        public double Subtract(double a, double b)
        {
            if (a < 100 && b < 100)
                return a - b;
            else
            {
                throw new Exception("Number to large");
            }
        }
        public double Multiply(double a, double b)
        {
            if (a < 100 && b < 100)
                return a * b;
            else
            {
                throw new Exception("Number to large");
            }
        }
        public double Power(double a, double b)
        {
            if (a < 100 && b < 100)
                return Math.Pow(a, b);
            else
            {
                throw new Exception("Number to large");
            }
        }
    }
}
