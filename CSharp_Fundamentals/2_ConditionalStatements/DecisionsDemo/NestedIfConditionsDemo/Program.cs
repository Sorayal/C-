// Demo for nested conditional code. Too much nested if-conditions is not
// good for code quality and readability. 

using System;

namespace NestedIfConditionsDemo
{
    class Program
    {
        static void Main()
        {
            bool isAdmin = false;
            bool isRegistered = true;
            string userName;
            Console.WriteLine("Please enter your username: ");
            userName = Console.ReadLine();

            if (isRegistered)
            {
                Console.WriteLine("Hello registered User!");
                if(userName != "")
                {
                    Console.WriteLine($"Hello, {userName}");
                    if(userName.Equals("Admin"))
                    {
                        Console.WriteLine("Hello Admin!");
                        isAdmin = true;
                    }
                }
            }
            else
            {
                Console.WriteLine("Hello unregistered User.");
            }

            if (isAdmin)
            {
                Console.WriteLine("Administrator Mode!");
            }
        }
    }
}
