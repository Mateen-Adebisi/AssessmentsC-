using System;

namespace Class1
{
    public class Num1
    {
        public static void DivisionofTwoNumers()
        {
            Console.WriteLine("Enter your number");
            double number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Arthmetic Operator ");
            string value = Console.ReadLine();

            Console.WriteLine("Enter the second number");
            double number2 = Convert.ToInt32(Console.ReadLine());

            if (value == "/")
            {
            Console.WriteLine(number1 / number2);
            }
            else
            {
            Console.WriteLine("invalid input");
            }
        }
       
    }
}