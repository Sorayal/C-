using System;

namespace ArraysAsParameter
{
    class Program
    {
        static void Main()
        {
            // 0 - 20 points 
            int[] studentGrades = new int[] { 15, 13, 8, 12, 6, 13 };
            double averageResult = GetAverage(studentGrades);
            Console.WriteLine($"The average of the students: {averageResult,0:0.000}");
            Console.WriteLine(new string('*', 40));
            Console.WriteLine("\n\n");

            // from 1(not happy) to 10 (very happy)
            int[] happiness = new int[] { 1, 9, 5, 8, 8 };

            int index = 1;
            foreach ( int point in happiness )
            {
                Console.WriteLine($"{index++}. Person happiness points: {point}");
            }

            Console.WriteLine(new string('*', 40));
            AddTwoPoints(happiness);
            index = 1;
            foreach (int point in happiness)
            {
                Console.WriteLine($"{index++}. Person happiness points: {point}");
            }
            double averageHappiness = GetAverage(happiness);
            Console.WriteLine($"Average happiness of all people: {averageHappiness,0:0.00}");
        }

        public static double GetAverage(int[] grades)
        {
            int size = grades.Length;
            double average;
            int sum = 0;

            for (int i = 0; i < grades.Length; i++)
            {
                sum += grades[i];
            }
            average = (double)sum / size;
            return average;
        }

        public static void AddTwoPoints(int[] happiness)
        {
            for (int i = 0; i < happiness.Length; i++)
            {
                happiness[i] = happiness[i] + 2;
            }
        }
    }
}
