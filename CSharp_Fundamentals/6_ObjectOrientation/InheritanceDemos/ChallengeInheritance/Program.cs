namespace ChallengeInheritance
{
    class Program
    {
        static void Main()
        {
            Employee employee1 = new ("Bauer", "Jens", 2500.00m);
            Boss oberBoss = new Boss("Ferinii", "Julia", 8000.00m, true);
            Trainee trainee1 = new("Baum", "Peter", 1250.00m, 20, 20);

            oberBoss.Lead();
            oberBoss.Work();
            trainee1.Work();
            employee1.Pause();
        }
    }
}
