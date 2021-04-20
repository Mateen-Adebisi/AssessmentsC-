using System;

namespace Assingment
{
     class Num4
    {
        public static void myCalculator()
        {
            // Calculator myCalculator = new Calculator();

            Console.WriteLine("Enter your number");
            double number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Arthimetic operator ");
            string value = Console.ReadLine();

            Console.WriteLine("Enter the second number");
            double number2 = Convert.ToInt32(Console.ReadLine());




            if (value == "plus" || value == "+")
            {
                double result = number1 + number2;
                Console.WriteLine(result);
            }
            else if (value == "subtract" || value == "-")
            {
                double result = number1 - number2;
                Console.WriteLine(result);
            }
            else if (value == "divide" || value == "/")
            {
                double result = number1 / number2;
                Console.WriteLine(result);
            }
            else if (value == "multiply" || value == "*")
            {
                double result = number1 * number2;
                Console.WriteLine(result);
            }
            else if (value == "modulus" || value == "%")
            {
                double result = number1 % number2;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("invalid input");
            }
        }
    }
}