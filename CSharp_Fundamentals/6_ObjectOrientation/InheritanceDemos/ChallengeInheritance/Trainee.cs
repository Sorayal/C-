using System;

namespace ChallengeInheritance
{
    class Trainee : Employee
    {
        public int WorkingHours { get; set; }
        public int SchoolHours { get; set; }

        public Trainee() { }
        public Trainee(string name, string firstName, decimal salary, int workingHours, int schoolHours) : base(name, firstName, salary)
        {
            WorkingHours = workingHours;
            SchoolHours = schoolHours;
        }

        public void Learn()
        {
            Console.WriteLine($"{FirstName} {Name} is learning...");
        }

        public override void Work()
        {
            Console.WriteLine($"The working time per week of the trainee: {WorkingHours}");
        }
    }
}
