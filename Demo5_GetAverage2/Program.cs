using System;

namespace Demo5_GetAverage2
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

            double avg = (asp + cs + unit) / 3;
            Console.WriteLine("The Average is " + avg);

            if (avg>=0 && avg<5)
            {
                Console.WriteLine("Your Grade is E");
            }
            else if (avg>=5 && avg<10)
            {
                Console.WriteLine("Your Grade is D");
            }
            else if (avg >= 10 && avg < 15)
            {
                Console.WriteLine("Your Grade is C");
            }
            else if (avg >= 15 && avg < 20)
            {
                Console.WriteLine("Your Grade is B");
            }
            else if (avg== 10)
            {
                Console.WriteLine("Your Grade is A");
            }
            else
            {
                Console.WriteLine("average not valid");
            }
        }

    }
}
// 0 -5 E
// 5 - 10 D
//10 15  C
//15 20 B
//20 A