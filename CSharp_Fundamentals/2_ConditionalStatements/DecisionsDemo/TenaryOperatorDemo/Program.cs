using System;

namespace TenaryOperatorDemo
{
    class Program
    {
        // Tenary Operator checks like if-else and it´s based on boolean true and false.
        // condition ? first expression : second expression
        // right associative means it will be processed from right to left.
        // Example: a ? b : c ? d : e => a ? b : (c ? d : e)
        // if - (else - if)
        // Not like (a ? b : c) ? d : e.
        static void Main()
        {
            int waterTemperature = -5;
            string stateOfMatter;

            if (waterTemperature < 0)
            {
                stateOfMatter = "solid";
            }
            else
            {
                if (waterTemperature > 100)
                {
                    stateOfMatter = "gas";
                }
                else
                {
                    stateOfMatter = "liquid";
                }
            }
            Console.WriteLine($"State of matter is {stateOfMatter}");

            waterTemperature += 150;
            stateOfMatter = waterTemperature < 0 ? "solid" : waterTemperature > 100 ? "gas" : "liquid" ;
            Console.WriteLine($"State of matter is {stateOfMatter}");
        }   
    }
}
