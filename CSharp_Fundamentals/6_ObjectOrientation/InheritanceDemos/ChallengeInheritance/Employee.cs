using System;

namespace ChallengeInheritance
{
    class Employee : IEmployee
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public decimal Salary { get; set; }

        public Employee() { }
        public Employee(string name, string firstName, decimal salary)
        {
            Name = name;
            FirstName = firstName;
            Salary = salary;
        }


        public virtual void Work()
        {
            Console.WriteLine($"{FirstName} {Name} is working...");
        }

        public void Pause()
        {
            Console.WriteLine($"{FirstName} {Name} takes break...");
        }
    }
}
