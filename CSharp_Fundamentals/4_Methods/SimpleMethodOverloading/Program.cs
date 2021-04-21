/* This program is just a demo to show how method overload works.
 * basically the methods differ in their parameters. 
 * Changing the return value only wouldn´t be enough for valid method overloading! */


using System;

namespace SimpleMethodOverloading
{
    public static class Program
    {
        private static int _randomNumber = 100;

        public static int RandomNumber
        {
            get => _randomNumber;
            set => _randomNumber = value;
        }

        public static void Main()
        {
            int i = 5;
            calc(ref i);
            calc(6);
            Console.WriteLine(i);
            calc(6, 2);

            calc(Program.RandomNumber);
        }

        public static void calc(ref int x) 
        {
            x = x * x;
        }

        public static void calc(int x) 
        {
            Console.WriteLine(x * x * x );
        }

        public static void calc(int x, int y) 
        {
            Console.WriteLine(Math.Pow(x,y));
        }

        // Compiler kicks in here, invalid overloading
        // It´s an example why changing return value is not enough.
        //public static int calc(int x) 
        //{
        //    return x * x * x * x;
        //}

    }
}
