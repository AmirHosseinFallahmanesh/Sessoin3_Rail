using System;

namespace Demo11_Random
{
    class Program
    {
        static void Main(string[] args)
        {

            Random randomMachine = new Random();
            int a=randomMachine.Next(1, 100);
            Console.WriteLine(a);
                
                
        }
    }
}
