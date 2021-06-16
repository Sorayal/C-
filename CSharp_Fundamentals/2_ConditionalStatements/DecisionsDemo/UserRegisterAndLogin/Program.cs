using System;

namespace UserRegisterAndLogin
{
    class Program
    {
        static void Main()
        {
            // New sytax for creating instance since .Net 5.0
            User user = new();
            //string userName = "";
            //string passWord = "";

            while (true)
            {
                Console.WriteLine("To register yourself, please enter a username: ");
                user.UserName = Console.ReadLine();
                if (user.UserName.Equals(""))
                {
                    Console.WriteLine("Username can´t be empty!");
                }
                else
                {
                    break;
                }
            }
            while (true)
            {
                Console.WriteLine("Please enter a password: (min. 8 chars)");
                user.PassWord = Console.ReadLine();
                if (user.PassWord.Length < 8)
                {
                    Console.WriteLine("Password too short!");
                }
                else
                {
                    User.GlobalUserIndex = User.GlobalUserIndex++;
                    break;
                }
            }

            Console.WriteLine("Sign In");
            Console.WriteLine("Please enter your username: ");
            string signInUserName = Console.ReadLine();

            Console.WriteLine("Please enter your password: ");
            string signInPassword = Console.ReadLine();

            bool userNameValid = CheckUserName(signInUserName, user.UserName);
            bool passWordValid = CheckPassWord(signInPassword, user.PassWord);

            if(userNameValid && passWordValid)
            {
                Console.WriteLine("Login successful!");
            }
            else
            {
                Console.WriteLine("Login failed!");
            }

        }

        public static bool CheckPassWord(string input, string currentPassword)
        {
            if (input.Equals(currentPassword))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckUserName(string input, string currentUserName)
        {
            if (input.Equals(currentUserName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
