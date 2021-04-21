using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Value types with range
            // Value types saves the values directly to a memory section called stack.
            // The stack is relative small in relation to another section called heap.
            // The heap is used to save Reference types. Instead of saving the values directly
            // only the memory adress will be saved in the variable. These adress leads to the 
            // actual values of these Reference types. Giving a variable which is a reference type
            // to a method as parameter may lead to changes at the actual values where this variable 
            // refers to. The method gets the memory adress. This is called call-by-reference.
            // Variables of value type which are given to a method as parameters will be treated 
            // differently. Value types will be copied and the method works only with the copy.
            // The is called call-by-value.

            Console.WriteLine(new string('*', 20));
            Console.WriteLine("Unsigned integral types:");

            Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
            Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
            Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
            Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

            Console.WriteLine(new string('*', 20));
            Console.WriteLine("Signed integral types:");

            Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
            Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
            Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
            Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");


            Console.WriteLine(new string('*', 20));
            Console.WriteLine("Floating point types:");
            Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
            Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
            Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");
            Console.WriteLine(new string('*', 20));
            Console.WriteLine(new string('*', 20));

            // Reference types
            int[] data; // Null reference, without values no memory adress is saved yet.
            // Doesn´t work yet. At compile time the compiler will complain about the missing reference.
            // Console.WriteLine(data[0]);

            // That will create at runtime an intance of this array with a reference to the values.
            data = new int[3];
            // By default the values will be 0.
            Console.WriteLine(data[1]);
            Console.WriteLine(new string('*', 20));

            // Calling it outside the range will throw an exception
            try
            {
                Console.WriteLine(data[4]);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Although strings are also a reference type, there is no new-operator necessary. 
            // It´s intended to make the creation easier, as strings are very often used.
            // Also strings are immutable. When the value will be changed a new string will be created.
            string name = "Peter";
        }
    }
}
