using System;
using System.Linq;

namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] topInts = new int[] {};

            for (int i = 0; i < nums.Length; i++) {
                int curNum = nums[i];
                bool isGreater = true;

                for (int j = i + 1; j < nums.Length; j++)
                {
                    int rightNum = nums[j];

                    if (rightNum >= curNum)
                    {
                        isGreater = false;
                        break;
                    }
                }

                if (isGreater)
                {
                    topInts = topInts.Append(curNum).ToArray();
                }
            }

            Console.WriteLine(string.Join(" ", topInts));
        }
    }
}