using System;

namespace HighScoreCheck
{
    class Program
    {

        static void Main()
        {
            HighScore.HighScorePlayer = "Peter";
            HighScore.HighScoreValue = 2000;

            Console.WriteLine("Enter your name: ");
            string inputName = Console.ReadLine();

            Console.WriteLine("Enter your score: ");
            string inputScore = Console.ReadLine();
            if(Int32.TryParse(inputScore, out int score))
            {
                CheckIfHighScore(inputName, score);
            }
            else
            {
                Console.WriteLine("Not a valid score!");
            }
        }

        public static void CheckIfHighScore(string userName, int score)
        {
            if(score > HighScore.HighScoreValue)
            {
                HighScore.HighScorePlayer = userName;
                HighScore.HighScoreValue = score;
                Console.Write($"New highscore is {score}\n" +
                              $"New player with highscore is {userName}");
            }
            else
            {
                Console.Write($"The old record about {HighScore.HighScoreValue} is not broken, \n" +
                              $"and is hold by {HighScore.HighScorePlayer}");
            }
        }
    }
}
