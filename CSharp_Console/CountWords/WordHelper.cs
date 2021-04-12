
namespace CountWords
{
    public class WordHelper
    {
        public int CountWords(string value)
        {
            int wordCounter = 0;

            for (int cursor = 1; cursor < value.Length; cursor++)
            {
                bool firstRequirement = char.IsLetterOrDigit(value[cursor - 1]) && char.IsWhiteSpace(value[cursor]);
                bool secondRequirement = char.IsLetterOrDigit(value[cursor - 1]) && char.IsPunctuation(value[cursor]);
                bool thirdRequirement = char.IsLetterOrDigit(value[value.Length - 1]) && cursor == value.Length-1;
                if (firstRequirement | secondRequirement | thirdRequirement)
                {
                    wordCounter++;
                }
            }
            return wordCounter;
        }
    }
}
