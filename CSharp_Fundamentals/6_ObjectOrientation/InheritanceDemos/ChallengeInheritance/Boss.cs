using System;

namespace ChallengeInheritance
{
    class Boss : Employee
    {
        public bool CompanyCar { get; set; }

        public Boss() { }
        public Boss(string name, string firstName, decimal salary, bool companyCar) : base(name, firstName, salary)
        {
            //Name = name;
            //FirstName = firstName;
            //Salary = salary;
            CompanyCar = companyCar;
        }

        public void Lead()
        {
            Console.WriteLine($"{FirstName} {Name} is leading...");
        }
    }
}
