using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public class Singleton
    {
        private static Singleton singleton = new Singleton();

        private Singleton() { }
        public static Singleton GetInstance()
        {
            return singleton;
        }

        public void PostMessage(string param)
        {
            Console.WriteLine(param);
        }
    }
}
