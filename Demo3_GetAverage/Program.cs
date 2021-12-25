using System;

namespace Demo3_GetAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Asp .net Mark");
            double asp = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter C# Mark");
            double cs = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Unit Testing Mark");
            double unit = Convert.ToDouble(Console.ReadLine());

            double avg = (asp + cs + unit)/3;
            Console.WriteLine("The Average is "+avg);

          }

    }
}
// 0 -5 E
// 5 - 10 D
//10 15  C
//15 20 B
//20 A



