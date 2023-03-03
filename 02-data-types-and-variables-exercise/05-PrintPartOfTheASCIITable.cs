using System;

namespace PrintPartOfTheASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int startIndex = int.Parse(Console.ReadLine());
            int endIndex = int.Parse(Console.ReadLine());

            string result = "";

            for (int i = startIndex; i <= endIndex; i++)
            {
                char curChar = (char)i;
                result += curChar + " ";
            }

            Console.WriteLine(result);
        }
    }
}