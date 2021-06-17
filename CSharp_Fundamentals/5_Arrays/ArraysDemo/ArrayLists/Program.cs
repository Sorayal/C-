using System;
using System.Collections;

namespace ArrayLists
{
    class Program
    {
        static void Main()
        {
            // Another collection ArrayList
            // Takes any objects and are dynamic in their size, for that they are not kept as one block in memory
            // You must consider all the possible exceptions due to the different datatypes, no type safety
            ArrayList myArrayList = new();

            ArrayList myArrayList2 = new(100);

            myArrayList.Add(25);
            myArrayList.Add("Hello!");
            myArrayList.Add(13.27);
            myArrayList.Add(13);
            myArrayList.Add(128);
            myArrayList.Add(25.3);
            myArrayList.Add(13);
            Console.WriteLine($"Number of elements in the first arraylist is {myArrayList.Count}");
            Console.WriteLine("Removing elements...");
            // Delete a element with specific value
            myArrayList.Remove(13);

            // Delete an element at a specific position
            myArrayList.RemoveAt(0);

            Console.WriteLine($"Number of elements in the first arraylist is {myArrayList.Count}");

            double sum = 0;
            foreach (object obj in myArrayList)
            {
                if(obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }
                else if(obj is double)
                {
                    sum += (double)obj;
                }
                else if(obj is string)
                {
                    Console.WriteLine(obj);
                }
            }
            Console.WriteLine($"The sum is: {sum,0:0.00}");
        }
    }
}
