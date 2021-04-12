using System;
using System.Collections.Generic;
using System.Text;

namespace VariableTypes
{
    public class ExampleClass
    {
        // Private class readonly variable
        private static readonly int StaticRandomNumber = 11;
        
        // These readonly variable can be used by constructors.
        // These variables will be put onto the heap, which differs
        // them from constants, which don´t need dynamic memory
        // allocations. 
        private readonly int SecondRandomNumber;

        // Const will be set only once during runtime. They 
        // can not be changed anymore during runtime. They will be called also as Literals.
        // It is not possible, to declare a const only. So they cannot be empty and must
        // be initialized with a value! Const are implicit static, so they can be called
        // without an instance.
        public const string constName = "I´m a const.";

        // Public static property , can be called directly without any instance
        // Static variables will be created once when the program execution starts 
        // Their life time ends, when the program ends. So basically there is only
        // one copy of these variables in the memory. 
        public static string GiveName { get; set; } = "Non static Example Class";

        // Private instance variable
        private readonly int RandomNumber = 21;

        // public property with hidden private backing field
        public string Name { get; set; }


        // public instance method
        public string ReturnNameAndNumber(string name)
        {
            string result = name + " " + RandomNumber;
            return result;
        }
    }
}
