using System;

namespace DatentypenImVergleich
{
    class Program
    {
        static void Main(string[] args)
        {
            byte vByte = 200;                                   // 0 bis 255
            sbyte vSByte = -45;                                 // -128 bis 127
            short vShort = -15784;                              // -32.768 bis 32.767
            ushort vUShort = 45960;                             // 0 bis 65.535
            int vInt = -1894112307;                             // -2.147.483.648 bis 2.147.483.647
            uint vUInt = 3489215047;                            // 0 bis 4.294.967.296
            long vLong = -3996794549303736183;                  // -9.223.372.036.854.775.808 bis 9.223.372.036.854.775.807
            ulong vULong = 14125657448224163497;                // 0 bis 18.446.744.073.709.551.615
            float vFloat = 39751.48f;                           // -3.402823e38 bis 3.402823e38
            double vDouble = 976252561462.7912;                 // -1.79769313486232e308 bis 1.79769313486232e308
            decimal vDecimal = 644186892645655128968.34768426M; // +/- 1,0 × 10e?28 zu +/- 7,9 × 10e28
            bool vBool = false;                                 // true (1) oder false (0)
            char vChar = 'c';                                   // Unicode-Zeichen (0 - 65.535)
            string vString = "Hallo Welt!";                     // Aneinanderreiung von char-Typen
            object vObject = new Program();                     // globaler Typ für alle Objekte
            int vZahl;
            const int vZahlKonstant = 16;

            Console.WriteLine(vByte);
            Console.WriteLine(vSByte);
            Console.WriteLine(vShort);
            Console.WriteLine(vUShort);
            Console.WriteLine(vInt);
            Console.WriteLine(vUInt);
            Console.WriteLine(vLong);
            Console.WriteLine(vULong);
            Console.WriteLine(vFloat);
            Console.WriteLine(vDouble);
            Console.WriteLine(vDecimal);
            Console.WriteLine(vBool);
            Console.WriteLine(vChar);
            Console.WriteLine(vString);
            Console.WriteLine(vObject);

            Console.WriteLine();

            // Variablen können zur jeder Zeit geändert werden
            vZahl = 418;
            vZahl = 9752;
            Console.WriteLine(vZahl);

            // Konstante Variablen können nicht geändert werden
            // vZahlKonstant = 123; --> nicht möglich, da Konstant
            Console.WriteLine(vZahlKonstant);

            Console.ReadKey();
        }
    }
}
