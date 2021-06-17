using System;

namespace SimpleClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            // Creating a new object / instance of the Airplane Class
            // Airplane is the datatype and fighter the name of this instance.
            Airplane fighter = new Airplane();

            // Sets the attribute for the instance fighter.
            fighter.Name = "Eurofighter";

            // It calls the method of this instance
            fighter.Fly();

            // Class is the prototype and can be used to create many objects / instances.
            // There is a distinction between class and instance methods and fields.
            // class methods and fields are directly bound to the class. For example there is 
            // a class field which is meant to be a common value which every instance shares.
            // On the opposite side an instance field is directly bound to the concrete object 
            // and will be not shared by other instances of the same class.
        }
    }

    // public is the accessor which indicates how a class is reachable from other classes
    // Airplane is the Classname and a new datatype within this program. 
    public class Airplane
    {
        // public fields which describe the attributes
        public string Name;

        // public method, reachable from outside this Airplane class
        // void means, this method gives no return value. string Name is
        // the parameter of this method which will be given in
        public void Fly()
        {
            Console.WriteLine($"{Name} wants to fly high");
        }
    }
}
