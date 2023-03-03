using System;

namespace LowerOrUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter = char.Parse(Console.ReadLine());
            string letterCase = letter == Char.ToLower(letter) ? "lower-case" : "upper-case";
            Console.WriteLine(letterCase);
        }
    }
}