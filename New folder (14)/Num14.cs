using System;

namespace Assingment
{
    public class Num14
    {
        public static void checkifagivenpositivenumber()
        {
             Console.WriteLine("\nInput first integer:");  
           int x = Convert.ToInt32(Console.ReadLine());
           if (x > 0)
           {
              Console.WriteLine(x % 3 == 0 || x % 7 == 0);
           }
        }
    }
}