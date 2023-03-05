using System;

namespace PrintNumbersInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];

            for (int i = 0; i < n; i++)
            {
                int curNum = int.Parse(Console.ReadLine());
                nums[i] = curNum;
            }

            Array.Reverse(nums);
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}