using System;

// Arrays are collection which contains many values of one datatype 
// Arrays are static, so the size has to be set before and can´t be changed.
// For that the values will be kept together as one block in the memory
namespace ArraysDemo
{
    class Program
    {
        static void Main()
        {
            // arraysize 6
            int[] grades = new int[5];
            // First position set with 3
            grades[0] = 3;
            // arrayName[index] = value;
            grades[1] = 2;
            grades[2] = 4;
            grades[3] = 1;
            grades[4] = 1;

            Console.WriteLine($"The grade at index 0 is {grades[0]}");

            string input = Console.ReadLine();
            grades[0] = int.Parse(input);
            Console.WriteLine($"The grade at index 0 is {grades[0]}");


            // another way
            int[] gradesMath = { 1, 3, 2, 2, 5, 4, 4, 3 };
            Console.WriteLine($"Die Arraygröße beträgt: {gradesMath.Length}");

            // Third way
            int[] gradesPhysics = new int[] { 2, 4, 5, 6, 2, 1, 1, 3 };
            Console.WriteLine($"Die Arraygröße beträgt: {gradesPhysics.Length}");


        }
    }
}
