using System;

namespace Destruktor
{
    public class Member
    {
        // member - private fields
        private string memberName;
        private string jobTitle;
        private int salary;

        // member - public fields
        public int age;

        // member - property, begins with a capitalized char
        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }

        public int Salary => salary;

        // public methods
        public void Introducing (bool isFriend)
        {
            Console.WriteLine($"Hello, I am {memberName} and my Job is {jobTitle} and I am {age} years old.");
            if (isFriend)
            {
                SharingPrivateInfo();
            }
        }

        // member - private method
        private void SharingPrivateInfo()
        {
            Console.WriteLine($"My salary is {salary}");
        }

        // member constructer default constructer
        public Member() 
        {
            age = 30;
            memberName = "Julia";
            salary = 70000;
            jobTitle = "Biologist";
        }

        // Member - Finalizer - Destructor 
        // For cleaning memory via Garbage collector
        // Disposable is another method for cleaning up
        ~Member(){}
    }
}
