using System;

namespace Demo9_While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text");
            string text = Console.ReadLine();
            Console.WriteLine("Press q To Exit,You Enterd :"+text);
            while (text!="q")
            {
                Console.WriteLine("Enter text");
                 text = Console.ReadLine();
                Console.WriteLine("Press q To Exit,You Enterd :" + text);

            }
            Console.WriteLine("Good Bye");

        }
    }
}
