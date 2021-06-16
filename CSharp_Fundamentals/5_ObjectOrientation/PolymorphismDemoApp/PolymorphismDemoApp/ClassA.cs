using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemoApp
{
    class ClassA
    {
        public void Sum()
        {
            Console.WriteLine("Sum");
        }

        public void Sum(int a, int b)
        {
            Console.WriteLine($"Sum is {a + b}");
        }

        public virtual void DisplayClass()
        {
            Console.WriteLine("A");
        }
    }
}
