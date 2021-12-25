using System;

namespace Demo6_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter Day");
            string day = Console.ReadLine();

            switch (day)
            {
                case "sat":
                    Console.WriteLine("Study C# Programming");
                    break;
                case "sun":
                    Console.WriteLine("Study ASP .NET Programming");
                    break;
                case "mon":
                    Console.WriteLine("Study Unit Testing");
                    break;
                case "tus":
                    Console.WriteLine("Study C# Programming");
                    break;
                case "wed":
                    Console.WriteLine("Do C# Project");
                    break;
                case "thr":
                    Console.WriteLine("Do ASP .NET Project");
                    break;
                case "fri":
                    Console.WriteLine("Take a Break");
                    break;
                default:
                    Console.WriteLine("input not valid. try Again");
                    break;
            }

        }
    }
}
