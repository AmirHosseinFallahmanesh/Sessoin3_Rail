using System;

namespace Demo4_Authentication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Username");
            string username = Console.ReadLine();
            if (username=="admin")
            {
                Console.WriteLine("Enter Password");
                string passwrod = Console.ReadLine();
                if (passwrod=="123")
                {
                    Console.WriteLine("Welcome To My App");
                }
                else
                {
                    Console.WriteLine("Password Not Valid");
                }
            }
            else
            {
                Console.WriteLine("Username Not Valid");
            }

        }
    }
}
