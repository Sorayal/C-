using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism.Models
{
    public class AirCraft : IVehicle
    {
        private double _speed;
        public virtual double Speed 
        {
            get {return _speed; }
            set 
            {
                if (value < 0 || value > 1000)
                {
                    Console.WriteLine($"{nameof(value)} must be between 0 and 1000");
                }
                _speed = value;
            } 
        }





        public virtual string GetTypeIdentifier()
        {
            return "Aircraft Model";
        }

        //Method Overloading for static(early) binding
        public void ChangeSpeed(int speedParam)
        {
            Speed += speedParam;
        }

        public void ChangeSpeed(double speedParam)
        {
            Speed += speedParam;
        }
    }
}
