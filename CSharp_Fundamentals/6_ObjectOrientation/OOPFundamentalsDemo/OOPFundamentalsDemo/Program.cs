namespace OOPFundamentalsDemo
{
    class Program
    {
        static void Main()
        {
            // Creating object of the human class
            //Human sascha = new();
            //sascha.firstName = "Sascha";
            //sascha.lastName = "BlauBart";
            Human sascha = new("Sascha", "Blaubart", "blue", 55);
            sascha.IntroduceMySelf();

            //Human peter = new();
            //peter.firstName = "Peter";
            //peter.lastName = "Schlauberger";
            Human peter = new("Peter", "Schlauberger", "brown", 20);
            peter.IntroduceMySelf();

            Human julia = new Human("Julia", "Weidenberger", "bluegreen", 1);
            julia.IntroduceMySelf();

            Human unknown = new();
            unknown.IntroduceMySelf();

            Human martina = new("Martina", "Müller", "green");
            martina.IntroduceMySelf();

            Human frank = new("Frank", "Bauer", 14);
            frank.IntroduceMySelf();

            Human missy = new("Missy", "Labala");
            missy.IntroduceMySelf();
        }
    }
}
