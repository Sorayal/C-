using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism.Models
{
    public class Helicopter : AirCraft
    {
        private double _speed;
        private bool _hover;
        public override double Speed
        {
            get { return _speed; }
            set
            {
                if(value < 0 || value > 200)
                {
                    Console.WriteLine($"{nameof(value)} between 0 and 200");
                }
                _speed = value;
            }
        }

        public bool Hover { get { return _hover; } set { _hover = value; } }

        public override string GetTypeIdentifier()
        {
            return "Helicopter Model";
        }

        public string ActivateHovering()
        {
            Hover = true;
            return "Hover activated";
        }

        public string DeactivateHovering()
        {
            Hover = false;
            return "Hover deactivated";
        }
    }
}
