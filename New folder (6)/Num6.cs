using System;

namespace Assingment

{
    public class Num6
    {
       public static void Multiplication()
       {
            int num;
            Console.WriteLine("Enter any value");
            num = int.Parse(Console.ReadLine());

            for(int i = 0; i <= 1000; i++)
            {
                Console.WriteLine("{0}*{1} = {2}", num, i, num*i);
            }
              
       }
      
    }
}