using System;

namespace InheritanceDemos
{
    class Program
    {
        static void Main()
        {
            Post post1 = new("New shoes!", true, "Sascha");
            Console.WriteLine($"Post to string method: {post1.ToString()}");

            ImagePost picPost1 = new("Here are my new shoes", "Sascha", "https://pics.de/myShoes", true);
            Console.WriteLine($"Post to string method: {picPost1.ToString()}");

            VideoPost videoPost1 = new("Here is a new video", "Sascha", "https://pics.de/myVideo", 10, true);
            Console.WriteLine($"Post to string method: {videoPost1.ToString()}");
            videoPost1.Play();
            Console.WriteLine("Press a button to stop the video.");
            Console.ReadKey();
        }
    }
}
