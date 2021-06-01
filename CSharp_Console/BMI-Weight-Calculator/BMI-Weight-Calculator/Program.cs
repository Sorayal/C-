using BMI_Weight_Calculator.Implementations;
using BMI_Weight_Calculator.Interfaces;
using System;

namespace BMI_Weight_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    ICustomException customException = CustomException.GetExceptionObject;

                    Console.WriteLine("\nPlease enter your weight in kilogram between 1 and 500 kg");
                    string inputWeight = Console.ReadLine();
                    double weight = double.Parse(inputWeight);
                    if(weight < 1 || weight > 500)
                    {
                        customException.ThrowWeightException();
                        continue;
                    }

                    Console.WriteLine("\nPlease enter your height in meter between 0.01 and 2.50 m");
                    string inputHeight = Console.ReadLine();
                    double height = double.Parse(inputHeight);
                    if(height < 0.01 || height > 2.50)
                    {
                        customException.ThrowHeightException();
                        continue;
                    }
                    IBodyMassIndex bmi = BodyMassIndex.GetBMIObject;

                    double result = bmi.CalculateBMI(weight,height);
                    string resultClassification = bmi.ClassifyBMI(result);
                    Console.WriteLine($"Your body mass index is: {result} kg/m^2");
                    Console.WriteLine($"This means for you: {resultClassification}");

                    Console.WriteLine("\nWould you like to stop the program? Press Escape for Yes");
                    if (Console.ReadKey().Key.Equals(ConsoleKey.Escape))
                    {
                        Environment.Exit(0);
                    }
                    Console.Clear();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wrong format. Try again.");
                    continue;
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("input can´t be null. Try again.");
                    continue;
                }
            }
        }
    }
}
