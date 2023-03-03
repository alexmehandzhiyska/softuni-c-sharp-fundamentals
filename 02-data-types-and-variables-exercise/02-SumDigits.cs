using System;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sumDigits = 0;

            while (num > 0)
            {
                sumDigits += num % 10;
                num /= 10;
            }

            Console.WriteLine(sumDigits);
        }
    }
}