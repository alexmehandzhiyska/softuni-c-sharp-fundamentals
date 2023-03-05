using System;
using System.Linq;

namespace SumEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sumEven = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int curNum = nums[i];

                if (curNum % 2 == 0)
                {
                    sumEven += curNum;
                }
            }

            Console.WriteLine(sumEven);
        }
    }
}