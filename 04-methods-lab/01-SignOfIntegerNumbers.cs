using System;

namespace SignOfIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string sign = checkSign(num);
            Console.Write($"The number {num} is {sign}.");
        }

        private static string checkSign(int num)
        {
            if (num < 0)
            {
                return "negative";
            }
            else if (num == 0)
            {
                return "zero";
            }
            else
            {
                return "positive";
            }
        }
    }
}