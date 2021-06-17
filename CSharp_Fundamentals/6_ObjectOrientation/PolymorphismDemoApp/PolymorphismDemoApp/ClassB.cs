using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemoApp
{
    class ClassB : ClassA
    {
        public override void DisplayClass()
        {
            Console.WriteLine("B");
        }
    }
}
