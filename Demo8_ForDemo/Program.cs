using System;

namespace Demo8_ForDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Mark Count");
            int markCount = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < markCount; i++)
            {
                Console.WriteLine("Enter Mark");
                int mark = Convert.ToInt32(Console.ReadLine());
                sum += mark;
            }
            double average = sum / markCount;
            Console.WriteLine("the average is "+average);
        }
    }
}
