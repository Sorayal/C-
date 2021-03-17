using System;

namespace CountWords
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string sentence = "!!!  Hallo,,,  mein   Name       ist  Bert ! Ich   heisse     !!        ";
            WordHelper wordHelper = new WordHelper();
            int wordCounter = wordHelper.CountWords(sentence);
            Console.WriteLine($"Der Satz hat {wordCounter} Wörter.");
        }
    }
}
