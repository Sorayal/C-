namespace ChallengeInheritance
{
    interface IEmployee
    {
        string FirstName { get; set; }
        string Name { get; set; }
        decimal Salary { get; set; }

        void Pause();
        void Work();
    }
}