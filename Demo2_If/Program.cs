using System;

namespace Demo2_If
{
    class Program
    {
        static void Main(string[] args)
        {
            //<    <=  >   >=  ==  !=


            int value = 10;

            if (value<10)
            {
                Console.WriteLine("value lower than 10");
            }
            else
            {
                Console.WriteLine("value higher than 10");
            }

            if (value==10)
            {
                Console.WriteLine("value equal 10");
            }
            else
            {
                Console.WriteLine("value not equal 10");

            }

        }
    }
}
