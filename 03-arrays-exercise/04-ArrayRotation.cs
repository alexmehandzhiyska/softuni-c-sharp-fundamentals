using System;
using System.Linq;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int firstEl = nums[0];
                nums = nums.Skip(1).ToArray();
                nums = nums.Append(firstEl).ToArray();
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}