using System;

namespace SwitchCaseDemo
{
    class Program
    {
        static void Main()
        {
            int age = 15;

            switch (age)
            {
                case 15:
                case 16:
                case 17:
                    Console.WriteLine("Too young for the party!");
                    break;
                case 25:
                    Console.WriteLine("Alright, party!");
                    break;
                // Like else in a if-else condtion
                // default case should be always implemented
                default:
                    Console.WriteLine("How old are you?");
                    break;
            }

            if(age == 15 || age == 16 || age == 17)
                Console.WriteLine("Too young for the party!");
            else if(age == 25)
                Console.WriteLine("Alright, party!");
            else
                Console.WriteLine("How old are you?");


            Console.WriteLine("Enter your name: ");
            string userName = Console.ReadLine();
            switch (userName)
            {
                case "Sascha":
                    Console.WriteLine("Hello, Sascha!");
                    break;
                default:
                    Console.WriteLine("Hello, stranger!");
                    break;
            }
        }
    }
}
