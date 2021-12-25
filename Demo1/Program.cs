using System;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "amir";
            Console.WriteLine("Hello "+name);

            Console.WriteLine("Enter Name");
            string name2 = Console.ReadLine();
            Console.WriteLine("Hello "+name2);


            Console.WriteLine("Enter Number1");
            int number1 =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter Number2");
            int number2 =Convert.ToInt32( Console.ReadLine());
            int result = number1 + number2;

            Console.WriteLine("The Result is "+result);

           
        }
    }
}
