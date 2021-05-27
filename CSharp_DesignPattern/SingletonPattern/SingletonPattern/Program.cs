using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Singleton Pattern");

            Singleton singleton = Singleton.GetInstance();
            singleton.PostMessage("That is a demo for the Singleton Pattern");

            
        }
    }
}
