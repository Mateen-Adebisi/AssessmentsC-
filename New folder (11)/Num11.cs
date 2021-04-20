namespace Assingment
{
    public class Num9
    {
        static void Main(string[] args)
        {
            Num9.ComputeThesumAGivenIn();
        }
        public static void ComputeThesumAGivenIn()
        {
            int num1 = 43;
            int num2 = 43;
            int total = num1 + num2;
            Console.WriteLine(total);
            if (num1 == num2)
            {
                Console.WriteLine(total * 3);
            }
        }

    }
}