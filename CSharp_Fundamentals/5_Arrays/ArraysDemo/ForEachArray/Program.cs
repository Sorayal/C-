using System;

namespace ForEachArray
{
    class Program
    {
        static void Main()
        {
            int[] nums = new int[10];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i + 10;
            }

            Console.WriteLine("With for loop: ");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"Element {i} = {nums[i]}");
            }

            Console.WriteLine(new string('-', 40));
            // Going through the collection "array" with foreach
            Console.WriteLine("With foreach loop: ");
            int counter = 0;
            foreach (int value in nums)
            {
                Console.WriteLine($"Element {counter++} = {value}");
            }

            Console.WriteLine(new string('-', 40));
            string[] friends = { "Peter", "Dennis", "Marc", "Thomas", "Ahmed" };

            foreach (var friend in friends)
            {
                Console.WriteLine($"Hello, {friend}");
            }
        }
    }
}
