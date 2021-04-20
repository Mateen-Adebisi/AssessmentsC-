using System;

namespace Assingment
{
    public class Num5
    {
        public static void RevercetheWordofaSectence()
        {
            Console.Write("Enter a word:  ");
            string word = Console.Readline();

            string reverseWordString = string.Join("", word.Split(' ').select(x => new String(x.Reverse().ToArray())));
            Console.WriteLine($"Reverse Word String : {reverseWordString}");
        }
    }
}