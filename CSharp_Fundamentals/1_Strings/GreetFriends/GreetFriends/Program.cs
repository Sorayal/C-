using System;

namespace GreetFriends
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] friends = { "Peta", "Tom", "Bernd"};
            foreach (var friend in friends)
            {
                 GreetFriend(friend);
            }

            GreetFriend(friends[1]);
        }

        public static void GreetFriend(string friend)
        {
            Console.WriteLine($"Hi {friend}, mein Freund!");
        }
    }
}
