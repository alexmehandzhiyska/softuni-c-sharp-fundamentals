using System;
using System.Linq;

namespace EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                int num1 = arr1[i];
                int num2 = arr2[i];

                if (num1 != num2)
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }

                sum += num1;
            }

            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}