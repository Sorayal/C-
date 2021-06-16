using System;

namespace PolymorphismDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassA FirstClass = new ClassA();
            // This demonstrates method overloading. Depending if arguments are given or not,
            // the right method will be choosen. It describes early binding which means the compiler 
            // checks it at develop time.
            FirstClass.Sum();
            FirstClass.Sum(2, 5);
            FirstClass.DisplayClass();

            ClassB SecondClass = new ClassB();
            SecondClass.DisplayClass();

            // This demonstrates late binding.
            ClassA ThirdClass = new ClassB();
            ThirdClass.DisplayClass();
            Console.WriteLine(ThirdClass.GetType());

        }
    }
}
