namespace OOPFundamentalsDemo
{
    // Class description : blueprint for a datatype / new instances
    class Human
    {
        // Member variables
        public string firstName;
        public string lastName;
        public string eyeColor;
        public int age;

        // Constructor
        // Setting up a custom constructor will deactivate the hidden default constructor: public Human()

        public Human() 
        {
            firstName = "unknown";
            lastName = "unknown";
            age = 0;
            eyeColor = "unknown";
        }

        public Human(string firstName,string lastName, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }

        public Human(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }
        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        // Parameterized constructor
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            // this is the pointer to the current object.
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
            //System.Console.WriteLine("Object of Human created!");
        }

        // Member method
        public void IntroduceMySelf()
        {
            string addChar = "s";
            if (age == 1)
            {
               addChar = "";
            }
            
            if(age != 0 && lastName != null && eyeColor != null && firstName != null)
            {
                System.Console.Write($"\nHello, I am {firstName} {lastName} \n" +
                                     $"my eyecolor is {eyeColor} and I´m {age} year{addChar} young.\n");
            }
            else if(lastName != null && eyeColor != null && firstName != null)
            {
                System.Console.Write($"\nHello, I am {firstName} {lastName} \n" +
                                     $"my eyecolor is {eyeColor}.\n");
            }
            else if(lastName != null && age != 0 && firstName != null)
            {
                System.Console.Write($"\nHello, I am {firstName} {lastName} \n" +
                                     $"and I´m {age} year{addChar} young.\n");
            }
            else if(lastName != null && firstName != null)
            {
                System.Console.Write($"\nHello, I am {firstName} {lastName}. \n");
            }
        }
    }
}
