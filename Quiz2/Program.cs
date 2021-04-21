using System;

namespace Assingment
{
    class Program
    {
        static void Main(string[] args)
        {
          

           
           
            

             Quiz2 quiz2 = new Quiz2();

            while (true)
            {
                Console.WriteLine("Enter 'start' to start Stopwatch\nEnter 'stop' to end Stopwach\nEnter any key to exit:\n");
                var input = Console.ReadLine().ToLower();

                if (input == "start" || input == "stop")
                    UseStopwatch(quiz2, input);
                else
                    return;
            }
        }
         static void UseStopwatch(MyWatch quiz2, string command)
        {
            switch (command)
            {
                case "start":
                    try
                    { 
                        
                        quiz2.Start();

                    }
                    catch (InvalidOperationException)
                    { 
                        Console.WriteLine("stopWatch is already started\n");
                        
                    }
                    break;
                case "stop":
                    try
                    {
                        quiz2.Stop();
                        Console.WriteLine("Duration: {0}\n", quiz2.GetDuration());
                    }
                    catch (InvalidOperationException)
                    {
                         Console.WriteLine("stopWatch is not started\n");
                    }
                    break;
                default:
                    break;
            }   
        }
   
   
   
    }
}
