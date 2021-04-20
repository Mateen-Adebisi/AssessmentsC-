using System;

namespace Assingment
{
    public class Num2
    {
        public static void SwapingofTwoNumbers()
        {

            int num1;
            int num2;
            int biku;

            Console.WriteLine("Enter your first number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your second number");
            num2 = int.Parse(Console.ReadLine());

            biku = num1;
            num1 = num2;
            num2 = biku;

            Console.WriteLine("Swapping");
            Console.WriteLine("First Number: " + num1);
            Console.WriteLine("Second Number: " + num2);
        }
    }
}