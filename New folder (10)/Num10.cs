using System;

namespace Assingment
{
    public class Num10
    {
         public static void Main(string[] args)
         {
            Console.WriteLine(Num01("Melena"));
        }
        public static string Num01(string well)
        {
            return well.Length > 1
            ? well.Substring(well.Length - 1) + well.Substring(1, well.Length - 2) + well.Substring(0, 1) : well;
        }
    }
}