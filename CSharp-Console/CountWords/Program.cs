using System;

namespace CountWords
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Expected values: Sentence: 7 words; sentence2: 69 words; sentence3: 11 words;
            string sentence = "!!!  Hallo,,,  mein   Name       ist  Bert ! Ich   heisse     !!        ";
            string sentence2 = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
                "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, " +
                "quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. " +
                "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat " +
                "nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia " +
                "deserunt mollit anim id est laborum.";
            string sentence3 = "   Test sentence    , with some words to check the leading     and trailing    ";
            WordHelper wordHelper = new WordHelper();
            int wordCounter = wordHelper.CountWords(sentence);
            Console.WriteLine($"Der Satz hat {wordCounter} Wörter.");

            wordCounter = wordHelper.CountWords(sentence2);
            Console.WriteLine($"Der Satz hat {wordCounter} Wörter.");

            wordCounter = wordHelper.CountWords(sentence3);
            Console.WriteLine($"Der Satz hat {wordCounter} Wörter.");
        }
    }
}
