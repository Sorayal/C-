using System;

namespace StringFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            Decimal pricePerOunce = 17.36m;
            String s = String.Format($"The current price is {pricePerOunce} per ounce");
            Console.WriteLine(s);
            decimal temp = 20.4m;
            s = String.Format($"The temperature is {temp}°C");
            Console.WriteLine(s);
        }
    }
}
