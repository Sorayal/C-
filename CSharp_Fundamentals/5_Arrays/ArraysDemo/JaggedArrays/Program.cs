using System;

namespace JaggedArrays
{
    class Program
    {
        static void Main()
        {
            // Arrays in array, jagged array
            int[][] jaggedArray = new int[3][];

            // Declaration of arrays within the main array
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new int[] { 2, 3, 5, 7, 11 };
            jaggedArray[1] = new int[] { 7, 7, 0 };
            jaggedArray[2] = new int[] { 1, 1 };

            // Another way to create a jagged array with values
            int[][] jaggedArray2 = new int[][]
            {
                new int[]{ 2, 3, 5, 7, 11},
                new int[]{ 1,2,3}
            };

            Console.WriteLine($"The middle value of the first entry is: {jaggedArray2[0][2]}");
            Console.WriteLine($"The middle value of the second entry is: {jaggedArray2[1][1]}");
            Console.WriteLine("\n\n");

            for (int i = 0; i < jaggedArray2.Length; i++)
            {
                Console.WriteLine($"Arrayelement {i}");
                for (int j = 0; j < jaggedArray2[i].Length; j++)
                {
                    Console.WriteLine($"{jaggedArray2[i][j]}");
                }
            }

            Console.WriteLine("\n\n");
            int counter = 0;
            foreach (var arrayElement in jaggedArray2)
            {
                Console.WriteLine("Arrayelement " + counter++);
                foreach (var number in arrayElement)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
