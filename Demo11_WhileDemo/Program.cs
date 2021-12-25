using System;
using System.Diagnostics;

namespace Demo11_WhileDemo
{//1 paint
//2  notepdad
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1)Paint");
                Console.WriteLine("2)Notepad");
                Console.WriteLine("3)Exit");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Process.Start("mspaint");
                        break;

                    case "2":
                        Process.Start("notepad");
                        break;
                        
                    case "3":
                        return;

                    default:
                        Console.WriteLine("Input Invalid Try Again");
                        Console.ReadKey();
                        break;
                }
            }
            
        }
    }
}
