using System;

namespace PrintAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int curNum = start; curNum <= end; curNum++)
            {
                sum += curNum;
                Console.Write($"{curNum} ");
            }

            Console.WriteLine($"\nSum: {sum}");
        }
    }
}