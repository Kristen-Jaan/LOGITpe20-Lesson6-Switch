using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning!");
            Console.WriteLine("What Day Of The Week Is It?");
            string Day = Console.ReadLine().ToLower();
            switch (Day)
            {
                case "sunday":
                    Console.WriteLine("Garfield");
                    break;
                case "monday":
                    Console.WriteLine("Shrek");
                    break;
                case "tuesday":
                    Console.WriteLine("Kachaow");
                    break;
                case "wednesday":
                    Console.WriteLine("Nut");
                    break;
                case "thursday":
                    Console.WriteLine("Sanic");
                    break;
                case "friday":
                    Console.WriteLine("Wazowski");
                    break;
                case "saturday":
                    Console.WriteLine("Stinky");
                    break;
                default:
                    Console.WriteLine("What Are You Doing?");
                    break;
            }
        }
    }
}
