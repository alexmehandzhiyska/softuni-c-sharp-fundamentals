using System;
using System.Linq;

namespace RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double[] nums = input.Split().Select(double.Parse).ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                int roundedNum = (int)Math.Round(nums[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{nums[i]} => {roundedNum}");
            }
        }
    }
}