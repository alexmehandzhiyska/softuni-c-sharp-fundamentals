using System;

namespace PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int pyramidSize = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= pyramidSize; i++) {
                PrintLine(i);
            }

            for (int j = pyramidSize - 1; j >= 1; j--)
            {
                PrintLine(j);
            }
        }

        private static void PrintLine(int maxNum)
        {
            int[] nums = new int[maxNum];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i + 1;
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}