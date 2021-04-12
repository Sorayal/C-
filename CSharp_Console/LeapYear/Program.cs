using System;
using System.Collections.Generic;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            bool rightInput = false;
            int actualYear = 0;

            Console.WriteLine("Leap Year Calculation");
            while (!rightInput)
            {               
                Console.WriteLine("Enter year to figure out, if it's a leap year.");
                string input = Console.ReadLine();
                rightInput = Int32.TryParse(input, out actualYear);
                if(rightInput == false)
                {
                    Console.WriteLine("Wrong input.");
                }
                else if(actualYear >= 1582 == false)
                {
                    Console.WriteLine("Input out of range. Lower limit for valid year: 1582");
                }
            }


            bool IsLeapYear = LeapYearCalculation.TestIfInputIsLeapYear(actualYear);
            Console.WriteLine($"Is {actualYear} ? : {IsLeapYear}");
            Console.WriteLine("##############################");

            //List to check
            List<int> years = new List<int>();
            for (int i = 1582; i < 2030; i++)
            {
                years.Add(i);
            }

            foreach (var currentYear in years)
            {
                IsLeapYear = LeapYearCalculation.TestIfInputIsLeapYear(currentYear);
                Console.WriteLine($"Is {currentYear} ? : {IsLeapYear}");
            }          
        }
    }
}
