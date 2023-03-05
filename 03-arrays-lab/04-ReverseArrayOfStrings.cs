using System;

namespace ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split(" ");
            Array.Reverse(strings);
            Console.WriteLine(string.Join(" ", strings));
        }
    }
}