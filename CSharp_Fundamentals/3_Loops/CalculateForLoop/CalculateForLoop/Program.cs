using System;

// Count to from 1 to 100 witout using explicit numbers
namespace CalculateForLoop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int start = 'a' / 'a'; //ASCII Code 97 => 97/97 == 1
            int limit = '(' + '<'; //ASCII Code Dec 40 + 60
            //string end = "....."; //can be used in combination with String.Length
            for (int i = start; i <= limit; i++)
            {
                Console.Write($" {i} ");
            }
        }
    }
}
