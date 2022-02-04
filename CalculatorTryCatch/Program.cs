using System;

namespace CalculatorTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            bool terminate = true;
            while (terminate)
            {

                Calculator calculator = new Calculator();
                Console.WriteLine("Please select type of calculation");
                Console.WriteLine("1=Add, 2=Subtract, 3=Multiply, 4=Power");

                ConsoleKeyInfo key = Console.ReadKey(true);

                Console.WriteLine("Type the two numbers:");
                double a = Convert.ToDouble(Console.ReadLine());
                double b = Convert.ToDouble(Console.ReadLine());
                double result = 0;
                string operation = "";

                switch (key.KeyChar)
                {
                    case '1':
                        result = calculator.Add(a, b);
                        operation = "Add";
                        break;
                    case '2':
                        result = calculator.Subtract(a, b);
                        operation = "Subtract";
                        break;
                    case '3':
                        result = calculator.Multiply(a, b);
                        operation = "Multiply";
                        break;
                    case '4':
                        result = calculator.Power(a, b);
                        operation = "Power";
                        break;
                }

                Console.WriteLine($"You chose {operation}, and typed: {a}, {b}.\nThe result is: {result}");

                Console.WriteLine("\nDo you want to do another operation?");
                var choice = Console.ReadKey(true);
                switch (choice.KeyChar)
                {
                    case 'y':
                    case 'Y':
                        terminate = true;
                        break;
                    case 'n':
                    case 'N':
                        terminate = false;
                        break;
                }
            }
        }
    }
}
