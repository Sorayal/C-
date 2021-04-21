using System;

namespace ReferenceTypeClass
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = ExampleClass.GiveName;
            string constant = ExampleClass.constName;
            Console.WriteLine(result);
            Console.WriteLine(constant);
        }
    }
}
