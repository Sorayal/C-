using System;

namespace EqualsVs__
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString = "hello";
            string secondString = "hello";
            string thirdString = null; //= "4";

            // Mixed check value and reference equality check
            // Value Check for strings is case sensitive
            Console.WriteLine($"firstString: {firstString}");
            Console.WriteLine($"secondString: {secondString}");
            Console.WriteLine($"thirdString: {thirdString}");
            Console.WriteLine(new string('*', 20));
            Console.WriteLine($"firstString == secondString: {firstString == secondString}");
            Console.WriteLine($"firstString equals secondString: {firstString.Equals(secondString)}");
            Console.WriteLine($"firstString ReferenceEquals secondString: {ReferenceEquals(firstString, secondString)}");
            Console.WriteLine(new string('*',20));
            Console.WriteLine($"firstString == thirdString: {firstString == thirdString}");
            Console.WriteLine($"firstString equals thirdString: {firstString.Equals(thirdString)}");
            Console.WriteLine($"firstString ReferenceEquals thirdString: {ReferenceEquals(firstString, thirdString)}");
            Console.WriteLine(new string('*', 20));
            Console.WriteLine(new string('*', 20));
            // Seems no difference between == and equals

            // The code below checks for value equality
            int firstNumber = 6;
            int secondNumber = 6;
            int thirdNumber = 7;
            Console.WriteLine($"firstNumber: {firstNumber}");
            Console.WriteLine($"secondNumber: {secondNumber}");
            Console.WriteLine($"thirdNumber: {thirdNumber}");
            Console.WriteLine(new string('*', 20));
            Console.WriteLine($"firstNumber == secondNumber: {firstNumber == secondNumber}");
            Console.WriteLine($"firstNumber equals secondNumber: { firstNumber.Equals(secondNumber)}");
            Console.WriteLine(new string('*', 20));
            Console.WriteLine($"firstNumber == thirdNumber: {firstNumber == thirdNumber}");
            Console.WriteLine($"firstNumber equals thirdNumber: { firstNumber.Equals(thirdNumber)}");

            

            Console.WriteLine(new string('*', 20));
            Car Saab = new Car();
            Tank Leopard = new Tank();
            Tank Merkava = new Tank();

            Console.WriteLine($"Car Saab ReferenceEquals Tank Leopard: {ReferenceEquals(Saab,Leopard)}");
            Console.WriteLine($"Car Saab equals Tank Leopard: { Saab.Equals(Leopard)}");
            Console.WriteLine(new string('*', 20));
            Console.WriteLine($"Tank Merkava ReferenceEquals Tank Leopard: {ReferenceEquals(Merkava, Leopard)}");
            Console.WriteLine($"Tank Merkava equals Tank Leopard: { Merkava.Equals(Leopard)}");
            Console.WriteLine(new string('*', 20));
            Console.WriteLine("Reference changed: Merkava = Leopard");
            Merkava = Leopard;
            Console.WriteLine($"Tank Merkava ReferenceEquals Tank Leopard: {ReferenceEquals(Merkava, Leopard)}");
            Console.WriteLine($"Tank Merkava equals Tank Leopard: { Merkava.Equals(Leopard)}");
        }
    }

    interface Vehicle
    {
        public string GetSize();
    }

    public class Car : Vehicle
    {
        public string GetSize()
        {
            return "Small";
        }
    }

    public class Tank : Vehicle
    {
        public bool CombatReady { get; set; } = true;
        public string GetSize()
        {
            return "Big";
        }
    }
}
