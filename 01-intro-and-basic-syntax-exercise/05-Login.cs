using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            char[] usernameArr = username.ToCharArray();
            Array.Reverse(usernameArr);

            string pass = new string(usernameArr);
            string curPassGuess = Console.ReadLine();

            int attempts = 1;

            while (curPassGuess != pass)
            {
                if (attempts == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }

                Console.WriteLine("Incorrect password. Try again.");
                attempts++;
                curPassGuess = Console.ReadLine();
            }

            Console.WriteLine($"User {username} logged in.");
        }
    }
}