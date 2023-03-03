using System;

namespace CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "";

            for (int i = 1; i <= 3; i++)
            {
                text += Console.ReadLine();
            }

            Console.WriteLine(text);
        }
    }
}