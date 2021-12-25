using System;
//A Accounting
//A Authentication
//a Authorization

//username admin, password 123
namespace Demo4_Authentication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Username");
            string username = Console.ReadLine();

            Console.WriteLine("Enter Password");
            string password = Console.ReadLine();

            if (username=="admin" && password=="123")
            {
                Console.WriteLine("Welcome To My Application");
            }
            else
            {
                Console.WriteLine("Username or Password Not Found");
            }
        }
    }
}
