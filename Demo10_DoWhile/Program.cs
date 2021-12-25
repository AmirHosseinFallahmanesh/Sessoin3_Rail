using System;

namespace Demo10_DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "";
            do
            {
                Console.WriteLine("Enter text");
                 text = Console.ReadLine();
                Console.WriteLine("Press q To Exit,You Enterd :" + text);

            } while (text!="q");
          
           
            Console.WriteLine("Good Bye");

        }
    }
}
