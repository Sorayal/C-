using System;

namespace VariablesDatatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Max of Short is: {short.MaxValue}");
            Console.WriteLine($"Min of Short is: {short.MinValue}");
            Console.WriteLine($"Max of Int is: {int.MaxValue}");
            Console.WriteLine($"Min of Int is: {int.MinValue}");
            Console.WriteLine($"Max of Long is: {long.MaxValue}");
            Console.WriteLine($"Min of Long is: {long.MinValue}");
            Console.WriteLine($"Min of float is: {float.MinValue}");
            Console.WriteLine($"Max of float is: {float.MaxValue}");
            Console.WriteLine($"Min of double is: {double.MinValue}");
            Console.WriteLine($"Max of double is: {double.MaxValue}");
            Console.WriteLine($"Min of decimal is: {decimal.MinValue}");
            Console.WriteLine($"Max of decimal is: {decimal.MaxValue}");

            // Zeichenliteral , erwartet genau ein Zeichen.
            char buchstabe = 'c';
            Console.WriteLine(buchstabe);

            // Bool-Literal
            Console.WriteLine(true);

            //TODO: Wert fixen /Ansicht - Aufgabenfenster zum Einblenden
            int a = 0;
            Console.WriteLine(a);

            // implizit typisiserte lokale Variablen mit dem Schlüsselwort var.
            var message = "Hello Universe";
            Console.WriteLine(message);
            
        }
    }
}
