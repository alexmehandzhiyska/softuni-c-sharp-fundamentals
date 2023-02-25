using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int factor = 1; factor <= 10; factor++)
            {
                Console.WriteLine($"{num} X {factor} = {num * factor}");
            }
        }
    }
}