using System;

namespace GradeDecision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the grade (A, B, C, D or F)");
            string input = Console.ReadLine();
            input = input.ToUpper();

            switch(input){
                case "A":
                    Console.WriteLine("You have an excellent grade");
                    break;
                case "B":
                    Console.WriteLine("You have a good grade");
                    break;
                case "C":
                    Console.WriteLine("You have a satisfying grade");
                    break;
                case "D":
                    Console.WriteLine("You have a sufficient grade");
                    break;
                case "F":
                    Console.WriteLine("You have a poor grade");
                    break;
                default:
                    Console.WriteLine("You entered no valid grade");
                    break;
            }
            Console.ReadKey();
        }
    }
}
