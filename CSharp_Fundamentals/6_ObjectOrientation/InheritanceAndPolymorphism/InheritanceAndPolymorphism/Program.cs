using InheritanceAndPolymorphism.Models;
using System;

namespace InheritanceAndPolymorphism
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AirCraft airCraft = new AirCraft();
            Console.WriteLine($"Speed after creation: {airCraft.Speed}");
            airCraft.ChangeSpeed(2.5);
            Console.WriteLine($"Speed after changing speed: {airCraft.Speed}");
            airCraft.ChangeSpeed(3);


            Console.WriteLine(new string('#',20));
            // Base Class Reference = Subclass Reference : A helicopter is an aircraft,
            // but not every aircraft is a helicopter

            // Declaring a reference points to an actual Helicopter object. 
            AirCraft helicopter = new Helicopter();
            // Uses the virtual method table to call the right method of the child class
            Console.WriteLine(helicopter.GetTypeIdentifier());
            Console.WriteLine(helicopter.GetHashCode());
            Console.WriteLine("\n");
            Console.WriteLine(new string('#', 20));
            // Declaring a new reference and set the memory address which points to the object from above
            // Explicit Typeconversion necessary : Subclass = (Datatype)Baseclass Reference
            Helicopter realHelicopter = (Helicopter)helicopter;
            Console.WriteLine(realHelicopter.ActivateHovering());
            // Asking for hashcode to show that both references points now to the same helicopter object.
            Console.WriteLine(realHelicopter.GetHashCode());
        }
    }
}
