using System;

namespace MultidimensionalArrays
{
    class Program
    {
        static void Main()
        {
            // 2-D Array
            string[,] matrix;

            // 3-D Array
            int[,,] threeD;

            int[,] array2D = new int[,]
            {
                { 1,2,3 },    //Zeile 0
                { 4,5,6 },    //Zeile 1
                { 7,8,9 }     //Zeile 2
            };

            Console.WriteLine($"Row 1, column 1: {array2D[1, 1]}");
            Console.WriteLine($"Row 2, column 0: {array2D[2, 0]}");

            string[,,] array3D = new string[,,]
            {
                // Level 0
                {
                    // Level 00 (Level 000 and Level 001)
                    { "000", "001"},
                    // Level 01 (Level 010 and Level 011)
                    { "010", "011"},
                    { "Hello", "Tim"}
                },
                // Level 1
                {
                    { "100", "101"},
                    { "110", "111"},
                    { "Bla", "Doktor"}
                }
            };
            Console.WriteLine(new string('*', 40));

            Console.WriteLine($"Array [0,0,0]: {array3D[0, 0, 0]}");
            Console.WriteLine($"Array [0,0,1]: {array3D[0, 0, 1]}");
            Console.WriteLine($"Array [0,1,0]: {array3D[0, 1, 0]}");
            Console.WriteLine($"Array [0,1,1]: {array3D[0, 1, 1]}");
            Console.WriteLine($"Array [1,0,0]: {array3D[1, 0, 0]}");
            Console.WriteLine($"Array [1,0,1]: {array3D[1, 0, 1]}");
            Console.WriteLine($"Array [1,1,0]: {array3D[1, 1, 0]}");
            Console.WriteLine($"Array [1,1,1]: {array3D[1, 1, 1]}");

            Console.WriteLine(new string('*', 40));
            Console.WriteLine($"Array [1,2,0]: {array3D[1, 2, 0]}");
            Console.WriteLine($"Array [1,2,1]: {array3D[1, 2, 1]}");
            Console.WriteLine($"Array [0,2,0]: {array3D[0, 2, 0]}");
            Console.WriteLine($"Array [0,2,1]: {array3D[0, 2, 1]}");

            Console.WriteLine(new string('*', 40));

            // 3 Rows , 2 Columns
            string[,] array2DString = new String[3, 2] 
            {
                { "eins", "zwei"},
                { "drei", "vier"},
                { "fünf", "sechs"},
            };

            Console.WriteLine(array2DString[1,1]);
            array2DString[1, 1] = "Bauer";
            Console.WriteLine(array2DString[1, 1]);

            Console.WriteLine($"Numbers of dimensions: {array2DString.Rank}");

        }
    }
}
