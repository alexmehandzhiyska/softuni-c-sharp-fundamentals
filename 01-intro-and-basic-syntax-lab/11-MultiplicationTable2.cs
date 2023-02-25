using System;

namespace MultiplicationTable2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());

            if (multiplier > 10)
            {
                Console.WriteLine($"{num} X {multiplier} = {num * multiplier}");
            }
            else
            {
                for (int factor = multiplier; factor <= 10; factor++)
                {
                    Console.WriteLine($"{num} X {factor} = {num * factor}");
                }
            }
        }
    }
}