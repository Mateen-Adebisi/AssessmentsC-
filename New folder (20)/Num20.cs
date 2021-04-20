using System;

namespace Assingment
{
    public class Num20
    {
        public static void CHeckTheCenturyFromYear()
        {
            Console.Write("enter your year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            int total = year / 100 + 1;

            Console.WriteLine(total);
        }
    }
}