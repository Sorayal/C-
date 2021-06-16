// Written under .Net 5.0
// Different behavior for DivideByZeroException

using System;

namespace TryCatchFinallyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            double randomNumber = 20;
            Console.WriteLine("Enter a number");
            string input = Console.ReadLine();

            try
            {
                double number = Double.Parse(input);
                double result = randomNumber / number;
                // Without this it shows the infinity symbol on the console
                if (number == 0)
                    throw new DivideByZeroException();
                Console.WriteLine($"{randomNumber} / {number} = {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong format. Not a number");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("You should enter a value.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Divide by zero not allowed.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Value too high.");
            }
            catch(Exception)
            {
                Console.WriteLine("Error orccurred.");
            }
            finally
            {
                Console.WriteLine("Close program...");
            }
        }
    }
}
