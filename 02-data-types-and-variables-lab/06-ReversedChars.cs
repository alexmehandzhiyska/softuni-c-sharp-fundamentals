using System;

namespace ReversedChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string letters = "";

            for (int i = 1; i <= 3; i++)
            {
                char curChar = char.Parse(Console.ReadLine());
                letters += curChar;
            }

            char[] charArr = letters.ToCharArray();
            Array.Reverse(charArr);
            Console.WriteLine(String.Join(" ", charArr));
        }
    }
}