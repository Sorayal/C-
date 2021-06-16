using System;

namespace DecisionsDemo
{
    class Program
    {
        static void Main()
        {
            //if (condition)
            //{
            //    execute code
            //}
            //else if (condition)
            //{
            //    execute code if second condition is meet
            //    more else if conditions won´t be checked if this conditon is meet
            //}
            //else
            //{
            //    alternative code execution if condition is not meet
            //}


            int temperature;
            while (true)
            {
                Console.WriteLine("Enter a temperature value: \n");
                string input = Console.ReadLine();
                bool validInput = Int32.TryParse(input, out temperature);
                if (!validInput || temperature < -273)
                {
                    Console.WriteLine("Invalid value");
                }
                else
                {
                    break;
                }
            }

            if (temperature < 20)
            {
                Console.WriteLine("It´s cold!");
            }
            else if(temperature == 20)
            {
                Console.WriteLine("It´s 10 degrees warm.");
            }
            else if(20 > temperature && temperature <= 30)
            {
                Console.WriteLine("It´s warm!");
            }
            else
            {
                Console.WriteLine("It´s hot!");
            }
        }
    }
}
