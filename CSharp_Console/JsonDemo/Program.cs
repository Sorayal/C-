using System;
using System.ComponentModel;
using System.IO;
using System.Text.Json;

namespace JsonDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person P1 = new Person()
            {
                Surname = "Peter",
                Lastname = "Pan",
                Age = 20,
                Street = "Paulstr. 20",
                City = "Essen",
                Zip = "45148"
            };

            // Write an object into JSON Format
            var json = JsonSerializer.Serialize(P1);
            Console.WriteLine(json + "\n" + new string('*',  40));


            // Reads from JSON Format and puts the result in an object
            Person P2 = new Person();
            try
            {
                using (StreamReader reader = File.OpenText(@"../../../Person.json"))
                {
                    P2 = JsonSerializer.Deserialize<Person>(reader.ReadToEnd());
                }
                // Using Descriptor to print the members and values of an object
                foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(P2))
                {
                    string memberName = descriptor.Name;
                    object memberValue = descriptor.GetValue(P2);
                    Console.WriteLine($"{memberName} : {memberValue}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
