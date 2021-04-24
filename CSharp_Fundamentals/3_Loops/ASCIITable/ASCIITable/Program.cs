// For loop to print the 7 bit ASCII table
using System;
using System.Text;

namespace ASCIITable
{
    public class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.ASCII;
            for (int i = 0; i < 128; i++)
            {
                Console.WriteLine($"Char {(char)i} | Decimal Code {i} | Hex Code {i:X} | Binary {Convert.ToString(i, 2)} ");
            }
        }
    }
}
