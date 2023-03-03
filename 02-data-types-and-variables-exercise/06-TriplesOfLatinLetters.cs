using System;

namespace TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 97; i < n + 97; i++)
            {
                for (int j = 97; j < n + 97; j++)
                {
                    for (int k = 97; k < n + 97; k++)
                    {
                        char char1 = (char)i;
                        char char2 = (char)j;
                        char char3 = (char)k;

                        Console.WriteLine($"{char1}{char2}{char3}");
                    }
                }
            }
        }
    }
}