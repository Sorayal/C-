using System;

// Little challenge with strings

/* Create the following output with only two WriteLine or Write methods
View English output:
        c:\Exercise\ACME\data.txt

Посмотреть русский вывод:
        c:\Exercise\ACME\ru - RU\data.txt
*/

namespace LittleChallengeStrings
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Both strings were given
            Console.OutputEncoding = System.Text.Encoding.Default; 
            //Console.WriteLine($"Current encoding for output: {Console.OutputEncoding}"); 
            string projectName = "ACME";
            string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
            
            // Solution
            Console.WriteLine("View English output:\n" +
                              $"\t\tc:\\Excercise\\{projectName}\\data.txt");
            Console.WriteLine($"{russianMessage}:\n" +
                              $"\t\tc:\\Exercise\\{projectName}\\ru-RU\\data.text");
        }
    }
}
