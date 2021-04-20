using System;

namespace Assingment
{
    public class Num13
    {
        public static void CheckingLongestWordInAnArray()
        {   
            string line = "oh my god am fucking tired off this trash";
            string[] words = line.Split(new[] { " " }, StringSplitOptions.None);
            string word = "";
            int check = 0;
            foreach (String world in words)
            {
                if (world.Length > check)
                {
                    word = world;
                    check = world.Length;
                }
            }
        
            Console.WriteLine(word);
        }
    }
}