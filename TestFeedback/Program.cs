using System;

namespace TestFeedback
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning!");
            Console.WriteLine("What Is Your Test Result?");
            string Test = Console.ReadLine().ToLower();
            switch (Test)
            {
                case "a":
                    Console.WriteLine("Excellent");
                    break;
                case "b":
                    Console.WriteLine("Very Good");
                    break;
                case "c":
                    Console.WriteLine("Passed");
                    break;
                case "d":
                    Console.WriteLine("Failed");
                    break;
                default:
                    Console.WriteLine("Wasted");
                    break;
            }
        }
    }
}
