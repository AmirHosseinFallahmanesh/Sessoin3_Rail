using System;

namespace Demo7_For
{
    //for
    //while
    //do While

    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            a = a + 1;
            a += 1;
            a++;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("__________________________");
            for (int i = 1; i < 1000; i*=2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("____________________________");
            for (int i = 0; i < 10; i++)
            {
                if (i==5)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("____________________________");
            for (int i = 0; i < 10; i++)
            {
                if (i==5)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }
    }
}
