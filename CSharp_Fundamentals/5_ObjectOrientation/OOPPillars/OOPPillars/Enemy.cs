using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPillars
{
    public class Enemy
    {
        private int health = 100;

        public int Health
        {
            get { return health; }
            set 
            { 
                if(value >= 0 && value <= 100)
                {
                    health = value;
                }
                else
                {
                    Console.WriteLine("Invalid value!");
                }
            }
        }

        public virtual void SayEnemyType()
        {
            Console.WriteLine("Enemy");
        }

    }
}
